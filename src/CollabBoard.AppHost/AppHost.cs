var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.CollabBoard_Server>("collabboard-server");

builder.AddJavaScriptApp("client", "../collabboard.client")
    .WithHttpEndpoint(port: 27297, env: "PORT")
    .WithExternalHttpEndpoints()
    .WithReference(api);

builder.Build().Run();
