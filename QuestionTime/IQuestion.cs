using System.Collections.Generic;

namespace QuestionTime
{
    interface IQuestion
    {
        List<string> Answers { get; }
        int Difficulty { get; }
        int IDAnswer { get; }
        string QuestionText { get; }
    }
}