// <copyright file="ICompany.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

using System.Dynamic;

namespace Arbalest.Shoot.Interfaces
{
    public interface ICompany
    {
        int Id { get; set; }

        string CompanyName { get; set; }
    }
}