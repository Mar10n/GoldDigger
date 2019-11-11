using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Customer : ClassNotify
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
                    Notify("Id");
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
                    Notify("Name");
                }
            }
        }


        private string _Address;

        public string Address
        {
            get { return _Address; }
            set
            {
                if (value != _Address)
                {
                    _Address = value;
                    Notify("Address");
                }
            }
        }


        private string _ZipCity;

        public string ZipCity
        {
            get { return _ZipCity; }
            set
            {
                if (value != _ZipCity)
                {
                    _ZipCity = value;
                    Notify("ZipCity");
                }
            }
        }


        private string _Country;

        public string Country
        {
            get { return _Country; }
            set
            {
                if (value != _Country)
                {
                    _Country = value;
                    Notify("Country");
                }
            }
        }


        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set
            {
                if (value != _Phone)
                {
                    _Phone = value;
                    Notify("Phone");
                }
            }
        }


        private string _MailAdr;

        public string MailAdr
        {
            get { return _MailAdr; }
            set
            {
                if (value != _MailAdr)
                {
                    _MailAdr = value;
                    Notify("MailAdr");
                }
            }
        }


        private string _MemberKey;

        public string MemberKey
        {
            get { return _MemberKey; }
            set
            {
                if (value != _MemberKey)
                {
                    _MemberKey = value;
                    Notify("MemberKey");
                }
            }
        }


        private DateTime _MemberDate;

        public DateTime MemberDate
        {
            get { return _MemberDate; }
            set
            {
                if (value != _MemberDate)
                {
                    _MemberDate = value;
                    Notify("MemberDate");
                }
            }
        }
    }
}