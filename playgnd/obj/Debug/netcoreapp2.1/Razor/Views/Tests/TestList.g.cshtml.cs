#pragma checksum "R:\Project\playground\playgnd\Views\Tests\TestList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b9c72241a3a00d673bb0aacf9db68f9354fa06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tests_TestList), @"mvc.1.0.view", @"/Views/Tests/TestList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tests/TestList.cshtml", typeof(AspNetCore.Views_Tests_TestList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35b9c72241a3a00d673bb0aacf9db68f9354fa06", @"/Views/Tests/TestList.cshtml")]
    public class Views_Tests_TestList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "R:\Project\playground\playgnd\Views\Tests\TestList.cshtml"
  
    ViewData["Title"] = "TestList";

#line default
#line hidden
            BeginContext(46, 133, true);
            WriteLiteral("\r\n<h2>Выбор Теста:</h2>\r\nОтображаются id тестов. Последний id - последний созданный тест. \r\nalpha версия.\r\n<table class=\"subjects\">\r\n");
            EndContext();
#line 10 "R:\Project\playground\playgnd\Views\Tests\TestList.cshtml"
                 foreach (string d in Model)
                {

#line default
#line hidden
            BeginContext(244, 157, true);
            WriteLiteral("                <tr class=\"subj\">\r\n                    <td>\r\n                        <div class=\"subj-name\">\r\n                           <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 401, "\"", 411, 1);
#line 15 "R:\Project\playground\playgnd\Views\Tests\TestList.cshtml"
WriteAttributeValue("", 409, d, 409, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(412, 110, true);
            WriteLiteral(" onclick=\"getSubj(this)\"/>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 19 "R:\Project\playground\playgnd\Views\Tests\TestList.cshtml"
                }

#line default
#line hidden
            BeginContext(541, 126, true);
            WriteLiteral("  </table>\r\n<script>\r\n    function getSubj(button) {  \r\n        name = button.value;        \r\n        window.location.href = \"");
            EndContext();
            BeginContext(668, 27, false);
#line 24 "R:\Project\playground\playgnd\Views\Tests\TestList.cshtml"
                           Write(Url.Action("Index","Tests"));

#line default
#line hidden
            EndContext();
            BeginContext(695, 38, true);
            WriteLiteral("\"+\"?id=\" + name;\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
