using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
            var values = testimonialManager.TGetList();

            return View(values);
        }
    }
}
