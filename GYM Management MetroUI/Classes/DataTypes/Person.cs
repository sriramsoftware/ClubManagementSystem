using System;
using System.Drawing;
using System.Security.Cryptography;  //md5 or it's ok ?

namespace GYMManagementMetroUI.Classes
{
    public class Person
     {
         public enum GenderType
         {
             Male,
             Female
         }
         #region Fields
         private string _email;
         private string INVALID_EMAIL = "_NULL_";
         #endregion
         #region Properties
         public string Name
         {
             get;
             set;
         }
         public string UserName
         {
             get;
             set;
         }
         public string Password
         {

             get;
             set;
         }
         public DateTime BirthDay
         {
             get;
             set;
         }
         public int Age
         {
             get;
             set;
         }
         public string Address
         {
             get;
             set;
         }
         public GenderType Gender
         {
             get;
             set;
         }
         public int PhoneNumber
         {
             get;
             set;
         }
         public string Email
        {
            get { return _email; }
            set {
                if (value.Contains("@") && value.Contains(".") )
                {
                    _email = value;
                    return;
                }
                _email = INVALID_EMAIL;
            }
        }
         public string UserID {get;set;}

         public Image UserImage { get; set; }

         public int SubscriptionID { get; set; }
         public bool ValidEmail
         {
             get
             {
                 return (Email == INVALID_EMAIL);
             }
         }
        
         public DateTime JoinDate { get; set; }
         public Permissions.Permissions Permissions { get; set; }
         #endregion

         #region Methods
         public void SetInvaludEmailSymbol(string Sybmol)
         {
             INVALID_EMAIL = Sybmol;
         }
         public Person()
         {
             Permissions = new Permissions.Permissions();
         }
         #endregion

     }
}
