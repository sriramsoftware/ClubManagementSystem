using ClubManagement.Classes.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubManagement.Classes.DataTypes
{
    /// <summary>
    /// we use this class to return the type of object
    /// </summary>
    class DetectType
    {

        /// <summary>
        /// retur type of obj
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Type dType(object obj)
        {
            object ob = new object();
            if (obj is Admins) ob = new Admins();
            else if (obj is Coach) ob = new Coach();
            else if (obj is Equipment) ob = new Equipment();
            else if (obj is Member) ob = new Member();
            else if (obj is Moderator) ob = new Moderator();
            //else if (obj is Person) ob = new Person();
            else return null;
            return ob.GetType();
        }


        /// <summary>
        /// return new object of same type
        /// [ Note: Edit method name to name which refers to its job! ]
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object dObj(object obj)
        {
            object ob = new object();
            if (obj is Admins) ob = new Admins();
            else if (obj is Coach) ob = new Coach();
            else if (obj is Equipment) ob = new Equipment();
            else if (obj is Member) ob = new Member();
            else if (obj is Moderator) ob = new Moderator();
            //else if (obj is Person) ob = new Person();
            else return null;
            return ob;
        }


        /// <summary>
        /// return name of dataType ==> i add className var in all data types
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object dName(object obj)
        {
            string ob = "";
            if (obj is Admins) ob = Admins.className;
            else if (obj is Coach) ob = Coach.className;
            else if (obj is Equipment) ob = Equipment.className;
            else if (obj is Member) ob = Member.className;
            else if (obj is Moderator) ob = Moderator.className;
            //else if (obj is Person) ob = Person.className; // => All Datatypes inherts form Person, then all is person!
            return ob;
        }
    }
}
