#pragma checksum "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e3ecd01c893fb754d9a059d40e17d59d75bb0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e3ecd01c893fb754d9a059d40e17d59d75bb0a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page-Movie Ticketing Web App-ComIT";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-sm-12\">\r\n\r\n            <div id=\"slides\" class=\"carousel slide\" data-ride=\"carousel\">\r\n                <ul class=\"carousel-indicators bg-dark fixed-bottom\">\r\n");
#nullable restore
#line 13 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                     for (var i = 0; i < Model.Count; i = i + 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 449, "\"", 478, 1);
#nullable restore
#line 15 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 457, i == 0?"active":"", 457, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#slides\" data-slide-to=\"");
#nullable restore
#line 15 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                                                           Write(i/4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 16 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n\r\n                <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                     for (var i = 0; i < Model.Count; i = i + 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 745, "\"", 788, 2);
            WriteAttributeValue("", 753, "carousel-item", 753, 13, true);
#nullable restore
#line 23 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 766, i == 0?"active":"", 767, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"row\">\r\n                                <div class=\"card col-3\">\r\n                                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 958, "\"", 980, 1);
#nullable restore
#line 26 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 964, Model[i].imgUrl, 964, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 981, "\"", 1002, 1);
#nullable restore
#line 26 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 987, Model[i].Title, 987, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"card-body\">\r\n                                        <h5 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                          Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                        Write(Model[i].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1278, "\"", 1313, 2);
            WriteAttributeValue("", 1285, "/Movies/Details/", 1285, 16, true);
#nullable restore
#line 30 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1301, Model[i].Id, 1301, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">book now</a>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"card col-3\">\r\n                                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1558, "\"", 1582, 1);
#nullable restore
#line 35 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1564, Model[i+1].imgUrl, 1564, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1583, "\"", 1606, 1);
#nullable restore
#line 35 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1589, Model[i+1].Title, 1589, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"card-body\">\r\n                                        <h5 class=\"card-title\">");
#nullable restore
#line 37 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                          Write(Model[i + 1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">");
#nullable restore
#line 38 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                        Write(Model[i + 1].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1890, "\"", 1927, 2);
            WriteAttributeValue("", 1897, "/Movies/Details/", 1897, 16, true);
#nullable restore
#line 39 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1913, Model[i+1].Id, 1913, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">book now</a>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"card col-3\">\r\n                                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2172, "\"", 2196, 1);
#nullable restore
#line 44 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2178, Model[i+2].imgUrl, 2178, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2197, "\"", 2220, 1);
#nullable restore
#line 44 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2203, Model[i+2].Title, 2203, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"card-body\">\r\n                                        <h5 class=\"card-title\">");
#nullable restore
#line 46 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                          Write(Model[i + 2].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">");
#nullable restore
#line 47 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                        Write(Model[i + 2].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2504, "\"", 2541, 2);
            WriteAttributeValue("", 2511, "/Movies/Details/", 2511, 16, true);
#nullable restore
#line 48 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2527, Model[i+2].Id, 2527, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">book now</a>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"card col-3\">\r\n                                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2784, "\"", 2808, 1);
#nullable restore
#line 52 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2790, Model[i+3].imgUrl, 2790, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2809, "\"", 2832, 1);
#nullable restore
#line 52 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2815, Model[i+3].Title, 2815, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"card-body\">\r\n                                        <h5 class=\"card-title\">");
#nullable restore
#line 54 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                          Write(Model[i + 3].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">");
#nullable restore
#line 55 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                        Write(Model[i + 3].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3116, "\"", 3153, 2);
            WriteAttributeValue("", 3123, "/Movies/Details/", 3123, 16, true);
#nullable restore
#line 56 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 3139, Model[i+3].Id, 3139, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">book now</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
