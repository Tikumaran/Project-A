#pragma checksum "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c35074ee59a64fc77ef19037f7168e8cfbd929c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ExecutiveRequests), @"mvc.1.0.view", @"/Views/Admin/ExecutiveRequests.cshtml")]
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
#line 1 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\_ViewImports.cshtml"
using DeliveryBookingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\_ViewImports.cshtml"
using DeliveryBookingProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c35074ee59a64fc77ef19037f7168e8cfbd929c8", @"/Views/Admin/ExecutiveRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ExecutiveRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliveryBookingProject.Models.DeliveryExecutive>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
  
    ViewData["Title"] = "ExecutiveRequests";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c35074ee59a64fc77ef19037f7168e8cfbd929c84511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>Executive Requests</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.ExecutiveId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.ExecutiveName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.IsVerified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 42 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                         using (Html.BeginForm("EditExecutiveRequest", "Admin", new { Id = item.ExecutiveId }, FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 45 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ExecutiveId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ExecutiveName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <select class=\"form-control\" name=\"IsVerified\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c35074ee59a64fc77ef19037f7168e8cfbd929c812531", async() => {
#nullable restore
#line 64 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                                       Write(Html.ValueFor(modelItem => item.IsVerified));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c35074ee59a64fc77ef19037f7168e8cfbd929c813806", async() => {
                WriteLiteral("Verified");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c35074ee59a64fc77ef19037f7168e8cfbd929c814803", async() => {
                WriteLiteral("Rejected");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </select>\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"submit\" class=\"btn btn-info\" value=\"Update\" />\r\n                            </td>\r\n");
#nullable restore
#line 72 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 77 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>No More Customer\'s</h4>\r\n");
#nullable restore
#line 81 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Admin\ExecutiveRequests.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliveryBookingProject.Models.DeliveryExecutive>> Html { get; private set; }
    }
}
#pragma warning restore 1591