#pragma checksum "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "539b91c050e16922f0a0175b6d8a90ec12d41a72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539b91c050e16922f0a0175b6d8a90ec12d41a72", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"background back2\">\r\n    <h1 class=\"h2\">");
#nullable restore
#line 2 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\Home\List.cshtml"
              Write(ViewBag.Back.NameCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"inline\">\r\n");
#nullable restore
#line 10 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\Home\List.cshtml"
             foreach (var item in ViewBag.List)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"cat-item\">\r\n                        <img class=\"cat-pic\"");
            BeginWriteAttribute("src", " src=\"", 358, "\"", 379, 2);
            WriteAttributeValue("", 364, "/img/", 364, 5, true);
#nullable restore
#line 13 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\Home\List.cshtml"
WriteAttributeValue("", 369, item.Path, 369, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n                        <h6 style=\"margin-top:5px;\" class=\"card-title btn-mid\">");
#nullable restore
#line 14 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\Home\List.cshtml"
                                                                          Write(item.Manufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 14 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\Home\List.cshtml"
                                                                                             Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Ma1x\Desktop\WebApplication7 — копия\WebApplication7\Views\Home\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-md-1\">\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
