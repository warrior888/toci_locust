// <copyright file="Emplyee.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

using Locust.Bll.Hitman.Interfaces;

namespace Locust.Bll.Hitman.Anathema
{
    public class Employee<TRepository> : Entity<TRepository>, IEmployee
    {
        public Employee(TRepository repository) : base(repository)
        {
        }
    }
}