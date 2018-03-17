using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// Here we Select what data we want.  
/// Select "List of Fields" From Orders
/// Then Place in the data fields defined.
/// 

namespace Simple_Inventory_System.Models
{
    [Table("Orders")]
    public class Order
    {
        public int OrderID { get; set; }
        public String CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime sDate;
        /// <summary>
        ///  Some Times ShippedDate will be Null.  DateTime requires a value be present so Nullabe<dateTime> is used to check 
        ///  if its a Null entry.  If its null it will assign it a temp value of "1/1/1" and used to signify black space.
        /// </summary>
        public Nullable<DateTime> ShippedDate {
            get
            {
                return sDate;
            }
            set
            {
                if (!value.HasValue)
                {
                    sDate = new DateTime(1, 1, 1);
                }
                else
                {
                    sDate = value.Value;
                }
            }
        }
        public String ShipName { get; set; }
        public String ShipAddress { get; set; }
        public String ShipCity { get; set; }
        public String ShipRegion { get; set; }
        public String ShipPostalCode { get; set; }
        public String ShipCountry { get; set; }
        
   }
}