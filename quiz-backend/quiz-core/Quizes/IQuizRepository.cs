using quiz_core.Framework;
using System.Threading.Tasks;

namespace quiz_core.Quizes
{
    /// <summary>
    /// Access to FOPS data.
    /// </summary>
    public interface IQuizRepository
    {
        /// <summary>
        /// Search for Quesiton (text) in data from Quiz.
        /// </summary>
        Task<SearchResult<QuizQuestionModel>> SearchQuestions(QuizQuestionSearch search);
    }
}
