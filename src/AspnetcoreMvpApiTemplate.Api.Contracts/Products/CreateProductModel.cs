namespace AspnetcoreMvpApiTemplate.Api.Products;

public record CreateProductModel
{
    public string? Code { get; init; }
    
    public string? Name { get; init; }

    public string? Description { get; init; }
}