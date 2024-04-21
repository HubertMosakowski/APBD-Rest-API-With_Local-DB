using WebApplication1.Repositories;
using WebApplication1.Service;
using Zadanie5.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddSingleton<IAnimalRepository, AnimalRepository>();
builder.Services.AddSingleton<IAnimalService, AnimalService>();
builder.Services.AddSingleton<IVisitRepository, VisitRepository>();
builder.Services.AddSingleton<IVisitService, VisitService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();