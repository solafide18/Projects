#pragma checksum "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "650fb4bd5abc5ce56eeaabd26ee6514e4077f80e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaksi__partialOrderDetails), @"mvc.1.0.view", @"/Views/Transaksi/_partialOrderDetails.cshtml")]
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
#line 1 "C:\Projects\IndoCybreShop\Views\_ViewImports.cshtml"
using IndoCybreShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\IndoCybreShop\Views\_ViewImports.cshtml"
using IndoCybreShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"650fb4bd5abc5ce56eeaabd26ee6514e4077f80e", @"/Views/Transaksi/_partialOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c6aac17847d1aaf18d92c0e21554fb627bee06", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaksi__partialOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IndoCybreShop.Models.ViewModels.OrderDetailViews>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""w3-container list-cart-item"">
    <table class=""w3-table-all w3-hoverable"">
        <thead>
            <tr class=""w3-light-grey"">
                <th>Product</th>
                <th>Price</th>
                <th>Quantity</th>
                <th>Total</th>
            </tr>
        </thead>
        <tbody id=""list-transaksi"">      
");
#nullable restore
#line 14 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"prd-item-cart\"");
            BeginWriteAttribute("id", " id=\'", 529, "\'", 557, 1);
#nullable restore
#line 16 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
WriteAttributeValue("", 534, "prd"+item.ProductID, 534, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("prdid", " prdid=\"", 558, "\"", 581, 1);
#nullable restore
#line 16 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
WriteAttributeValue("", 566, item.ProductID, 566, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        <span");
            BeginWriteAttribute("id", " id=\'", 640, "\'", 672, 1);
#nullable restore
#line 18 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
WriteAttributeValue("", 645, "prdname"+item.ProductID, 645, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
                                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td>\r\n                        <span");
            BeginWriteAttribute("id", " id=\'", 782, "\'", 815, 1);
#nullable restore
#line 21 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
WriteAttributeValue("", 787, "prdprice"+item.ProductID, 787, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
                                                           Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td>\r\n                        <span");
            BeginWriteAttribute("id", " id=\'", 923, "\'", 953, 1);
#nullable restore
#line 24 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
WriteAttributeValue("", 928, "count"+item.ProductID, 928, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
                                                        Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td>\r\n                        <span");
            BeginWriteAttribute("id", " id=\'", 1060, "\'", 1093, 1);
#nullable restore
#line 27 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
WriteAttributeValue("", 1065, "totalprc"+item.ProductID, 1065, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
                                                           Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"3\" class=\"text-center\"><b>Total</b>\r\n                </td>\r\n                <td>\r\n                    <b><span id=\"totalsemuaharga\">");
#nullable restore
#line 35 "C:\Projects\IndoCybreShop\Views\Transaksi\_partialOrderDetails.cshtml"
                                             Write(ViewBag.totalharga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></b>\r\n                </td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IndoCybreShop.Models.ViewModels.OrderDetailViews>> Html { get; private set; }
    }
}
#pragma warning restore 1591
