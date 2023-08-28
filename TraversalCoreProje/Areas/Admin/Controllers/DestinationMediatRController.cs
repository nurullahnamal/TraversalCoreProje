using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Queries.GuideQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public DestinationMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task< IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());

            return View(values);
        }
    }
}
