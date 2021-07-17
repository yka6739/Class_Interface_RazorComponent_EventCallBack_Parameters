using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviceswithinterfacess.Client.Helpers
{
   public  interface IRepository
    {
        List<Data> GetData();
    }
}
