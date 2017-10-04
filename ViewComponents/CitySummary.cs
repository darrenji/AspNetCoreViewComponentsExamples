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

        public string Invoke()
        {
            return $"{repository.Cites.Count()} cities, "
                + $"{repository.Cites.Sum(x => x.Population)} people";
        }
    }
}
