﻿using System;
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


    }
}
