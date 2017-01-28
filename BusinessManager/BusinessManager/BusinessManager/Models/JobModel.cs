using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    public class JobModel
    {
        public int ID { get; private set; }
        public int AccountID { get; private set; }
        public string Date { get; private set; }
        public string Description { get; private set; }
        public double FixedPrice { get; private set; }
        public double HourlyRate { get; private set; }
        public double Hours { get; private set; }

        public JobModel(int ID, int AccountID, string Date, string Description, double FixedPrice)
        {
            this.ID = ID;
            this.AccountID = AccountID;
            this.Date = Date;
            this.Description = Description;
            this.FixedPrice = FixedPrice;
        }

        public JobModel(int ID, int AccountID, string Date, string Description, double HourlyRate, double Hours)
        {
            this.ID = ID;
            this.AccountID = AccountID;
            this.Date = Date;
            this.Description = Description;
            this.HourlyRate = HourlyRate;
            this.Hours = Hours;
        }
    }
}
