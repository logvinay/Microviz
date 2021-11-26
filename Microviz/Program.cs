WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    IServiceCollection services = builder.Services;
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
}

WebApplication app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
}

app.Run();
