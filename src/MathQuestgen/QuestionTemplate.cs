using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuestgen
{
    public class QuestionTemplate
    //题目模板 - 父类
    {
        public List<string> conditionScripts = new List<string>();
        public string answerScript;
        public string name;
        public List<string> questionStems = new List<string>();
    }
    public class ChoiceQuestionTemplate : QuestionTemplate
    //选择题
    {
        public string interferenceScript;
    }
    public class FillingblankQuestionTemplate : QuestionTemplate
    //填空题
    {

    }
    public class CalcultaionQuestionTemplate : QuestionTemplate
    //计算题
    {

    }
}
