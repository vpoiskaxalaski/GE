#pragma checksum "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12255a82b018d6e00a279e17e2c6c49b73ecc87f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12255a82b018d6e00a279e17e2c6c49b73ecc87f", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281c32c9918f31d8a330ce9c35de964d48a6e472", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Manage/RequestPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 95, true);
            WriteLiteral("<div class=\"view\">\r\n    <div class=\"container\">\r\n        <h1 class=\"view__title\">\r\n            ");
            EndContext();
            BeginContext(96, 17, false);
#line 4 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
       Write(ViewBag.Post.Name);

#line default
#line hidden
            EndContext();
            BeginContext(113, 123, true);
            WriteLiteral("\r\n        </h1>\r\n    </div>\r\n    <div class=\"post\">\r\n        <div class=\"post-image\">\r\n            <img class=\'voi__poster\'");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 236, "\"", 332, 1);
#line 9 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
WriteAttributeValue("", 242, string.Concat("/images/" + ViewBag.Post.UserId + "/", ViewBag.Post.ImagesGallery[0].Name), 242, 90, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(333, 272, true);
            WriteLiteral(@" />
        </div>
        <div class=""info info_summary"" style=""all:unset"">
            <div class=""infoi"">
                <h4 class=""infoi__title"">
                    Дата:
                </h4>
                <div class=""infoi__content"">
                    ");
            EndContext();
            BeginContext(606, 27, false);
#line 17 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
               Write(ViewBag.Post.DateCreatePost);

#line default
#line hidden
            EndContext();
            BeginContext(633, 243, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"infoi\">\r\n                <h4 class=\"infoi__title\">\r\n                    Категория:\r\n                </h4>\r\n                <div class=\"infoi__content\">\r\n                    ");
            EndContext();
            BeginContext(877, 29, false);
#line 25 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
               Write(ViewBag.Post.Subcategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(906, 4, true);
            WriteLiteral(" ,  ");
            EndContext();
            BeginContext(911, 37, false);
#line 25 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                                                 Write(ViewBag.Post.Subcategory.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(948, 239, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"infoi\">\r\n                <h4 class=\"infoi__title\">\r\n                    Город:\r\n                </h4>\r\n                <div class=\"infoi__content\">\r\n                    ");
            EndContext();
            BeginContext(1188, 22, false);
#line 33 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
               Write(ViewBag.Post.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1210, 4, true);
            WriteLiteral(" ,  ");
            EndContext();
            BeginContext(1215, 28, false);
#line 33 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                                          Write(ViewBag.Post.City.RegionName);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 246, true);
            WriteLiteral(" область\r\n                </div>\r\n            </div>\r\n            <div class=\"infoi\">\r\n                <h4 class=\"infoi__title\">\r\n                    Цена:\r\n                </h4>\r\n                <div class=\"infoi__content\">\r\n                    ");
            EndContext();
            BeginContext(1490, 31, false);
#line 41 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
               Write(ViewBag.Post.Subcategory.Points);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 248, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"infoi\">\r\n                <h4 class=\"infoi__title\">\r\n                    Номер телефона:\r\n                </h4>\r\n                <div class=\"infoi__content\">\r\n                    ");
            EndContext();
            BeginContext(1770, 29, false);
#line 49 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
               Write(ViewBag.Post.User.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 306, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""infoi"">
                <h3 class=""infoi__title"" style=""float:unset"">
                    Описание
                </h3>
                <div class=""expand"">
                    <div class=""expandContent"">
                        ");
            EndContext();
            BeginContext(2106, 24, false);
#line 58 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                   Write(ViewBag.Post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2130, 286, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <!--Image Gallery-->
        <div class=""view-images"">
            <h3 class=""title"">
                Галерея
            </h3>
            <div class=""gallery-thumbnails clearfix"">
");
            EndContext();
#line 69 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                 foreach (var item in ViewBag.Post.ImagesGallery)
                {

#line default
#line hidden
            BeginContext(2502, 76, true);
            WriteLiteral("                    <span>\r\n                        <img class=\'voi__poster\'");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2578, "\"", 2649, 1);
#line 72 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
WriteAttributeValue("", 2584, string.Concat("/images/" + ViewBag.Post.UserId + "/", item.Name), 2584, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2650, 84, true);
            WriteLiteral(" width=\'162\' height=\'228\' onclick=\"openImg(this);\" />\r\n                    </span>\r\n");
            EndContext();
#line 74 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                }

#line default
#line hidden
            BeginContext(2753, 207, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    \r\n\r\n</div>\r\n<div class=\"container\">\r\n    <div class=\"containerImage\">\r\n        <b class=\"closebtn\" onclick=\"this.parentElement.style.display=\'none\'\"></b>\r\n");
            EndContext();
            BeginContext(3061, 156, true);
            WriteLiteral("        <img id=\"expandedImg\" style=\"width:50%; display:block; margin-left:auto; margin-right:auto\">\r\n        <div id=\"imgtext\"></div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 89 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
 if (ViewBag.Post.UserId != ViewBag.User.Id)
 {

#line default
#line hidden
            BeginContext(3267, 37, true);
            WriteLiteral("    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(3304, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a53103a46a254340b5cdf6520c56bc4a", async() => {
                BeginContext(3353, 48, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"postId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3401, "\"", 3425, 1);
#line 93 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
WriteAttributeValue("", 3409, ViewBag.Post.Id, 3409, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3426, 137, true);
                WriteLiteral(">\r\n            <button class=\"btn btn-dark\" style=\"background-color:#216100; color:whitesmoke\" type=\"submit\">Запросить</button>\r\n        ");
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
            BeginContext(3570, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 97 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
 }

#line default
#line hidden
            BeginContext(3588, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3611, 415, true);
                WriteLiteral(@"
        <script type=""text/javascript"">
            function openImg(imgs) {
                var expandImg = document.getElementById(""expandedImg"");
                var imgText = document.getElementById(""imgtext"");
                expandImg.src = imgs.src;
                imgText.innerHTML = imgs.alt;
                expandImg.parentElement.style.display = ""block"";
            }
        </script>
    ");
                EndContext();
            }
            );
            BeginContext(4029, 4, true);
            WriteLiteral("\r\n\r\n");
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
