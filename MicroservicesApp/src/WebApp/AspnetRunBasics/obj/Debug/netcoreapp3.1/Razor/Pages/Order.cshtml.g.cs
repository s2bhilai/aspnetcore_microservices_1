#pragma checksum "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2238b930a19312e0a1be8eb2bb1629a201d2dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspnetRunBasics.Pages.Pages_Order), @"mvc.1.0.razor-page", @"/Pages/Order.cshtml")]
namespace AspnetRunBasics.Pages
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
#line 1 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\_ViewImports.cshtml"
using AspnetRunBasics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\_ViewImports.cshtml"
using AspnetRunBasics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2238b930a19312e0a1be8eb2bb1629a201d2dc2", @"/Pages/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69c53c7b7ba494d406494af252068c16028c5f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Order : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-block btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col\">\n            <nav aria-label=\"breadcrumb\">\n                <ol class=\"breadcrumb\">\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2238b930a19312e0a1be8eb2bb1629a201d2dc24589", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Order</li>
                </ol>
            </nav>
        </div>
    </div>
</div>

<div class=""container mb-4"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th scope=""col""> </th>
                            <th scope=""col"">First Name</th>
                            <th scope=""col"">Last Name</th>
                            <th scope=""col"">Email</th>
                            <th scope=""col"">Address</th>
                            <th scope=""col"" class=""text-right"">TotalPrice</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 37 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
                         foreach (var order in Model.Orders)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td><img src=\"https://dummyimage.com/50x50/55595c/fff\" /></td>\n                                <td>");
#nullable restore
#line 41 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
                               Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 42 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
                               Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 43 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
                               Write(order.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 44 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
                               Write(order.AddressLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td class=\"text-right\">");
#nullable restore
#line 45 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
                                                  Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\n                            </tr>\n");
#nullable restore
#line 47 "D:\Tech\MicroServices_Path\Udemy\Microservices\MicroservicesApp\src\WebApp\AspnetRunBasics\Pages\Order.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n        <div class=\"col mb-2\">\n            <div class=\"row\">\n                <div class=\"col-sm-12  col-md-6\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2238b930a19312e0a1be8eb2bb1629a201d2dc29221", async() => {
                WriteLiteral("Continue Shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspnetRunBasics.OrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRunBasics.OrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRunBasics.OrderModel>)PageContext?.ViewData;
        public AspnetRunBasics.OrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
