#pragma checksum "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8c29c42984a8e1df2162b3fae7eb1c37657d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectSmithAshley.Pages.DataVisualization.MyViews.Pages_DataVisualization_MyViews_BunniesForSale), @"mvc.1.0.razor-page", @"/Pages/DataVisualization/MyViews/BunniesForSale.cshtml")]
namespace FinalProjectSmithAshley.Pages.DataVisualization.MyViews
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
#line 1 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\_ViewImports.cshtml"
using FinalProjectSmithAshley;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8c29c42984a8e1df2162b3fae7eb1c37657d07", @"/Pages/DataVisualization/MyViews/BunniesForSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4688f6746c86c04ed2084900269b4b83c4389712", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DataVisualization_MyViews_BunniesForSale : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
  
    ViewData["Title"] = "Bunnies For Sale";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bunnies For Sale</h1>\r\n</div>\r\n<table id=\"myTable\" class=\"table-striped table-bordered\" style=\"width:100%;\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayNameFor(model => model.VwBunnyForSale[0].BunnyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayNameFor(model => model.VwBunnyForSale[0].BreederLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayNameFor(model => model.VwBunnyForSale[0].Breed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayNameFor(model => model.VwBunnyForSale[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayNameFor(model => model.VwBunnyForSale[0].State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayNameFor(model => model.VwBunnyForSale[0].PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
         foreach (var item in Model.VwBunnyForSale)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayFor(modelItem => item.BunnyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayFor(modelItem => item.BreederLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayFor(modelItem => item.Breed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Hofstra\Documents\FinalProjectSmithAshley\FinalProjectSmithAshley\Pages\DataVisualization\MyViews\BunniesForSale.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectSmithAshley.Pages.DataVisualization.MyViews.BunniesForSaleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectSmithAshley.Pages.DataVisualization.MyViews.BunniesForSaleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectSmithAshley.Pages.DataVisualization.MyViews.BunniesForSaleModel>)PageContext?.ViewData;
        public FinalProjectSmithAshley.Pages.DataVisualization.MyViews.BunniesForSaleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
