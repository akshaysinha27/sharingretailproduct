#pragma checksum "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a878813c4feb0d2f97e8fec7fcfe284bd5575806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Index), @"mvc.1.0.view", @"/Views/Carts/Index.cshtml")]
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
#line 1 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a878813c4feb0d2f97e8fec7fcfe284bd5575806", @"/Views/Carts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Carts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAPI.Models.Carts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/NavBarSession.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/GreenTick.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GreenTick.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("py-2 btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
   Layout = "_Layout2"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a878813c4feb0d2f97e8fec7fcfe284bd55758067669", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""Saurabh"" content=""Shopping Cart"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a878813c4feb0d2f97e8fec7fcfe284bd55758068229", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a878813c4feb0d2f97e8fec7fcfe284bd55758069405", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a878813c4feb0d2f97e8fec7fcfe284bd557580610581", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a878813c4feb0d2f97e8fec7fcfe284bd557580611758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a878813c4feb0d2f97e8fec7fcfe284bd557580612935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a878813c4feb0d2f97e8fec7fcfe284bd557580614112", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    \n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a878813c4feb0d2f97e8fec7fcfe284bd557580616218", async() => {
                WriteLiteral("\n\n    \n\n\n");
#nullable restore
#line 31 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
     if (Model.Count() == 0)
            {
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""jumbotron text-center"">
            <h1 class=""display-3"">Cart is Empty!</h1>
            <div class=""swal2-icon swal2-error swal2-animate-error-icon"" style=""display: flex;""><span class=""swal2-x-mark""><span class=""swal2-x-mark-line-left""></span><span class=""swal2-x-mark-line-right""></span></span></div>

           
            <hr>
            <p>
                Having trouble? <a");
                BeginWriteAttribute("href", " href=\"", 1627, "\"", 1634, 0);
                EndWriteAttribute();
                WriteLiteral(">Contact us</a>\n            </p>\n            <p class=\"lead\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a878813c4feb0d2f97e8fec7fcfe284bd557580617389", async() => {
                    WriteLiteral("Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </p>\n        </div>\n");
#nullable restore
#line 47 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
    
  

        }

        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""single_product"">
            <div class=""container-fluid"" style="" background-color: #fff; padding: 3rem;"">



                <div class=""row"">

                    <div class=""col-lg-8"">


                        <div class=""jumbotron wish-list mb-3"">






");
#nullable restore
#line 71 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row mb-4\">\n                <div class=\"col-md-5 col-lg-3 col-xl-3\">\n                    <div class=\"view zoom overlay z-depth-1 rounded mb-3 mb-md-0\">\n");
#nullable restore
#line 76 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                           string imreBase64Data = Convert.ToBase64String(item.Product.ImageName);
                            string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img class=\"img-fluid w-100\"");
                BeginWriteAttribute("src", " src=\"", 2694, "\"", 2711, 1);
#nullable restore
#line 78 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
WriteAttributeValue("", 2700, imgDataURL, 2700, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""250"" height=""200"">


                    </div>
                </div>
                <div class=""col-md-7 col-lg-9 col-xl-9"">
                    <div>
                        <div class=""d-flex justify-content-between"">
                            <div>
                                <div class=""d-flex justify-content-between align-baseline"">
                                    <h5>");
#nullable restore
#line 88 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\n                                    <h3 style=\"position:relative; top:-8px; left:3px\">x ");
#nullable restore
#line 89 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                                </div>\n                                <p class=\"mb-3 text-muted text-uppercase small\">Category - ");
#nullable restore
#line 91 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                                                      Write(item.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\n                                <p class=\"mb-3 text-muted text-uppercase small\">Vendor Name - ");
#nullable restore
#line 92 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                                                         Write(item.Vendor.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>


                            </div>
                            <div>

                            </div>
                        </div>
                        <div class=""d-flex justify-content-between align-items-center border-dark "">
                            <div>
                                ");
#nullable restore
#line 102 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                           Write(Html.ActionLink("Remove", "DeleteFromCart", "Carts", new { id = item.CartId }, new { @class = "fa fa-remove" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\n\n                                ");
#nullable restore
#line 104 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                           Write(Html.ActionLink("Add Quantity", "IncreaseCartItem", "Carts", new { id = item.CartId }, new { @class = "fa fa-plus-circle" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 106 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                 if (item.Quantity > 1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>|</span>\n");
#nullable restore
#line 109 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                       Write(Html.ActionLink(" Reduce Quantity", "DecreaseFromCart", "Carts", new { id = item.CartId }, new { @class = "fa fa-minus-circle" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                                                                                                                                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            <p class=\"mb-0\"><h3><strong> ₹ ");
#nullable restore
#line 112 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                      Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></h3></p>\n                        </div>\n                    </div>\n                </div>\n            </div>\n");
                WriteLiteral(@"                                <div class="" mb-3"">
                                    <div class=""card-body"">

                                        <h5 class=""mb-4"">Expected shipping delivery</h5>

                                        <p class=""mb-0"">");
#nullable restore
#line 123 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                   Write(item.DeliveryDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                    </div>\n                                </div>\n                                                    <hr />");
#nullable restore
#line 126 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                          }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>

                        <div class="" mb-3"">
                            <div class=""card-body"">

                                <h5 class=""mb-4"">We accept</h5>

                                <img class=""mr-2"" width=""45""
                                     src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/visa.svg""
                                     alt=""Visa"">
                                <img class=""mr-2"" width=""45""
                                     src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/amex.svg""
                                     alt=""American Express"">
                                <img class=""mr-2"" width=""45""
                                     src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/mastercard.svg""
                                     alt=""Mastercard"">

                            </div>
                        </div>
");
                WriteLiteral("\n                    </div>\n\n                    <div class=\"col-lg-4\">\n");
#nullable restore
#line 151 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                           double shipping = 0;
                            double itemCost = 0;
                            foreach (var item in Model)
                            {
                                shipping += (double)(item.Vendor.DeliveryCharge);
                                itemCost += (double)(item.Price * item.Quantity);

                            } 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <!-- Card -->
                        <div class="" mb-3"">
                            <div class=""card-body"">

                                <h5 class=""mb-3"">The total amount of</h5>

                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 pb-0"">
                                        Shopping Items
                                        <span>₹ ");
#nullable restore
#line 169 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                           Write(itemCost);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </li>
                                    <li class=""list-group-item d-flex justify-content-between align-items-center px-0"">
                                        Shipping
                                        <span>₹ ");
#nullable restore
#line 173 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                           Write(shipping);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </li>
                                    <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3"">
                                        <div>
                                            <strong>The total amount of</strong>

                                            <p class=""mb-0""><strong>(including VAT)</strong></p>

                                        </div>
                                        <div>

");
#nullable restore
#line 184 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                              double sum = 0;
                                                foreach (var item in Model) { sum += (((double)item.Quantity * item.Price) + item.Vendor.DeliveryCharge); } 

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                                            <div>\n                                                <h4> <strong>Total Price: ₹ ");
#nullable restore
#line 189 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                                                                       Write(sum);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong></h4>\n                                            </div>\n\n                                        </div>\n                                    </li>\n                                </ul>\n\n                                ");
#nullable restore
#line 196 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
                           Write(Html.ActionLink("Proceed To Buy", "Checkout", "Carts", null, new { @class = "btn btn-success", @style = "width:100%" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                            </div>\n                        </div>\n\n\n                    </div>\n\n\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 208 "C:\Users\872691\source\repos\Product_Retail_Management\MVC\Views\Carts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAPI.Models.Carts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
