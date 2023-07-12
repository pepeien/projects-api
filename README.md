# projects-api

### tl;dr

 ```
git clone https://github.com/pepeien/projects-api.git
cd projects-api/
npm install && npm start
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

3. Change if necessary `ProjectStatics.ApiId` for the desired api key name;

4. Change `ProjectStatics.TargetUser` for the targeted user `username`;

5. Change if necessary `ApiKeysDatabase.ConnectionString` to reflect the `MongoDB` address;

6. Change if necessary `ApiKeysDatabase.DatabaseName` to reflect the `MongoDB` database name;

7. Change if necessary `ApiKeysDatabase.CollectionName` to reflect the `MongoDB` collection name;

9. This project doesn't deal with database authentication, you may change the code at `ApiKeysDatabaseSettings.cs` and `appsettings.json`;

### Running with Docker CLI

1. Issue `docker build -t projects-api .`;
   
2. Issue `docker run -dp 127.0.0.1:9001:9001 projects-api`.

##### Requirements

- [Docker](https://docs.docker.com/engine/install) (Windows, Linux, Mac)

### Running W/O Docker

1. At the root of the project;

2. Issue `npm install` wait for the installation;

3. Issue `npm start`;

##### Requirements

- [npm](https://nodejs.org/en/download/package-manager) (Windows, Linux, Mac)

## Documentation

You can reach to the [Developer Portal](https://api.ericodesu.com/#/service/projects) to a more hands-on driven information.
