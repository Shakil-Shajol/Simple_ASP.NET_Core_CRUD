using Simple_ASP.NET_Core_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_ASP.NET_Core_CRUD.Repository
{
    public interface IGenderRepo
    {
        IEnumerable<Gender> GetAllGenders();
    }
}
