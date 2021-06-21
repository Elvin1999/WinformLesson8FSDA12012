using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7.Model;

namespace WindowsFormsApp7.Data
{
    public class CarContext : DbContext
    {
        public CarContext() : base("CarDb")
        {

        }
        public DbSet<Car> Cars { get; set; }
        //////public DbSet<Oil> Oils { get; set; }


    }
}
