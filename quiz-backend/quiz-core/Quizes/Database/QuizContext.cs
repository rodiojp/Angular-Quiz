using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace quiz_core.Quizes.Database
{
    public class QuizContext :DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }

        public DbSet<QuizQuestionModel> Questions { get; set; }

    }
}
