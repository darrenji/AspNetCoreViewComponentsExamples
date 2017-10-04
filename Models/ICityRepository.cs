using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreViewComponentsExamples.Models
{
    public interface ICityRepository
    {
        IEnumerable<City> Cites { get; }
        void AddCity(City newCity);
    }
}
