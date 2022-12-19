using Microsoft.EntityFrameworkCore;
using WebAPI;
using WebAPI.Data;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DemoApiContext>((serviceProvider,option) =>
{
    var config = serviceProvider.GetService<IConfiguration>();
    option.UseSqlServer(config.GetConnectionString("DemoApiContext"));
});

builder.Services.AddScoped(typeof(DemoApiContext), typeof(DemoApiContext));


var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo Web API V1");
    // this will make sure that when we browser to the API web site
    // by default it shows the swagger page
    c.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Create database and seed data
await app.UseDemoDbSetupAsync();

app.Run();
