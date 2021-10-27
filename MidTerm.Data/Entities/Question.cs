using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace midTerm.Data.Entities
{
    public class Question
    {
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        public string Text { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}