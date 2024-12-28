using minimal_api.DTO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) => {
    if(loginDTO.Email == "adm@gmail.com" && loginDTO.Senha == "12345"){
        return Results.Ok("Sucesso");
    }else{
        return Results.Unauthorized();
    }
}); 

app.Run();
