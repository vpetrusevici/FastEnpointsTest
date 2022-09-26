using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;
services.AddFastEndpoints();

services.AddSwaggerDoc(c =>
{
    c.DocumentName = "openapi";
},
shortSchemaNames: true);

var app = builder.Build();


app.UseFastEndpoints(c =>
{
    c.Endpoints.ShortNames = true;
});

app.UseOpenApi();
app.UseSwaggerUi3(c =>
{
    c.ConfigureDefaults();
});
app.Run();
