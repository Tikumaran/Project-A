#pragma checksum "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36cdd3ce87f91ed0c0c51696bffb226ccf67c7ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36cdd3ce87f91ed0c0c51696bffb226ccf67c7ad", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1f54105708d92dcd174227840ed0563d28627c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryBookingProject.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36cdd3ce87f91ed0c0c51696bffb226ccf67c7ad4387", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Login</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36cdd3ce87f91ed0c0c51696bffb226ccf67c7ad5446", async() => {
                WriteLiteral("\r\n    <h4>Login</h4>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36cdd3ce87f91ed0c0c51696bffb226ccf67c7ad5815", async() => {
                    WriteLiteral("\r\n                <table>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 19 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
                       Write(Html.LabelFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 22 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
                       Write(Html.EditorFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 27 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
                       Write(Html.LabelFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            ");
#nullable restore
#line 30 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 35 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
                       Write(Html.LabelFor(m => m.UserType, new { @Class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <td>\r\n                            Customer:  ");
#nullable restore
#line 38 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
                                  Write(Html.RadioButtonFor(m => m.UserType, "Customer", new { @Class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            Executive: ");
#nullable restore
#line 39 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
                                  Write(Html.RadioButtonFor(m => m.UserType, "Executive", new { @Class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                        </td>
                    </tr>
                </table>
                <div class=""form-group"">
                    <input type=""submit"" value=""SignIn"" class=""btn btn-primary"" />
                    <button type=""reset"" value=""Reset"" class=""btn btn-primary"">ReSet</button>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 52 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
   Write(Html.ActionLink(" CustomerSignUp ", "Register", "Customer"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n        ");
#nullable restore
#line 53 "C:\Users\tikum\Desktop\Final Project\Training-Final-Project\src\DeliveryBookingSolution\DeliveryBookingProject\Views\User\Login.cshtml"
   Write(Html.ActionLink(" ExecutiveSignUp ", "Register", "Executive"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryBookingProject.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
