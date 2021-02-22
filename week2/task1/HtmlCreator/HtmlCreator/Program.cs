using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlCreator.Core;
using Microsoft.VisualBasic;

namespace HtmlCreator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var metatags = "<meta charset=\"UTF - 8\">";

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
                }
            };

            var refsToDisplay = refs.Select(tag => tag.Content);
            
            var body = $"\n\t<body>" +
                        $"\n\t\t{string.Join(" |\n\t\t", refsToDisplay)}" +
                       $"\n\t</body>\n";
            
            var htmlText = new string[]
            {
                "<html>", 
                $"{header}", 
                 $"{body}",
                 "</html>"
            };

            var systemPath = System.Environment.
                GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData
                );
            var complete = Path.Combine(systemPath, "index.html");

            //File.Create(complete);

            //using var stream = File.Open(complete, FileMode.Open, FileAccess.Write, FileShare.Read);
            
            // Your file in C:\ProgramData\index.html
            File.WriteAllText(complete, string.Concat(htmlText));
            
            var proc = Process.Start(@"cmd.exe ", @"/c " + complete); 
        }
    }
}