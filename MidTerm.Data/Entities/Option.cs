using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace midTerm.Data.Entities
{
    public class Option
    {
        [Required]
        public int Id { get; set; }
     
        [StringLength(100)]
        public string Text { get; set; }
        public int? Order { get; set; }
        
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
    }
}