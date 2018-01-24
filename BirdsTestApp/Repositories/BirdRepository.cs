using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdsTestApp.Models;

namespace BirdsTestApp.Repositories
{
    public class BirdRepository : IBirdRepository
    {
        public List<Bird> GetAll()
        {
            List<Bird> birds = new List<Bird>();
            birds.Add(GetByID(1));
            birds.Add(GetByID(2));
            birds.Add(GetByID(3));
            return birds;
        }


        public Bird GetByID(int id)
        {
            if (id == 1)
            {
                return new Bird()
                {
                    CommonName = "Great horned owl",
                    ScientificName = "Bubo virginianus",
                    WingSpan = 1530,
                    Distribution = "North, Central and South America",
                    ID = 1
                };
            }
            if (id == 2)
            {
                return new Bird()
                {
                    CommonName = "Rusty blackbird",
                    ScientificName = "Euphagus carolinus",
                    WingSpan = 360,
                    Distribution = "North America - boreal forest and wintering in southern US states",
                    ID = 2
                };
            }
            if (id == 3)
            {
                return new Bird()
                {
                    CommonName = "Northern waterthrush",
                    ScientificName = "Parkesia noveboracensis",
                    WingSpan = 150,
                    Distribution = "North, Central and South America",
                    ID = 3
                };
            }
            return null;
        }
    }
}
