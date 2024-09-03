//Minimal APIs em c#
//Testar a API
// - Rest Client - Extensão Vs
// - Postman
// - Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Endpoint - FUncionalidades
//Requisição - URL e método/verbo HTTP
app.MapGet("/", () => "Genshin could never.");
app.MapGet("/b", () => "0w0.");

app.Run();
