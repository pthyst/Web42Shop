#pragma checksum "D:\Web42Shop\Web42Shop\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e684dbc08eae8125d6f478e403a4fd2c501ddd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "D:\Web42Shop\Web42Shop\Views\_ViewImports.cshtml"
using Web42Shop;

#line default
#line hidden
#line 2 "D:\Web42Shop\Web42Shop\Views\_ViewImports.cshtml"
using Web42Shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e684dbc08eae8125d6f478e403a4fd2c501ddd2", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac241f70b368de2487bcde9e1a99ecec126da33", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/macbook.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product__image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/dell.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/asus.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/sony.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Web42Shop\Web42Shop\Views\Products\Index.cshtml"
  
    ViewBag.Title = "Products";
    Layout = "~/Views/Shared/Users/_IndexLayout.cshtml";
    ViewBag.SearchFlag = "Sản phẩm mới";

#line default
#line hidden
            BeginContext(142, 628, true);
            WriteLiteral(@"
<div class=""container-fluid section"">
    <!-- Sản phẩm mới -->
    <div class=""container"">
        <h1 class=""section__title"">Kết quả tìm kiếm: </h1><h3 class=""iblck"" style=""margin-left: 1rem"">Sản phẩm mới </h3>
        <div class=""row"">
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck fl product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(770, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd25888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(827, 684, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Macbook 2019</p>
                    <p class=""mrg0 product__oldprice"">35,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">17,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(1511, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd27845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1565, 683, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Laptop Dell</p>
                    <p class=""mrg0 product__oldprice"">30,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">15,000,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(2248, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd29802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2302, 683, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Laptop ASUS</p>
                    <p class=""mrg0 product__oldprice"">21,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">15,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(2985, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd211759", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3039, 750, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Laptop SONY VAIO</p>
                    <p class=""mrg0 product__oldprice"">13,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">6,500,000 VNĐ</p>
                </div>
            </a>
        </div><!--- end of row -->
        <div class=""row"">
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(3789, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd213786", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3846, 684, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Macbook 2019</p>
                    <p class=""mrg0 product__oldprice"">35,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">17,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(4530, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd215745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4584, 683, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Laptop Dell</p>
                    <p class=""mrg0 product__oldprice"">30,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">15,000,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(5267, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd217703", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5321, 683, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Laptop ASUS</p>
                    <p class=""mrg0 product__oldprice"">21,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">15,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""col-3 product"">
                <p class=""mrg0 iblck product__saleoff"">-50%</p>
                <p class=""mrg0 iblck fr product__views"">
                    <i class=""fas fa-heart""></i> 4.8
                    <i class=""fas fa-eye""></i> 1998
                    <i class=""fas fa-shopping-cart""></i> 1011
                </p>
                ");
            EndContext();
            BeginContext(6004, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e684dbc08eae8125d6f478e403a4fd2c501ddd219661", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6058, 1271, true);
            WriteLiteral(@"
                <div class=""product__info"">
                    <p class=""mrg0 product__name"">Laptop SONY VAIO</p>
                    <p class=""mrg0 product__oldprice"">13,000,000 VNĐ</p>
                    <p class=""mrg0 product__newprice"">6,500,000 VNĐ</p>
                </div>
            </a>
        </div><!--- end of row -->
        <!-- Section pagination -->
        <div class=""container txt-center section__pagination"">
            <a href=""#"" class=""paginumber paginumber--first""><i class=""fas fa-caret-left""></i></a>
            <a href=""#"" class=""paginumber paginumber--active"">1</a>
            <a href=""#"" class=""paginumber"">2</a>
            <a href=""#"" class=""paginumber"">3</a>
            <a href=""#"" class=""paginumber"">4</a>
            <a href=""#"" class=""paginumber"">5</a>
            <a href=""#"" class=""paginumber"">6</a>
            <a href=""#"" class=""paginumber"">7</a>
            <a href=""#"" class=""paginumber"">8</a>
            <a href=""#"" class=""paginumber"">9</a>
          ");
            WriteLiteral("  <a href=\"#\" class=\"paginumber\">10</a>\r\n            <a href=\"#\" class=\"paginumber paginumber--last\"><i class=\"fas fa-caret-right\"></i></a>\r\n        </div><!-- end of  Section pagination-->\r\n    </div>\r\n</div><!-- end of section Sản phẩm mới -->\r\n");
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
