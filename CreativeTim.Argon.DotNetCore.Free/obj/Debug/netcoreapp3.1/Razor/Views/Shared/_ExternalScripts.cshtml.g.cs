#pragma checksum "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95794e3804807bb0184df13437f23345d3d9188e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ExternalScripts), @"mvc.1.0.view", @"/Views/Shared/_ExternalScripts.cshtml")]
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
#line 1 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
using GestionDeVehiculos.Infrastructure.AppSettingsModels;

#line default
#line hidden
#line 2 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95794e3804807bb0184df13437f23345d3d9188e", @"/Views/Shared/_ExternalScripts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7b73f4b5ab57cb2c4600262264325cfb5af658", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ExternalScripts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 6 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
 if (!string.IsNullOrWhiteSpace(OptionsScriptTags.Value?.GoogleTagManager))
{

#line default
#line hidden
            WriteLiteral(@"    <!-- Google Tag Manager -->
    <script>
(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
            new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
            j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
            'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
    })(window,document,'script','dataLayer','");
#line 14 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
                                        Write(OptionsScriptTags.Value.GoogleTagManager);

#line default
#line hidden
            WriteLiteral("\');</script>\r\n    <!-- End Google Tag Manager -->\r\n");
#line 16 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
}


#line default
#line hidden
#line 19 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
 if (!string.IsNullOrWhiteSpace(OptionsScriptTags.Value?.GoogleAnalytics))
{

#line default
#line hidden
            WriteLiteral(@"    <!-- Google Analytics Code -->
    <script>
        (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
                (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
                m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
        })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

        ga('create', '");
#line 28 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
                 Write(OptionsScriptTags.Value.GoogleAnalytics);

#line default
#line hidden
            WriteLiteral("\', \'auto\');\r\n        ga(\'send\', \'pageview\');\r\n    </script>\r\n    <!-- End Google Analytics Code -->\r\n");
#line 32 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
}


#line default
#line hidden
#line 35 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
 if (!string.IsNullOrWhiteSpace(OptionsScriptTags.Value?.Facebook))
{

#line default
#line hidden
            WriteLiteral(@"    <!-- Facebook Pixel Code -->
    <script>
        !function(f,b,e,v,n,t,s)
        {if(f.fbq)return;n=f.fbq=function(){n.callMethod?
                n.callMethod.apply(n,arguments):n.queue.push(arguments)};
            if(!f._fbq)f._fbq=n;n.push=n;n.loaded=!0;n.version='2.0';
            n.queue=[];t=b.createElement(e);t.async=!0;
            t.src=v;s=b.getElementsByTagName(e)[0];
            s.parentNode.insertBefore(t,s)}(window, document,'script',
            'https://connect.facebook.net/en_US/fbevents.js');
        fbq('init', '");
#line 47 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
                Write(OptionsScriptTags.Value.Facebook);

#line default
#line hidden
            WriteLiteral(@"');
        fbq('track', 'PageView');
    </script>
    <noscript>
        <img height=""1"" width=""1"" style=""display:none""
             src=""https://www.facebook.com/tr?id=your-pixel-id-goes-here&ev=PageView&noscript=1"" />
    </noscript>
    <!-- End Facebook Pixel Code -->
");
#line 55 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Shared\_ExternalScripts.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<ScriptTags> OptionsScriptTags { get; private set; }
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
