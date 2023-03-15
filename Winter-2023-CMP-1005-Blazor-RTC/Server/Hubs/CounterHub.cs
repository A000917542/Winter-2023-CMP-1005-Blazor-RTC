using Microsoft.AspNetCore.SignalR;
using Winter_2023_CMP_1005_Blazor_RTC.Server.Services.CounterService;

namespace Winter_2023_CMP_1005_Blazor_RTC.Server.Hubs
{
    public class CounterHub : Hub
    {
        private readonly ICounterService _ctr;

        public CounterHub(ICounterService ctr)
        {
            _ctr = ctr;
        }

        public async Task SendCount()
        {
            await Clients.All.SendAsync("NewCount", _ctr.GetCount());
        }

        public async Task IncrementCountByOne()
        {
            _ctr.AddToCount(1);
            await SendCount();
        }
    }
}
