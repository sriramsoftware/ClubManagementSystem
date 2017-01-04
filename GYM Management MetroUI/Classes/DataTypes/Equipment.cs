using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ClubManagement.Classes.DataTypes
{
   public class Equipment
    {
        public static readonly string className = "Equipment"; // Readonly to prevent edit!
        #region Properties
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Image Photo { get; set; }
        public int Quantity { get; set; }
        public float PricePerOne { get; set; }
        public EquipFactory Factory { get; set; }
        public int MaintainPeriod { get; set; }
        #endregion

    }
}
