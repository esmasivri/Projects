#pragma checksum "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ed079994b6357a6d8bb08832b9b345f1217ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
#line 1 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Areas\Admin\Views\_ViewImports.cshtml"
using BlogSiteDesign.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Areas\Admin\Views\_ViewImports.cshtml"
using BlogSiteDesign.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ed079994b6357a6d8bb08832b9b345f1217ccd", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892d9d89b8fc5a802e63b61fb733c54541b6102d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\esmas\Desktop\tm\arap esmoş\BlogSiteDesign\BlogSiteDesign\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>YAZAR AJAX İŞLEMLERİ</h1>\r\n<br/>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ed079994b6357a6d8bb08832b9b345f1217ccd4139", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("<button type=\"button\" id=\"btngetlist\" class=\"btn btn-outline-primary\">Yazar Listesi</button>\r\n\r\n<br/>\r\n<br/>\r\n");
                WriteLiteral("<div id=\"writerlist\"></div>\r\n<br/>\r\n<br/>\r\n<div id=\"writerget\"></div>\r\n\r\n");
                WriteLiteral(@"
<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazarın id değerini giriniz.(konsol)"" class=""form-control""/>
    <br />
    <button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar Getir</button>
</div>

<br/>
<hr />

");
                WriteLiteral(@"<div>
    <input type=""text"" class=""form-control"" id=""txtwriterid"" placeholder=""Yazar ID"" />
    
    <input type=""text"" class=""form-control"" id=""txtWritername"" placeholder=""Yazar Adı"" />
    <br/>
    <button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar Ekle</button>
</div>
<br />
<hr/>

");
                WriteLiteral("<div>\r\n    <input type=\"text\" class=\"form-control\" id=\"txtid\" placeholder=\"Silinecek Yazar ID\" />\r\n    <br />\r\n    <button type=\"button\" id=\"btndeletewriter\" class=\"btn btn-outline-danger\">Yazar Sil</button>\r\n</div>\r\n<br />\r\n\r\n<hr />\r\n\r\n");
                WriteLiteral(@"<div>
    <input type=""text"" class=""form-control"" id=""txtid1"" placeholder=""Güncellenecek Yazar ID"" />
    <input type=""text"" class=""form-control"" id=""txtwritername1"" placeholder=""Güncellenecek İsim"" />
    <br/>
    <button type=""button"" id=""btngetupdate"" class=""btn btn-outline-primary"">Yazar Güncelle</button>

</div>
<br/>
<br/>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        // 1) yazarları table halinde listelemek için ajax
        $(""#btngetlist"").click(function(){

            $.ajax({
                contentType:""application/json"",
                dataType:""json"",
                type:""Get"",
                url:""/Admin/Writer/WriterList"",
                success:function(func){
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml=""<table class=table table-bordered <tr><th>YazarID </th><th>Yazar Adı </th></tr>"";
                    $.each(w,(index,value)=>{
                        tablehtml+=`<tr><td>${value.Id}</td> <td>${value.Name}</td></tr>`
                    });
                    tablehtml +=""</table>"";
                    $(""#writerlist"").html(tablehtml)
                    
                }
            });

        });

        // 2) id değerine göre yazarı konsola getirme işlemi ajax
        $(""#btngetbyid"").click(x=>{

            let id = $(""#");
                WriteLiteral(@"writerid"").val();
            $.ajax({

                contentType:""application/json"",
                dataType:""json"",
                type:""get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data:{ writerid:id},
                success:function(func){
                    let w= jQuery.parseJSON(func);
                    console.log(w);

                    let getvalue=`<table class=table table-bordered> <tr> <th> Yazar ID </th><th>Yazar Adı</th></tr> <tr><td>${w.Id}</td><td>${w.Name}</td></tr> </table>`;
                    $(""#writerget"").html(getvalue);

                }
            });
        })


        //3) yazar ekleme işlemi ajax
        $(""#btnaddwriter"").click(function () {
            let writer= {
                Id: $(""#txtwriterid"").val(),
                Name: $(""#txtWritername"").val()
            };

            $.ajax({
                type:""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
     ");
                WriteLiteral(@"           success: function(func){
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar Ekleme İşlemi Başarılı bir şekilde gerçekleşti."")
                }
            });

        });

        // 4) yazar silme işlemi ajax
        $(""#btndeletewriter"").click(x=>{
            let id = $(""#txtid"").val();

            $.ajax({
                url:""/Admin/Writer/DeleteWriter/""+id,
                type:""post"",
                dataType:""json"",
                success: function (func) {
                    
                    alert(""Yazar Silme İşlemi Başarılı bir şekilde gerçekleşti."")
                }

            });
        });


        // 5) yazar güncelleme işlemi ajax
        $(""#btngetupdate"").click(function(){

            let writer={
                Id: $(""#txtid1"").val(),
                Name: $(""#txtwritername1"").val()
            };

            $.ajax({
                type:""post"",
                url:""/Admin/Writer/UpdateWri");
                WriteLiteral("ter/\",\r\n                data:writer,\r\n                success:function(func){\r\n                    alert(\"Güncelleme işlemi başarıyla tamamlanmıştır.\")\r\n                }\r\n            })\r\n            \r\n        })\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
