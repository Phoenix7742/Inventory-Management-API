var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


// ✅ Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5004")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();


// ✅ Use CORS middleware
app.UseCors();
app.MapControllers();




app.Run();