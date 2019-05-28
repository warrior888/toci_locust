// <copyright file="Entity.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

using Locust.Bll.Hitman.Interfaces;

namespace Locust.Bll.Hitman
{
    public abstract class Entity<TRepository> : IEntity<TRepository> // ??
    {
        protected TRepository Repository;

        protected Entity(TRepository repository)
        {
            Repository = repository;
        }    
    }
}