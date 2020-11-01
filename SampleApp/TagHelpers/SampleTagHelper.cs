using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SampleApp.TagHelpers
{
    [HtmlTargetElement("input", TagStructure = TagStructure.WithoutEndTag)]
    public class SampleTagHelper : InputTagHelper
    {
        public SampleTagHelper(IHtmlGenerator generator) : base(generator)
        {
        }
    }
}
