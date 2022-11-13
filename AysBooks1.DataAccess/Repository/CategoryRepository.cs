using System;
using System.Collections.Generic;
using System.Text;
using AysBooks1.DataAccess.Repository.IRepository;
using AysBooks1.Models;
using AysBookStore.DataAccess.Data;

namespace AysBooks1.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db);
        
          _db=db;
        }
        public void Update(Category category)

    {
        var objFormDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
        if (objFormDb != null)
        {
            objFormDb.Name = category.Name;
            _db.SaveChanges();
        }
        //throw new NotImplementedException();
    }

}




