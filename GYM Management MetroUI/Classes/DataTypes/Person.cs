using System;
using System.Drawing;

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
         private string name;
         private DateTime birthDate;
         private int age;
         private string _address;
         private string id;
         private int _phoneNumber;
         private GenderType _gender;
         private string _email;
         private string INVALID_EMAIL = "_NULL_";

         #endregion
         #region Properties
         public string Name
        {
            get { return name; }
            set { name = value; }
        }
         public DateTime BirthDay
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
         public int Age
        {
            get { return age; }
            set { age = value; }
        }
         public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
         public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
         public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
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
         public string UserID
        {
            get { return id; }
            set { id = value; }
        }

         public Image UserImage { get; set; }

         public string UserName { get; set; }
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
