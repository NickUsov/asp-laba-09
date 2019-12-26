using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public enum Role { Admin,User,Guest}
    //[DisplayName("Anonimus")]
    public partial class User
    {
        //[HiddenInput(DisplayValue = true)]
        public int Id { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Role Role { get; set; }
        public bool IsMarried { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        [Display(Name ="Address 1")]
        [UIHint("Multiline")]
        public string Line1 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}