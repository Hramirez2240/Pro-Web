#pragma checksum "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e010e335348276d237675f966122e72e5667c30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Sidenav), @"mvc.1.0.view", @"/Views/Shared/_Sidenav.cshtml")]
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
#line 1 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos;

#line default
#line hidden
#line 2 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos.Infrastructure.ApplicationUserClaims;

#line default
#line hidden
#line 3 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos.Models;

#line default
#line hidden
#line 4 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\_ViewImports.cshtml"
using GestionDeVehiculos.Models.Identity;

#line default
#line hidden
#line 1 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e010e335348276d237675f966122e72e5667c30", @"/Views/Shared/_Sidenav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7b73f4b5ab57cb2c4600262264325cfb5af658", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Sidenav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/brand/blue.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- Sidenav -->
<nav class=""sidenav navbar navbar-vertical fixed-left navbar-expand-xs navbar-light bg-white"" id=""sidenav-main"">
    <div class=""scrollbar-inner"">

        <!-- Brand -->
        <div class=""sidenav-header  align-items-center"">
            <a class=""navbar-brand"" href=""javascript:void(0)"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4e010e335348276d237675f966122e72e5667c305341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </a>
        </div>
        <div class=""navbar-inner"">
            <!-- Collapse -->
            <div class=""collapse navbar-collapse"" id=""sidenav-collapse-main"">

                <!-- Collapse header -->
                <div class=""navbar-collapse-header d-md-none"">
                    <div class=""row"">
                        <div class=""col-6 collapse-brand"">
                            <a href=""/"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4e010e335348276d237675f966122e72e5667c307012", async() => {
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
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""col-6 collapse-close"">
                            <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#sidenav-collapse-main"" aria-controls=""sidenav-main"" aria-expanded=""false"" aria-label=""Toggle sidenav"">
                                <span></span>
                                <span></span>
                            </button>
                        </div>
                    </div>
                </div>

                <!-- Navigation -->
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a");
            BeginWriteAttribute("class", " class=\"", 1695, "\"", 1758, 2);
            WriteAttributeValue("", 1703, "nav-link", 1703, 8, true);
#line 38 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue(" ", 1711, Context.Request.Path == "/" ? "active" : "", 1712, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1759, "\"", 1786, 1);
#line 38 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue("", 1766, Url.Action("Index"), 1766, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"ni ni-tv-2 text-primary\"></i> Dashboard\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 1995, "\"", 2063, 2);
            WriteAttributeValue("", 2003, "nav-link", 2003, 8, true);
#line 43 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue(" ", 2011, Context.Request.Path == "/icons" ? "active" : "", 2012, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2064, "\"", 2091, 1);
#line 43 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue("", 2071, Url.Action("Icons"), 2071, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"ni ni-planet text-orange\"></i> Icons\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 2297, "\"", 2364, 2);
            WriteAttributeValue("", 2305, "nav-link", 2305, 8, true);
#line 48 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue(" ", 2313, Context.Request.Path == "/maps" ? "active" : "", 2314, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2365, "\"", 2391, 1);
#line 48 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue("", 2372, Url.Action("Maps"), 2372, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"ni ni-pin-3 text-primary\"></i> Google\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 2598, "\"", 2668, 2);
            WriteAttributeValue("", 2606, "nav-link", 2606, 8, true);
#line 53 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue(" ", 2614, Context.Request.Path == "/profile" ? "active" : "", 2615, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2669, "\"", 2698, 1);
#line 53 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue("", 2676, Url.Action("Profile"), 2676, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"ni ni-single-02 text-yellow\"></i> Profile\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 2909, "\"", 2978, 2);
            WriteAttributeValue("", 2917, "nav-link", 2917, 8, true);
#line 58 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue(" ", 2925, Context.Request.Path == "/tables" ? "active" : "", 2926, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2979, "\"", 3007, 1);
#line 58 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\FINAL-WEB\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_Sidenav.cshtml"
WriteAttributeValue("", 2986, Url.Action("Tables"), 2986, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"ni ni-bullet-list-67 text-default\"></i> Tables\r\n                        </a>\r\n                    </li>\r\n                    \r\n");
            WriteLiteral("                    \r\n");
            WriteLiteral("                    \r\n");
            WriteLiteral("\r\n                <!-- Divider -->\r\n                <hr class=\"my-3\">\r\n\r\n              \r\n\r\n                <!-- Navigation -->\r\n              \r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</nav>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
