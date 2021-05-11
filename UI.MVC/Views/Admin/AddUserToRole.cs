using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.MVC.Views.Admin
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("tag-name")]
    public class AddUserToRole : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
