#pragma checksum "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1a9cde332f446cbe9f8eda7d5ed1c1fe7fea23d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
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
#line 1 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
using BlogSiteDesign.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a9cde332f446cbe9f8eda7d5ed1c1fe7fea23d", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc64eec2fa525b77020b1e848690b09c4fd9cd99", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Adı Soyadı</th>\r\n        <th>Sil</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 445, "\"", 488, 2);
            WriteAttributeValue("", 452, "/EmployeeTest/DeleteEmploye/", 452, 28, true);
#nullable restore
#line 21 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 480, item.ID, 480, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 553, "\"", 595, 2);
            WriteAttributeValue("", 560, "/EmployeeTest/EditEmployee/", 560, 27, true);
#nullable restore
#line 22 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 587, item.ID, 587, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Views\EmployeeTest\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/EmployeeTest/AddEmploye/\" class=\"btn btn-outline-primary\">Yeni Çalışan Giriniz</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591