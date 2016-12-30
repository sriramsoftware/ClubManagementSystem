using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DBAccess
{
    /// <summary>
    /// Under Constructing
    /// </summary>
   public class DBResultClass
    {
        public enum DBResult
        {
            Success,
            Failed
        }

        public string ResultMessage { get; }
        public DBResult Result { get;}
        public DBResultClass(DBResult result, string resultMessage)
        {
            this.Result = result;
            ResultMessage = resultMessage;
        }
    }
}
