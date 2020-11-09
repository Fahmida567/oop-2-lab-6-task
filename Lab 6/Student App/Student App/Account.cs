using System;
using System.Collections.Generic;
using System.Text;

namespace Student_App
{
    class Account
    {
        private string accName;

        public  string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string acid;

        public string AcId
       {
            get { return acid; }
            set { acid = value; }
        }
        private int balance;

        public int Balance 
        {
            get { return balance; }
            set { balance = value; }
        }


    }
}
