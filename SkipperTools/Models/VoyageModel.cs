using System;
using System.ComponentModel.DataAnnotations;

namespace SkipperTools.Models
{
    public class VoyageModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string AreaName { get; set; }
        public bool IsEnded { get; set; }




    }
}
