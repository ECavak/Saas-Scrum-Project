﻿using PropTabTabIK.Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PropTabTabIK.DataAccess.Repositories.Abstract
{
    public interface ISideRepository<T> where T : SideEntity
    {

        bool Add(T item);

        bool Add(List<T> items);

        bool Update(T item);

        bool Remove(T item);

        bool Remove(Guid id);

        bool RemoveAll(Expression<Func<T, bool>> exp);

        T GetByID(Guid id);

        T GetByDefault(Expression<Func<T, bool>> exp);

        List<T> GetActive();

        List<T> GetDefault(Expression<Func<T, bool>> exp);

        List<T> GetAll();

        bool Activate(Guid id);

        bool Any(Expression<Func<T, bool>> exp);

        int Save();
    }
}
