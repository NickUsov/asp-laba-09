using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
        
    }
    public partial class UserMetaData
    {
        public int Id { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Role Role { get; set; }
        public bool IsMarried { get; set; }
        public Address Address { get; set; }
    }
}