#pragma checksum "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19d269c650958606c348ac50cda98d05a30f37fe"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d269c650958606c348ac50cda98d05a30f37fe", @"/Views/Customer/Error.cshtml")]
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
            WriteLiteral("    <script>\r\n        alert(\"UserName is Already Exists Try Other\");\r\n        window.location.href = \"Register\";\r\n    </script>\r\n");
#nullable restore
#line 7 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Booking Is Exists")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"Already Booked Executive in Same date\");\r\n        window.location.href = \"BookingExecutive\";\r\n    </script>\r\n");
#nullable restore
#line 14 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}
else if (TempData.Peek("Msg").ToString() == "Not Eligible")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\"You Are Not Eligible for this Order\");\r\n        window.location.href = \"Home\";\r\n    </script>\r\n");
#nullable restore
#line 21 "C:\Users\tikum\Desktop\Softura training\Project A\src\DeliveryBookingProject\Views\Customer\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
