#pragma checksum "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce8e1bc984fa4f6243b9696e1ce764c3ff4dbbee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Profile), @"mvc.1.0.view", @"/Views/Customer/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce8e1bc984fa4f6243b9696e1ce764c3ff4dbbee", @"/Views/Customer/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryBookingProject.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Home</h1>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.IsVerified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
       Write(Html.DisplayFor(model => model.IsVerified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 58 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
Write(Html.ActionLink("ChangeProfileDetails", "EditCustomerInfo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 59 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
Write(Html.ActionLink("Book Executive", "BookingExecutive"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 60 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
Write(Html.ActionLink("Booking Status", "BookingStatus"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 61 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\Customer\Profile.cshtml"
Write(Html.ActionLink("Booking Details", "Bookings"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryBookingProject.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
