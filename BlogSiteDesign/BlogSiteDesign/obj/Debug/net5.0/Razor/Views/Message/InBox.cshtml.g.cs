#pragma checksum "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1824a42dd47daae9877e260f28ad32c8a42f4f21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#line 1 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1824a42dd47daae9877e260f28ad32c8a42f4f21", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc64eec2fa525b77020b1e848690b09c4fd9cd99", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Kutusu</h1>\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Gönderen</th>\r\n        <th>Tarih</th>\r\n        <th>Mesajı Aç</th>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
           Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
           Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
            Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>           \r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 654, "\"", 700, 2);
            WriteAttributeValue("", 661, "/Message/MessageDetails/", 661, 24, true);
#nullable restore
#line 28 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"
WriteAttributeValue("", 685, item.MessageID, 685, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning \">Mesajı Aç</a></td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\Message\InBox.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591