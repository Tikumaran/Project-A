#pragma checksum "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78992fc7a5c031bdb8c1025069c799ba61972786"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Executive_BookingDetailByOrderId), @"mvc.1.0.view", @"/Views/Executive/BookingDetailByOrderId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78992fc7a5c031bdb8c1025069c799ba61972786", @"/Views/Executive/BookingDetailByOrderId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_Executive_BookingDetailByOrderId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryBookingProject.Models.DeliveryBooking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
  
    ViewData["Title"] = "BookingDetailByOrderId";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order Detail</h1>\r\n\r\n<div>\r\n    <hr />\r\n");
#nullable restore
#line 11 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 15 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 21 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 27 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 30 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 33 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 36 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 39 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 42 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 45 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.ResMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 48 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.ResMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 51 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 54 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 57 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 60 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
#nullable restore
#line 63 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>No More Details</h4>\r\n");
#nullable restore
#line 67 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Executive\BookingDetailByOrderId.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
