#pragma checksum "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01893e597f6e2f1691cf25a61b969fe3032a0f5e9821084c80264bc51959c3a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"01893e597f6e2f1691cf25a61b969fe3032a0f5e9821084c80264bc51959c3a4", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4d3ce79b2913c022d0cf413aab48f768121134aaecfd269ba42f76ffeb35a9df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodOrder.Core.ViewModels.Orders.OrderVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
  
    string fullName = Model.UserVM.Name;
    double totalPrice = 0;
    int foodCount = 0;
    for (int i = 0; i < Model.OrderDetailVMs.Count(); i++)
    {
        totalPrice += Model.OrderDetailVMs[i].Price * Model.OrderDetailVMs[i].Amount *
                                        (100 - (Model.OrderDetailVMs[i].SaleCampaignID == null ? 0 : Model.OrderDetailVMs[i].SalePercent.Value)) / 100;
        foodCount += Model.OrderDetailVMs[i].Amount;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Order detail</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Dashboard</a></li>
        <li class=""breadcrumb-item active"">Order detail</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01893e597f6e2f1691cf25a61b969fe3032a0f5e9821084c80264bc51959c3a47418", async() => {
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
#line 34 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.AppUserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.ActionLink(Model.AppUserID.ToString(), "Details", "User", new { id = Model.AppUserID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Name\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 50 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 62 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IsPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 65 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.DatePaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 68 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.DatePaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderStatusVM.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.OrderStatusVM.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n\r\n\r\n\r\n\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 81 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PromotionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 84 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.ActionLink(Model.PromotionID.ToString(), "Details", "Promotions", new { id = Model.PromotionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 87 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PromotionAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 90 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PromotionAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 93 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.FinalTotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 96 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FinalTotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 99 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.AddressName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 102 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.AddressName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 105 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.AddressString));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 108 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => model.AddressString));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </dd>
                    <dt class=""col-sm-2"">
                        Order details
                    </dt>
                    <dd class=""col-sm-10"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th scope=""col"">#</th>
                                    <th scope=""col"">Food name</th>
                                    <th scope=""col"">Amount</th>
                                    <th scope=""col"">Price</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 124 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                 for (int i = 0; i < Model.OrderDetailVMs.Count(); i++)
                                {
                                    var price = Model.OrderDetailVMs[i].Price * Model.OrderDetailVMs[i].Amount * 
                                        (100 - (Model.OrderDetailVMs[i].SaleCampaignID == null ? 0 : Model.OrderDetailVMs[i].SalePercent)) / 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 129 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 131 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                       Write(Html.ActionLink(@Model.OrderDetailVMs[i].FoodVM.Name, "Details", "Foods", new { id = @Model.OrderDetailVMs[i].FoodVM.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 133 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                       Write(Model.OrderDetailVMs[i].Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 134 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                       Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 136 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"bg-info\">\r\n                                    <th scope=\"row\">Total</th>\r\n                                    <td></td>\r\n                                    <td>");
#nullable restore
#line 140 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                   Write(foodCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 141 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                                   Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n\r\n\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n\r\n            <div>\r\n");
#nullable restore
#line 152 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(User, RoleTypes.Admin)).Succeeded)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 6821, "", 6871, 1);
#nullable restore
#line 154 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 6827, Url.Action("Delete", new { id = Model.ID }), 6827, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 155 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(User, RoleTypes.Admin)).Succeeded)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 7068, "", 7116, 1);
#nullable restore
#line 158 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 7074, Url.Action("Edit", new { id = Model.ID }), 7074, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 159 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div style=\"height:20px\"></div>\r\n\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01893e597f6e2f1691cf25a61b969fe3032a0f5e9821084c80264bc51959c3a424149", async() => {
                WriteLiteral(@"
                        <div>
                            Change order status:
                        </div>
                        <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-4 form-group"">
                            <label class=""control-label""></label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01893e597f6e2f1691cf25a61b969fe3032a0f5e9821084c80264bc51959c3a424730", async() => {
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 171 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderStatusID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 173 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.OrderStatusList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\" hidden>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01893e597f6e2f1691cf25a61b969fe3032a0f5e9821084c80264bc51959c3a427049", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 177 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01893e597f6e2f1691cf25a61b969fe3032a0f5e9821084c80264bc51959c3a428693", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 178 "C:\Users\Admin\Desktop\flutter\v3\KLTN_2021\BackEnd\FoodOrder.Admin\Views\Orders\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n\r\n                        <button type=\"submit\" class=\"btn btn-primary mb-2\">Confirm change</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodOrder.Core.ViewModels.Orders.OrderVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
