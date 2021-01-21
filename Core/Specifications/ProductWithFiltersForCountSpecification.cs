using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecification : BaseSpecifications<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productSpecParams)
        : base(x =>
        (!productSpecParams.BrandId.HasValue || x.ProductBrandId == productSpecParams.BrandId) &&
        (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId)
        )
        {
            
        }
    }
}