using System;
using System.Linq;

namespace WordCard.Models
{
    public interface IWordRepository{
        IQueryable<Word> Words { get; }
        MyDbContext ctxt { get; }
    }
}
