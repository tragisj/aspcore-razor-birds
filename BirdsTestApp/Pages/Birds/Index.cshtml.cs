
using System.Collections.Generic;
using BirdsTestApp.Models;
using BirdsTestApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BirdsTestApp.Pages.Birds
{
    public class IndexModel : PageModel
    {

        private IBirdRepository _birdsRepo;

        public List<Bird> Birds { get; set; }

        [TempData]
        public string Message { get; set; }


        public IndexModel(IBirdRepository localRepo)
        {
            _birdsRepo = localRepo;
        }


        public void OnGet()
        {
            Birds = _birdsRepo.GetAll();
        }
    }
}