#pragma checksum "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02865a85793aa5f40a57156df95ea135c431cb85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_BookingDetailById), @"mvc.1.0.view", @"/Views/Customer/BookingDetailById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02865a85793aa5f40a57156df95ea135c431cb85", @"/Views/Customer/BookingDetailById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_BookingDetailById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryBookingProject.Models.DeliveryBooking>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
  
    ViewData["Title"] = "BookingDetailById";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02865a85793aa5f40a57156df95ea135c431cb854246", async() => {
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
            WriteLiteral("\r\n<h1>Booking Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n");
#nullable restore
#line 11 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 15 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayNameFor(model => model.ExecutiveId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayFor(model => model.ExecutiveId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 21 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 27 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayNameFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 30 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 33 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 36 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 39 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 42 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 44 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
             if (Model.ResMessage != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
               Write(Html.DisplayNameFor(model => model.ResMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
               Write(Html.DisplayFor(model => model.ResMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 52 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 54 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayNameFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 57 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 60 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 63 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
#nullable restore
#line 66 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>No More Details</h4>\r\n");
#nullable restore
#line 70 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\BookingDetailById.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryBookingProject.Models.DeliveryBooking> Html { get; private set; }
    }
}
#pragma warning restore 1591
