#pragma checksum "R:\Project\playground\playgnd\Views\Admin\TestSubjList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a478e2d46f6b9a08566ee6617c10df61bb15f085"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a478e2d46f6b9a08566ee6617c10df61bb15f085", @"/Views/Admin/TestSubjList.cshtml")]
    public class Views_Admin_TestSubjList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "R:\Project\playground\playgnd\Views\Admin\TestSubjList.cshtml"
  
    ViewData["Title"] = "TestSubjList";

#line default
#line hidden
            BeginContext(69, 51, true);
            WriteLiteral("\r\n<h2>Выбор курса</h2>\r\n <table class=\"subjects\">\r\n");
            EndContext();
#line 8 "R:\Project\playground\playgnd\Views\Admin\TestSubjList.cshtml"
                 foreach (string d in Model)
                {

#line default
#line hidden
            BeginContext(185, 157, true);
            WriteLiteral("                <tr class=\"subj\">\r\n                    <td>\r\n                        <div class=\"subj-name\">\r\n                           <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 342, "\"", 352, 1);
#line 13 "R:\Project\playground\playgnd\Views\Admin\TestSubjList.cshtml"
WriteAttributeValue("", 350, d, 350, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(353, 110, true);
            WriteLiteral(" onclick=\"getSubj(this)\"/>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 17 "R:\Project\playground\playgnd\Views\Admin\TestSubjList.cshtml"
                }

#line default
#line hidden
            BeginContext(482, 131, true);
            WriteLiteral("  </table>\r\n<script>\r\n    function getSubj(button) {  \r\n        name = button.value;    \r\n       \r\n        window.location.href = \"");
            EndContext();
            BeginContext(614, 36, false);
#line 23 "R:\Project\playground\playgnd\Views\Admin\TestSubjList.cshtml"
                           Write(Url.Action("ReturnSubjects","Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(650, 34, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
