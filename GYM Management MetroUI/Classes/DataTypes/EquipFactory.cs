using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubManagement.Classes.DataTypes
{
   public class EquipFactory
    {
        public string CompanyName { get; set; }
        public string WebSite { get; set; }
        public int ID { get; set; }
        public static EquipFactory Parse(EquipFactory equip)
        {
            EquipFactory e = new EquipFactory();
            string st = equip.ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            string[] splited = st.Split('-');
            e.ID = Convert.ToInt32(splited[0]);
            e.CompanyName = splited[1];
            e.WebSite = splited[2];
            return e;
        }
        
        public override string ToString()
        {
            string result = "";
            result = string.Format("[{0} - {1} - {2}]",ID,this.CompanyName,this.WebSite);
            return result;
        }
    }
}
