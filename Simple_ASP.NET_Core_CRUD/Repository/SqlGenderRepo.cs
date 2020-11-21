using Simple_ASP.NET_Core_CRUD.DataAccessLayer;
using Simple_ASP.NET_Core_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_ASP.NET_Core_CRUD.Repository
{
    public class SqlGenderRepo : IGenderRepo
    {
        private readonly StudentContext _context;

        public SqlGenderRepo(StudentContext context)
        {
            _context = context;
        }
        public IEnumerable<Gender> GetAllGenders()
        {
            return _context.Genders.ToList();
        }
    }
}
