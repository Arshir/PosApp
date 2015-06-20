using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PosAPPDataAccessLayerBase;
using PosAPPBusinessLayer.Error_Logging;
using PosAPPBusinessLayer.Customer_Info_Class;
using PosAPPDataAccesLayer.Customer_Info_Data;
using PosAPPBusinessLayer.User_Account_Info_Class;
using PosAPPDataAccesLayer.User_Account_Info_Data;
using PosAPPDataAccesLayer.Query_Model;

namespace PosAPPDataAccesLayer.General_Info_Data
{
    public class DAL: IDAL
    {
        private DALHelper dalHelper;

        public DAL()
        {
            try
            {
                this.dalHelper = new DALHelper();
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
            }
        }

        #region Transaction Management
        public bool IsInTransaction 
        {
            get { return dalHelper.IsInTransaction; }
        }

        public void BeginTransaction()
        {
            try
            {
                dalHelper.BeginTransaction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CommitTransaction()
        {
            try
            {
                dalHelper.CommitTransaction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RollBackTransaction()
        {
            try
            {
                dalHelper.RollBackTransaction();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Concurrency Management
        public bool IsDirty 
        {
            get { return false; }
        }
        #endregion

        #region Save
        public void Save(object item)
        {
            if (item.GetType() == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    edm.Save(item);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The type is not known for saving");
            }
        }
        #endregion

        #region Update
        public void Update(object item)
        {
            if (item.GetType() == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    edm.Update(item);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The type is not known for update");
            }
        }
        #endregion

        #region Delete
        public void Delete(object item)
        {
            if (item.GetType() == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    edm.Delete(item);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
    
            else
            {
                throw new ArgumentOutOfRangeException("The type is not known for delete");
            }
        }
        #endregion

        #region GetByCriteria
        public IList<T> GetByCriteria<T>(Query query) where T : class
        {
            if (typeof(T) == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    return (IList<T>)edm.GetByCriteria(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (typeof(T) == typeof(User))
            {
                UserDataMapper edm = new UserDataMapper();
                try
                {
                    return (IList<T>)edm.GetByCriteria(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The type is not known for getCriterior");
            }
        }
        #endregion

        #region Get All
        public IList<T> GetAll<T>() where T : class 
        {
            if (typeof(T) == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    return (IList<T>)edm.GetAll();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The type is not known for getAll");
            }
        }
        #endregion

        #region LazyLoad
        public IList<T> LazyLoad<T>() where T : class 
        {
            if (typeof(T) == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    return (IList<T>)edm.LazyLoad();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region LazyLoadByID
        public T LazyLoadByID<T>(object key) where T : class
        {
            if (typeof(T) == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    T item = (T)(object)edm.LazyLoadByID(key);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region LazyLoadCriteria
        public IList<T> LazyLoadCriteria<T>(Query query) where T : class
        { 
            if (typeof(T) == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    return (IList<T>)edm.LazyLoadCriteria(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The Method LazyLoadCriterior is not Known");
            }
        }
        #endregion

        #region Get By ID
        public T GetByID<T>(object key) where T : class
        {
            if (typeof(T) == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    T item = (T)(object)edm.GetByID(key);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                throw new ArgumentException("The Method GetByID does not exist");
        }
        #endregion

        #region Get By Phone Number
        public T GetByPhoneNumber<T>(object key) where T : class
        {
            if (typeof(T) == typeof(Customer))
            {
                CustomerDataMapper edm = new CustomerDataMapper();
                try
                {
                    T item = (T)(object)edm.GetByPhoneNumber(key);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                throw new ArgumentException("The Method GetByPhoneNumber does not exist");
        }
        #endregion


        #region OpenConnection
        public void OpenConnection()
        {
            try
            {
                dalHelper.OpenConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CloseConnection
        public void CloseConnection()
        {
            try
            {
                dalHelper.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
