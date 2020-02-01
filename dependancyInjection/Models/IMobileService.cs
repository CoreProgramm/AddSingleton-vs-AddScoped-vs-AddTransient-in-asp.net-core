using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dependancyInjection.Models
{
   public interface IMobileService
    {
        IEnumerable<Mobile> GetAll();   
        Mobile Add(Mobile mobile);
    }
}
