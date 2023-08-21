﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        private GuideManager guideManager = new GuideManager(new EfGuideDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
