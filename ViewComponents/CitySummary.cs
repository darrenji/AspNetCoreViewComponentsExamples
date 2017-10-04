using AspNetCoreViewComponentsExamples.Models;
using Microsoft.AspNetCore.Mvc;
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
            return View(new CityViewModel {
                Cities = repository.Cites.Count(),
                Population = repository.Cites.Sum(c => c.Population)
            });
        }
    }
}
