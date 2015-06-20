using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PosAPPDataAccesLayer.Query_Model;

namespace PosAPPDataAccesLayer.General_Info_Data
{
    public interface IDAL
    {
        //Transaction Management
        bool IsInTransaction { get; }
        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();

        //Concurrency Management
        bool IsDirty { get; }

        //Connection Management
        void OpenConnection();
        void CloseConnection();

        //RUD Methods
        void Save(object item);
        void Update(object item);
        void Delete(object key);

        //Query Management
        IList<T> GetAll<T>() where T : class;
        IList<T> LazyLoad<T>() where T : class;
        IList<T> LazyLoadCriteria<T>(Query query) where T : class;
        IList<T> GetByCriteria<T>(Query query) where T : class;

        T GetByID<T>(object key) where T : class;
        T LazyLoadByID<T>(object key) where T : class;
        T GetByPhoneNumber<T>(object key) where T : class;  
    }
}
