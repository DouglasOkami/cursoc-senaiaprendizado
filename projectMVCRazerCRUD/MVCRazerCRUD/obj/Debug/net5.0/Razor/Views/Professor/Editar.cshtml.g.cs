#pragma checksum "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34f61b001d106dee9051bba4497f4c3cf8b2f9a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Editar), @"mvc.1.0.view", @"/Views/Professor/Editar.cshtml")]
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
#line 1 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\_ViewImports.cshtml"
using MVCRazerCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\_ViewImports.cshtml"
using MVCRazerCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f61b001d106dee9051bba4497f4c3cf8b2f9a4", @"/Views/Professor/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e77dac016f3c0546016ce15e42e480081e0d5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
  
    var professor = ViewBag.professorRetornado;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Página de Atualizar o Professor</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34f61b001d106dee9051bba4497f4c3cf8b2f9a44262", async() => {
                WriteLiteral("\r\n    <div class=\"form-professor-id\">\r\n        <label for=\"id\">ID:</label>\r\n        <input type=\"text\" name=\"professorId\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 311, "\"", 332, 1);
#nullable restore
#line 8 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 319, professor.Id, 319, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"nome\">Nome:</label>\r\n        <input type=\"text\" name=\"professorNome\" placeholder=\"Ex.Douglas Ferreira\" id=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 512, "\"", 535, 1);
#nullable restore
#line 12 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 520, professor.Nome, 520, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"email\">Email:</label>\r\n        <input type=\"text\" name=\"professorEmail\" placeholder=\"Ex.douglas@gmail.com\" id=\"email\"");
                BeginWriteAttribute("value", " value=\"", 741, "\"", 765, 1);
#nullable restore
#line 16 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 749, professor.Email, 749, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"endereco\">Endereco:</label>\r\n        <input type=\"text\" name=\"professorEndereco\" placeholder=\"Ex. São Paulo\" id=\"endereco\"");
                BeginWriteAttribute("value", " value=\"", 976, "\"", 1003, 1);
#nullable restore
#line 20 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 984, professor.Endereco, 984, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"telefone\">Telefone:</label>\r\n        <input type=\"text\" name=\"professorTelefone\" placeholder=\"Ex. (11) 9999-9999\" id=\"telefone\"");
                BeginWriteAttribute("value", " value=\"", 1219, "\"", 1246, 1);
#nullable restore
#line 24 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 1227, professor.Telefone, 1227, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div form-group>\r\n        <label for=\"cargo\">Cargo:</label>\r\n        <input type=\"text\" name=\"professorCargo\" placeholder=\"Ex. Professor de Matemática\" id=\"cargo\"");
                BeginWriteAttribute("value", " value=\"", 1451, "\"", 1475, 1);
#nullable restore
#line 28 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 1459, professor.Cargo, 1459, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <button type=\"submit\">Atualizar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 5 "C:\Users\dev\Documents\projetoCsharpDouglasGit\projectMVCRazerCRUD\MVCRazerCRUD\Views\Professor\Editar.cshtml"
AddHtmlAttributeValue("", 112, Url.Action("Atualizar"), 112, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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