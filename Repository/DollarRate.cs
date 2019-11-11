using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DollarRate
    {

        private int _Id;

        public int Id
        {
            get { return _Id; }
            set
            {
                if (value != _Id)
                {
                    _Id = value;
                }
            }
        }


        private double _Rate;

        public double Rate
        {
            get { return _Rate; }
            set
            {
                if (value != _Rate)
                {
                    _Rate = value;
                }
            }
        }


        private DateTime _RateDate;

        public DateTime RateDate
        {
            get { return _RateDate; }
            set
            {
                if (value != _RateDate)
                {
                    _RateDate = value;
                }
            }
        }
    }
}