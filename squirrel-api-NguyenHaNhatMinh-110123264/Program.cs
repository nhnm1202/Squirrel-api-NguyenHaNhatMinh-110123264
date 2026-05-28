var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "API lich su giao dich dang chay. Hay vao /api/giaodich");

app.MapControllers();

app.Run();
