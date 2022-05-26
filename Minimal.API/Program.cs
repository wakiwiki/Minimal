using MediatR;
using Microsoft.EntityFrameworkCore;
using Minimal.Core.Interfaces;
using Minimal.Core.Services.MovieUseCases;
using Minimal.Infrastructure;
using Minimal.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();//.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
//Infrastructure
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("TestDB"));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//Services
builder.Services.AddMediatR(typeof(CreateMovieHandler));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseMvc();

app.MapGet("/", () => "Hello World!");

app.Run();
