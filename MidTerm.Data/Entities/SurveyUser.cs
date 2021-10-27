using System;
using System.ComponentModel.DataAnnotations;
using midTerm.Data.Enums;

namespace midTerm.Data.Entities
{
    public class SurveyUser
    {
        [Required]
        public int Id { get; set; }

        [StringLength(2, ErrorMessage = "Name length can't be more than 8.")]
        public string FirstName { get; set; }

        [StringLength(2, ErrorMessage = "Name length can't be more than 8.")]
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
    }
}
