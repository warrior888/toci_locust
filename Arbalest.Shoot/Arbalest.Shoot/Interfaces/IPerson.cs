﻿// <copyright file="IPerson.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

namespace Arbalest.Shoot.Interfaces
{
    public interface IPerson
    {
        int Age { get; set; }

        Role PersonRole { get; set; }
    }
}