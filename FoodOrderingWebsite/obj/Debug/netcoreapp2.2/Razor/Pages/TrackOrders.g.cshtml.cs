#pragma checksum "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f81c8693aaecd90319a37772b3e3612a5afc1d19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodOrderingWebsite.Pages.Pages_TrackOrders), @"mvc.1.0.razor-page", @"/Pages/TrackOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TrackOrders.cshtml", typeof(FoodOrderingWebsite.Pages.Pages_TrackOrders), null)]
namespace FoodOrderingWebsite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f81c8693aaecd90319a37772b3e3612a5afc1d19", @"/Pages/TrackOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdbe8046df2b504b1af4c905626e1cba92dd2525", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TrackOrders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml"
  
    ViewData["Title"] = "TrackOrders";

#line default
#line hidden
            BeginContext(107, 554, true);
            WriteLiteral(@"<div class=""container"" style=""padding-top: 25px"">
    <h4 class=""lead text-muted"">TrackOrders</h4>
    <table class=""table table-responsive-sm"">
        <thead>
            <tr>
                <th>
                    Meals Ordered
                </th>
                <th>
                    Total Price
                </th>
                <th>
                    ETA
                </th>
                <th>
                    Date and Time of Order
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 27 "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml"
             foreach (var item in Model.DeliveryStatus)
            {

#line default
#line hidden
            BeginContext(733, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(806, 45, false);
#line 31 "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FoodBought));

#line default
#line hidden
            EndContext();
            BeginContext(851, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(931, 40, false);
#line 34 "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(971, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1051, 57, false);
#line 37 "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EstimatedTimeofArrival));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1188, 57, false);
#line 40 "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateTimeOrderCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Simi\source\repos\side-projects\FoodOrderingWebsite\FoodOrderingWebsite\foodorderingwebsite\Pages\TrackOrders.cshtml"
            }

#line default
#line hidden
            BeginContext(1312, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodOrderingWebsite.Pages.TrackOrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodOrderingWebsite.Pages.TrackOrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodOrderingWebsite.Pages.TrackOrdersModel>)PageContext?.ViewData;
        public FoodOrderingWebsite.Pages.TrackOrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
