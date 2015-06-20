using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosAPPBusinessLayer.Staff_Info_Class;

namespace PosAPPBusinessLayer.User_Account_Info_Class
{
    public class User
    {
        private int id;
        private string userName;
        private string password;
        private bool accountBlocked;
        private Staff staff;
        private bool archived;

        public User()
        {
            try
            {
                this.id = 0;
                this.userName = string.Empty;
                this.password = string.Empty;
                this.accountBlocked = false;
                this.staff = new Staff();
                this.archived = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool AccountBlocked
        {
            get { return accountBlocked; }
            set { accountBlocked = value; }
        }

        public Staff Staff
        {
            get { return staff; }
            set { staff = value; }
        }

        public bool Archived
        {
            get { return archived; }
            set { archived = value; }
        }
    }
}
