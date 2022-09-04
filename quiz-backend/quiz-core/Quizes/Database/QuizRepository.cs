using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
//using FluentValidation;
using Microsoft.EntityFrameworkCore;
//using NodaTime;
using quiz_core.Framework;
using quiz_core.Framework.Services;

namespace quiz_core.Quizes.Database
{
    [RegisterScopedService]
    internal class QuizRepository : IQuizRepository
    {
        private readonly QuizContext _dbContext;
        public QuizRepository(
            QuizContext dbContext
        )
        {
            _dbContext = dbContext;
        }



        public async Task<SearchResult<QuizQuestionModel>> SearchQuestions(QuizQuestionSearch search)
        {
            var questions = new List<QuizQuestionModel> { new QuizQuestionModel { Text = "value1" }, new QuizQuestionModel { Text = "value2" } };
            SearchResult<QuizQuestionModel> searchResult = new SearchResult<QuizQuestionModel>
            {
                TotalCount = questions.Count,
                Items = questions
            };
            return searchResult;
        }
    }
}
