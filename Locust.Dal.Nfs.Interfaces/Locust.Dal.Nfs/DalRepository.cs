// <copyright file="DalRepository.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Locust.Dal.Nfs.Interfaces;

namespace Locust.Dal.Nfs
{
    public class DalRepository<TModel, TTablePrimaryKey> : IDalRepository<TModel, TTablePrimaryKey>
    {
        public Dictionary<List<TTablePrimaryKey>, List<TModel>> SelectManyToMany(Expression<Action<TModel>> @where)
        {
            throw new NotImplementedException();
        }

        public Dictionary<TTablePrimaryKey, List<TModel>> Select(Expression<Action<TModel>> @where)
        {
            throw new NotImplementedException();
        }
    }
}