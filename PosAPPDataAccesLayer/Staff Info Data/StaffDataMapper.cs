using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Collections;
using System.ComponentModel;
using PosAPPDataAccessLayerBase;
using PosAPPDataAccesLayer.Query_Model;
using PosAPPBusinessLayer.Staff_Info_Class;
using PosAPPBusinessLayer.Error_Logging;

namespace PosAPPDataAccesLayer.Staff_Info_Data
{
    public class StaffDataMapper
    {
        private DALHelper dal;
        private Staff staff;

        public StaffDataMapper()
        {
            this.dal = new DALHelper();
            this.staff = new Staff();
        }

        #region SAVE
        public void Save(object item)
        {
            try
            {
                Staff staff = (Staff)item;
                dal.ClearParameters();
                dal.CreateParameter("@FirstName", staff.FirstName, DbType.String);
                dal.CreateParameter("@OtherName", staff.OtherName, DbType.String);
                dal.CreateParameter("@LastName", staff.OtherName, DbType.String);
                dal.CreateParameter("@DOB", staff.DOB, DbType.Date);

                dal.ExecuteNonQuery("Insert Into Staff (ID,FirstName,OtherName,LastName,DOB) Values(@ID,@FirstName,@OtherName,@LastName,@DOB)");
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
                Staff staff = (Staff)item;
                dal.ClearParameters();
                dal.CreateParameter("@ID", staff.ID, DbType.Int32);
                dal.CreateParameter("@FirstName", staff.FirstName, DbType.String);
                dal.CreateParameter("@OtherName", staff.OtherName, DbType.String);
                dal.CreateParameter("@LastName", staff.OtherName, DbType.String);
                dal.CreateParameter("@DOB", staff.DOB, DbType.Date);

                dal.ExecuteNonQuery("Update Staff Set FirstName=@FirstName,OtherName=@OtherName,LastName=@LastName,DOB=@DOB Where ID =@ID");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
        }
        #endregion

        #region Get All
        public IList<Staff> GetAll()
        {
            IList<Staff> staffs = new List<Staff>();
            try
            {
                string query = "select CustomerView.* from CustomerView ";
                query += "WHERE CustomerView.Archived=@Archived order BY CustomerView.FirstName ASC";
                DataTable table = dal.ExecuteReader(query);

                foreach (Staff staf in BuildStaffFromData(table))
                {
                    staffs.Add(staf);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }

            return staffs;
        }
        #endregion

        #region GetByCriteria
        public IList<Staff> GetByCriteria(Query query1)
        {
            IList<Staff> staffs = new List<Staff>();
            try
            {
                DataTable table = new DataTable();

                string query = "select CustomerView.* from CustomerView ";

                string selectStatement = QueryTranslater.TranslateQuery(query, query1);
                selectStatement += "  CustomerView.Archived=@Archived order BY CustomerView.OtherName ASC";
                table = dal.ExecuteReader(selectStatement);
                foreach (Staff staf in BuildStaffFromData(table))
                {
                    staffs.Add(staf);
                }
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return staffs;
        }
        #endregion

        #region Get By PhoneNumber
        public Staff GetByPhoneNumber(object key)
        {
            Staff staff = new Staff();
            try
            {
                DataTable table = new DataTable();
                dal.ClearParameters();
                dal.CreateParameter("@Archived", staff.Archived, DbType.Boolean);
                dal.CreateParameter("@PrimaryPhoneNumber", key.ToString(), DbType.String);
                string query = "SELECT StaffView.* From CustomerView ";
                query += "WHERE StaffView.PrimaryPhoneNumber=@PrimaryPhoneNumber And StaffView.Archived=@Archived order BY StaffView.LastName ASC";

                table = dal.ExecuteReader(query);
                foreach (Staff staf in BuildStaffFromData(table))
                {
                    staff = staf;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return staff;
        }
        #endregion

        #region LazyLoad
        public IList<Staff> LazyLoad()
        {
            IList<Staff> staffs = new List<Staff>();
            try
            {
                dal.ClearParameters();
                dal.CreateParameter("@Archived", false, DbType.Boolean);
                string query = "SELECT StaffView.* From StaffView Where StaffView.Archived=@Archived Order By StaffView.LastName";
                DataTable table = dal.ExecuteReader(query);
                foreach (Staff staf in BuildStaffFromData(table))
                {
                    staffs.Add(staf);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return staffs;
        }
        #endregion

        #region LazyLoadCriteria
        public IList<Staff> LazyLoadCriteria(Query query1)
        {
            IList<Staff> staffs = new List<Staff>();
            try
            {
                DataTable table = new DataTable();
                string query = "SELECT StaffView.* From StaffView ";
                string selectStatement = QueryTranslater.TranslateQuery(query, query1);
                selectStatement += " StaffView.Archived='False' Order By StaffView.StaffNumber";
                table = dal.ExecuteReader(selectStatement);
                foreach (Staff staf in BuildStaffFromData(table))
                {
                    staffs.Add(staf);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return staffs;
        }
        #endregion

        #region Get By ID
        public Staff GetByID(object key)
        {
            Staff staff = new Staff();
            try
            {
                DataTable table = new DataTable();
                dal.ClearParameters();
                dal.CreateParameter("@Archived", "False", DbType.String);
                dal.CreateParameter("@ID", key.ToString().Trim(), DbType.String);
                string query = "SELECT StaffView.* From CustomerView ";
                query += "WHERE StaffView.ID=@ID And StaffView.Archived=@Archived order BY StaffView.LastName ASC";

                table = dal.ExecuteReader(query);
                foreach (Staff staf in BuildStaffFromData(table))
                {
                    staff = staf;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return staff;
        }
        #endregion

        #region LazyLoadByID
        public Staff LazyLoadByID(object item)
        {
            Staff staff = new Staff();
            try
            {
                Staff sta = new Staff();
                dal.ClearParameters();
                dal.CreateParameter("@Archived", sta.Archived, DbType.Boolean);
                dal.CreateParameter("@StaffNumber", sta.StaffNumber, DbType.String);
                string query = "SELECT StaffView.* From StaffView Where StaffView.StaffNumber=@StaffNumber AND StaffView.Archived=@Archived Order By StaffView.LastName";
                DataTable table = dal.ExecuteReader(query);
                foreach (Staff staf in BuildStaffFromData(table))
                {
                    staff = staf;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return staff;
        }
        #endregion

        #region BuildStaffFromData
        private IList<Staff> BuildStaffFromData(DataTable table)
        {
            IList<Staff> staffs = new List<Staff>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    Staff staff = new Staff()
                    {
                        ID = int.Parse(row["ID"].ToString()),
                        StaffNumber = row["StaffNumber"].ToString(),
                        FirstName = row["FirstName"].ToString(),
                        OtherName = row["OtherName"].ToString(),
                        DOB = row["DOB"] is DBNull ? null : (Nullable<DateTime>)DateTime.Parse(row["DOB"].ToString()), 
                        Archived = row["Archived"] is DBNull ? false : bool.Parse(row["Archived"].ToString()),
                    };
                    staffs.Add(staff);
                }
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return staffs;
        }
        #endregion

        #region DELET
        public void Delete(object key)
        {
            try
            {
                dal.ClearParameters();
                dal.CreateParameter("@ID", key.ToString(), DbType.Int32);
                dal.CreateParameter("@Archived", true, DbType.Boolean);

                dal.ExecuteNonQuery("Update Staff Set Archived=@Archived Where ID =@ID");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
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
                Logger.LogError(ex);
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
                Logger.LogError(ex);
                throw ex;
            }

        }
        #endregion
    }
}
