using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MathQuestgen
{
    public class UnknownTemplateTypeException : ApplicationException
    {
        string type;
        public UnknownTemplateTypeException(string message, string type) : base(message)
        {
            this.type = type;
        }
        public UnknownTemplateTypeException(string type) : base()
        {
            this.type = type;
        }
    }

    public static class Tools
    {
        public static string ReadStringFromStream(Stream stream, int maxSize, Encoding encoding)
        {
            byte[] buffer = new byte[maxSize];
            stream.Read(buffer, 0, maxSize);
            return encoding.GetString(buffer);
        }
    }

    public class GeneralData
    {
        public static string HTML_Preset = "<!DOCTYPE HTML>\n<script type=\"text/x-mathjax-config\">\nMathJax.Hub.Config({showProcessingMessages:false,messageStyle:\"none\",extensions:[\"tex2jax.js\"],jax:[\"input/TeX\", \"output/HTML-CSS\"],tex2jax:{inlineMath:[['$','$'],[\"\\\\(\",\"\\\\)\"]],displayMath:[['$$','$$'],[\"\\\\[\",\"\\\\]\"] ]},'HTML-CSS':{showMathMenu:false}});MathJax.Hub.Queue([\"Typeset\",MathJax.Hub]);\n</script>\n<script src=\"https://cdn.jsdelivr.net/npm/mathjax@2.7.9/MathJax.js\"></script>\n";
        public static string TempDirectory = Environment.GetEnvironmentVariable("TEMP") + Path.DirectorySeparatorChar + "mathQuestgen";
        public static string Version = "dev.20210315";

        public Dictionary<int /*ID*/ , QuestionTemplate> questionTemplates = new Dictionary<int, QuestionTemplate>();
        public bool firstLoad = true;

        private GeneralData()
        {

        }
        private static GeneralData _instance = null;
        public static GeneralData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GeneralData();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
    }
}
