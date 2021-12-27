
using Aspncore_GraphQL.Contracts;
using Aspncore_GraphQL.Entities.Context;
using Aspncore_GraphQL.GraphQL.GraphQLScheme;
using Aspncore_GraphQL.Repository;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddScoped<IDependencyResolver>(s =>
    new FuncDependencyResolver(s.GetRequiredService));

builder.Services.AddScoped<AppScheme>();

builder.Services.AddGraphQL(o => { o.ExposeExceptions = false; })
    .AddGraphTypes(ServiceLifetime.Scoped);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "AspNetCore_GraphQL", Version = "v1" });
});

// If using Kestrel:
builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
});

// If using IIS:
builder.Services.Configure<IISServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AspNetCore_GraphQL v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseGraphQL<AppScheme>();
app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());

app.MapControllers();

app.Run();