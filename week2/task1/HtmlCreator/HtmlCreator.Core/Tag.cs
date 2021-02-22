using HtmlCreator.Core.Enums;

namespace HtmlCreator.Core
{
    public class Tag
    {
        public TagType TagType { get; set; }
        public string Content { get; set; }

        public override string ToString()
            => $"{Content}";
    }
}