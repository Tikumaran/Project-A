#pragma checksum "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d48479eb5da52643e084b4c6738c682d5f142d7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Error), @"mvc.1.0.view", @"/Views/Customer/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48479eb5da52643e084b4c6738c682d5f142d7d", @"/Views/Customer/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
 if (TempData.Peek("Msg").ToString() == "UserName Exists")
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"UserName is Already Exists Try Other\");\r\n        window.location.href = \"Register\";\r\n    </script>\r\n");
#nullable restore
#line 8 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Booking Is Exists")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"Already Booked Executive in Same date\");\r\n        window.location.href = \"BookingExecutive\";\r\n    </script>\r\n");
#nullable restore
#line 17 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Not Eligible")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"You Are Not Eligible for this Order\");\r\n        window.location.href = \"Home\";\r\n    </script>\r\n");
#nullable restore
#line 26 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Not Registered")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"Registration Not Succeed\");\r\n        window.location.href = \"Home\";\r\n    </script>\r\n");
#nullable restore
#line 35 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Not BookingAdded")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"Booking Not Succeed\");\r\n        window.location.href = \"BookingExecutive\";\r\n    </script>\r\n");
#nullable restore
#line 44 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Booking Is IN Error Check Log")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"Booking Not Succeed Check Log\");\r\n        window.location.href = \"BookingExecutive\";\r\n    </script>\r\n");
#nullable restore
#line 53 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "No Executives")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"No Executives\");\r\n        window.location.href = \"BookingExecutive\";\r\n    </script>\r\n");
#nullable restore
#line 62 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Selecting Invalid Executive")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
Write(TempData.Remove("Msg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"Selecting Invalid Executive\");\r\n        window.location.href = \"BookingExecutive\";\r\n    </script>\r\n");
#nullable restore
#line 71 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
