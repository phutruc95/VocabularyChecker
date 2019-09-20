using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyChecker_Model.ViewModel
{
    public class Answer
    {
        public int ID { get; set; }
        public string KeyWordAnswer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
