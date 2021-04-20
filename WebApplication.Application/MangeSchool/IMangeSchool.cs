using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Domain;

namespace WebApplication.Application.MangeSchool
{
    public interface IMangeSchool
    {
        List<Schools> GetSchools();
    }
}
