#pragma checksum "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0477430ddc61c44504cdcada4b4a2988d6205b01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moderator_Index), @"mvc.1.0.view", @"/Views/Moderator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Moderator/Index.cshtml", typeof(AspNetCore.Views_Moderator_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0477430ddc61c44504cdcada4b4a2988d6205b01", @"/Views/Moderator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281c32c9918f31d8a330ce9c35de964d48a6e472", @"/Views/_ViewImports.cshtml")]
    public class Views_Moderator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Moderator/ResolvePost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Moderator/RejectPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(82, 284, true);
            WriteLiteral(@"
<div class=""videos-inner"">
    <div class=""view-header"">
        <div class=""container"">
            <h1 class=""view__title"">
                Панель модератора
            </h1>
        </div>
    </div>
    <div align=""center"">
        <h3 style=""color:red"">
            ");
            EndContext();
            BeginContext(367, 15, false);
#line 13 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(382, 306, true);
            WriteLiteral(@"
        </h3>
    </div>
    <div class=""F__category"">
    </div>

    <table class=""table table-bordered table-striped sortable"">
        <thead>
            <tr><th>Наименование объявления</th><th>Дата создания объявления</th><th>Логин пользователя</th></tr>
        </thead>
        <tbody>
");
            EndContext();
#line 24 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
             foreach (GE.Models.PostVM post in ViewBag.Posts)
            {

#line default
#line hidden
            BeginContext(766, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(813, 129, false);
#line 27 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
                   Write(Html.ActionLink((string)post.Name, "PostInformation", "Manage", new { id = post.Id }, new { UpdateTargetId = "postInformation" }));

#line default
#line hidden
            EndContext();
            BeginContext(942, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(974, 19, false);
#line 28 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
                   Write(post.DateCreatePost);

#line default
#line hidden
            EndContext();
            BeginContext(993, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1025, 18, false);
#line 29 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
                   Write(post.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1100, 396, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cf9e8eaa0f744ee9aa8a815601f2699", async() => {
                BeginContext(1152, 60, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1212, "\"", 1228, 1);
#line 32 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
WriteAttributeValue("", 1220, post.Id, 1220, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1229, 260, true);
                WriteLiteral(@">
                            <button style="" -webkit-border-radius: 4px; border-color: #ff6600 !important; background-color: #ff6600 !important; color:white; width:inherit; border: 1px solid #cccccc;"" type=""submit"">Одобрить</button>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1496, 78, true);
            WriteLiteral("\r\n                    <td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1574, 396, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47c730494e9147ebb5d89d9a878d4eaa", async() => {
                BeginContext(1625, 60, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1685, "\"", 1701, 1);
#line 38 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
WriteAttributeValue("", 1693, post.Id, 1693, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1702, 261, true);
                WriteLiteral(@">
                            <button style="" -webkit-border-radius: 4px; border-color: crimson !important; background-color: crimson !important; color:white; width:inherit; border: 1px solid #cccccc;"" type=""submit"">Отклонить</button>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1970, 51, true);
            WriteLiteral("\r\n                    <td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Moderator\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2036, 69, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <hr style=\"    color: #ddd;\">\r\n");
            EndContext();
            BeginContext(2280, 44, true);
            WriteLiteral("    <div id=\"postInformation\"></div>\r\n</div>");
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
