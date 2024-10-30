using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.MyCustomTagHelper
{
    [HtmlTargetElement("selam")]
    public class SelamTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";  // h2 etiketi ile selam mesajı gösteriliyor
            output.Attributes.SetAttribute("style", "color:green;");
            output.Content.SetContent("Merhaba! Hoşgeldinizz");
        }
    }
}
