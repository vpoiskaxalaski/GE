#pragma checksum "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2d93f0c5a23e9599b5e0ab512629a4a5eaa44f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d93f0c5a23e9599b5e0ab512629a4a5eaa44f1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281c32c9918f31d8a330ce9c35de964d48a6e472", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GE.DAL.Model.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 92, true);
            WriteLiteral("\r\n<div class=\"videos-mask\">\r\n    <div id=\"content\">\r\n        <ul class=\"videos-list vois\">\r\n");
            EndContext();
#line 7 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
             foreach (GE.Models.PostVM post in ViewBag.posts)
            {

#line default
#line hidden
            BeginContext(250, 48, true);
            WriteLiteral("            <li class=\"voi\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 298, "\"", 323, 2);
            WriteAttributeValue("", 305, "Home/Post/", 305, 10, true);
#line 10 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 315, post.Id, 315, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 324, "\"", 342, 1);
#line 10 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 332, post.Name, 332, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(343, 5, true);
            WriteLiteral(">\r\n\r\n");
            EndContext();
            BeginContext(543, 44, true);
            WriteLiteral("                    <img class=\'voi__poster\'");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 587, "\"", 682, 1);
#line 13 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 593, string.Concat("/images/" + post.User.Id + "/", post.ImagesGallery.ToList().First().Name), 593, 89, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(683, 165, true);
            WriteLiteral(" />\r\n                </a>\r\n                <div class=\"voi__content\">\r\n                    <p class=\"voi__title\">\r\n                        <a class=\"voi__title-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 848, "\"", 873, 2);
            WriteAttributeValue("", 855, "Home/Post/", 855, 10, true);
#line 17 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 865, post.Id, 865, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(874, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(906, 9, false);
#line 18 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
                       Write(post.Name);

#line default
#line hidden
            EndContext();
            BeginContext(915, 125, true);
            WriteLiteral("\r\n                        </a>\r\n                    </p>\r\n                    <p class=\"voi__info\">\r\n                        ");
            EndContext();
            BeginContext(1041, 23, false);
#line 22 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
                   Write(post.Subcategory.Points);

#line default
#line hidden
            EndContext();
            BeginContext(1064, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1067, 21, false);
#line 22 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
                                             Write(post.Subcategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 152, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"overlay\" original-title=\"\">\r\n                    <a class=\"overlay-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1240, "\"", 1266, 2);
            WriteAttributeValue("", 1247, "/Home/Post/", 1247, 11, true);
#line 26 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 1258, post.Id, 1258, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1267, 52, true);
            WriteLiteral("></a>\r\n                </div>\r\n\r\n            </li>\r\n");
            EndContext();
#line 30 "E:\UNIVER\CourseProject\GE\GE.WEB\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1334, 54, true);
            WriteLiteral("        </ul>\r\n        <hr style=\"    color: #ddd;\">\r\n");
            EndContext();
            BeginContext(1570, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<GE.DAL.Model.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
