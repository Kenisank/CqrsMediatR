using CqrsMediatR.Data;
using CqrsMediatR.Models;
using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetProductsHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;


        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken) =>
            await _fakeDataStore.GetAllProducts();

    }
}