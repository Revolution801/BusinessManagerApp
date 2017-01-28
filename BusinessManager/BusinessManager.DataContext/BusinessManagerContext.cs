using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace BusinessManager.DataContext
{
    class BusinessManagerContext: DbContext
    {
        public BusinessManagerContext(): base("BusinessManagerContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<JobModel> Jobs { get; set; }
        
    }
}
