using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlCreator.Core;

namespace HtmlCreator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var metatags = "<meta charset=\"UTF-8\">";

            var header =
                $"\n\t<head>"
                + $"\n\t\t{metatags}"
                + $"\n\t</head>";

            var refs = new Tag[]
            {
                new Tag()
                {
                    Content = "<a href=\"mailto:maxim@hotmail.com\">Maxim</a>"
                },  
                new Tag()
                {
                    Content = "<a href=\"mailto:igor@hotmail.com\">Igor</a> "
                },  
                new Tag()
                {
                    Content = "<a href=\"mailto:ivan@hotmail.com\">Ivan</a>"
                }, 
                new Tag()
                {
                    Content = "<a href=\"mailto:ivan@hotmail.com\">Maxim<script>alert(\'Name!\')</script></a>"
                } 
            };
            // Task 2:
            // https://stackoverflow.com/questions/19414829/how-to-remove-script-tags-from-an-html-page-using-c .
            var regexRemScript = new Regex(@"<script[^>]*>[\s\S]*?</script>");
            
            var refsToDisplay = refs
                .Select(tag => regexRemScript.Replace(tag.Content, ""));
            
            var body = $"\n\t<body>" +
                        $"\n\t\t{string.Join(" |<br>\n\t\t", refsToDisplay)}" +
                       $"\n\t</body>\n";

            var htmlText =
                "<html>" +
                $"{header}" +
                $"{body}" +
                "</html>";
            

            var systemPath = System.Environment.
                GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData
                );
            var complete = Path.Combine(systemPath, "index.html");

            // Your file in C:\ProgramData\index.html
            File.WriteAllText(complete, htmlText);
            
            // Runs our html-file.
            var proc = Process.Start(@"cmd.exe ", @"/c " + complete);
        }
    }
}