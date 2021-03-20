using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace MathQuestgen
{
    public static partial class Tools
    {
        public static QuestionTemplate LoadTemplate(string path, int id)
        {
            QuestionTemplate template;
            TemplateFilesBase64 templateFiles = JsonConvert.DeserializeObject<TemplateFilesBase64>(File.ReadAllText(path));
            Deserializer YAMLdeserializer = new Deserializer();
            QuestionTemplate.YamlMetadataFormat metadata =
                YAMLdeserializer.Deserialize<QuestionTemplate.YamlMetadataFormat>(
                    Encoding.UTF8.GetString(Convert.FromBase64String(templateFiles.metadata)));
            switch (metadata.type)
            {
                case "choice":
                    template = new ChoiceQuestionTemplate(); break;
                case "fillingblank":
                    template = new FillingblankQuestionTemplate(); break;
                case "calculation":
                    template = new CalculaionQuestionTemplate(); break;
                default:
                    throw new ApplicationException("未知的题型'" + metadata.type + "'");
            }
            template.name = metadata.name;
            template.tags = metadata.tags;
            template.answerScript = Encoding.UTF8.GetString(Convert.FromBase64String(templateFiles.script_answer));
            if (template.GetType() == typeof(ChoiceQuestionTemplate))
            {
                ((ChoiceQuestionTemplate)template).interferenceScript =
                    Encoding.UTF8.GetString(Convert.FromBase64String(templateFiles.script_interference));
            }
            string[] questionTextLines =
                Encoding.UTF8.GetString(Convert.FromBase64String(templateFiles.questionText))
                .Split('\n'); //将题干文件分行“切片”
            string textTmp = "";
            foreach (var line in questionTextLines)
            {
                if (line.Trim() == "----")
                { //检测到分割线，则将缓存加入题干并清空缓存
                    if (textTmp != "")
                    {
                        template.questionTexts.Add(textTmp);
                        textTmp = "";
                    }
                }
                else
                {
                    textTmp += line + "\n"; //将单行文本带分行符压入缓存
                }
            }
            foreach (var item in templateFiles.script_condition)
            {
                template.conditionScripts.Add(item.Key,
                    Encoding.UTF8.GetString(Convert.FromBase64String(item.Value)));
            }

            return template;
        }
    }
}

