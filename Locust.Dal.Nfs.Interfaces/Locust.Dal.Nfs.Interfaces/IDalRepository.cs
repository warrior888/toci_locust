// <copyright file="IDalRepository.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Locust.Dal.Nfs.Interfaces
{
                                    // db ef entity, int or string
    public interface IDalRepository<TModel, TTablePrimaryKey> // tabelka bazy danych, klucz glowny bazy danych
    {
                                                                          // (model => model.id == ?? and model.name == ??)
        Dictionary<List<TTablePrimaryKey>, List<TModel>> SelectManyToMany (Expression<Action<TModel>> where); /* np select id, name from TModel where id in (1,2) friends .... and name like = 'ag%'*/
        Dictionary<TTablePrimaryKey, List<TModel>> Select (Expression<Action<TModel>> where); /* np select id, name from TModel where id in (1,2) friends .... and name like = 'ag%'*/
    }
}