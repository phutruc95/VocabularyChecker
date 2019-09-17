using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyChecker_Model;

namespace VocabularyChecker.Repository
{
    public class VocabularyCheckerContext : DbContext
    {
        public VocabularyCheckerContext() : base("VocabularyCheckerContext")
        {

        }
        public DbSet<Word> Words { get; set; }
    }
}
