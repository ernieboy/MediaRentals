using System;
using MediaRentals.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediaRentals.Infrastructure.EntityFramework.Configuration
{
    public class BookAuthorConfiguration: IEntityTypeConfiguration<BookAuthor>
    {
        public BookAuthorConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            throw new NotImplementedException();
        }
    }
}
