using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) 
            : base(options) { }

        //Model class, after migration PaymentDetails table will be created in SQL Server Database.
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
