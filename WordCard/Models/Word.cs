using System;
using System.ComponentModel.DataAnnotations;

namespace WordCard.Models
{
    public class Word{
        public string Name { get; set; }
        public string Explanation { get; set; }
        [Key]
        public int Index { get; set; }
        public int TimesAccessed { get; set; }
        public int TimesCorrect { get; set; }

        public Word(){
        }
    }
}
