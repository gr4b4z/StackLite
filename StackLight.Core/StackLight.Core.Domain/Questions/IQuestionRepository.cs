using System;

namespace StackLight.Core.Domain.Questions
{
    public interface IQuestionRepository
    {
        Question Get(Guid questionId);
        void Add(Question question);
        int GetAllQuestionsCount();
        void Save();
    }
}