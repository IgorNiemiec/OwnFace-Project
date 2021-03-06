﻿using FakeFacebook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace FakeFacebook.Context
{

    public class AccountContext : DbContext
    {
      

        public AccountContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Account> Account { get; set; }


        public DbSet<Friends> Friends { get; set; }


    }
}
