using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GYMManagementMetroUI.Classes.UsefulClasses
{
    /// <summary>
    /// this Changes class for handling any changes will happen
    /// Under Constructing
    /// </summary>
    /// 
    class Changes
    {
        /// <summary>
        /// object bigObj will be considering depending on current tab that use make any change
        /// </summary>
        private object bigObj;

        public Changes()
        {

        }

        /// <summary>
        /// Listener method to detect ant changes 
        /// </summary>
        /// <returns> field value</returns>
        public static object Listener()
        {

            object itemValue = "aaa";

            return  itemValue;
        }
    }
}
