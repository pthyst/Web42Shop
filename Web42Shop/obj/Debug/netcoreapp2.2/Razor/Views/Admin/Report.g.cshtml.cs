#pragma checksum "H:\Web42Shop\Web42Shop\Views\Admin\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a6d3c30e4febfe128a28e3349391e32d4f122c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Report), @"mvc.1.0.view", @"/Views/Admin/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Report.cshtml", typeof(AspNetCore.Views_Admin_Report))]
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
#line 1 "H:\Web42Shop\Web42Shop\Views\_ViewImports.cshtml"
using Web42Shop;

#line default
#line hidden
#line 2 "H:\Web42Shop\Web42Shop\Views\_ViewImports.cshtml"
using Web42Shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d3c30e4febfe128a28e3349391e32d4f122c0", @"/Views/Admin/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac241f70b368de2487bcde9e1a99ecec126da33", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "H:\Web42Shop\Web42Shop\Views\Admin\Report.cshtml"
  
    ViewData["Title"] = "Report";
    Layout = "~/Views/Admin/_AdminIndexLayout.cshtml";

#line default
#line hidden
            BeginContext(100, 103, true);
            WriteLiteral("\r\n<h1>Trang thống kê tình hình đặt hàng, số lượng người dùng mới đăng kí, theo ngày, tháng,...</h1>\r\n\r\n");
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
