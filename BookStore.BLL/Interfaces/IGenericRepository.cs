﻿using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Interfaces
{
    public interface IGenericRepository <T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        
        Task<T> GetById(int id);

    } 
}
