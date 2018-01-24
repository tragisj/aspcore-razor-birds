using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdsTestApp.Models;

namespace BirdsTestApp.Repositories
{
    public interface IBirdRepository
    {
        Bird GetByID(int id);
        List<Bird> GetAll();
    }
}
