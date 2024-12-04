using ClassLibrary1.core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;


namespace Crowdshipping.Data
{
    public class DataContext : DbContext
    {


        public DbSet<Payment> PaymentsList { get; set; }
        public DbSet<Shipment> shipmentsList { get; set; }
        public DbSet<PackageOrderer> packageOrdererList { get; set; }
        public DbSet<Courier> CouriersList { get; set; }



        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {





        }


    }
}
