#pragma checksum "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505a21139d210c8215f731c078bb25a226663296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Executive_BookingDetailById), @"mvc.1.0.view", @"/Views/Executive/BookingDetailById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505a21139d210c8215f731c078bb25a226663296", @"/Views/Executive/BookingDetailById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_Executive_BookingDetailById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryBookingProject.Models.DeliveryBooking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
  
    ViewData["Title"] = "BookingDetailById";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505a21139d210c8215f731c078bb25a2266632965000", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "505a21139d210c8215f731c078bb25a2266632966039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>Request Information</h1>\r\n\r\n<div>\r\n    <hr />\r\n");
#nullable restore
#line 15 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
     if(Model!= null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
         using (Html.BeginForm("EditRequests", "Executive", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayNameFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayName("Address:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.TempData.Peek("Address").ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.TempData.Peek("City").ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayNameFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                   Rs. ");
#nullable restore
#line 55 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
                  Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayName("Request Message"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.DisplayName("Response Message"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
               Write(Html.TextAreaFor(model => model.ResMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 69 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
                  
                    TempData["Id"] = Html.ValueFor(model=>model.OrderId);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dl>\r\n            <div>\r\n                <input type=\"submit\" name=\"accept\" value=\"Accept\" class=\"btn btn-success\" />\r\n                <input type=\"submit\" name=\"reject\" value=\"Reject\" class=\"btn btn-danger\" />\r\n            </div>\r\n");
#nullable restore
#line 77 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
          
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            alert(\"No Found Your Details\");\r\n        </script>\r\n        <h4>No Found Your Details</h4>\r\n");
#nullable restore
#line 85 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailById.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
