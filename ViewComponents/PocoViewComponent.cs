using AspNetCoreViewComponentsExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreViewComponentsExamples.ViewComponents
{
    public class PocoViewComponent
    {
        private ICityRepository repository;

        public PocoViewComponent(ICityRepository repo)
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
