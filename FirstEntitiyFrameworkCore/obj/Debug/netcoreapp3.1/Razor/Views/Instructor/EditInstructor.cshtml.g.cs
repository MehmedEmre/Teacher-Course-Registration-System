#pragma checksum "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "478104c94dc2df29391cf0e3b42fe5842b7f39b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_EditInstructor), @"mvc.1.0.view", @"/Views/Instructor/EditInstructor.cshtml")]
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
#line 2 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
using FirstEntityFrameworkCore.Entity.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
using FirstEntityFrameworkCore.DAC.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478104c94dc2df29391cf0e3b42fe5842b7f39b1", @"/Views/Instructor/EditInstructor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ceed74051217980b6c6fae7166c901610d28f96", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_EditInstructor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditInstructorModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control nameAndSurname"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Soyad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-input value"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("switch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Instructor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditInstructor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JavaScript/EditInstructor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"

<style>

    .card {
        border: 1px solid rgba(153, 153, 153, 0.36);
    }

    .border-dark {
        border-color: #343a40 !important;
    }
    .card-footer {
        padding: 0.75rem 1.25rem;
        background-color: rgba(153, 153, 153, 0.36);
        border-top: 1px solid rgba(0, 0, 0, 0.125);
    }

</style>

<div class=""d-flex flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"">
    <h1 class=""h2""></h1>

    <div class=""btn-toolbar mb-2 mb-md-0"">
        <h4 class=""mb-2 float-left nameAndSurname"">Eğitmen ");
