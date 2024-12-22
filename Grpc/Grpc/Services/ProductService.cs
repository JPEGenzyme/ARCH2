using Grpc;
using Grpc.Core;

namespace Grpc.Services
{
    public class ProductService : Product.ProductBase
    {
        public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ProductResponse
            {
                ProductDetails = $"Details for Product ID: {request.ProductId}"
            });
        }
    }

}
