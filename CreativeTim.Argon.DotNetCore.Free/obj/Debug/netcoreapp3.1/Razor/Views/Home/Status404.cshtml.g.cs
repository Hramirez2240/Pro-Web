#pragma checksum "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Status404.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e818233124d2b8fc1656712aa9f7e42978cc0157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Status404), @"mvc.1.0.view", @"/Views/Home/Status404.cshtml")]
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
#line 1 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos;

#line default
#line hidden
#line 2 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos.Infrastructure.ApplicationUserClaims;

#line default
#line hidden
#line 3 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos.Models;

#line default
#line hidden
#line 4 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos.Models.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e818233124d2b8fc1656712aa9f7e42978cc0157", @"/Views/Home/Status404.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7b73f4b5ab57cb2c4600262264325cfb5af658", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Status404 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Status404.cshtml"
  
    ViewData["Title"] = ViewBag.StatusCodeDescription ?? ViewBag.StatusCode.ToString();

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-lg-5 col-md-7 text-center\">\r\n        <h1 class=\"text-white\">");
#line 7 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Status404.cshtml"
                          Write(ViewBag.StatusCode);

#line default
#line hidden
            WriteLiteral(" - ");
#line 7 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Status404.cshtml"
                                                Write(ViewBag.StatusCodeDescription);

#line default
#line hidden
            WriteLiteral("</h1>\r\n        <a class=\"text-light\"");
            BeginWriteAttribute("href", " href=\"", 308, "\"", 345, 1);
#line 8 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Status404.cshtml"
WriteAttributeValue("", 315, Url.Action("Index", "Movies"), 315, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" title=\"Go Home\">Go Home</a>\r\n    </div>\r\n</div>");
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
