#pragma checksum "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e093729cf496452b51e7e6db44a90df78414154a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Executive_BookingRequests), @"mvc.1.0.view", @"/Views/Executive/BookingRequests.cshtml")]
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
#line 1 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\_ViewImports.cshtml"
using DeliveryBookingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\_ViewImports.cshtml"
using DeliveryBookingProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e093729cf496452b51e7e6db44a90df78414154a", @"/Views/Executive/BookingRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_Executive_BookingRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliveryBookingProject.Models.DeliveryBooking>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
  
    ViewData["Title"] = "BookingRequests";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e093729cf496452b51e7e6db44a90df78414154a4216", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Booking Requests</h1>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 14 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
               Write(Html.DisplayNameFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 41 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                     using (Html.BeginForm("BookingDetailById", "Executive", new { Id = item.OrderId }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 44 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Select\" />\r\n                        </td>\r\n");
#nullable restore
#line 67 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 72 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"No More Booking Requests\")\r\n    </script>\r\n    <h4>No More Booking Requests For You</h4>\r\n");
#nullable restore
#line 79 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Executive\BookingRequests.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliveryBookingProject.Models.DeliveryBooking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
