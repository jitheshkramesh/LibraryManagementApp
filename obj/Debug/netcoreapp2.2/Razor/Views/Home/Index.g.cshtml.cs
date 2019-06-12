#pragma checksum "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "351e8d446d4b2e35d859459453c3414b1856007d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\_ViewImports.cshtml"
using LibraryManagementApp;

#line default
#line hidden
#line 2 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\_ViewImports.cshtml"
using LibraryManagementApp.Models;

#line default
#line hidden
#line 3 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\_ViewImports.cshtml"
using LibraryManagementApp.Data.Model;

#line default
#line hidden
#line 4 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\_ViewImports.cshtml"
using LibraryManagementApp.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351e8d446d4b2e35d859459453c3414b1856007d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28fc9833969dd914a8b1fa3bd026e4cef2ac8f28", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\Home\Index.cshtml"
  
    int availableBooks = Model.BookCount - Model.LendBookCount;

#line default
#line hidden
            BeginContext(141, 291, true);
            WriteLiteral(@"
<h1>Library management dashboard</h1>

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                Customers Count
            </div>
            <div class=""panel-body"">
                There are ");
            EndContext();
            BeginContext(433, 19, false);
#line 19 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\Home\Index.cshtml"
                     Write(Model.CustomerCount);

#line default
#line hidden
            EndContext();
            BeginContext(452, 287, true);
            WriteLiteral(@" customers
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                Authors Count
            </div>
            <div class=""panel-body"">
                There are ");
            EndContext();
            BeginContext(740, 17, false);
#line 29 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\Home\Index.cshtml"
                     Write(Model.AuthorCount);

#line default
#line hidden
            EndContext();
            BeginContext(757, 283, true);
            WriteLiteral(@" authors
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                Books count
            </div>
            <div class=""panel-body"">
                There are ");
            EndContext();
            BeginContext(1041, 14, false);
#line 39 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\Home\Index.cshtml"
                     Write(availableBooks);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 24, true);
            WriteLiteral(" books available out of ");
            EndContext();
            BeginContext(1080, 15, false);
#line 39 "G:\Work File\LibraryManagementApp\LibraryManagementApp\Views\Home\Index.cshtml"
                                                            Write(Model.BookCount);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 62, true);
            WriteLiteral(" books\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591