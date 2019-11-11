using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PreciusMetals
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


        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                }
            }
        }


        private double _DkkPrice;

        public double DkkPrice
        {
            get { return _DkkPrice; }
            set
            {
                if (value != _DkkPrice)
                {
                    _DkkPrice = value;
                }
            }
        }


        private double _UsdPrice;

        public double UsdPrice
        {
            get { return _UsdPrice; }
            set
            {
                if (value != _UsdPrice)
                {
                    _UsdPrice = value;
                }
            }
        }
    }
}