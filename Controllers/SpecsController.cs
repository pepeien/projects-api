using Microsoft.AspNetCore.Mvc;
using Projects.Types.DTO;

namespace Projects.Controllers
{
    [ApiController]
    [Route("/projects/api/specs")]
    public class SpecsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;

        public SpecsController(ILogger<ProjectsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public ActionResult<ResponseWrapper<List<pepefolio.Endpoint>>> GetAll()
        {
            ResponseWrapper<List<pepefolio.Endpoint>> ProjectsResponse = new();

            try
            {
                ProjectsResponse.WasSuccessful = true;
                ProjectsResponse.Result = new List<pepefolio.Endpoint>();

                ProjectsResponse.Result.Add(this._GenerateAllProjectsEndpoint());
                ProjectsResponse.Result.Add(this._GenerateRegularProjectsEndpoint());
                ProjectsResponse.Result.Add(this._GenerateTestableProjectsEndpoint());

                return Ok(ProjectsResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                ProjectsResponse.WasSuccessful = false;
                ProjectsResponse.Message = ex.Message;

                return StatusCode(500, ProjectsResponse);
            }
        }

        private pepefolio.Endpoint _GenerateAllProjectsEndpoint()
        {
            pepefolio.Endpoint Endpoint = new();

            Endpoint.Name = "All";
            Endpoint.Version = 1;
            Endpoint.Variants = new();

            pepefolio.VariantEndpoint GetVariant = new();
            GetVariant.Method = pepefolio.RequestMethod.Get;

            Endpoint.Variants.Add(GetVariant);

            return Endpoint;
        }

        private pepefolio.Endpoint _GenerateRegularProjectsEndpoint()
        {
            pepefolio.Endpoint Endpoint = new();

            Endpoint.Name = "Regular";
            Endpoint.Path = "regular";
            Endpoint.Version = 1;
            Endpoint.Variants = new();

            pepefolio.VariantEndpoint GetVariant = new();
            GetVariant.Method = pepefolio.RequestMethod.Get;

            Endpoint.Variants.Add(GetVariant);
            return Endpoint;
        }

        private pepefolio.Endpoint _GenerateTestableProjectsEndpoint()
        {
            pepefolio.Endpoint Endpoint = new();

            Endpoint.Name = "Testable";
            Endpoint.Path = "testable";
            Endpoint.Version = 1;
            Endpoint.Variants = new();

            pepefolio.VariantEndpoint GetVariant = new();
            GetVariant.Method = pepefolio.RequestMethod.Get;

            Endpoint.Variants.Add(GetVariant);

            return Endpoint;
        }
    }
}