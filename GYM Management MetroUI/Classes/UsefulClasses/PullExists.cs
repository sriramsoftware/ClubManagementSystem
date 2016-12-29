using DevComponents.DotNetBar.Controls;
using GYMManagementMetroUI.Classes.DataTypes;
using System.Windows.Forms;



namespace GYMManagementMetroUI.Classes.UsefulClasses
{
    

    //this class to pull exists person details while adding new one
    //benefit if 2 brothers will go to sign up { add first one and pull him for his brother etc..}
    class PullExists
    {

        private  object p;

        //                comboBox   ,    groupPnl   ,   [member,coach,admin...etc]
        public PullExists(string theExist, Control theNew, string type, int id)
        {
           
            //hold data
            switch (type.ToLower())
            {
                //                create object,        pull db data,           change
                case "member":    p = new Member();     dbPullData(1, id);      changeMember(theNew, p);    break;
                case "coach":     p = new Coach();      dbPullData(2, id);      changeCoach(theNew, p);     break;
                case "moderator": p = new Moderator();  dbPullData(3, id);      changeModerator(theNew, p); break;
                case "admin":     p = new Admins();     dbPullData(4, id);      changeAdmin(theNew, p);     break;
                case "equipment": p = new Equipment();  dbPullData(5, id);      changeEquiment(theNew, p);  break;
            }

            

        }

        public static void  dbPullData(int type,int id){
            

            switch (type)
            {
                case 1: queryT(id, "membersTable"); break;
                case 2: queryT(id, "coachsTable"); break;
                case 3: queryT(id, "moderatorsTable"); break;
                case 4: queryT(id, "adminsTable"); break;
                case 5: queryT(id, "equipmentsTable"); break;
            }
            
        }     


        public static object queryT(int id, string table)
        {
            // new Person() is an ex
            object obj = new Person();

            // query will be here to pull data from 'table' where id == 'id'

            //obj =

            return obj;
        }


        public static void changeMember(Control theNew, object old)
        {
            foreach (Control control in theNew.Controls)
            {
                //switch(control type) and assign like rest class
                //theNew.Text = old->text etc...
            }
        }

        public static void changeCoach(Control theNew, object old)
        {
            foreach (Control control in theNew.Controls)
            {
                //switch(control type) and assign like rest class
                //theNew.Text = old->text etc...
            }
        }

        public static void changeModerator(Control theNew, object old)
        {
            foreach (Control control in theNew.Controls)
            {
                //switch(control type) and assign like rest class
                //theNew.Text = old->text etc...
            }
        }

        public static void changeAdmin(Control theNew, object old)
        {
            foreach (Control control in theNew.Controls)
            {
                //switch(control type) and assign like rest class
                //theNew.Text = old->text etc...
            }
        }

        public static void changeEquiment(Control theNew, object old)
        {
            foreach (Control control in theNew.Controls)
            {
                //switch(control type) and assign like rest class
                //theNew.Text = old->text etc...
            }
        }


    }
}
