#pragma checksum "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6949a26dcd2e6b9d45694878f66ca1080b1daeec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Single), @"mvc.1.0.view", @"/Views/Products/Single.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Single.cshtml", typeof(AspNetCore.Views_Products_Single))]
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
#line 1 "G:\Web42Shop\Web42Shop\Views\_ViewImports.cshtml"
using Web42Shop;

#line default
#line hidden
#line 2 "G:\Web42Shop\Web42Shop\Views\_ViewImports.cshtml"
using Web42Shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6949a26dcd2e6b9d45694878f66ca1080b1daeec", @"/Views/Products/Single.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac241f70b368de2487bcde9e1a99ecec126da33", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Single : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("iblck fl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/asus.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/sony.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
  
    ViewBag.Title = "SingleProduct";
    Layout = "~/Views/Shared/Users/_IndexLayout.cshtml";

#line default
#line hidden
            BeginContext(105, 298, true);
            WriteLiteral(@"
<div class=""container-fluid section__product"">
    <div class=""row"">
        <!-- Sản phẩm tương tự -->
        <div class=""col-3 product__side"">
            <p class=""product_side__title txt-center"">SẢN PHẨM TƯƠNG TỰ</p>
            <a href=""#"" class=""blck other_product"">
                ");
            EndContext();
            BeginContext(403, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6949a26dcd2e6b9d45694878f66ca1080b1daeec5969", async() => {
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
            BeginContext(449, 367, true);
            WriteLiteral(@"
                <div class=""iblck"">
                    <p class=""other_product__name"">Laptop ASUS</p>
                    <p class=""other_product__oldprice"">13,000,000 VNĐ</p>
                    <p class=""other_product__newprice"">6,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""blck other_product"">
                ");
            EndContext();
            BeginContext(816, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6949a26dcd2e6b9d45694878f66ca1080b1daeec7599", async() => {
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
            BeginContext(862, 367, true);
            WriteLiteral(@"
                <div class=""iblck"">
                    <p class=""other_product__name"">Laptop ASUS</p>
                    <p class=""other_product__oldprice"">13,000,000 VNĐ</p>
                    <p class=""other_product__newprice"">6,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""blck other_product"">
                ");
            EndContext();
            BeginContext(1229, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6949a26dcd2e6b9d45694878f66ca1080b1daeec9230", async() => {
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
            BeginContext(1275, 367, true);
            WriteLiteral(@"
                <div class=""iblck"">
                    <p class=""other_product__name"">Laptop ASUS</p>
                    <p class=""other_product__oldprice"">13,000,000 VNĐ</p>
                    <p class=""other_product__newprice"">6,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""blck other_product"">
                ");
            EndContext();
            BeginContext(1642, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6949a26dcd2e6b9d45694878f66ca1080b1daeec10862", async() => {
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
            BeginContext(1688, 367, true);
            WriteLiteral(@"
                <div class=""iblck"">
                    <p class=""other_product__name"">Laptop ASUS</p>
                    <p class=""other_product__oldprice"">13,000,000 VNĐ</p>
                    <p class=""other_product__newprice"">6,500,000 VNĐ</p>
                </div>
            </a>
            <a href=""#"" class=""blck other_product"">
                ");
            EndContext();
            BeginContext(2055, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6949a26dcd2e6b9d45694878f66ca1080b1daeec12495", async() => {
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
            BeginContext(2101, 1122, true);
            WriteLiteral(@"
                <div class=""iblck"">
                    <p class=""other_product__name"">Laptop ASUS</p>
                    <p class=""other_product__oldprice"">13,000,000 VNĐ</p>
                    <p class=""other_product__newprice"">6,500,000 VNĐ</p>
                </div>
            </a>
        </div><!-- end of Sản phẩm tương tự -->

        <!-- Chi tiết sản phẩm -->
        <div class=""col-9 product__main"">
            <!-- Tên sản phẩm -->
            <p class=""product__main__name"">Laptop SONY 2019</p>
            <!-- Link sản phẩm -->
            <div class=""product__main__link"">
                <a href=""Home/Index"" class=""iblck"">Trang chủ </a><i class=""fas fa-chevron-right""></i>
                <a href=""#"" class=""iblck"">Laptop </a><i class=""fas fa-chevron-right""></i>
                <a href=""#"" class=""iblck"">SONY </a><i class=""fas fa-chevron-right""></i>
                <a href=""#"" class=""iblck"">Laptop SONY 2019</a>
            </div>
            
            <div class=""row"">
 ");
            WriteLiteral("               <!-- Thông tin chính -->\r\n                <div class=\"col-9\">\r\n                    ");
            EndContext();
            BeginContext(3223, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6949a26dcd2e6b9d45694878f66ca1080b1daeec14947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3252, 3004, true);
            WriteLiteral(@"
                    <table>
                        <tr>
                            <th>Tên sản phẩm</th>
                            <td>Laptop SONY 2019</td>
                        </tr>
                        <tr>
                            <th>Giá cũ</th>
                            <td class=""oldprice"">13,000,000 VNĐ</td>
                        </tr>
                        <tr>
                            <th>Giá mới</th>
                            <td class=""newprice"">6,500,000 VNĐ</td>
                        </tr>
                        <tr>
                            <th>Chi tiết sản phẩm</th>
                            <td>
                                <p>- Core i7</p>
                                <p>- RAM 8Gb</p>
                                <p>- Ổ cứng HDD 520Gb</p>
                                <p>- Kiểu dáng sang trọng, bắt mắt.</p>
                                <p>- Khối lượng 2kg, tiện lợi cho việc mang theo để làm việc và học tập.</p>
            ");
            WriteLiteral(@"                </td>
                        </tr>
                    </table>
                    <!-- Viết đánh giá phản hồi -->
                    <div class=""blck w100 writecomment"">
                        <p class=""mrg0 iblck writecomment__username""><strong>Jack Sóng Gió</strong></p>
                        <div class=""iblck writecomment__stars"">
                            <script>
                                function DrawStars(_point) {
                                    var yellow = parseInt(_point, 10);
                                    var display = """";
                                    for (var i = 1; i <= 5; i++) {
                                        if (i < yellow || i == yellow) {
                                            display += ""<i class=\""fas fa-star star--yellow\"" onclick=\""DrawStars("" + parseInt(i, 10) + "")\""></i>"";
                                        }
                                        else {
                                            displa");
            WriteLiteral(@"y += ""<i class=\""fas fa-star star--black\"" onclick=\""DrawStars("" + parseInt(i, 10) + "")\""></i>"";
                                        }

                                    }
                                    document.getElementsByClassName(""writecomment__stars"")[0].innerHTML = display;
                                    document.getElementsByClassName(""writecomment__points"")[0].value = parseInt(yellow, 10);
                                }
                            </script>
                            <i class=""fas fa-star"" onclick=""DrawStars(1)""></i>
                            <i class=""fas fa-star"" onclick=""DrawStars(2)""></i>
                            <i class=""fas fa-star"" onclick=""DrawStars(3)""></i>
                            <i class=""fas fa-star"" onclick=""DrawStars(4)""></i>
                            <i class=""fas fa-star"" onclick=""DrawStars(5)""></i>
                        </div>

                        ");
            EndContext();
            BeginContext(6256, 601, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6949a26dcd2e6b9d45694878f66ca1080b1daeec19240", async() => {
                BeginContext(6310, 540, true);
                WriteLiteral(@"
                            <!-- Dòng input này để form gửi số điểm đánh giá sản phẩm lưu vào database, không được xóa -->
                            <div class=""col-2""><input type=""text"" class=""writecomment__points"" name=""stars"" value=""0"" readonly hidden /></div>
                            <textarea class=""blck w100"" cols=""10"" rows=""1"">Đê lại bình luận hoặc đánh giá về sản phẩm tại đây ...</textarea>
                            <div class=""txt-right""><button type=""submit"">Đăng bình luận</button></div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6857, 92, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"container-fluid mrg0 padd0\">\r\n");
            EndContext();
#line 130 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                          
                            for (int i = 0; i <= 5; i++)
                            {

#line default
#line hidden
            BeginContext(7066, 55, true);
            WriteLiteral("                                <div class=\"comment\">\r\n");
            EndContext();
#line 134 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                      string fakename = "RichKid_2019" + i.ToString();

#line default
#line hidden
            BeginContext(7210, 76, true);
            WriteLiteral("                                    <p class=\"mrg0 iblck comment__username\">");
            EndContext();
            BeginContext(7287, 8, false);
#line 135 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                                                       Write(fakename);

#line default
#line hidden
            EndContext();
            BeginContext(7295, 175, true);
            WriteLiteral("</p>\r\n                                    <p class=\"mrg0 iblck comment__datetime\"><i>10/10/2019</i></p>\r\n                                    <div class=\"blck comment_stars\">\r\n");
            EndContext();
#line 138 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                          
                                            if (i % 2 == 0)
                                            {

#line default
#line hidden
            BeginContext(7622, 424, true);
            WriteLiteral(@"                                                <i class=""fas fa-star star--yellow""></i>
                                                <i class=""fas fa-star star--yellow""></i>
                                                <i class=""fas fa-star star--yellow""></i>
                                                <i class=""fas fa-star""></i>
                                                <i class=""fas fa-star""></i>
");
            EndContext();
#line 146 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(8190, 411, true);
            WriteLiteral(@"                                                <i class=""fas fa-star star--yellow""></i>
                                                <i class=""fas fa-star star--yellow""></i>
                                                <i class=""fas fa-star""></i>
                                                <i class=""fas fa-star""></i>
                                                <i class=""fas fa-star""></i>
");
            EndContext();
#line 154 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                            }
                                        

#line default
#line hidden
            BeginContext(8691, 112, true);
            WriteLiteral("                                    </div>\r\n                                    <div class=\"comment__content\">\r\n");
            EndContext();
#line 158 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                         if (i % 2 == 0)
                                        {

#line default
#line hidden
            BeginContext(8902, 69, true);
            WriteLiteral("<p>Sản phẩm này dùng rất tốt. Mong Shop đừng ra sản phẩm nào nữa.</p>");
            EndContext();
#line 159 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                                                                                              }

#line default
#line hidden
            BeginContext(8974, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 160 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                         if (i % 2 != 0)
                                        {

#line default
#line hidden
            BeginContext(9073, 75, true);
            WriteLiteral("<p>Sản phẩm này không những mắc tiền mà còn dở nữa. Mọi người đừng mua.</p>");
            EndContext();
#line 161 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                                                                                                                    }

#line default
#line hidden
            BeginContext(9151, 84, true);
            WriteLiteral("                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 164 "G:\Web42Shop\Web42Shop\Views\Products\Single.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(9293, 1404, true);
            WriteLiteral(@"                    </div>
                </div><!-- end of Thông tin chính -->

                <!-- Các nút Mua hàng,Thêm vào giỏ,Chia sẻ -->
                <div class=""col-3 relative"">
                    <div class=""product__main__info"">
                        
                            <p class=""iblck""><i class=""fas fa-star""></i> 4.5/5</p>
                            <p class=""iblck""><i class=""fas fa-eye""></i> 12,345</p>
                            <p class=""iblck""><i class=""fas fa-shopping-cart""></i> 12,000</p>
                        
                    </div>
                    <div class=""product__main__actions sticky"">
                        <a href=""#"" class=""action action--buynow""><i class=""fas fa-cash-register""></i> MUA NGAY</a>
                        <a href=""#"" class=""action action--addtocart""><i class=""fas fa-shopping-cart""></i> THÊM VÀO GIỎ</a>
                        <a href=""#"" class=""action action--share""><i class=""fas fa-share-alt""></i> CHIA SẺ</a>
               ");
            WriteLiteral(@"     </div>
                    <div class=""product__main__tags"">
                        <a href=""#"">#laptop</a><a href=""#"">#SONY</a><a href=""#"">#2019</a>
                    </div>
                </div><!-- end of Các nút Mua hàng,Thêm vào giỏ,Chia sẻ -->

            </div>
        </div><!-- end of Chi tiết sản phẩm -->

    </div>
</div>

<script>

</script>");
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
