#pragma checksum "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64a60799e0f45cbfb77fcf53c79f617749ec8134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterModal), @"mvc.1.0.view", @"/Views/Account/RegisterModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegisterModal.cshtml", typeof(AspNetCore.Views_Account_RegisterModal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a60799e0f45cbfb77fcf53c79f617749ec8134", @"/Views/Account/RegisterModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281c32c9918f31d8a330ce9c35de964d48a6e472", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GE.Models.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("#dialogContent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.maskedinput.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 408, true);
            WriteLiteral(@"
<div class=""modal-content"">
    <div class=""autH"">
        <div class=""modal-header"">
            <button class=""close"" type=""button"" data-dismiss=""modal"" aria-hidden=""true"">
                <i class=""icon icon_default""></i>
                <i class=""icon icon_hover""></i>
            </button>
            <h3 class=""title"">
                Регистрация
            </h3>
        </div>
        ");
            EndContext();
            BeginContext(444, 2264, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1321e89ee6ca4bf6a5bbe2d1b213df5f", async() => {
                BeginContext(529, 115, true);
                WriteLiteral("\r\n          <div align=\"center\">\r\n                <h3 style=\"color:#cb95aa;font-size:small;\">\r\n                    ");
                EndContext();
                BeginContext(645, 15, false);
#line 17 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
               Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(660, 59, true);
                WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            ");
                EndContext();
                BeginContext(720, 63, false);
#line 21 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
       Write(Html.ValidationSummary(true, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(783, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(840, 95, false);
#line 23 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control formOther", @placeholder = "Логин" }));

#line default
#line hidden
                EndContext();
                BeginContext(935, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(954, 73, false);
#line 24 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(1027, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1104, 87, false);
#line 27 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", @placeholder = "E-mail" }));

#line default
#line hidden
                EndContext();
                BeginContext(1191, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1210, 74, false);
#line 28 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(1284, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1361, 112, false);
#line 31 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
                EndContext();
                BeginContext(1473, 374, true);
                WriteLiteral(@"
                <a class=""autH-toggle-password"">
                    <span class=""value __value_show"" onclick=""showPassword()"">
                        Показать
                    </span>
                    <span class=""value __value_hide"" onclick=""hidePassword()"">
                        Скрыть
                    </span>
                </a>
                ");
                EndContext();
                BeginContext(1848, 77, false);
#line 40 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(1925, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(2002, 127, false);
#line 43 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.TextBoxFor(m => m.ConfirmPassword, new { @class = "form-control", @placeholder = "Confirm password", @type = "password" }));

#line default
#line hidden
                EndContext();
                BeginContext(2129, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2148, 84, false);
#line 44 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(2232, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(2309, 116, false);
#line 47 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "form-control", @placeholder = "Номер телефона", @id = "Phone" }));

#line default
#line hidden
                EndContext();
                BeginContext(2425, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2444, 80, false);
#line 48 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
           Write(Html.ValidationMessageFor(m => m.PhoneNumber, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(2524, 177, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <button class=\"btn btn_color\" type=\"submit\">Зарегистрироваться</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2708, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2750, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\RegisterModal.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
            BeginContext(2823, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2825, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71c9f943046940d2a20af64a7d6a3bfa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2903, 405, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    function showPassword() {
        $('a.autH-toggle-password').addClass('on');
        $('#Password').attr('type', 'text');
    }
    function hidePassword() {
        $('a.autH-toggle-password').removeClass('on');
        $('#Password').attr('type', 'password');
    }
    $(function ($) {
        $(""#Phone"").mask(""+375(99) 999-99-99"");
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GE.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
