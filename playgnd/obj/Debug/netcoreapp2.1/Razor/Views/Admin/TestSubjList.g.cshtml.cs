#pragma checksum "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9525e8fdae2fbcc0e0ca1635c7227abfd2de40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TestSubjList), @"mvc.1.0.view", @"/Views/Admin/TestSubjList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/TestSubjList.cshtml", typeof(AspNetCore.Views_Admin_TestSubjList))]
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
#line 1 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
using playgnd.Models.Admin.Test;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9525e8fdae2fbcc0e0ca1635c7227abfd2de40", @"/Views/Admin/TestSubjList.cshtml")]
    public class Views_Admin_TestSubjList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CourseModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
  
    ViewData["Title"] = "TestSubjList";

#line default
#line hidden
            BeginContext(109, 49, true);
            WriteLiteral("<h2>Выбор курса</h2>\r\n <table class=\"subjects\">\r\n");
            EndContext();
#line 8 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
                 foreach (CourseModel m in Model)
                {

#line default
#line hidden
            BeginContext(228, 157, true);
            WriteLiteral("                <tr class=\"subj\">\r\n                    <td>\r\n                        <div class=\"subj-name\">\r\n                           <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 385, "\"", 398, 1);
#line 13 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
WriteAttributeValue("", 393, m.Id, 393, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(399, 267, true);
            WriteLiteral(@" onclick=""getSubj(this)""/>
                        </div>
                    </td>
                </tr>
                <tr class=""subj"">
                    <td>
                        <div class=""subj-name"">
                           <input type=""button""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 666, "\"", 681, 1);
#line 20 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
WriteAttributeValue("", 674, m.Name, 674, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 267, true);
            WriteLiteral(@" onclick=""getSubj(this)""/>
                        </div>
                    </td>
                </tr>
                <tr class=""subj"">
                    <td>
                        <div class=""subj-name"">
                           <input type=""button""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 949, "\"", 965, 1);
#line 27 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
WriteAttributeValue("", 957, m.Count, 957, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(966, 110, true);
            WriteLiteral(" onclick=\"getSubj(this)\"/>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
                }

#line default
#line hidden
            BeginContext(1095, 129, true);
            WriteLiteral("  </table>\r\n<script>\r\n    function getSubj(button) {  \r\n        name = button.value;           \r\n        window.location.href = \"");
            EndContext();
            BeginContext(1225, 36, false);
#line 36 "R:\Project\playground\playground\playgnd\Views\Admin\TestSubjList.cshtml"
                           Write(Url.Action("ReturnSubjects","Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 34, true);
            WriteLiteral("\"+\"?subj=\"+name;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CourseModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
