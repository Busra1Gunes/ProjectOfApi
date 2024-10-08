﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // T , referans tip olmalı ve T  IEntity olabilir yada IEntity implemente eden bir nesne olabilir.
    //new lenebilir olmalı IEntity interface dir ve newlenemez böylece sadece  IEntity implemente eden bir nesne olabilir.
    public interface IEntityRepository<T> where T: class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
