﻿using BarberShop_Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BarberShop_Api.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {
        }


        public DbSet<ClientModel> Clients;

    }
}
