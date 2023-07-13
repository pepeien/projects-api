# projects-api

### tl;dr

 ```
git clone https://github.com/pepeien/projects-api.git
cd projects-api/
docker build -t projects-api && docker run -dp 127.0.0.1:9001:9001 projects-api
```

### Setting up

1. At the root of the project reach for the `Program.cs` file and add the address of the application that will consume the service at the `origins` Array;

Before
```
string[] origins = { "http://localhost:4200" };
```

After
```
string[] origins = { "http://localhost:4200", "http://localhost:3000" };
```

2. Still at the root of the project, reach for development `appsettings.Development.json` or for production `appsettings.json`;


3. These are the variables and their descriptions:

| Variable       | Description  | Type           | Default | Required |
|:--------------:|:-------------|:--------------:|:--------:|:--------:|
| ProjectStatics.ApiId             | API key name                   | String  | ghub:1  | ✅ |
| ProjectStatics.TargetUser        | Targeted user `username`       | String  | pepeien | ✅ |
| ApiKeysDatabase.ConnectionString | `MongoDB` address              | String  | mongodb://mongodb:27017 | ✅ |
| ApiKeysDatabase.DatabaseName     | `MongoDB` database name        | String  | portfolio | ✅ |
| ApiKeysDatabase.CollectionName   | `MongoDB` collection name      | String  | api_keys  | ✅ |

3. This project doesn't deal with database authentication, you may change the code at `ApiKeysDatabaseSettings.cs` and `appsettings.json`;

4. After the first run and creation of the `api_keys` collection, add the entry:

```
{
    id: {ProjectStatics.ApiId},
    value: {GITHUB_API_KEY},
    origin: {ANY_DESCRIPTION}
}
```

### Running with Docker CLI

1. Issue `docker build -t projects-api .`;
   
2. Issue `docker run -dp 127.0.0.1:9001:9001 projects-api`.

##### Requirements

- [Docker](https://docs.docker.com/engine/install) (Windows, Linux, Mac)

## Documentation

You can reach to the [Developer Portal](https://api.ericodesu.com/#/service/projects) to a more hands-on driven information.
