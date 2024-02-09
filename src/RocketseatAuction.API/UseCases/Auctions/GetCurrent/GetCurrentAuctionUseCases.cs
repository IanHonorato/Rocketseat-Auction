using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCases
    {
        private readonly IAuctionRepository _repository;

        public GetCurrentAuctionUseCases(IAuctionRepository repository)
        {
            _repository = repository;
        }
        public Auction? Execute()
        {
            return _repository.GetCurrent();
        }
    }
}
