#pragma checksum "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b67b30ffc189d358c72957a679f2ec2f0d89f5e4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67b30ffc189d358c72957a679f2ec2f0d89f5e4", @"/Views/Home/Post.cshtml")]
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
            BeginContext(0, 138, true);
            WriteLiteral("<div class=\"view\">\r\n    <div class=\"view-header\">\r\n        <div class=\"container\">\r\n            <h1 class=\"view__title\">\r\n                ");
            EndContext();
            BeginContext(139, 17, false);
#line 5 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
           Write(ViewBag.Post.Name);

#line default
#line hidden
            EndContext();
            BeginContext(156, 329, true);
            WriteLiteral(@"
            </h1>
        </div>
    </div>
    <div class=""F__category"">
    </div>
    <div class=""view-watch player"">
        <div class=""container"">
            <div class=""view-side"">
                <div class=""thumbnail"">
                    <div class=""thumb"">
                        <img class='voi__poster'");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 485, "\"", 581, 1);
#line 16 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
WriteAttributeValue("", 491, string.Concat("/images/" + ViewBag.Post.UserId + "/", ViewBag.Post.ImagesGallery[0].Name), 491, 90, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(582, 528, true);
            WriteLiteral(@" width='162' height='228' style=""    max-height: 390px;"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""view-side"" style=""margin-left:300px"">
            <div class=""info info_summary"" style=""all:unset"">
                <div class=""infoi"">
                    <h4 class=""infoi__title"">
                        Дата:
                    </h4>
                    <div class=""infoi__content"">
                        ");
            EndContext();
            BeginContext(1111, 27, false);
#line 30 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                   Write(ViewBag.Post.DateCreatePost);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 275, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""infoi"">
                    <h4 class=""infoi__title"">
                        Категория:
                    </h4>
                    <div class=""infoi__content"">
                        ");
            EndContext();
            BeginContext(1414, 29, false);
#line 38 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                   Write(ViewBag.Post.Subcategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1443, 4, true);
            WriteLiteral(" ,  ");
            EndContext();
            BeginContext(1448, 37, false);
#line 38 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                                                     Write(ViewBag.Post.Subcategory.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 271, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""infoi"">
                    <h4 class=""infoi__title"">
                        Город:
                    </h4>
                    <div class=""infoi__content"">
                        ");
            EndContext();
            BeginContext(1757, 22, false);
#line 46 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                   Write(ViewBag.Post.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1779, 4, true);
            WriteLiteral(" ,  ");
            EndContext();
            BeginContext(1784, 28, false);
#line 46 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                                              Write(ViewBag.Post.City.RegionName);

#line default
#line hidden
            EndContext();
            BeginContext(1812, 278, true);
            WriteLiteral(@" область
                    </div>
                </div>
                <div class=""infoi"">
                    <h4 class=""infoi__title"">
                        Цена:
                    </h4>
                    <div class=""infoi__content"">
                        ");
            EndContext();
            BeginContext(2091, 31, false);
#line 54 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                   Write(ViewBag.Post.Subcategory.Points);

#line default
#line hidden
            EndContext();
            BeginContext(2122, 280, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""infoi"">
                    <h4 class=""infoi__title"">
                        Номер телефона:
                    </h4>
                    <div class=""infoi__content"">
                        ");
            EndContext();
            BeginContext(2403, 29, false);
#line 62 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                   Write(ViewBag.Post.User.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2432, 388, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""view-side"">
            <div class=""view-story"">
                <h3 class=""infoi__title"" style=""float:unset"">
                    Описание
                </h3>
                <div class=""expand"">
                    <div class=""expandContent"">
                        ");
            EndContext();
            BeginContext(2821, 24, false);
#line 74 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                   Write(ViewBag.Post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2845, 282, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""view-images"" style=""margin-left:300px"">
            <h3 class=""title"">
                Галерея
            </h3>
            <div class=""gallery-thumbnails clearfix"">
");
            EndContext();
#line 84 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                 foreach (var item in ViewBag.Post.ImagesGallery)
                {

#line default
#line hidden
            BeginContext(3213, 76, true);
            WriteLiteral("                    <span>\r\n                        <img class=\'voi__poster\'");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3289, "\"", 3360, 1);
#line 87 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
WriteAttributeValue("", 3295, string.Concat("/images/" + ViewBag.Post.UserId + "/", item.Name), 3295, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3361, 84, true);
            WriteLiteral(" width=\'162\' height=\'228\' onclick=\"openImg(this);\" />\r\n                    </span>\r\n");
            EndContext();
#line 89 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
                }

#line default
#line hidden
            BeginContext(3464, 454, true);
            WriteLiteral(@"            </div>
        </div>
    </div>

</div>
<div class=""container"">
    <div class=""containerImage"">
        <b class=""closebtn"" onclick=""this.parentElement.style.display='none'""></b>
        <span onclick=""this.parentElement.style.display='none'"" class=""closebtn"">&times;</span>
        <img id=""expandedImg"" style=""width:50%; display:block; margin-left:auto; margin-right:auto"">
        <div id=""imgtext""></div>
    </div>
</div>
");
            EndContext();
#line 103 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
 if (ViewBag.Post.UserId != ViewBag.User.Id)
 {

#line default
#line hidden
            BeginContext(3968, 37, true);
            WriteLiteral("    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(4005, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22dfc03796474c93bf1b87c5c8fa371a", async() => {
                BeginContext(4054, 48, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"postId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4102, "\"", 4126, 1);
#line 107 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
WriteAttributeValue("", 4110, ViewBag.Post.Id, 4110, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4127, 237, true);
                WriteLiteral(">\r\n            <button style=\"margin-bottom: 30px;border-color: #ff6600 !important; background-color: #ff6600 !important; color:white; padding: 6px 12px; width: 100%; border: 1px solid #cccccc;\" type=\"submit\">Запросить</button>\r\n        ");
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
            BeginContext(4371, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 111 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Post.cshtml"
 }

#line default
#line hidden
            BeginContext(4389, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4412, 415, true);
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
            BeginContext(4830, 4, true);
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
