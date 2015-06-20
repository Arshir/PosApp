using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PosAPPBusinessLayer.Error_Logging;
using PosAPPBusinessLayer.User_Account_Info_Class;
using PosAPPBusinessLayer.Staff_Info_Class;
using PosAPPDataAccesLayer.Query_Model;
using PosAPPDataAccessLayerBase;

namespace PosAPPDataAccesLayer.User_Account_Info_Data
{
    public class UserDataMapper
    {
        private DALHelper dal;

        public UserDataMapper()
        {
            this.dal = new DALHelper();
        }

        #region Save
        public void Save(object item)
        {
            try
            {
                User user = (User)item;
                dal.ClearParameters();
                dal.CreateParameter("@UserName", user.UserName, DbType.String);
                dal.CreateParameter("@Password", user.Password, DbType.String);
                dal.CreateParameter("@AccountBlocked", user.AccountBlocked, DbType.Boolean);
                dal.CreateParameter("@StaffID", user.Staff.ID, DbType.Int32);
                dal.ExecuteNonQuery("Insert Into User (UserName,Password,AccountBlocked,StaffID) Values (@UserName,@Password,@AccountBlocked,@StaffID)");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
        }
        #endregion

        #region Update
        public void Update(object item)
        {
            try
            {
                User user = (User)item;
                dal.ClearParameters();
                dal.CreateParameter("@ID", user.ID, DbType.Int32);
                dal.CreateParameter("@UserName", user.UserName, DbType.String);
                dal.CreateParameter("@Password", user.Password, DbType.String);
                dal.CreateParameter("@AccountBlocked", user.AccountBlocked, DbType.Boolean);
                dal.CreateParameter("@StaffID", user.Staff.ID, DbType.Int32);
                dal.ExecuteNonQuery("Update Users Set UserName=@UserName,Password=@Password,AccountBlocked=@AccountBlocked,StaffID=@StaffID Where ID =@ID");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
        }
        #endregion

        #region GetAll
        public IList<User> GetAll()
        {
            IList<User> users = new List<User>();
            try
            {
                string query = "Select UserView.* From UserView Where UserView.AccountBlocked='False'";
                DataTable usersTable = dal.ExecuteReader(query);
                foreach (User use in BuildUserFromData(usersTable))
                {
                    users.Add(use);
                }
                
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return users;
        }
        #endregion

        #region GetByCriteria
        public IList<User> GetByCriteria(Query query1)
        {
            IList<User> users = new List<User>();
            try
            {
                string query = "Select UserView.*,UserView.*,UserView.FirstName +' '+ UserView.OtherName +' '+ UserView.LastName as StaffName From UserView";
                string selectStatement = QueryTranslater.TranslateQuery(query, query1);
                selectStatement += "  UserView.AccountBlocked='False' order BY UserView.UserName ASC";
                DataTable usersTable = dal.ExecuteReader(selectStatement);
                foreach (User use in BuildUserFromData(usersTable))
                {
                    users.Add(use);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return users;
        }
        #endregion

        public void Delete(object item)
        {
            try
            {
                User user = (User)item;
                string query = "Update User Set AccountBlocked = '" + user.AccountBlocked + "' Where ID =" + user.ID;
                dal.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
        }

        #region BuildUserFromData
        private IList<User> BuildUserFromData(DataTable table)
        {
            IList<User> users = new List<User>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    User user = new User()
                    {
                        ID = int.Parse(row["ID"].ToString()),
                        UserName = row["UserName"].ToString(),
                        Password = row["Password"].ToString(),
                        Staff = new Staff() 
                        {
                            ID = int.Parse(row["StaffID"].ToString()),
                            GetFullName = row["StaffName"].ToString() 
                        },
                        AccountBlocked = bool.Parse(row["AccountBlocked"].ToString()),
                        Archived = bool.Parse(row["Archived"].ToString()),
                    };
                    users.Add(user);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return users;
        }
        #endregion

        #region Open Connection
        public void OpenConnection()
        {
            try
            {
                dal.OpenConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Close Connection
        public void CloseConnection()
        {
            try
            {
                dal.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion


    }
}
