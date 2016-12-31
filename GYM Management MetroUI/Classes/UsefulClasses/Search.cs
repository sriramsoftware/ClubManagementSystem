using System.Windows.Forms;

namespace GYMManagementMetroUI.Classes.UsefulClasses
{
    /// <summary>
    /// this Search class to search for data in lstView s 
    /// </summary>
    class Search
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str">text that will be written in textbox search</param>
        /// <param name="list"> the listView container will search inside</param>
        public Search(string str, ListView list )
        {
            foreach (ListViewItem  item in list.Items)
            {
                // foreach coloumns [name, age , salary...etc] check if it == str
                // if true background white yellow
                // cnt++ for items lable text (will be near search box)  for each row
            }
        }
    }
}
