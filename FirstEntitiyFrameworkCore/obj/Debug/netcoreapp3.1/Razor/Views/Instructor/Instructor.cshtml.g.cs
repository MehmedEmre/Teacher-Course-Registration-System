#pragma checksum "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b84ed87c8f0650e571c3e9e87a67d4c6448ec30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_Instructor), @"mvc.1.0.view", @"/Views/Instructor/Instructor.cshtml")]
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
#line 1 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
using FirstEntityFrameworkCore.Entity.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
using FirstEntityFrameworkCore.DAC.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b84ed87c8f0650e571c3e9e87a67d4c6448ec30", @"/Views/Instructor/Instructor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ceed74051217980b6c6fae7166c901610d28f96", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_Instructor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InstructorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Instructor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Instructor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
  
    ViewData["Title"] = "Instructor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom\">\r\n    <h1 class=\"h2\"></h1>\r\n\r\n    <div class=\"btn-toolbar mb-2 mb-md-0\">\r\n        <h4 class=\"mb-2 float-left\">Eğitmen İşlemleri</h4>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b84ed87c8f0650e571c3e9e87a67d4c6448ec305403", async() => {
                WriteLiteral("\r\n    <div class=\"form-row\">\r\n\r\n        <div class=\"col-sm-12 mt-1 mb-1\">\r\n            <h5");
                BeginWriteAttribute("class", " class=\"", 590, "\"", 598, 0);
                EndWriteAttribute();
                WriteLiteral(">Eğitmen Bilgileri</h5>\r\n        </div>\r\n\r\n        <div class=\"col-sm-4 mb-3\">\r\n            <label for=\"name\">Ad</label>\r\n            ");
#nullable restore
#line 28 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
       Write(Html.TextBoxFor(x => x.name, "", new { @class = "form-control", id = "instructorNameText", placeholder = "Ad" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-4 mb-3\">\r\n            <label for=\"surname\">Soyad</label>\r\n            ");
#nullable restore
#line 33 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
       Write(Html.TextBoxFor(x => x.surname, "", new { @class = "form-control", id = "instructorSurnameText", placeholder = "Soyad" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <label for=\"inputState\">Branşlar</label>\r\n\r\n    <div class=\"form-group col-sm-4\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b84ed87c8f0650e571c3e9e87a67d4c6448ec307068", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 41 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ModelArray);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.selectList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>

    <button class=""btn btn-outline-dark mt-3"" type=""submit"">

        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-person-plus"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
            <path fill-rule=""evenodd"" d=""M8 5a2 2 0 1 1-4 0 2 2 0 0 1 4 0zM6 8a3 3 0 1 0 0-6 3 3 0 0 0 0 6zm6 5c0 1-1 1-1 1H1s-1 0-1-1 1-4 6-4 6 3 6 4zm-1-.004c-.001-.246-.154-.986-.832-1.664C9.516 10.68 8.289 10 6 10c-2.29 0-3.516.68-4.168 1.332-.678.678-.83 1.418-.832 1.664h10zM13.5 5a.5.5 0 0 1 .5.5V7h1.5a.5.5 0 0 1 0 1H14v1.5a.5.5 0 0 1-1 0V8h-1.5a.5.5 0 0 1 0-1H13V5.5a.5.5 0 0 1 .5-.5z"" />
        </svg>

        <span class=""ml-1"" typeof=""submit"" id=""addInstructor""> Eğitmeni Ekle</span>

    </button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<hr />

<h3 class=""mt-4"">Mevcut Eğitmenlerin Listesi:</h3>

<div class=""table-responsive"">
    <table class=""table  col-sm-10"">

        <thead>
            <tr>
                <th>#</th>
                <th>Eğitmen Adı</th>
                <th>Eğitmen Soyadı</th>
                <th>Branşlar</th>
                <th>Dersler</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 73 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
              
                List<Teacher> newList = ViewBag.Instructor as List<Teacher>;
                List<Branch_Teacher> branchList = ViewBag.branchList as List<Branch_Teacher>;
                List<Lessons> lessonList = ViewBag.lessonList as List<Lessons>;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
             if (newList != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                 if (newList.Count != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                     for (int i = 0; i < newList.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 86 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                           Write(newList[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 91 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                           Write(newList[i].surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <span class=\"float-right\">\r\n");
#nullable restore
#line 94 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                     using (Html.BeginForm("Delete", "Edit"))
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"btn btn-outline-warning btn-sm float-left\">Düzenle</button>\r\n");
#nullable restore
#line 98 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                     using (Html.BeginForm("Delete", "Lesson"))
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                   Write(Html.Hidden("id", newList[i].id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"btn btn-outline-danger btn-sm float-left ml-1\">Sil</button>\r\n");
#nullable restore
#line 104 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </span>
                            </td>
                            <td>
                                <div class=""btn-group dropright"">
                                    <button class=""btn btn-secondary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        Branşlar
                                    </button>
                                    <div class=""dropdown-menu"">

");
#nullable restore
#line 114 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                          
                                            List<Branch_Teacher> bList = branchList.ToList().Where(x => newList[i].id == x.TeacherId).ToList();

                                            if (bList.Count == 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button class=\"dropdown-item\" type=\"button\">Branş Mevcut Değil!</button>\r\n");
#nullable restore
#line 120 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                            }
                                            else
                                            {
                                                foreach (Branch_Teacher item in bList)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <button class=\"dropdown-item\" type=\"button\">");
#nullable restore
#line 125 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                                                                           Write(item.branch.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 126 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                                }
                                            }

                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>

                            </td>

                            <td>
                                <div class=""btn-group dropright"">
                                    <button class=""btn btn-secondary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        Dersler
                                    </button>
                                    <div class=""dropdown-menu"">

");
#nullable restore
#line 143 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                          
                                            List<Lessons> lList = lessonList.ToList().Where(x => newList[i].id == x.TeacherId).ToList();

                                            if (lList.Count == 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button class=\"dropdown-item\" type=\"button\">Ders Mevcut Değil!</button>\r\n");
#nullable restore
#line 149 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                            }
                                            else
                                            {
                                                foreach (Lessons item in lList)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <button class=\"dropdown-item\" type=\"button\">");
#nullable restore
#line 154 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                                                                           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 155 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                                                }
                                            }

                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 164 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>Gösterilecek Herhangi Bir Eğitmen Mevcut Değil!</td>\r\n                    </tr>\r\n");
#nullable restore
#line 172 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>Gösterilecek Herhangi Bir Eğitmen Mevcut Değil!</td>\r\n                </tr>\r\n");
#nullable restore
#line 179 "C:\Users\mehme\source\repos\FirstEntitiyFrameworkCore\FirstEntitiyFrameworkCore\Views\Instructor\Instructor.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
    </table>
</div>


<script>

    $(""#addInstructor"").on(""click"", function () {


        setTimeout(function () {

            $(""#instructorNameText"").val("""")
            $(""#instructorSurnameText"").val("""")

        }, 1000)

    })


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InstructorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591