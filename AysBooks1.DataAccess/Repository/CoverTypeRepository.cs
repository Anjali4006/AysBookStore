using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AysBooks1.DataAccess.Repository.IRepository;
using AysBooks1.Models;
using AysBookStore.DataAccess.Data;

namespace AysBooks1.DataAccess.Repository
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
                var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id); //removed s 
                if (objFromDb != null) // Save changes if not null
                {
                    objFromDb.Name = coverType.Name;
                    //_db.SaveChanges();
                }

            }
        }
    }
