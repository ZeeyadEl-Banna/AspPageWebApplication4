using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Domain;

namespace WebApplication.Application.MangeSchool
{
    public class MangeSchool : IMangeSchool
    {
        public List<Schools> GetSchools()
        {
            return new List<Schools>(){
                new Schools(){ID=1,Name="El-Sherouk",Location="Tala",Rank=1},
                new Schools(){ID=2,Name="El-Manar",Location="Tala",Rank=2},
                new Schools(){ID=3,Name="El-Ghad",Location="Tala",Rank=3},
                new Schools(){ID=4,Name="Suzan",Location="Tala",Rank=4},
                new Schools(){ID=5,Name="El-Geel",Location="Tanta",Rank=5},
                new Schools(){ID=6,Name="El-Hafria",Location="Henak",Rank=0}
            };
        }
    }
}
