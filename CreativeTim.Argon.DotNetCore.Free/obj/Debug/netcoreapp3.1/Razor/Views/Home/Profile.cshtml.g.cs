#pragma checksum "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb71d85a938cc18c75e20fb13c34423c08a2033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 3 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb71d85a938cc18c75e20fb13c34423c08a2033", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7b73f4b5ab57cb2c4600262264325cfb5af658", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/img-1-1000x600.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/login.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("input-username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("input-email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("jesse@example.com"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("input-first-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("First name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#line 6 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
  
    Layout = "_LayoutProfile";
    ViewData["Title"] = "Profile";

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-xl-4 order-xl-2\">\r\n        <div class=\"card card-profile\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "feb71d85a938cc18c75e20fb13c34423c08a203310886", async() => {
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
            WriteLiteral("\r\n            <div class=\"row justify-content-center\">\r\n                <div class=\"col-lg-3 order-lg-2\">\r\n                    <div class=\"card-profile-image\">\r\n                        <a href=\"#\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "feb71d85a938cc18c75e20fb13c34423c08a203312325", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                </div>
            </div>
            <div class=""card-header text-center border-0 pt-8 pt-md-4 pb-0 pb-md-4"">
                <div class=""d-flex justify-content-between"">
                    <a href=""#"" class=""btn btn-sm btn-info mr-4"">Connect</a>
                    <a href=""#"" class=""btn btn-sm btn-default float-right"">Message</a>
                </div>
            </div>
            <div class=""card-body pt-0"">
                <div class=""row"">
                    <div class=""col"">
                        <div class=""card-profile-stats d-flex justify-content-center"">
                            <div>
                                <span class=""heading"">22</span>
                                <span class=""description"">Friends</span>
                            </div>
                            <div>
                                <span class=""heading"">10</span>
                                <span class=""des");
            WriteLiteral(@"cription"">Photos</span>
                            </div>
                            <div>
                                <span class=""heading"">89</span>
                                <span class=""description"">Comments</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""text-center"">
                    <h5 class=""h3"">
                        ");
#line 51 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                    Write(Model.FullName != null ? Model.FullName : Model.Username);

#line default
#line hidden
            WriteLiteral(@"<span class=""font-weight-light"">, 27</span>
                    </h5>
                    <div class=""h5 font-weight-300"">
                        <i class=""ni location_pin mr-2""></i>
                        Bucharest, Romania
                    </div>
                    <div class=""h5 mt-4"">
                        <i class=""ni business_briefcase-24 mr-2""></i>
                        Solution Manager - Creative Tim Officer
                    </div>
                    <div>
                        <i class=""ni education_hat mr-2""></i>University of Computer Science
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-8 order-xl-1"">
        <div class=""card"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb71d85a938cc18c75e20fb13c34423c08a203316073", async() => {
                WriteLiteral(@"
                <div class=""card-header"">
                    <div class=""row align-items-center"">
                        <div class=""col-12"">
                            <h3 class=""mb-0"">Edit profile </h3>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <h6 class=""heading-small text-muted mb-4"">
                        User information
                    </h6>
                    <div class=""pl-lg-4"">
");
#line 84 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                         if (!string.IsNullOrWhiteSpace(TempData["StatusMessage"] as string))
                        {

#line default
#line hidden
                WriteLiteral(@"                            <!-- everything went ok -->
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <div role=""alert"" class=""alert alert-success alert-dismissible fade show"">
                                        ");
#line 90 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                                   Write(TempData["StatusMessage"]);

#line default
#line hidden
                WriteLiteral(@"
                                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                            <span aria-hidden=""true"">×</span>
                                        </button>
                                    </div>
                                </div>
                            </div>
");
#line 97 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                        }
                        

#line default
#line hidden
#line 99 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                         if (!ViewData.ModelState.IsValid && ViewData.ModelState[string.Empty] != null)
                        {

#line default
#line hidden
                WriteLiteral("                            <!-- errors -->\r\n");
#line 102 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                             foreach (var error in @ViewData.ModelState[string.Empty]?.Errors)
                            {

#line default
#line hidden
                WriteLiteral(@"                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <div role=""alert"" class=""alert alert-warning alert-dismissible fade show"">
                                            <span>");
#line 107 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                                             Write(error.ErrorMessage);

#line default
#line hidden
                WriteLiteral(@"</span>
                                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                                <span aria-hidden=""true"">×</span>
                                            </button>
                                        </div>
                                    </div>
                                </div>
");
#line 114 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                            }

#line default
#line hidden
#line 114 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
                             
                        }

#line default
#line hidden
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-username"">Username</label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "feb71d85a938cc18c75e20fb13c34423c08a203320968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 120 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-email"">Email address</label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "feb71d85a938cc18c75e20fb13c34423c08a203323385", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 126 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-first-name"">Full name</label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "feb71d85a938cc18c75e20fb13c34423c08a203325795", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 134 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación web\Pro-Web\CreativeTim.Argon.DotNetCore.Free\Views\Home\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr class=""my-4""/>
                    <!-- Address -->
                    <h6 class=""heading-small text-muted mb-4"">Contact information</h6>
                    <div class=""pl-lg-4"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-address"">Address</label>
                                    <input id=""input-address"" class=""form-control"" placeholder=""Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"" type=""text"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4"">
                                ");
                WriteLiteral(@"<div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-city"">City</label>
                                    <input type=""text"" id=""input-city"" class=""form-control"" placeholder=""City"" value=""New York"">
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-country"">Country</label>
                                    <input type=""text"" id=""input-country"" class=""form-control"" placeholder=""Country"" value=""United States"">
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""input-country"">Postal code</label>
                                    ");
                WriteLiteral(@"<input type=""number"" id=""input-postal-code"" class=""form-control"" placeholder=""Postal code"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr class=""my-4""/>
                    <!-- Description -->
                    <h6 class=""heading-small text-muted mb-4"">About me</h6>
                    <div class=""pl-lg-4"">
                        <div class=""form-group"">
                            <label class=""form-control-label"">About Me</label>
                            <textarea rows=""4"" class=""form-control"" placeholder=""A few words about you ..."">A beautiful Dashboard for Bootstrap 4. It is Free and Open Source.</textarea>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""row align-items-center"">
                        <div class=""col-12 text-center"">
                            <butt");
                WriteLiteral("on type=\"submit\" class=\"btn btn-md btn-primary\">\r\n                                Save\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_17.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
