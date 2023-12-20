using Takid.Api.Data;
using Takid.Api.Interfaces;
using Takid.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IGuardInfoRepository, GuardInfoRepository>();
builder.Services.AddScoped<ISupervisorInfoRepository, SupervisorInfoRepository>();
builder.Services.AddScoped<IDapperContext, DapperContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();


app.Run();
