#pragma checksum "C:\Projects\IndoCybreShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6bebafea031c4d85fb2d1d02f6c3e769411a6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6bebafea031c4d85fb2d1d02f6c3e769411a6b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c6aac17847d1aaf18d92c0e21554fb627bee06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\IndoCybreShop\Views\Home\Index.cshtml"
  
ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .container-web {
        margin-top: 50px;
    }

    .sidebar-shop {}

    .sidebar-shop-item {
        font-size: 18px;
        width: 100%;
        background-color: #f1f1f1;

    }

    .sidebar-shop-item ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        width: inherit;

    }

    .sidebar-shop-item li a {
        display: block;
        color: #000;
        padding: 8px 16px;
        text-decoration: none;
    }

    .sidebar-shop-item li a.active {
        background-color: #4CAF50;
        color: white;
    }

    .sidebar-shop-item li a:hover:not(.active) {
        background-color: #555;
        color: white;
    }

    .content-shop {
        width: 100%;
        height: inherit;
    }

    .content-shop .shop-item {
        text-align: center;
        padding-bottom: 10px;
        margin-bottom: 10px;
        /* border: 1px solid rgba(0,0,0,.125);
        border-radius: .25rem; */
    }

    .shop-item");
            WriteLiteral(@" img {
        height: 100%;
        width: 100%;
        object-fit: contain;
    }

    .list-cart-item {
        margin-top: 20px;
    }

    .w3-container {
        margin-bottom: 2rem;
    }

    #form-konfirmasi .row {
        margin-bottom: 10px;
    }
