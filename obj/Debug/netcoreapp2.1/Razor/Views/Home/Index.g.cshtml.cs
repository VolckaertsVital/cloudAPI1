#pragma checksum "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f97ad0627d9ccd92e0993b38b7e0ce0cc1a3863"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
using PagedList;

#line default
#line hidden
#line 3 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f97ad0627d9ccd92e0993b38b7e0ce0cc1a3863", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e9ad4242ca7fc3e40d981d8562687ce07c0317", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Drank>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/no-image-available.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
  
  ViewBag.Title = "Drank list";

#line default
#line hidden
            BeginContext(112, 742, true);
            WriteLiteral(@"<style>
  .button {
  background-color: #4CAF50;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  cursor: pointer;
  }
  #products {
  font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
  }

  #products td, #products th {
  border: 1px solid #ddd;
  padding: 8px;
    }

  #products tr:nth-child(even){background-color: #f2f2f2;}

  #products tr:hover {background-color: #ddd;}

  #products th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;

  
}
</style>


<div >

");
            EndContext();
#line 51 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
   using (Html.BeginForm("index", "home", FormMethod.Get))
  {

#line default
#line hidden
            BeginContext(919, 27, true);
            WriteLiteral("    <b> Search by ID:</b>\r\n");
            EndContext();
            BeginContext(951, 42, false);
#line 54 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
Write(Html.RadioButton("searchBy", "Name", true));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 4, true);
            WriteLiteral("Name");
            EndContext();
            BeginContext(1018, 41, false);
#line 55 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
Write(Html.RadioButton("searchBy", "NameBrand"));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 9, true);
            WriteLiteral("NameBrand");
            EndContext();
            BeginContext(1082, 13, true);
            WriteLiteral("\r\n    <br/>\r\n");
            EndContext();
            BeginContext(1100, 22, false);
#line 57 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
Write(Html.TextBox("search"));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 41, true);
            WriteLiteral(" <input type=\"submit\" value=\"Search\" />\r\n");
            EndContext();
#line 58 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"

  }

#line default
#line hidden
            BeginContext(1170, 223, true);
            WriteLiteral("  \r\n  <table id=\"products\">\r\n    <tr class=\"header\">\r\n      <th>Id</th>\r\n      <th>Name</th>\r\n      <th>NameBrand</th>\r\n      <th>image</th>\r\n      <th>Meer details</th>\r\n      <th></th>\r\n     \r\n      <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 72 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
     if(Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(1429, 91, true);
            WriteLiteral("        <th>\r\n          <td colspan=\"6\">No rows match search criteria</td>\r\n        </th>\r\n");
            EndContext();
#line 77 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
    }
    else {
    foreach (var Drank in Model)
    {

#line default
#line hidden
            BeginContext(1580, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1611, 8, false);
#line 82 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
           Write(Drank.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1619, 24, true);
            WriteLiteral("</td>\r\n             <td>");
            EndContext();
            BeginContext(1644, 10, false);
#line 83 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
            Write(Drank.name);

#line default
#line hidden
            EndContext();
            BeginContext(1654, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1678, 15, false);
#line 84 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
           Write(Drank.NameBrand);

#line default
#line hidden
            EndContext();
            BeginContext(1693, 39, true);
            WriteLiteral("</td>\r\n            <td>\r\n              ");
            EndContext();
            BeginContext(1732, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f391a75206a84302b602bd977999bd9a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1775, 37, true);
            WriteLiteral("\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(1812, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fbc918ccb0c432895551142e03ea180", async() => {
                BeginContext(1883, 70, true);
                WriteLiteral("\r\n            <button class=\"button\"> Meer info</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
                                                                WriteLiteral(Drank.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1957, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1980, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "746807b0979b42828e8d34fbea2e49d4", async() => {
                BeginContext(2050, 67, true);
                WriteLiteral("\r\n            <button class=\"button\"> Delete</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
                                                               WriteLiteral(Drank.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2121, 48, true);
            WriteLiteral("</td>\r\n           \r\n           \r\n        </tr>\r\n");
            EndContext();
#line 97 "C:\Users\Vital Volckaerts\Documents\school\2EA\Cloud API\2de jaar\DrankAPI\Views\Home\Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(2185, 51, true);
            WriteLiteral("       \r\n      </td>\r\n    </tr>\r\n  </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Drank>> Html { get; private set; }
    }
}
#pragma warning restore 1591
