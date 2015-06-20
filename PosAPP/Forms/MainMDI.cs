using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosAPPBusinessLayer.Error_Logging;

namespace PosAPP.Forms
{
    public partial class MainMDI : Form
    {
        public Form frm;
        public MainMDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        public void MakeMenusInvisible()
        {
            try
            {
                menuStrip1.Visible = false;
                //SystemSetup


                //Reports

            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
        }

        public void SetAccessLevels(int userID)
        {
            try
            {
                DataTable accessTable = null;
                menuStrip1.Visible = true;
                //foreach (DataRow row in accessTable.Rows)
                //{
                //    if (row["AccessLevel1"].ToString() == "Employment")
                //    {

                //    }
                //    if (row["AccessLevel1"].ToString() == "PayRoll Management")
                //    {
                        
                //    }
                //    if (row["AccessLevel1"].ToString() == "Time And Attendance")
                //    {
                        
                //    }

                //    if (row["AccessLevel1"].ToString() == "Employee Management")
                //    {
                        
                //    }

                //    if (row["AccessLevel1"].ToString() == "System Setup")
                //    {
                        
                //    }

                //    if (row["AccessLevel1"].ToString() == "Reports")
                //    {
                        
                //    }
                //}
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login(this);
                login.MdiParent = this;
                login.Show();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }

        private void itemPricingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
