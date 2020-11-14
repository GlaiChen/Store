#pragma checksum "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "042d043bfd4930637b5357a03ae2f8a478835544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCarts_Index), @"mvc.1.0.view", @"/Views/ShoppingCarts/Index.cshtml")]
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
#line 1 "C:\Users\97254\Documents\GitHub\Store\Views\_ViewImports.cshtml"
using BooksStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\97254\Documents\GitHub\Store\Views\_ViewImports.cshtml"
using BooksStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"042d043bfd4930637b5357a03ae2f8a478835544", @"/Views/ShoppingCarts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c269e86a9abc6e417b650ea50037e65f98d4826", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCarts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksStore.ViewModels.ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCarts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50px; margin-left: 40px; padding-top: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClearFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Section Begin -->
<section class=""banner-section set-bg"" data-setbg=""img/bluebanner.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""banner__text"">
                    <h2>Shopping Cart</h2>
                    <div class=""banner__option"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042d043bfd4930637b5357a03ae2f8a4788355446915", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span>Cart</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Banner Section End -->\r\n\r\n<!-- Products Cart Begin\r\n<div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 28 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
     foreach (var item in Model.ShoppingCart.ShoppingCartItems)
    {
        var Subtotal = item.Book.Price * item.Quantity;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row-card\">\r\n            <div class=\"col-12 col-sm-12 col-md-2 text-center\">\r\n                <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 1032, "\"", 1060, 1);
#nullable restore
#line 34 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
WriteAttributeValue("", 1038, item.Book.PictureName, 1038, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"prewiew\" width=\"120\" height=\"180\">\r\n            </div>\r\n            <div class=\"col-12 text-sm-center col-sm-12 text-md-left col-md-6\">\r\n                <h4 class=\"product-name\"><strong>");
#nullable restore
#line 37 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                                            Write(item.Book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n                <h4>\r\n                    <small>");
#nullable restore
#line 39 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                      Write(item.Book.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                </h4>
            </div>
            <div class=""col-12 col-sm-12 text-sm-center col-md-3 text-md-right row-card"">
                <div class=""col-3 col-sm-3 col-md-6 text-md-right"" style=""padding-top: 5px"">
                    <h4>");
#nullable restore
#line 44 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                   Write(Subtotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-muted\"> </span></h4>\r\n                </div>\r\n                <div class=\"col-4 col-sm-4 col-md-4\">\r\n                    <div class=\"quantity\">\r\n                        <input type=\"number\" step=\"1\" max=\"99\" min=\"1\"");
            BeginWriteAttribute("value", " value=\"", 1873, "\"", 1895, 1);
#nullable restore
#line 48 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
WriteAttributeValue("", 1881, item.Quantity, 1881, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Qty\" class=\"qty\" size=\"4\" readonly=\"readonly\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-2 col-sm-2 col-md-2 text-right\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042d043bfd4930637b5357a03ae2f8a47883554411457", async() => {
                WriteLiteral("\r\n                        <i class=\"fa fa-trash-o mt-0\" aria-hidden=\"true\" size=\"6\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                                                                 WriteLiteral(item.Book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 59 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
    <!-- Products Cart End -->
<!--Cart Products Start -->

<table class=""table"">
    <thead>
        <tr>
            <th width=""100px"">
                Product
            </th>
            <th width=""200px"">
                Book Name
            </th>
            <th class=""center-tr"">
                More Details
            </th>
            <th class=""center-tr"">
                Price
            </th>
            <th class=""center-tr"">
                Quantity
            </th>
            <th class=""center-tr"">
                Subtotal
            </th>
            <th class=""center-tr"">
                Actions
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 92 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
         foreach (var item in Model.ShoppingCart.ShoppingCartItems)
        {
            var Subtotal = item.Book.Price * item.Quantity;
            var Total = Subtotal;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 3476, "\"", 3504, 1);
#nullable restore
#line 98 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
WriteAttributeValue("", 3482, item.Book.PictureName, 3482, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"prewiew\">\r\n                </td>\r\n                <td>\r\n                    <strong>");
#nullable restore
#line 101 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                       Write(item.Book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </td>\r\n                <td class=\"center-td\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042d043bfd4930637b5357a03ae2f8a47883554416381", async() => {
                WriteLiteral("<i class=\"fa fa-info-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                                                                     WriteLiteral(item.Book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-td\">\r\n                    ");
#nullable restore
#line 107 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
               Write(item.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$\r\n                </td>\r\n                <td class=\"center-td\">\r\n                    <input type=\"number\" step=\"1\" max=\"99\" min=\"1\"");
            BeginWriteAttribute("value", " value=\"", 4058, "\"", 4080, 1);
#nullable restore
#line 110 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
WriteAttributeValue("", 4066, item.Quantity, 4066, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Qty\" class=\"qty\" size=\"4\" readonly=\"readonly\">\r\n                </td>\r\n                <td class=\"center-td\">\r\n                    ");
#nullable restore
#line 113 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
               Write(Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("$\r\n                </td>\r\n                <td class=\"center-td\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042d043bfd4930637b5357a03ae2f8a47883554420083", async() => {
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                                                                                           WriteLiteral(item.Book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042d043bfd4930637b5357a03ae2f8a47883554422559", async() => {
                WriteLiteral("<i class=\"fa fa-minus-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                                                                                                WriteLiteral(item.Book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042d043bfd4930637b5357a03ae2f8a47883554425041", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                                                                                               WriteLiteral(item.Book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 121 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr />\r\n<!--Cart Products End -->\r\n\r\n<!--Cart Summary Begin-->\r\n");
#nullable restore
#line 128 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
  
    var GrandSubtotals= Math.Round(Model.ShoppingCartTotal,2);
    var Tax = Math.Round(GrandSubtotals * 0.17,2);
    var GradnTotal= Math.Round(GrandSubtotals + Tax,2);


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""bottom-right"">
    <table>
        <thead>
            <tr> 
                <th></th>  
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr> 
                <th> Subtotal </th>
                <td> ");
#nullable restore
#line 144 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                Write(GrandSubtotals);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n            <tr> \r\n                <th> Tax (17%) </th>\r\n                <td> ");
#nullable restore
#line 147 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                Write(Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n            <tr> \r\n                <th> Shipping </th>\r\n                <td> Free </td>\r\n            <tr> \r\n                <th> Grand Total </th>\r\n                <td> ");
#nullable restore
#line 153 "C:\Users\97254\Documents\GitHub\Store\Views\ShoppingCarts\Index.cshtml"
                Write(GradnTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n            </tr>\r\n    </table> <br />\r\n    <a href=\"/Orders/Checkout\">\r\n        <button type=\"button\" class=\"site-btn\">Procceed To Checkout</button>\r\n    </a>\r\n</section>\r\n");
            WriteLiteral("\r\n<!--Cart Summary End-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksStore.ViewModels.ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
