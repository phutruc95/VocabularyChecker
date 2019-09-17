using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyChecker_Model
{
    public class Word
    {
        [Key]
        public int ID { get; set; }
        public string English { get; set; }
        public string VietnameseMeaning { get; set; }
        public string PartOfSpeech { get; set; }
        public List<string> Examples { get; set; }
    }
}
