#pragma checksum "R:\Project\playground\playgnd\Views\Admin\TestControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571e1b2671a735423454327c04aee789a9e479ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TestControl), @"mvc.1.0.view", @"/Views/Admin/TestControl.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/TestControl.cshtml", typeof(AspNetCore.Views_Admin_TestControl))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571e1b2671a735423454327c04aee789a9e479ba", @"/Views/Admin/TestControl.cshtml")]
    public class Views_Admin_TestControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin/test/add.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/testfrontend.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "R:\Project\playground\playgnd\Views\Admin\TestControl.cshtml"
  
    ViewData["Title"] = "TestControl";


#line default
#line hidden
            BeginContext(64, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "973caf05197542ed943dd7398e677d51", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(121, 272, true);
            WriteLiteral(@"
<meta content=""text/html; charset=utf-8"" http-equiv=""content-type"">
<h2>Добавление теста</h2>
<div style=""width:100%; height:200px;"">
    <div>
        <div class=""options-left"">
            Курс:
            <input class=""options-input-text"" id=""subj"" type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 393, "\"", 407, 1);
#line 13 "R:\Project\playground\playgnd\Views\Admin\TestControl.cshtml"
WriteAttributeValue("", 401, Model, 401, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(408, 1369, true);
            WriteLiteral(@" disabled/>
            <br />
            <label>Название</label><input class=""options-input-text"" id=""name"" type=""text"" /><br />
            <label>Описание</label><input class=""options-input-text"" id=""main"" type=""text"" /><br />
            <label>Текст в конце теста</label><input class=""options-input-text"" id=""results"" type=""text"" /><br />
            <label>Кол-во вопросов в базе</label><input class=""options-input-num"" id=""totalQue"" type=""number"" value=""0"" /><br />
            <label>Кол-во вопросов в тесте</label><input class=""options-input-num"" id=""testQue"" type=""number"" value=""0"" /><br />

            <input class=""button"" type=""button"" value=""Ввод вопросов"" onclick=""questionsAction()"" />
            <input class=""button"" type=""button"" value=""Добавить в базу!"" onclick=""generatejson()"" />
        </div>
        <div class=""options-right"">
            <label>Показывать резутьтат после каждого ответа</label><input id=""opt1"" type=""checkbox"" /><br />
            <label>Перемешивать вопросы</lab");
            WriteLiteral(@"el><input id=""opt2"" type=""checkbox"" /><br />
            <label>Перемешивать варианты ответа</label><input id=""opt3"" type=""checkbox"" /><br />
            <label>Запретить неотвеченные вопросы</label><input id=""opt4"" type=""checkbox"" /><br />
        </div>
    </div>
</div>
<div>
        <div id=""questions"">
        </div>
    </div>
");
            EndContext();
            BeginContext(1777, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22401aafc79742049ca527717af81411", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1827, 3031, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    function generatejson() {
        json = ' \
        { ""info"": { \
        ""name"":    ""'+ document.getElementById('name').value + '"", \
        ""main"":    ""<p>'+ document.getElementById('main').value + '</p>"", \
        ""results"": ""<p>'+ document.getElementById('results').value + '</p>"", \
        ""level1"":  """", \
        ""level2"":  """", \
        ""level3"":  """", \
        ""level4"":  """", \
        ""level5"":  """"  \
        }, \
        ""questions"": [ \
        ';
        var numQ = document.getElementById('totalQue').value;
        var numAns = """";
        for (var i = 0; i < numQ; i++) {
            numAns = document.getElementById('a' + i).value;
            json = json + ' \
            { \
             ""q"": ""'+ document.getElementById('q' + i).value + '"", \
            ""a"": [ \
            ' ;
            for (var j = 0; j < numAns - 1; j++) {
                json = json + ' \
                {""option"": ""'+ document.getElementById('' + i + 'opti");
            WriteLiteral(@"on' + j).value + '"",      ""correct"": ' + document.getElementById('' + i + 'valid' + j).checked + '}, \
                ';
            }
            var ji = numAns - 1;
            json = json + ' \
             {""option"": ""'+ document.getElementById('' + i + 'option' + ji).value + '"",      ""correct"": ' + document.getElementById('' + i + 'valid' + ji).checked + '} \
            ],\
            ""correct"": ""<p><span>Ответ верный</span></p>"", \
            ""incorrect"": ""<p><span>Ответ неверный</span></p>"" \
            }, \
            ';
        }
        json = json + ' \
                ] \
        };  \
        ';       
        var subject, name, questionsInTest, questionsAll, resultOfQuestion, mixAnswers, mixQuestions, notAnsweredForbidden;
        subject = document.getElementById('subj').value;
        name = document.getElementById('name').value;
        questionsInTest = document.getElementById('testQue').value;
        questionsAll = document.getElementById('totalQue').value;
    ");
            WriteLiteral(@"    resultOfQuestion = document.getElementById('opt1').checked;
        mixAnswers = document.getElementById('opt3').checked;
        mixQuestions = document.getElementById('opt2').checked;
        notAnsweredForbidden = document.getElementById('opt4').checked;
        var xhr = new XMLHttpRequest();
        var params = 'subject=' + encodeURIComponent(subject) + '&name=' + encodeURIComponent(name) + '&questionsInTest=' + encodeURIComponent(questionsInTest) + '&questionsAll=' + encodeURIComponent(questionsAll) + '&resultOfQuestion=' + encodeURIComponent(resultOfQuestion) + '&mixAnswers=' + encodeURIComponent(mixAnswers) + '&mixQuestions=' + encodeURIComponent(mixQuestions) + '&notAnsweredForbidden=' + encodeURIComponent(notAnsweredForbidden) + '&json=' + encodeURIComponent(json);
        xhr.open(""POST"", '/admin/addtest', true);
        xhr.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
        xhr.send(params);
      
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