#nullable restore
#line 29 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
                                                      Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
                                                                  Write(Model.surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" İçin Ders Ve Branş Kaydı</h4>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478104c94dc2df29391cf0e3b42fe5842b7f39b19013", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"col-sm-12 ml-2\">\r\n\r\n        <div class=\"card border-dark mb-2\" style=\"max-width: 60rem;\">\r\n            <div class=\"card-header\">\r\n                <div class=\"col-sm-12 mt-1 mb-1 row ml-1\">\r\n                    <h5");
                BeginWriteAttribute("class", " class=\"", 1090, "\"", 1098, 0);
                EndWriteAttribute();
                WriteLiteral(@">Eğitmen Bilgileri</h5>
                </div>
            </div>
            <div class=""card-body text-dark row"">
                <div class=""col-sm-4 mb-3 row ml-1"">
                    <label for=""instructorNameText"">Ad</label>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "478104c94dc2df29391cf0e3b42fe5842b7f39b19943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 47 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-sm-4 mb-3 row ml-1\">\r\n                    <label for=\"instructorSurnameText\">Soyad</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "478104c94dc2df29391cf0e3b42fe5842b7f39b111927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 52 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.surname);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"card-footer text-muted\">\r\n                <div class=\"custom-control custom-switch mt-1 float-right\">\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "478104c94dc2df29391cf0e3b42fe5842b7f39b113944", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 59 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isEnable);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2024, "Switch(\'nameAndSurname\',\'switch\',", 2024, 33, true);
#nullable restore
#line 59 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 2057, Model.Id, 2057, 9, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2066, ")", 2066, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <label class=\"custom-control-label\" for=\"switch\"></label>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 70 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
     for (int i = 0; i < Model.branchKeys.Count; i++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-sm-12 ml-2 mb-2\"");
                BeginWriteAttribute("id", " id=\"", 2336, "\"", 2348, 2);
                WriteAttributeValue("", 2341, "card_", 2341, 5, true);
#nullable restore
#line 72 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
WriteAttributeValue("", 2346, i, 2346, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""card border-dark  mb-2"" style=""max-width: 60rem;"">


                <div class=""card-header"">

                    <div class=""row"">
                        <span class=""col-sm-5 row ml-1"">
                            <p>Branş Adı</p>
                        </span>

                        <span class=""col-sm-5 row ml-1"">
                            <p>Ders Adı</p>
                        </span>

                    </div>

                </div>

                <div class=""card-body row"">
                    <div class=""col-sm-5 row ml-1"">

                        <div class=""col-sm-6"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478104c94dc2df29391cf0e3b42fe5842b7f39b118310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3040, "form-control", 3040, 12, true);
                AddHtmlAttributeValue(" ", 3052, "switch_", 3053, 8, true);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3060, i, 3060, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onchange", 9, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3074, "branchWarningMessage(\'1message_", 3074, 31, true);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3105, i, 3105, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 3107, "\',\'switch_", 3107, 10, true);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3117, i, 3117, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 3119, "\',\'s_", 3119, 5, true);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3124, i, 3124, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 3126, "\',\'2message_", 3126, 12, true);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3138, i, 3138, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 3140, "\')", 3140, 2, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.branchKeys[i];

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.branchValues[i]);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3214, "1switch_", 3214, 8, true);
#nullable restore
#line 95 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3222, i, 3222, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n\r\n                        <small class=\"ml-1 d-none\"");
                BeginWriteAttribute("id", " id=\"", 3330, "\"", 3346, 2);
                WriteAttributeValue("", 3335, "1message_", 3335, 9, true);
#nullable restore
#line 98 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
WriteAttributeValue("", 3344, i, 3344, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color:red\">Bu branşı bırakırsanız bu branşa ait derste bırakılacaktır! </small>\r\n                        <small class=\"ml-1 d-none\"");
                BeginWriteAttribute("id", " id=\"", 3486, "\"", 3502, 2);
                WriteAttributeValue("", 3491, "2message_", 3491, 9, true);
#nullable restore
#line 99 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
WriteAttributeValue("", 3500, i, 3500, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""color:red"">""Bir Eğitmene ait en az bir branş olmalıdır!"" </small>
                        
                    </div>

                    <div class=""col-sm-5 row ml-1 mt-1"">
                        <div class=""col-sm-6"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478104c94dc2df29391cf0e3b42fe5842b7f39b125238", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3783, "form-control", 3783, 12, true);
                AddHtmlAttributeValue(" ", 3795, "switch_", 3796, 8, true);
#nullable restore
#line 105 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3803, i, 3803, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 105 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.lessonKeys[i];

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 105 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.lessonValues[i]);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3877, "2switch_", 3877, 8, true);
#nullable restore
#line 105 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 3885, i, 3885, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"card-footer text-muted\">\r\n                    <div class=\"custom-control custom-switch mt-1 float-right\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "478104c94dc2df29391cf0e3b42fe5842b7f39b129187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 113 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isEnable);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4237, "s_", 4237, 2, true);
#nullable restore
#line 113 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 4239, i, 4239, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4252, "Switch(\'switch_", 4252, 15, true);
#nullable restore
#line 113 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 4267, i, 4267, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 4269, "\',", 4269, 2, true);
                AddHtmlAttributeValue(" ", 4271, "\'s_", 4272, 4, true);
#nullable restore
#line 113 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 4275, i, 4275, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 4277, "\',", 4277, 2, true);
#nullable restore
#line 113 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 4279, Model.Id, 4279, 9, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 4288, ",\'card_", 4288, 7, true);
#nullable restore
#line 113 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
AddHtmlAttributeValue("", 4295, i, 4295, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 4297, "\')", 4297, 2, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <label");
                BeginWriteAttribute("class", " class=\"", 4335, "\"", 4368, 3);
                WriteAttributeValue("", 4343, "custom-control-label", 4343, 20, true);
                WriteAttributeValue(" ", 4363, "s_", 4364, 3, true);
#nullable restore
#line 114 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
WriteAttributeValue("", 4366, i, 4366, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("for", " for=\'", 4369, "\'", 4379, 2);
                WriteAttributeValue("", 4375, "s_", 4375, 2, true);
#nullable restore
#line 114 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"
WriteAttributeValue("", 4377, i, 4377, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 119 "C:\Users\mehme\Desktop\Desktop\GitHub\Teacher-Course-Registration-System\FirstEntitiyFrameworkCore\Views\Instructor\EditInstructor.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<hr />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478104c94dc2df29391cf0e3b42fe5842b7f39b136473", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditInstructorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591