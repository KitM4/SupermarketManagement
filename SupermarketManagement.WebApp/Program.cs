using SupermarketManagement.Domain.Models;
using SupermarketManagement.Data.Repositories;
using SupermarketManagement.Application.UseCases.Products;
using SupermarketManagement.Application.UseCases.Categories;
using SupermarketManagement.Application.Interfaces.Repositories;
using SupermarketManagement.Application.UseCases.Transactions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<IRepository<Category>, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

builder.Services.AddTransient<AddCategoryUseCase>();
builder.Services.AddTransient<ViewCategoriesUseCase>();
builder.Services.AddTransient<EditCategoryUseCase>();
builder.Services.AddTransient<DeleteCategoryUseCase>();
builder.Services.AddTransient<GetCategoryByIdUseCase>();

builder.Services.AddTransient<AddProductUseCase>();
builder.Services.AddTransient<SellProductUseCase>();
builder.Services.AddTransient<EditProductUseCase>();
builder.Services.AddTransient<ViewProductsUseCase>();
builder.Services.AddTransient<DeleteProductUseCase>();
builder.Services.AddTransient<GetProductByIdUseCase>();
builder.Services.AddTransient<ViewProductsByCategoryId>();

builder.Services.AddTransient<GetTransactionsUseCase>();
builder.Services.AddTransient<RecordTransactionUseCase>();
builder.Services.AddTransient<GetTodayTransactionsUseCase>();

WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();