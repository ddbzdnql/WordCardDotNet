using System;
using System.Linq;
using System.Collections.Generic;

namespace WordCard.Models
{
    public class EFWordRepo : IWordRepository{
        public MyDbContext ctxt { get; }
        public IQueryable<Word> Words => ctxt.Words;

        public EFWordRepo(MyDbContext context){
            ctxt = context;
        }

        public int FindNextIndex() {
            int i = 1;
            foreach (var w in Words) { 
                if (i != w.Index) {
                    return i;
                }
                i++;
            }
            return i;
        }
    }
}
