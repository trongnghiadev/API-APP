#pragma checksum "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "964707c2fb2d00fb88b0e419e944c92e2aa844e6434f55b2479c345a559bcee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ratings_Details), @"mvc.1.0.view", @"/Views/Ratings/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\_ViewImports.cshtml"
using FoodOrder.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\_ViewImports.cshtml"
using FoodOrder.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\_ViewImports.cshtml"
using FoodOrder.Admin.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"964707c2fb2d00fb88b0e419e944c92e2aa844e6434f55b2479c345a559bcee0", @"/Views/Ratings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4d3ce79b2913c022d0cf413aab48f768121134aaecfd269ba42f76ffeb35a9df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ratings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodOrder.Core.ViewModels.Ratings.RatingVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Rating detail</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Dashboard</a></li>
        <li class=""breadcrumb-item active"">Rating detail</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964707c2fb2d00fb88b0e419e944c92e2aa844e6434f55b2479c345a559bcee04713", async() => {
                WriteLiteral("Back to list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FoodID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayFor(model => model.FoodID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Star));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayFor(model => model.Star));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TimeCreate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
               Write(Html.DisplayFor(model => model.TimeCreate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n            <div>\r\n");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(User, RoleTypes.Admin)).Succeeded)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 1805, "", 1888, 1);
#nullable restore
#line 50 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
WriteAttributeValue("", 1811, Url.Action("Delete", new { orderID = Model.OrderID, foodID = Model.FoodID }), 1811, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(User, RoleTypes.Admin)).Succeeded)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 2085, "", 2166, 1);
#nullable restore
#line 54 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
WriteAttributeValue("", 2091, Url.Action("Edit", new { orderID = Model.OrderID, foodID = Model.FoodID }), 2091, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Ratings\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodOrder.Core.ViewModels.Ratings.RatingVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
