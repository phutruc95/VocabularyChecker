using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyChecker_Model
{
    public class Exercise
    {
        [Key]
        public int ID { get; set; }
        public string Content { get; set; }
        public string KeyWord { get; set; }

        public int WordId { get; set; }
        public Word Word { get; set; }
    }
}
