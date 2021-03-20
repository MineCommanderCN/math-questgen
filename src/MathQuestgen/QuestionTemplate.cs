using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuestgen
{
    public class TemplateFilesBase64
    //用于JSON读取
    {
        public string metadata;
        public string questionText;
        public string script_answer;
        public string script_interference;
        public Dictionary<string, string> script_condition = new Dictionary<string, string>();
    }
    public class QuestionTemplate
    //题目模板 - 父类
    {
        public Dictionary<string, string> conditionScripts = new Dictionary<string, string>();
        public string answerScript;
        public string name;
        public List<string> questionTexts = new List<string>();
        public List<string> tags;

        public struct YamlMetadataFormat //YAML源信息格式
        {
            public string name;
            public string type;
            public List<string> tags;
        }
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
    public class CalculaionQuestionTemplate : QuestionTemplate
    //计算题
    {

    }
}
