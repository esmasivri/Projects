#pragma checksum "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661428a61661bca2d7c197196e8b8e9a80d70d84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\_ViewImports.cshtml"
using BlogSiteDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\_ViewImports.cshtml"
using BlogSiteDesign.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661428a61661bca2d7c197196e8b8e9a80d70d84", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc64eec2fa525b77020b1e848690b09c4fd9cd99", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<section class=\"main-content-w3layouts-agileits\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<h3 class=\"tittle\">Bloglar</h3>\r\n\t\t\t<div class=\"inner-sec\">\r\n\t\t\t\t<!--left-->\r\n\t\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 16 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
                         foreach (var item in Model)
					    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t  <div class=\"col-lg-4 card\">\r\n\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 522, "\"", 543, 1);
#nullable restore
#line 20 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
WriteAttributeValue("", 528, item.BlogImage, 528, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 575, "\"", 581, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i>");
#nullable restore
#line 27 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
                                                                           Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"mx-2\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-comment\"></i> 0</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 35 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1207, "\"", 1245, 3);
            WriteAttributeValue("", 1214, "/Blog/BlogReadAll/", 1214, 18, true);
#nullable restore
#line 40 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1232, item.BlogID, 1232, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1244, "/", 1244, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
                                                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h5>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 43 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
                                                     Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </p>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1653, "\"", 1691, 3);
            WriteAttributeValue("", 1660, "/Blog/BlogReadAll/", 1660, 18, true);
#nullable restore
#line 45 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1678, item.BlogID, 1678, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1690, "/", 1690, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t  </div>\r\n\t\t\t\t\t\t  <br />\r\n");
#nullable restore
#line 49 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Blog\Index.cshtml"
						  
					    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<!--//left-->\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
