#pragma checksum "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dba312f9744a41e5a2a81832bb0d8ec7534bf36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodOrderingWebsite.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(FoodOrderingWebsite.Pages.Pages_Index), null)]
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
#line 1 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\_ViewImports.cshtml"
using FoodOrderingWebsite;

#line default
#line hidden
#line 3 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\_ViewImports.cshtml"
using FoodOrderingWebsite.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dba312f9744a41e5a2a81832bb0d8ec7534bf36", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53faf057128910339b223a88dd84b98f05f8bc1b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "searchLocationParams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-sender", "food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-sender", "resturant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page new branch";

#line default
#line hidden
            BeginContext(82, 31, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(113, 374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dba312f9744a41e5a2a81832bb0d8ec7534bf365799", async() => {
                BeginContext(156, 20, true);
                WriteLiteral("\r\n        \r\n        ");
                EndContext();
                BeginContext(176, 151, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dba312f9744a41e5a2a81832bb0d8ec7534bf366202", async() => {
                    BeginContext(246, 15, true);
                    WriteLiteral("\r\n             ");
                    EndContext();
                    BeginContext(261, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dba312f9744a41e5a2a81832bb0d8ec7534bf366619", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 11 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
                WriteLiteral(ViewData["Location"]);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(308, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 10 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.LocationOptions;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(327, 28, true);
                WriteLiteral("\r\n        <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 355, "\"", 386, 1);
#line 13 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
WriteAttributeValue("", 363, ViewData["FoodSearch"], 363, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(387, 93, true);
                WriteLiteral(" name=\"searchFoodParams\" />\r\n        <button type=\"submit\" class=\"btn\"> Search</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 8 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(487, 15, true);
            WriteLiteral("\r\n\r\n    <div>\r\n");
            EndContext();
#line 18 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
         if (Model.ResturantList is null)
        {
            

#line default
#line hidden
#line 20 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
             foreach (var item in Model.FoodList)
            {

#line default
#line hidden
            BeginContext(622, 41, true);
            WriteLiteral("                <p>\r\n                    ");
            EndContext();
            BeginContext(664, 35, false);
#line 23 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
               Write(Html.DisplayFor(m => item.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(699, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(724, 32, false);
#line 24 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
               Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(756, 25, true);
            WriteLiteral(" | \r\n                    ");
            EndContext();
            BeginContext(782, 38, false);
#line 25 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
               Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(820, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(844, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dba312f9744a41e5a2a81832bb0d8ec7534bf3614118", async() => {
                BeginContext(916, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sender", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sender"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(927, 24, true);
            WriteLiteral("\r\n                </p>\r\n");
            EndContext();
#line 28 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
            }

#line default
#line hidden
#line 28 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
             

        }
        else
        {
            

#line default
#line hidden
#line 33 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
             foreach (var item in Model.ResturantList)
            {

#line default
#line hidden
            BeginContext(1075, 41, true);
            WriteLiteral("                <p>\r\n                    ");
            EndContext();
            BeginContext(1117, 40, false);
#line 36 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
               Write(Html.DisplayFor(m => item.ResturantName));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1182, 34, false);
#line 37 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
               Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1241, 39, false);
#line 38 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
               Write(Html.DisplayFor(m => item.OpeningHours));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1302, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dba312f9744a41e5a2a81832bb0d8ec7534bf3618991", async() => {
                BeginContext(1379, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sender", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sender"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1390, 24, true);
            WriteLiteral("\r\n                </p>\r\n");
            EndContext();
#line 41 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
            }

#line default
#line hidden
#line 41 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1440, 13, true);
            WriteLiteral("\r\n        <p>");
            EndContext();
            BeginContext(1454, 23, false);
#line 44 "C:\Users\Simi\source\repos\FoodOrderingWebsite\FoodOrderingWebsite\FoodOrderingWebsite\Pages\Index.cshtml"
      Write(ViewData["SearchError"]);

#line default
#line hidden
            EndContext();
            BeginContext(1477, 28, true);
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
