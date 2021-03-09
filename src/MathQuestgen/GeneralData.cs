using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuestgen
{
    public class GeneralData
    {
        public static string HTML_Preset = "<!DOCTYPE HTML>\n<script type=\"text/x-mathjax-config\">\nMathJax.Hub.Config({ extensions:[\"tex2jax.js\"],jax:[\"input/TeX\", \"output/HTML-CSS\"],tex2jax: { inlineMath:[ ['$','$'], [\"\\\\(\",\"\\\\)\"] ],displayMath:[ ['$$','$$'], [\"\\\\[\",\"\\\\]\"] ]} }); MathJax.Hub.Queue([\"Typeset\", MathJax.Hub]);\n</script>\n<script src=\"https://cdn.jsdelivr.net/npm/mathjax@2.7.9/MathJax.js\"></script>\n";

        public List<QuestionTemplate> questionTemplates = new List<QuestionTemplate>();

        private GeneralData()
        {
            questionTemplates.Add(new ChoiceQuestionTemplate
            {
                questionStems = new List<string> { "若**直角三角形**的斜边长为${hypotenuse}，一条直角边为${right}，则另一条直角边为( )。" },
                metadata = new QuestionTemplate.Metadata { name = "测试用", type = QuestionTemplate.TemplateTypes.choice }
            }
            );
        }
        private static GeneralData instance = null;
        public static GeneralData generalData
        {
            get
            {
                if (instance == null)
                {
                    instance = new GeneralData();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
    }
}
