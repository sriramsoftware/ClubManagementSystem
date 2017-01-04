using System;
using System.Drawing;

//md5 or it's ok ?

namespace ClubManagement.Classes.DataTypes
{
    public abstract class Person
     {
        public static readonly string className = "Person"; // Readonly to prevent edit!
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
         public string Photo
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
        public DateTime DeactivateDate { get; set; }
        public int PendingState { get; set; }
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
        public string Comments { get; set; }
        public DateTime JoinDate { get; set; }
         public Permissions.PermissionsClass Permissions { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Theme { get; set; }
        #endregion

        #region Methods
        public void SetInvaludEmailSymbol(string sybmol)
         {
             INVALID_EMAIL = sybmol;
         }
         public Person()
         {
             Permissions = new Permissions.PermissionsClass();
         }
         #endregion

     }
}
