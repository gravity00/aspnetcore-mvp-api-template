namespace AspnetcoreMvpApiTemplate.Api.Products;

public interface IProductsEndpoint
{
    Task<CreateProductResultModel> CreateAsync(
        CreateProductModel model,
        CancellationToken ct
    );

    Task<ProductModel> GetByIdAsync(
        Guid id,
        CancellationToken ct
    );
}