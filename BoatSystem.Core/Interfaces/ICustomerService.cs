using BoatSystem.Core.Entities;
using BoatSystem.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoatSystem.Core.Interfaces
{
    public interface ICustomerService
    {
        Task<int?> GetCustomerIdByUserIdAsync(string userId);
        Task<decimal> GetWalletBalanceAsync(int customerId);
        Task<bool> AddFundsToWalletAsync(int customerId, decimal amount);
        Task<IEnumerable<Trip>> BrowseAvailableTripsAsync();
        Task<IEnumerable<BoatDto>> BrowseAvailableBoatsAsync();
        Task<BoatBooking> BookTripAsync(int customerId, int tripId, int participants, List<int> additionalServiceIds);
        Task<BoatBooking> BookBoatAsync(int customerId, int boatId, List<int> serviceIds, string purpose);
        Task<decimal> CalculateTotalCostAsync(int bookingId);
        Task<bool> CancelBookingAsync(int bookingId);
        Task<IEnumerable<BoatBooking>> GetBookingHistoryAsync(int customerId);
    }
}