</style>
<div class=""container-web"">
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""sidebar-shop"" id=""sidebar-shop-div"">
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""content-shop"" id=""content-shop-div"">
            </div>
        </div>
    </div>
    <hr />
    <div class=""row"" id=""cart-shop-indocybre"">
        <div class=""col"">
            <div class=""text-center"">
                Cart
            </div>
            <div class=""w3-container list-cart-item"">
                <table class=""w3-table-all w3-hoverable"">
                    <thead>
                        <tr class=""w3-light-grey"">
                            <th>Product</th>
    ");
            WriteLiteral(@"                        <th>Price</th>
                            <th colspan=""2"">Quantity</th>
                            <th>Total</th>
                        </tr>
                    </thead>
                    <tbody id=""list-item-in-cart"">
                        <tr>
                            <td colspan=""5"" class=""text-center"">
                                    <b>No Item</b>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div id=""review-cart"">
                <button class=""btn btn-success"" onclick=""showpopupconfirm()""><i
                        class=""fas fa-shopping-cart""></i>&nbsp;&nbsp;Buy</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""modalConfirm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
    aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"" style=""width: 80%;"">
        <div class=""mo");
            WriteLiteral(@"dal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Konfirmasi</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""form-konfirmasi"">
                    <div class=""container"">
                        ");
#nullable restore
#line 130 "C:\Projects\IndoCybreShop\Views\Home\Index.cshtml"
                   Write(Html.Partial("_partialFormKonfirmasi"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""continuetobuy()"">Continue</button>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">
    var req = [];
    var countitem = 0;
    var modalConfirm = $(""#modalConfirm"");

    $(document).ready(function () {
        countitem = 0;
        loadCategories(0);
    });

    function addProduct(el) {
        readyDataTable();
        var productid = $(el).attr(""prodctId"");
        // var nameProduct = $(el).attr(""nameProduct"");
        // console.log(productid);
        // req.push({ ProductID: parseInt(productid) });
        // console.log(req);
        // countitem++;
        // $(""#countitem"").text(req.length);
        $.ajax({
            url: '");
#nullable restore
#line 161 "C:\Projects\IndoCybreShop\Views\Home\Index.cshtml"
             Write(Url.Action("addItem","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/' + productid,
            data: JSON.stringify(req),
            contentType: ""application/json"",
            type: ""post"",
            dataType: ""html"",
            success: function (result) {
                $(""#list-item-in-cart"").html(result);
            }
        });
    }

    function readyDataTable() {
        req = [];
        $(""#list-item-in-cart tr.prd-item-cart"").each(function () {
            var id = parseInt($(this).attr(""prdid""));
            var qty = $(""#count"" + id).text();
            var prdname = $(""#prdname"" + id).text();
            var prdprice = $(""#prdprice"" + id).text();
            var totalprice = $(""#totalprc"" + id).text();
            req.push(
                {
                    ProductID: id,
                    Quantity: qty,
                    ProductName: prdname,
                    UnitPrice: prdprice,
                    TotalPrice: totalprice
                });
        })
    }

    function loadCategories(cid) {
        $.ajax({");
            WriteLiteral("\r\n            url: \'");
#nullable restore
#line 193 "C:\Projects\IndoCybreShop\Views\Home\Index.cshtml"
             Write(Url.Action("LoadCategories","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/' + cid,
            type: ""get"",
            dataType: ""html"",
            success: function (result) {
                $(""#sidebar-shop-div"").html(result);
            }
        });
        loadProducts(cid);
    }

    function loadProducts(cid) {
        $.ajax({
            url: '");
#nullable restore
#line 205 "C:\Projects\IndoCybreShop\Views\Home\Index.cshtml"
             Write(Url.Action("LoadProducts","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/' + cid,
            type: ""get"",
            dataType: ""html"",
            success: function (result) {
                $(""#content-shop-div"").html(result);
            }
        });
    }

    function minusCount(e) {
        var id = $(e).attr(""itemid"");
        var qty = parseInt($(""#count"" + id).text());
        var prdprice = parseInt($(""#prdprice"" + id).text());
        qty = qty - 1;
        if (qty < 1) {
            $(""tr#prd"" + id).remove();
        }
        else {
            var totalprice = qty * prdprice;
            $(""#count"" + id).text(qty);
            $(""#totalprc"" + id).text(totalprice);
        }
        var totalharga = parseInt($(""#totalsemuaharga"").text());
        totalharga = totalharga - prdprice;
        $(""#totalsemuaharga"").text(totalharga);
    }

    function plusCount(e) {
        var id = $(e).attr(""itemid"");
        var qty = parseInt($(""#count"" + id).text());
        var prdprice = parseInt($(""#prdprice"" + id).text());
        qty = qty + 1");
            WriteLiteral(@";
        var totalprice = qty * prdprice;
        var totalharga = parseInt($(""#totalsemuaharga"").text());
        totalharga = totalharga + prdprice;
        $(""#count"" + id).text(qty);
        $(""#totalprc"" + id).text(totalprice);
        $(""#totalsemuaharga"").text(totalharga);
    }

    function showpopupconfirm() {
        readyDataTable();
        if (req.length > 0) {
            modalConfirm.modal(""show"");
        }
        else {
            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Belum ada Item yang dipilih',
            });
        }
    }

    function continuetobuy() {
        try {
            readyDataTable();
            var CustomerID = $(""#costumerid"").val();
            var RequiredDate = $(""#requireddate"").val();
            var ShippedDate = $(""#shipdate"").val();
            var Freight = $(""#freight"").val();
            var ShipName = $(""#shipname"").val();
            var ShipAddress = $(""#shipadd");
            WriteLiteral(@"ress"").val();
            var ShipCity = $(""#shipcity"").val();
            var ShipRegion = $(""#shipregion"").val();
            var ShipPostalCode = $(""#shippostalcode"").val();
            var ShipCountry = $(""#shipcountry"").val();

            if (CustomerID == null || CustomerID == """") throw ""Harap memilih Customer"";
            if (RequiredDate == null || RequiredDate == """") throw ""Harap mengisi tanggal wajib"";
            if (ShippedDate == null || ShippedDate == """") throw ""Harap mengisi tanggal pengiriman"";
            if (Freight == null || Freight == """") throw ""Harap mengisi jumlah kargo"";
            if (ShipName == null || ShipName == """") throw ""Harap kapal pengiriman"";
            if (ShipCountry == null || ShipCountry == """") throw ""Harap mengisi negara tujuan pengiriman"";
            if (ShipAddress == null || ShipAddress == """") throw ""Harap mengisi alamat tujuan pengiriman"";
            if (ShipCity == null || ShipCity == """") throw ""Harap mengisi kota tujuan pengiriman"";
            ");
            WriteLiteral(@"if (ShipRegion == null || ShipRegion == """") throw ""Harap mengisi provinsi tujuan pengiriman"";
            if (ShipPostalCode == null || ShipPostalCode == """") throw ""Harap mengisi kode pos tujuan pengiriman"";


            var dataReq = {
                CustomerID: CustomerID,
                RequiredDate: RequiredDate,
                ShippedDate: ShippedDate,
                Freight: Freight,
                ShipName: ShipName,
                ShipAddress: ShipAddress,
                ShipCity: ShipCity,
                ShipRegion: ShipRegion,
                ShipPostalCode: ShipPostalCode,
                ShipCountry: ShipCountry,
                list: req
            }

            $.ajax({
                url: '");
#nullable restore
#line 300 "C:\Projects\IndoCybreShop\Views\Home\Index.cshtml"
                 Write(Url.Action("BuyItem","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: JSON.stringify(dataReq),
                contentType: ""application/json"",
                type: ""post"",
                dataType: ""json"",
                success: function (result) {
                    console.log(result);
                    if(result.status)
                    {
                        modalConfirm.modal(""hide"");
                        Swal.fire({
                            icon: 'success',
                            title: 'Success',
                            text: result.remarks,
                        }).then(function(){
                            window.location.reload();
                        });
                    }
                    else{
                        Swal.fire({
                            icon: 'error',
                            title: 'Error',
                            text: result.remarks,
                        })
                    }
                },
                error:function(err){
       ");
            WriteLiteral(@"             Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: err,
                    })
                }
            });
            console.log(dataReq);
            
        } catch (error) {
            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: error,
            })
        }
    }
</script>");
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
