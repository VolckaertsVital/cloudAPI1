#pragma checksum "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52c3884c823dd56c8c736e5becce67e1a18b4de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\_ViewImports.cshtml"
using DrankAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52c3884c823dd56c8c736e5becce67e1a18b4de", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffa453818b3301cc0ca7a01a102fe52c37c6345", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Drank>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Details.cshtml"
  
  ViewBag.Title = "Drank Details";

#line default
#line hidden
            BeginContext(62, 218, true);
            WriteLiteral("\r\n  <table>\r\n    <tr class=\"header\">\r\n      <th>Id</th>\r\n      <th>Name</th>\r\n      <th>NameBrand</th>\r\n      <th>type</th>\r\n      <th>AlcoholPersentage</th>\r\n    </tr>\r\n    <tr *ngFor=\"let r of list.Data\">\r\n      <td>");
            EndContext();
            BeginContext(281, 8, false);
#line 17 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Details.cshtml"
     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(289, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(307, 10, false);
#line 18 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Details.cshtml"
     Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(317, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(335, 15, false);
#line 19 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Details.cshtml"
     Write(Model.NameBrand);

#line default
#line hidden
            EndContext();
            BeginContext(350, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(368, 10, false);
#line 20 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Details.cshtml"
     Write(Model.type);

#line default
#line hidden
            EndContext();
            BeginContext(378, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(396, 23, false);
#line 21 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Details.cshtml"
     Write(Model.AlcoholPersentage);

#line default
#line hidden
            EndContext();
            BeginContext(419, 84, true);
            WriteLiteral("</td>\r\n      <td>\r\n       \r\n        </a>\r\n      </td>\r\n    </tr>\r\n  </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Drank> Html { get; private set; }
    }
}
#pragma warning restore 1591
