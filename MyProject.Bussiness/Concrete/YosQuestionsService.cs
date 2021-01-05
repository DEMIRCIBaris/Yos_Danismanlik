using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyProject.Bussiness.Concrete
{
    public class YosQuestionsService : IYosQuestionsService
    {
        private readonly IYosQuestionsDal yosQuestionsDal;

        public YosQuestionsService(IYosQuestionsDal yosQuestionsDal)
        {
            this.yosQuestionsDal = yosQuestionsDal;
        }
        public void Add(YosQuestions entity)
        {
            yosQuestionsDal.Add(entity);
        }

        public void Delete(YosQuestions entity)
        {
            yosQuestionsDal.Delete(entity);
        }

        public YosQuestions Get(Expression<Func<YosQuestions, bool>> filter)
        {
            var yosQuestions = yosQuestionsDal.Get(filter);
            return yosQuestions;
        }

        public List<YosQuestions> GetList(Expression<Func<YosQuestions, bool>> filter = null)
        {
            var yosQuestions = yosQuestionsDal.GetList(filter);
            return yosQuestions;
        }

        public void Update(YosQuestions entity)
        {
            yosQuestionsDal.Update(entity);
        }
    }
}
