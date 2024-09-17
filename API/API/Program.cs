using API.Models;
using Microsoft.AspNetCore.Mvc;
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



//GET: /api/prodcut/list
app.MapGet("/api/product/list", () => 
{
    if(products.Count != 0)
    {
       return Results.Ok(products); 
    }
    return Results.NotFound();
});

//POST /api/product/create
app.MapPost("/api/product/create", ([FromBody]Product product) => 
{
    products.Add(product);
    return Results.Created("",product);
});

app.MapDelete("/api/product/delete", ([FromBody] Product prodcutD) =>
{
    var product = products.FirstOrDefault(i => i.Id == prodcutD.Id);
    
     if(product == null)
        {
         return Results.NotFound("Produto não encontrado.");
        }
       
        products.Remove(product);
        return Results.Ok("Produto " +product.Name + " deletado com sucesso.");
}
);

app.MapPut("/api/product/update", ([FromBody] Product productU) =>
{
    var product = products.FirstOrDefault(i => i.Id == productU.Id);
     if(product == null)
     {
        return Results.NotFound("Produto não encontrado.");
     }
     product.Name = productU.Name;
     product.Description = productU.Description;
     product.Price = productU.Price;
     product.Quantity = productU.Quantity;
     return Results.Ok(product);

});

app.MapGet("/api/product/search", ([FromBody] Product productS) =>
{
    var product = products.FirstOrDefault(i => i.Name == productS.Name);
    if(product == null)
    {
        return Results.NotFound("Produto não encontrado.");
    }
    return Results.Ok("Porduto "+ productS.Name+ "encontrado com sucesso.");
});

app.Run();
