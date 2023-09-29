var builder = WebApplication.CreateBuilder(args);
// Patr�n MVC
builder.Services.AddMvc();

var app = builder.Build();
//Enrutamiento de archivos estaticos
app.UseStaticFiles();

//Enrutamiento por defecto
app.MapDefaultControllerRoute();
app.Run();
