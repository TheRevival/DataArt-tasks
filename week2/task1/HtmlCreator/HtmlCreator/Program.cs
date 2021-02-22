using System;
using System.Linq;
using System.Text;
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
            
            var htmlText = 
                $"<html>" 
                    + $"{header}" 
                    + $"{body}" 
              + $"</html>";

            using var 
        }
    }
}