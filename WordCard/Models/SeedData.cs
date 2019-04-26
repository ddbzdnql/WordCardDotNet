using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using WordCard.Models;

namespace WordCard.Models
{
    public class SeedData{
        public static void initialize(IApplicationBuilder app) {
            MyDbContext repo = app.ApplicationServices.GetRequiredService<MyDbContext>();
            repo.Database.Migrate();
            if (!repo.Words.Any()) {
                repo.Words.AddRange(
                    new Word {
                        Name = "abase",
                        Explanation = "lower; degrade; humiliate; make humble; make (oneself) lose self-respect",
                        Index = 1
                    },
                    new Word {
                        Name = "word 2",
                        Explanation = "placeholder for real words with explanations to be populated later",
                        Index = 2
                    },
                    new Word
                    {
                        Name = "word 3",
                        Explanation = "placeholder for real words with explanations to be populated later",
                        Index = 3
                    },
                    new Word
                    {
                        Name = "word 4",
                        Explanation = "placeholder for real words with explanations to be populated later",
                        Index = 4
                    },
                    new Word
                    {
                        Name = "word 5",
                        Explanation = "placeholder for real words with explanations to be populated later",
                        Index = 5
                    }
                );
                repo.SaveChanges();
            }
        }
    }
}
