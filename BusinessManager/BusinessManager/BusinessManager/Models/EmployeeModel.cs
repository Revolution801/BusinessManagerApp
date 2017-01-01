using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    class EmployeeModel
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double HourlyRate { get; private set; }

        public EmployeeModel(int ID, string FirstName, string LastName, double HourlyRate)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.HourlyRate = HourlyRate;
        }
    }
}
