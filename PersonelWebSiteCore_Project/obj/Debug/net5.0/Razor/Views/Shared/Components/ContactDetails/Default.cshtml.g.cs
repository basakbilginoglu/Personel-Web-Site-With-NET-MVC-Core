#pragma checksum "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68eb745bcdeddb7c9fbbdaffecf4177c37daa08b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
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
#line 1 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\_ViewImports.cshtml"
using PersonelWebSiteCore_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\_ViewImports.cshtml"
using PersonelWebSiteCore_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68eb745bcdeddb7c9fbbdaffecf4177c37daa08b", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61458568aa5194584055732b52b86bd9ade6dde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ContactDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-6\" data-aos=\"fade-left\" data-aos-delay=\"300\">\r\n");
#nullable restore
#line 5 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml"
     foreach(var item in Model)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mt-3 px-1\">\r\n\r\n        <div class=\"h5\">");
#nullable restore
#line 10 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n          <p>");
#nullable restore
#line 11 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml"
        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
          <p>Ya da aşağıdaki iletişim kanallarından bana ulaşabilirsiniz.</p>
          <p>Görüşmek üzere!</p>
        </div>
        <div class=""mt-53 px-1"">
          <div class=""row""> 
            <div class=""col-sm-2"">
              <div class=""pb-1"">Email:</div>
            </div>
            <div class=""col-sm-10"">
              <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 21 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml"
                                     Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n           \r\n         \r\n            <div class=\"col-sm-2\">\r\n              <div class=\"pb-1\">Telefon:</div>\r\n            </div>\r\n            <div class=\"col-sm-10\">\r\n              <div class=\"pb-1 fw-bolder\">");
#nullable restore
#line 29 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml"
                                     Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Shared\Components\ContactDetails\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
