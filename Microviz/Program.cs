WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

{
    string documentFile = Path.Combine(Environment.CurrentDirectory, "Document", "docfile.xml");
    IServiceCollection services = builder.Services;
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(option => option.IncludeXmlComments(documentFile));
}

WebApplication app = builder.Build();

{
    //if (app.Environment.IsDevelopment())
    //{
        app.UseSwagger();
        app.UseSwaggerUI();
    //}
    app.UseHttpsRedirection();
    app.UseRouting();
    app.UseAuthorization();
    app.UseEndpoints(endpoint => endpoint.MapDefaultControllerRoute());
}

app.Run();
