﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MediaRentals.Infrastructure.EntityFramework
{
    public class IdentitiesDbContext : IdentityDbContext
    {
        public IdentitiesDbContext(DbContextOptions<IdentitiesDbContext> options)
            : base(options)
        {
        }
    }
}
