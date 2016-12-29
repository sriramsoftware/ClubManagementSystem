using System.Windows.Forms;

namespace GYMManagementMetroUI.Classes.UsefulClasses
{
    //this class to search for data in lstView s 
    class Search
    {
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
