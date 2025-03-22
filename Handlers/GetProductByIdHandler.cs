using CqrsMediatR.Data;
using CqrsMediatR.Models;
using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {

        private readonly FakeDataStore _dataStore;

        public GetProductByIdHandler(FakeDataStore dataStore) => _dataStore = dataStore;


        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) => await _dataStore.GetAllProductById(request.id);

    }
}