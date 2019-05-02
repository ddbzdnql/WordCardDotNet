using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WordCard.Models{
    public class ListView{
        public List<Word> snapshot { get; set; } = new List<Word>();
        public DbSet<Word> repo { get; set; }

        public ListView(MyDbContext r){
            repo = r.Words;
            foreach (var w in repo){
                snapshot.Add(w);
            }
        }

        public int GetCount() { return snapshot.Count; }
    }
}
