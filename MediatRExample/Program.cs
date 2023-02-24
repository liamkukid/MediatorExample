var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(typeof(TestRequest).Assembly);
});

builder.Services.AddControllers();

builder.Services.AddScoped(
    typeof(IPipelineBehavior<,>), 
    typeof(RequestExceptionProcessorBehavior<,>));

builder.Services.AddScoped(
    typeof(IPipelineBehavior<,>), 
    typeof(RequestExceptionActionProcessorBehavior<,>));

builder.Services.AddScoped(
    typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

builder.Services.AddScoped(
    typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>));

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
