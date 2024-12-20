var builder = WebApplication.CreateBuilder(args);
builder.AddGraphQL().AddApiTypes();

var app = builder.Build();

app.MapGraphQL();
app.MapGet("/", () => "Hello World!");

app.RunWithGraphQLCommands(args);





