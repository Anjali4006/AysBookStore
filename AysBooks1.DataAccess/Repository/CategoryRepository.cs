﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AysBooks1.DataAccess.Repository.IRepository;
using AysBooks1.Models;
using AysBookStore.DataAccess.Data;

namespace AysBooks1.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // throw new NotImplementedException();

            // use the .NET Linq to retrive the first or default category object
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }

        }

        public void Update(CategoryRepository category)
        {
            throw new NotImplementedException();
        }
    }

}




