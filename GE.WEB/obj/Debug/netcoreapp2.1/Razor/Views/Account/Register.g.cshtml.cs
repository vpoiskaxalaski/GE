#pragma checksum "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b4761f3bacf8a0e23155b8571d21c8af542685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4761f3bacf8a0e23155b8571d21c8af542685", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281c32c9918f31d8a330ce9c35de964d48a6e472", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GE.Models.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:10px 40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 136, true);
            WriteLiteral("<div class=\"autH\">\r\n    <div class=\"modal-header\">\r\n        <h3 class=\"title\">\r\n            Регистрация\r\n        </h3>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(172, 2110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1ad9a615704dff917d819a2bdc0501", async() => {
                BeginContext(253, 105, true);
                WriteLiteral("\r\n        <div align=\"center\">\r\n            <h3 style=\"color:#cb95aa;font-size:small;\">\r\n                ");
                EndContext();
                BeginContext(359, 15, false);
#line 11 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(374, 47, true);
                WriteLiteral("\r\n            </h3>\r\n        </div>\r\n\r\n        ");
                EndContext();
                BeginContext(422, 63, false);
#line 15 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
   Write(Html.ValidationSummary(true, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(485, 48, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(534, 95, false);
#line 17 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control formOther", @placeholder = "Логин" }));

#line default
#line hidden
                EndContext();
                BeginContext(629, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(644, 73, false);
#line 18 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(717, 64, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(782, 87, false);
#line 21 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", @placeholder = "E-mail" }));

#line default
#line hidden
                EndContext();
                BeginContext(869, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(884, 74, false);
#line 22 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(958, 64, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1023, 112, false);
#line 25 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
                EndContext();
                BeginContext(1135, 338, true);
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
                BeginContext(1474, 77, false);
#line 34 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(1551, 64, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1616, 127, false);
#line 37 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.ConfirmPassword, new { @class = "form-control", @placeholder = "Confirm password", @type = "password" }));

#line default
#line hidden
                EndContext();
                BeginContext(1743, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1758, 84, false);
#line 38 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(1842, 64, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1907, 116, false);
#line 41 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "form-control", @placeholder = "Номер телефона", @id = "Phone" }));

#line default
#line hidden
                EndContext();
                BeginContext(2023, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2038, 80, false);
#line 42 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.PhoneNumber, "", new { @style = "color:red;" }));

#line default
#line hidden
                EndContext();
                BeginContext(2118, 157, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button class=\"btn btn_color\" type=\"submit\">Зарегистрироваться</button>\r\n        </div>\r\n    ");
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
            BeginContext(2282, 49, true);
            WriteLiteral("\r\n    <div class=\"autH-another-action\">\r\n        ");
            EndContext();
            BeginContext(2332, 70, false);
#line 49 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Account\Register.cshtml"
   Write(Html.ActionLink("Вход", "Login", "Account", null, new { @class = "" }));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 54, true);
            WriteLiteral("\r\n        в существующий аккаунт\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2456, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5b5ccd455ab4967a764f56890151b20", async() => {
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
            BeginContext(2534, 411, true);
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
</script>


");
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
