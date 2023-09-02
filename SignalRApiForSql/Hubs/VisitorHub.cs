using Microsoft.AspNetCore.SignalR;
using SignalRApiForSql.Models;

namespace SignalRApiForSql.Hub
{
    public class VisitorHub:Microsoft.AspNetCore.SignalR.Hub
    {
        private readonly VisitorService _visitorService;


        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList", _visitorService.GetVisitorChartList());
        }
    }
}
