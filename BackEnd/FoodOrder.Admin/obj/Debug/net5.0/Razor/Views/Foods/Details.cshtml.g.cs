#pragma checksum "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3b4fa8c4f60fb06394e9785fe42b3a4e72972233cf0aa3cc3b714e10b961c0e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Foods_Details), @"mvc.1.0.view", @"/Views/Foods/Details.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
using FoodOrder.Core.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
using FoodOrder.Core.ViewModels.Ratings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3b4fa8c4f60fb06394e9785fe42b3a4e72972233cf0aa3cc3b714e10b961c0e4", @"/Views/Foods/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4d3ce79b2913c022d0cf413aab48f768121134aaecfd269ba42f76ffeb35a9df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Foods_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodOrder.Core.ViewModels.Foods.FoodVM>
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
#line 6 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    PaginatedList<RatingVM> ratingVMs = ViewBag.RatingVMs as PaginatedList<RatingVM>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Food detail</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Dashboard</a></li>
        <li class=""breadcrumb-item active"">Food detail</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4fa8c4f60fb06394e9785fe42b3a4e72972233cf0aa3cc3b714e10b961c0e45201", async() => {
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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div>\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Image\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2377, "\"", 2471, 1);
#nullable restore
#line 58 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
WriteAttributeValue("", 2384, Configuration["BaseAddress"] + Configuration["user-content"] + "/" + Model.ImagePath, 2384, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2472, "\"", 2496, 1);
#nullable restore
#line 58 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
WriteAttributeValue("", 2480, Model.ImagePath, 2480, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2532, "\"", 2625, 1);
#nullable restore
#line 59 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
WriteAttributeValue("", 2538, Configuration["BaseAddress"] + Configuration["user-content"] + "/" + Model.ImagePath, 2538, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:150px;height:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 2659, "\"", 2681, 1);
#nullable restore
#line 59 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
WriteAttributeValue("", 2665, Model.ImagePath, 2665, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </a>
                    </dd>
                    <dt class=""col-sm-2"">
                        Categories
                    </dt>
                    <dd class=""col-sm-10"">
                        <ul class=""list-group"">
");
#nullable restore
#line 67 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                             foreach (var item in Model.CategoryVMs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    ");
#nullable restore
#line 70 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                               Write(Html.ActionLink(item.Name, "Details", "Categories", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 72 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </dd>

                    <dt class=""col-sm-2"">
                        User reviews
                    </dt>
                    <dd class=""col-sm-10"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th scope=""col"">#</th>
                                    <th scope=""col"">User name</th>
                                    <th scope=""col"">Star</th>
                                    <th scope=""col"">Comment</th>
                                    <th scope=""col"">Time</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 92 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                                 for (int i = 0; i < ratingVMs.Items.Count(); i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 95 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 96 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                                       Write(Html.ActionLink(ratingVMs.Items[i].UserFullName, "Details", "User", new { id = ratingVMs.Items[i].UserID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 97 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                                       Write(ratingVMs.Items[i].Star);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 98 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                                       Write(ratingVMs.Items[i].Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 99 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                                       Write(ratingVMs.Items[i].TimeCreate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 101 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n\r\n\r\n                    </dd>\r\n                </dl>\r\n\r\n                <div>\r\n");
#nullable restore
#line 111 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                     if ((await AuthorizationService.AuthorizeAsync(User, RoleTypes.Admin)).Succeeded)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 5100, "", 5150, 1);
#nullable restore
#line 113 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
WriteAttributeValue("", 5106, Url.Action("Delete", new { id = Model.ID }), 5106, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 114 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 5234, "", 5282, 1);
#nullable restore
#line 116 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Foods\Details.cshtml"
WriteAttributeValue("", 5240, Url.Action("Edit", new { id = Model.ID }), 5240, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodOrder.Core.ViewModels.Foods.FoodVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591