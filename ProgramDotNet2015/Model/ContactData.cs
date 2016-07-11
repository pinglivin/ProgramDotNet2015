using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAdressbookTests
{
    public class ContactData
    {
        private string name;
        private string lastName;
        private string company;
        private string mobile ="";

        public ContactData(string name, string lastName, string company)
        {
            this.name = name;
            this.lastName = lastName;
            this.company = company;
        }

        public ContactData(string name, string lastName, string company, string mobile)
        {
            this.name = name;
            this.lastName = lastName;
            this.company = company;
            this.mobile = mobile;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }
    }
}
