using AspNetCoreViewComponentsExamples.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreViewComponentsExamples.ViewComponents
{
    public class CitySummary:ViewComponent
    {
        private ICityRepository repository;

        public CitySummary(ICityRepository repo)
        {
            repository = repo;
        }

        //public string Invoke()
        //{
        //    return $"{repository.Cites.Count()} cities, "
        //        + $"{repository.Cites.Sum(x => x.Population)} people";
        //}

        /// <summary>
        /// 通常是Action中返回视图，但在ViewComponent中也可以返回视图
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            //return View(new CityViewModel {
            //    Cities = repository.Cites.Count(),
            //    Population = repository.Cites.Sum(c => c.Population)
            //});

            //直接返回html代码片段
            //return Content("This is a <h3><i>string</i></h3>");
            return new HtmlContentViewComponentResult(new HtmlString("This is a <h3><i>string</i></h3>"));
               
        }
    }
}
