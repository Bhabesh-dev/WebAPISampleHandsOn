using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPISampleHandsOn.Models
{
    public class Brand : BaseEntity
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }

    public class Category : BaseEntity
    {
        public int CategotyID { get; set; }
        public string CategoryName { get; set; }

    }


    public class Product :BaseEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public int ModelYear { get; set; }
        public decimal listPrice { get; set; }

    }


    public class Stock
    {
        public int StoreID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }


    }


    public class Customer:BaseEntity
    {
        public int CustomerID { get; set; }
        public string FirstName  { get; set; }

        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }

    public class OrderItems
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int ProductID { get; set; }
        public int Quanity { get; set; }
        public decimal ListPrice { get; set; }
        public decimal Discount { get; set; }


    }

    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreID { get; set; }
        public int StaffID { get; set; }


    }


    public class Staff : BaseEntity
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Active { get; set; }
        public int StoreID { get; set; }
        public int ManagerID { get; set; }

    }

    public class Store : BaseEntity
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }

        public string EmailID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }

}
