using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuestgen
{
    public class QuestionTemplate
    // 题目模板
    {
        public enum TemplateTypes
        {
            choice = 0,
            fillingblank = 1,
            calculation = 2
        }
        public class Metadata
        {
            public string name;
            public TemplateTypes type;
        }
        public Metadata metadata = new Metadata();
        public List<string> questionStems = new List<string>();

    }
    public class ChoiceQuestionTemplate : QuestionTemplate
    // 选择题
    {
        public List<string> conditionScripts = new List<string>();
        public string option_answerScript;
        public string option_interferenceScript;
    }
}
