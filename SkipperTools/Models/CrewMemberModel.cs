using System;
using System.ComponentModel.DataAnnotations;

namespace SkipperTools.Models
{
    public class CrewMemberModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Function { get; set; }
        public DateTime BirthDay { get; set; }
        public int Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string EMailAddress { get; set; }

        //DO NOT add any sensetive data props before security tests


    }
}
