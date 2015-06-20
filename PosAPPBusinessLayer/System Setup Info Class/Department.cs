using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAPPBusinessLayer.System_Setup_Info_Class
{
    public class Department
    {
        private int id;
        private string description;
        private bool active;
        private bool archived;

        public Department()
        {
            try
            {
                this.id = 0;
                this.description = string.Empty;
                this.active = false;
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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public bool Archived
        {
            get { return archived; }
            set { archived = value; }
        }
    }
}
