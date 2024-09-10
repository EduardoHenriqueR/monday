using API.Models;
//Minimal APIs em c#
//Testar a API
// - Rest Client - Extensão Vs
// - Postman
// - Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//ChatGpt
// Criação de uma lista de produtos
List<Product> products = new List<Product>();

// Adicionando produtos à lista
    products.Add(new Product
    {
        Name = "Laptop",
        Description = "A high-performance laptop",
        Quantity = 10,
        Price = 999.99
    });

    products.Add(new Product
    {
        Name = "Smartphone",
        Description = "A latest model smartphone",
        Quantity = 25,
        Price = 499.99
    });

    products.Add(new Product
    {
        Name = "Headphones",
        Description = "Noise-cancelling headphones",
        Quantity = 15,
        Price = 89.99
    });

    products.Add(new Product
    {
        Name = "Chinese Rice",
        Description = "Chinese style rice.",
        Quantity = 10,
        Price = 1.99
    });




//Endpoint - FUncionalidades
//Requisição - URL e método/verbo HTTP

//GET: /
app.MapGet("/", () => "API Products");



//Lição
app.MapGet("/repositorio/{usuario}/{repositorio}", (string usuario, string repositorio) =>
{
    return $"User: {usuario}, Repositório: {repositorio}";
});

//POST /api/product/create/parametro_nome
app.MapPost("/api/product/create/{name}", (string name) => 
{
    Product product = new Product();
    product.Name = name;
    products.Add(product);
    return products;
});

//Lição 
app.MapPost("/usuario", (Usuario usuario) => 
{
    return Results.Ok($"User: {usuario.Nome}, {usuario.Idade} years old.");
});


app.MapPost("/product", (Product product) =>
{ 
    return Results.Ok($"Product: {product.Id}, {product.Name}, {product.Quantity}, {product.Price}, {product.Description}");
});


//GET: /api/prodcut/list
app.MapGet("/api/product/list", () => 
{
    return Results.Ok(products);
});




app.Run();
