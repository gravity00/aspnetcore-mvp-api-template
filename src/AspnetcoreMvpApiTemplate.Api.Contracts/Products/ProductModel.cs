namespace AspnetcoreMvpApiTemplate.Api.Products;

public record ProductModel
{
    public Guid Id { get; init; }

    public string? Code { get; init; }

    public string? Name { get; init; }

    public string? Description { get; init; }

    public DateTimeOffset CreatedOn { get; init; }
}