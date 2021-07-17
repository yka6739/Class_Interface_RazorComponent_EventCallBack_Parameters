using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviceswithinterfacess.Client.Helpers
{
    public class MyClass : IRepository
    {
        public List<Data> GetData()
        {
           
            return new List<Data>()
            {
                new Data(){Id=101,Name="Aman", Address="Noida"},
                new Data(){Id=102,Name="manish", Address="Gr Noida"},
                new Data(){Id=103,Name="Ajay", Address="Noida"},
                new Data(){Id=104,Name="Vijay", Address="Gr Noida"}
            };
        }
    }
}
