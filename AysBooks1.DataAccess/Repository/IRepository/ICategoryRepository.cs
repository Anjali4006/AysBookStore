﻿using System;
using System.Collections.Generic;
using System.Text;
using AysBooks1.Models;

namespace AysBooks1.DataAccess.Repository.IRepository
{
     public interface ICategoryRepository : IRepository<Category>
    {
        void Update(CategoryRepository category);
    }
}
