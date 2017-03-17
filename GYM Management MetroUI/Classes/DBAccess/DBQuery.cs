using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubManagement.Classes.DBAccess
{
    /// <summary>
    /// We'll use it to pull data from db,
    /// To use this class use it by typing:
    /// DBQuery [varName] = DBQuery.Instance;
    /// </summary>
    class DBQuery
    {
        #region Singletone
        private static DBQuery _me = null;
        public static DBQuery Instance
        {
            get
            {
                if (_me == null)
                {
                    _me = new DBQuery();
                }
                return _me;
            }
        }
        private DBQuery()
        {
            _me = this;
        }
        #endregion
    }
}
