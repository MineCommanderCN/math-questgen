using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace MQTBuilder
{
    class Program
    {
        public class TemplateFilesBase64
        {
            public string metadata;
            public string questionText;
            public string script_answer;
            public string script_interference;
            public Dictionary<string, string> script_condition = new Dictionary<string, string>();
        }
        static void Main(string[] args)
        {
            TemplateFilesBase64 templateFiles = new TemplateFilesBase64();
            string inputPath;
            if (args.Length >= 1)
            {
                inputPath = args[0];
                goto start_withoutOutput;
            }
        start:
            try
            {
                Console.WriteLine("请将制作好的模板文件夹拖进此窗口，再按下回车“Enter”键：");
                inputPath = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("读取目录出错！请重试。\n错误信息：{0}", e.ToString());
                goto start;
            }
        start_withoutOutput:
            try
            {
                byte[] buffer = File.ReadAllBytes(Path.Combine(inputPath, "metadata.yml"));
                templateFiles.metadata = Convert.ToBase64String(buffer);
                buffer = File.ReadAllBytes(Path.Combine(inputPath, "question_text.txt"));
                templateFiles.questionText = Convert.ToBase64String(buffer);
                buffer = File.ReadAllBytes(Path.Combine(inputPath, "script\\answer.js"));
                templateFiles.script_answer = Convert.ToBase64String(buffer);
                if (File.Exists(Path.Combine(inputPath, "script\\interference.js")))
                {
                    buffer = File.ReadAllBytes(Path.Combine(inputPath, "script\\interference.js"));
                    templateFiles.script_interference = Convert.ToBase64String(buffer);
                }
                string[] conditionFiles = Directory.GetFiles(Path.Combine(inputPath, "script\\condition"));
                foreach (string item in conditionFiles)
                {
                    buffer = File.ReadAllBytes(item);
                    templateFiles.script_condition.Add(Path.GetFileNameWithoutExtension(item), Convert.ToBase64String(buffer));
                }
                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "templates\\" + new DirectoryInfo(inputPath).Name + ".mqt"),
                    JsonConvert.SerializeObject(templateFiles));
            }
            catch (Exception e)
            {
                Console.WriteLine("构建出错了！请重试。\n错误信息：{0}", e.ToString());
                goto start;
            }
            Console.WriteLine("模板文件构建完成！已自动将模板添加至templates文件夹中，您可以打开MathQuestgen直接使用。\n请按任意键退出...");
            Console.ReadKey();
        }
    }
}
