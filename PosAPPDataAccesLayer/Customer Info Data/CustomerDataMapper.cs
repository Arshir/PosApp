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
using PosAPPBusinessLayer.Customer_Info_Class;
using PosAPPDataAccessLayerBase;
using PosAPPDataAccesLayer.Query_Model;
using PosAPPBusinessLayer.Error_Logging;

namespace PosAPPDataAccesLayer.Customer_Info_Data
{
    public class CustomerDataMapper
    {
        private DALHelper dal;
        private Customer customer;

        public CustomerDataMapper()
        {
            this.dal = new DALHelper();
            this.customer = new Customer();
        }

        #region SAVE
        public void Save(object item)
        {
            try
            {
                Customer customer = (Customer)item;
                dal.ClearParameters();
                dal.CreateParameter("@FirstName", customer.FirstName, DbType.String);
                dal.CreateParameter("@OtherName", customer.OtherName, DbType.String);
                dal.CreateParameter("@DOB", customer.DOB, DbType.Date);

                dal.ExecuteNonQuery("Insert Into Customer (ID,FirstName,OtherName,DOB) Values(@ID,@FirstName,@OtherName,@DOB)");
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
                Customer customer=(Customer)item;
                dal.ClearParameters();
                dal.CreateParameter("@ID", customer.ID, DbType.Int32);
                dal.CreateParameter("@FirstName", customer.FirstName, DbType.String);
                dal.CreateParameter("@OtherName", customer.OtherName, DbType.String);
                dal.CreateParameter("@DOB", customer.DOB, DbType.Date);

                dal.ExecuteNonQuery("Update Customer Set FirstName=@FirstName,OtherName=@OtherName,DOB=@DOB Where ID =@ID");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
        }
        #endregion

        #region Get All
        public IList<Customer> GetAll()
        {
            IList<Customer> customers = new List<Customer>();
            try
            {
                string query = "select CustomerView.* from CustomerView ";
                query += "WHERE CustomerView.Archived=@Archived order BY CustomerView.FirstName ASC";
                DataTable table = dal.ExecuteReader(query);

                foreach (Customer cus in BuildCustomerFromData(table))
                {
                    customers.Add(cus);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }

            return customers;
        }
        #endregion

        #region GetByCriteria
        public IList<Customer> GetByCriteria(Query query1)
        {
            IList<Customer> customers = new List<Customer>();
            try
            {
                DataTable table = new DataTable();

                string query = "select CustomerView.* from CustomerView ";

                string selectStatement = QueryTranslater.TranslateQuery(query, query1);
                selectStatement += "  CustomerView.Archived=@Archived order BY CustomerView.OtherName ASC";
                table = dal.ExecuteReader(selectStatement);
                foreach (Customer cus in BuildCustomerFromData(table))
                {
                    customers.Add(cus);
                }
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return customers;
        }
        #endregion

        #region Get By PhoneNumber
        public Customer GetByPhoneNumber(object key)
        {
            Customer customer = new Customer();
            try
            {
                DataTable table = new DataTable();
                dal.ClearParameters();
                dal.CreateParameter("@Archived", customer.Archived, DbType.Boolean);
                dal.CreateParameter("@PrimaryPhoneNumber", key.ToString(), DbType.String);
                string query = "SELECT CustomerView.* From CustomerView ";
                query += "WHERE CustomerView.PrimaryPhoneNumber=@PrimaryPhoneNumber And CustomerView.Archived=@Archived order BY CustomerView.OtherName ASC";

                table = dal.ExecuteReader(query);
                foreach (Customer cust in BuildCustomerFromData(table))
                {
                    customer = cust;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return customer;
        }
        #endregion

        #region LazyLoad
        public IList<Customer> LazyLoad()
        {
            IList<Customer> customers = new List<Customer>();
            try
            {
                dal.ClearParameters();
                dal.CreateParameter("@Archived", false, DbType.Boolean);
                string query = "SELECT CustomerView.* From CustomerView Where CustomerView.Archived=@Archived Order By CustomerView.OtherName";
                DataTable table = dal.ExecuteReader(query);
                foreach (Customer cust in BuildCustomerFromData(table))
                {
                    customers.Add(cust);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return customers;
        }
        #endregion

        #region LazyLoadCriteria
        public IList<Customer> LazyLoadCriteria(Query query1)
        {
            IList<Customer> customers = new List<Customer>();
            try
            {
                DataTable table = new DataTable();
                string query = "SELECT CustomerView.* From CustomerView ";
                string selectStatement = QueryTranslater.TranslateQuery(query, query1);
                selectStatement += " CustomerView.Archived='False' Order By CustomerView.CustomerNumber";
                table = dal.ExecuteReader(selectStatement);
                foreach (Customer customer in BuildCustomerFromData(table))
                {
                    customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return customers;
        }
        #endregion

        #region Get By ID
        public Customer GetByID(object key)
        {
            Customer customer = new Customer();
            try
            {
                DataTable table = new DataTable();
                dal.ClearParameters();
                dal.CreateParameter("@Archived", "False", DbType.String);
                dal.CreateParameter("@ID", key.ToString().Trim(), DbType.String);
                string query = "SELECT CustomerView.* From CustomerView ";
                query += "WHERE CustomerView.ID=@ID And CustomerView.Archived=@Archived order BY CustomerView.OtherName ASC";

                table = dal.ExecuteReader(query);
                foreach (Customer cust in BuildCustomerFromData(table))
                {
                    customer = cust;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return customer;
        }
        #endregion

        #region LazyLoadByID
        public Customer LazyLoadByID(object item)
        {
            Customer customer = new Customer();
            try
            {
                Customer cus = new Customer();
                dal.ClearParameters();
                dal.CreateParameter("@Archived", cus.Archived, DbType.Boolean);
                dal.CreateParameter("@CustomerNumber", cus.CustomerNumber, DbType.String);
                string query = "SELECT CustomerView.* From CustomerView Where CustomerView.CustomerNumber=@CustomerNumber AND CustomerView.Archived=@Archived Order By CustomerView.OtherName";
                DataTable table = dal.ExecuteReader(query);
                foreach (Customer cust in BuildCustomerFromData(table))
                {
                    customer = cust;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return customer;
        }
        #endregion

        #region BuildCustomerFromData
        private IList<Customer> BuildCustomerFromData(DataTable table)
        {
            IList<Customer> customers = new List<Customer>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    Customer customer = new Customer()
                    {
                        ID = int.Parse(row["ID"].ToString()),
                        CustomerNumber = row["CustomerNumber"].ToString(),
                        FirstName = row["Code"].ToString(),
                        OtherName = row["Description"].ToString(),
                        DOB = row["DOB"] is DBNull ? null : (Nullable<DateTime>)DateTime.Parse(row["DOB"].ToString()), 
                        Archived = row["Archived"] is DBNull ? false : bool.Parse(row["Archived"].ToString()),
                    };
                    customers.Add(customer);
                }
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
                throw ex;
            }
            return customers;
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

                dal.ExecuteNonQuery("Update Customer Set Archived=@Archived Where ID =@ID");
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
