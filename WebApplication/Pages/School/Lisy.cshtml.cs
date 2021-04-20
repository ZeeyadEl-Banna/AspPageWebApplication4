using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using WebApplication.Domain;
using WebApplication.Application;
using WebApplication.Pages;
using WebApplication.Application.MangeSchool;

namespace WebApplication.Pages.School
{
    public class LisyModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IMangeSchool mangeschool;

        public LisyModel(IConfiguration config, IMangeSchool mangeSchool)
        {
            this.config = config;
            mangeschool = mangeSchool;
        }

        public List<Schools> School { get; set; }
        public void OnGet()
        {
            School = mangeschool.GetSchools();
        }
    }
}
