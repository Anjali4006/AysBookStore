using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AysBooks1.DataAccess.Repository.IRepository;
using AysBooks1.Models;
using AysBookStore.DataAccess.Data;
namespace AysBooks1.DataAccess.Repository : Repository<CoverType>, ICoverTypeRepository

{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // throw new NotImplementedException();

            // use the .NET Linq to retrive the first or default category object
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();
            }

        }
    }
}
