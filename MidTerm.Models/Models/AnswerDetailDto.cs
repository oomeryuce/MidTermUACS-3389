using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Models.Models
{
    public class AnswerDetailDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserCountry { get; set; }
        public string OptionsText { get; set; }
        public string QuestionText { get; set; }
        public string QuestionDescription { get; set; }
    }
}
