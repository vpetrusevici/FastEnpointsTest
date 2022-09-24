using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;
services.AddControllers();
services.AddFastEndpoints();

services.AddSwaggerDoc(c =>
{
    c.DocumentName = "openapi";
},
shortSchemaNames: true);

var app = builder.Build();


app.UseRouting();
app.UseFastEndpoints(c =>
{
    c.Endpoints.ShortNames = true;
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseOpenApi();
app.UseSwaggerUi3(c =>
{
    c.ConfigureDefaults();
});
app.Run();
