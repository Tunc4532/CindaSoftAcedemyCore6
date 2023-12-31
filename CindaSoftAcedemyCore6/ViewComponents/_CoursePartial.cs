﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.ViewComponents
{
    public class _CoursePartial : ViewComponent
    {
        private readonly ICourseService _courseService;

        public _CoursePartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetList();
            return View(values);
        } 
    }
}
