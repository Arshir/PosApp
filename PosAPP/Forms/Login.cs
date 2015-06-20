using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PosAPPBusinessLayer.User_Account_Info_Class;
using PosAPPDataAccesLayer.General_Info_Data;
using PosAPPBusinessLayer.Error_Logging;
using PosAPPDataAccesLayer.Query_Model;

namespace PosAPP.Forms
{
    public partial class Login : Form
    {
        private IDAL dal;
        private MainMDI mainMenu;
        private IList<User> users;

        public Login()
        {
            try
            {
                InitializeComponent();
                this.dal = new DAL();
                this.users = new List<User>();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }

        public Login(MainMDI mainMenu)
        {
            try
            {
                InitializeComponent();
                this.dal = new DAL();
                this.mainMenu = mainMenu;
                this.mainMenu.MakeMenusInvisible();
                this.users = new List<User>();
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Query query = new Query();
                query.Criteria.Add(new Criterion() 
                { 
                    Property = "username", 
                    CriterionOperator = CriterionOperator.EqualTo, 
                    Value = userNameTextBox.Text, CriteriaOperator = CriteriaOperator.And 
                });
                query.Criteria.Add(new Criterion() 
                { 
                    Property = "password", 
                    CriterionOperator = CriterionOperator.EqualTo, 
                    Value = passwordTextBox.Text, 
                    CriteriaOperator = CriteriaOperator.And 
                });
                query.Criteria.Add(new Criterion() 
                { 
                    Property = "AccountBlocked", 
                    CriterionOperator = CriterionOperator.EqualTo, 
                    Value = "False", 
                    CriteriaOperator = CriteriaOperator.And 
                });
                users = dal.GetByCriteria<User>(query);
                if (users.Count > 0)
                {
                    GlobalData.User.ID = users[0].ID;
                    GlobalData.User.Staff.GetFullName = users[0].Staff.GetFullName;
                    GlobalData.Caption += " - Current User: " + users[0].UserName;
                    mainMenu.Text = GlobalData.Caption;
                    mainMenu.SetAccessLevels(GlobalData.User.ID);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password", GlobalData.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A network related error occured while establishing a connection to the central database", GlobalData.Caption,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Logger.LogError(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                dal.CloseConnection();
                this.MdiParent.Close();
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = GlobalData.Caption;
                userNameTextBox.Select();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }
    }
}  
