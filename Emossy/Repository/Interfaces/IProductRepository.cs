using Emossy.Models.Request;
using Req = Emossy.Models.Request;
using Res = Emossy.Models.Response;


namespace Emossy.Repository.Interfaces
{
    public interface IProductRepository
    {
        public Task<bool> Create(CreateProduct createProduct);
        public Task<bool> Edit(EditProduct editProduct);
        public Task<Models.Response.Product?> GetById(ProductById product);
        public Task<bool> Delete(ProductById product);
    }
}
