using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using WordCard.Models;

namespace WordCard.Models
{
    public class QuizView{
        public IWordRepository repo { get; set; }
        public List<Word> snapshot { get; set; } = new List<Word>();
        public int index { get; set; } = 0;

        public QuizView(IWordRepository r){
            repo = r;
            foreach (Word w in r.Words) {
                snapshot.Add(w);
            }
        }

        public Word getCurrent() {
            return snapshot.ElementAt(index);
        }

        public void forward() {
            index += 1;
            if (index == repo.Words.Count()-1) {
                index = repo.Words.Count()-1;
            }
        }

        public void backward() {
            index -= 1;
            if (index < 0) {
                index = 0;
            }
        }
    }
}
