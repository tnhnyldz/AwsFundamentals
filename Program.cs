using AwsFundamentals.DynamoDb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CustomerRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
	//.AddJsonFile($"appsettings.Development.json", optional: true, reloadOnChange: true)
	.AddEnvironmentVariables();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
