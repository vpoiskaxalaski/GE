#pragma checksum "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Manage\ChangePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca620e970f0ab8565db410249cc0880a5ed910e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ChangePost), @"mvc.1.0.view", @"/Views/Manage/ChangePost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ChangePost.cshtml", typeof(AspNetCore.Views_Manage_ChangePost))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 4 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\_ViewImports.cshtml"
using GE.WEB;

#line default
#line hidden
#line 2 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\_ViewImports.cshtml"
using GE.Models;

#line default
#line hidden
#line 3 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\_ViewImports.cshtml"
using GE.DAL.Model;

#line default
#line hidden
#line 5 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca620e970f0ab8565db410249cc0880a5ed910e", @"/Views/Manage/ChangePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281c32c9918f31d8a330ce9c35de964d48a6e472", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ChangePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Manage/ChangePost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 289, true);
            WriteLiteral(@"<div class=""videos-inner"">
    <div class=""view-header"">
        <div class=""container"">
            <h1 class=""view__title"">
                Изменение объявления
            </h1>
        </div>
    </div>
    <div align=""center"">
        <h3 style=""color:#ff6600"">
            ");
            EndContext();
            BeginContext(290, 15, false);
#line 11 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Manage\ChangePost.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(305, 99, true);
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n    <div align=\"center\">\r\n        <h3 style=\"color:red\">\r\n            ");
            EndContext();
            BeginContext(405, 13, false);
#line 16 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Manage\ChangePost.cshtml"
       Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(418, 68, true);
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n    <div class=\"videos-mask\">\r\n        ");
            EndContext();
            BeginContext(486, 1384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f37c97f60d24002adb376bd4f785f13", async() => {
                BeginContext(600, 72, true);
                WriteLiteral("\r\n            <input id=\"Id\" name=\"Id\" style=\"display: none\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 672, "\"", 696, 1);
#line 21 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Manage\ChangePost.cshtml"
WriteAttributeValue("", 680, ViewBag.Post.Id, 680, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(697, 490, true);
                WriteLiteral(@">
            <div class=""validation-summary-valid text-danger"" data-valmsg-summary=""true"" style=""color:red;"">
                <ul>
                    <li style=""display:none""></li>
                </ul>
            </div>
            <div class=""form_section"">
                <label class=""form_section form_tag"">Имя продукта</label>
                <input class=""form_controlinput"" id=""Name"" name=""Name"" pattern="".{3,}"" placeholder=""например HTC"" required=""required"" type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1187, "\"", 1213, 1);
#line 29 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Manage\ChangePost.cshtml"
WriteAttributeValue("", 1195, ViewBag.Post.Name, 1195, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1214, 404, true);
                WriteLiteral(@">
            </div>
            <br>
            <div class=""form_section"">
                <label class=""form_section form_tag"">Описание</label>
                <textarea class=""form_control form_controlinputarea"" cols=""20"" id=""Description"" maxlength=""200"" name=""Description"" placeholder=""Описание должно быть не меньше 5 и не больше 200 символов"" required=""required"" rows=""3"" style=""resize:none"">");
                EndContext();
                BeginContext(1619, 24, false);
#line 34 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Manage\ChangePost.cshtml"
                                                                                                                                                                                                                                                       Write(ViewBag.Post.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1643, 220, true);
                WriteLiteral("</textarea>\r\n            </div>\r\n            <br>\r\n            <button class=\"btn btn-success\" style=\"background-color: #216100 !important; color:whitesmoke;margin-left: 420px;\" type=\"submit\">Сохранить</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1870, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
