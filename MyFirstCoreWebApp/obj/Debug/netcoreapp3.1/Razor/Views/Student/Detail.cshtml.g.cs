#pragma checksum "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dbdd67dcf0b98dcf2128c165e6256b71deed9de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbdd67dcf0b98dcf2128c165e6256b71deed9de", @"/Views/Student/Detail.cshtml")]
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFirstCoreWebApp.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml"
  
    ViewBag.Title = "Student Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-center m-3\">\r\n    <div class=\"col-sm-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header text-center\">\r\n                <h1>");
#nullable restore
#line 10 "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h4>Student ID: ");
#nullable restore
#line 13 "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml"
                           Write(Model.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Name: ");
#nullable restore
#line 14 "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml"
                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Branch: ");
#nullable restore
#line 15 "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml"
                       Write(Model.Branch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Section: ");
#nullable restore
#line 16 "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml"
                        Write(Model.Section);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Gender: ");
#nullable restore
#line 17 "D:\xampp\htdocs\dotnet_core\MyFirstCoreWebApp\Views\Student\Detail.cshtml"
                       Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"card-footer text-center\">\r\n                <a href=\"/Student\" class=\"btn btn-primary\">Back</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFirstCoreWebApp.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
