#pragma checksum "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64204c37a0cf6d109d5fc4579b1eaa64b6dd30d2e9bc1f1e03636924944007eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Details), @"mvc.1.0.view", @"/Views/Categories/Details.cshtml")]
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
#line 3 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
using FoodOrder.Core.ViewModels.Foods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"64204c37a0cf6d109d5fc4579b1eaa64b6dd30d2e9bc1f1e03636924944007eb", @"/Views/Categories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4d3ce79b2913c022d0cf413aab48f768121134aaecfd269ba42f76ffeb35a9df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodOrder.Core.ViewModels.Categories.CategoryVM>
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
#line 5 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<FoodVM> foodVMs = ViewBag.ListFood;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Categories details</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Dashboard</a></li>
        <li class=""breadcrumb-item active"">Categories details</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64204c37a0cf6d109d5fc4579b1eaa64b6dd30d2e9bc1f1e03636924944007eb5012", async() => {
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
#line 25 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dd class=\"col-sm-3\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1679, "\"", 1773, 1);
#nullable restore
#line 43 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1686, Configuration["BaseAddress"] + Configuration["user-content"] + "/" + Model.ImagePath, 1686, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1774, "\"", 1798, 1);
#nullable restore
#line 43 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1782, Model.ImagePath, 1782, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1834, "\"", 1927, 1);
#nullable restore
#line 44 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1840, Configuration["BaseAddress"] + Configuration["user-content"] + "/" + Model.ImagePath, 1840, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"");
            BeginWriteAttribute("alt", " alt=\"", 1947, "\"", 1969, 1);
#nullable restore
#line 44 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1953, Model.ImagePath, 1953, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </a>
                    </dd>
                </dl>
            </div>

            <hr class=""solid"">
            <h1 class=""mt-4"">List Food in Category</h1>
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                           Write(Html.DisplayNameFor(model => foodVMs.FirstOrDefault().ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                Image\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                           Write(Html.DisplayNameFor(model => foodVMs.FirstOrDefault().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                           Write(Html.DisplayNameFor(model => foodVMs.FirstOrDefault().Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 69 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                           Write(Html.DisplayNameFor(model => foodVMs.FirstOrDefault().Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 72 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                           Write(Html.DisplayNameFor(model => foodVMs.FirstOrDefault().Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 78 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                         if (Model != null && foodVMs != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                             foreach (var item in foodVMs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 84 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>
                                        <div class=""row-cols-sm-3 row-cols-lg-1"" style=""width:100px;height:100px;overflow: hidden;"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4033, "\"", 4126, 1);
#nullable restore
#line 88 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 4040, Configuration["BaseAddress"] + Configuration["user-content"] + "/" + item.ImagePath, 4040, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4127, "\"", 4150, 1);
#nullable restore
#line 88 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 4135, item.ImagePath, 4135, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 4228, "\"", 4320, 1);
#nullable restore
#line 89 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 4234, Configuration["BaseAddress"] + Configuration["user-content"] + "/" + item.ImagePath, 4234, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"");
            BeginWriteAttribute("alt", " alt=\"", 4340, "\"", 4361, 1);
#nullable restore
#line 89 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 4346, item.ImagePath, 4346, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </a>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 94 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 97 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 100 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 103 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>

                                        <div class=""dropdown"">
                                            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                Action
                                            </button>
                                            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                                <a class=""dropdown-item btn btn-primary""");
            BeginWriteAttribute("href", " href=", 5802, "", 5852, 1);
#nullable restore
#line 112 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 5808, Url.Action("Details", new { id = item.ID }), 5808, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n\r\n");
#nullable restore
#line 114 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                                                 if ((await AuthorizationService.AuthorizeAsync(User, RoleTypes.Admin)).Succeeded)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a class=\"dropdown-item btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 6143, "", 6192, 1);
#nullable restore
#line 116 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 6149, Url.Action("Delete", new { id = item.ID }), 6149, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 117 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <a class=\"dropdown-item btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 6346, "", 6393, 1);
#nullable restore
#line 119 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 6352, Url.Action("Edit", new { id = item.ID }), 6352, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n                                            </div>\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 125 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n            <div>\r\n\r\n\r\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 6789, "", 6837, 1);
#nullable restore
#line 134 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 6795, Url.Action("Edit", new { id = Model.ID }), 6795, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n");
#nullable restore
#line 136 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(User, RoleTypes.Admin)).Succeeded)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 7015, "", 7065, 1);
#nullable restore
#line 138 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 7021, Url.Action("Delete", new { id = Model.ID }), 7021, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 139 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Categories\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodOrder.Core.ViewModels.Categories.CategoryVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591