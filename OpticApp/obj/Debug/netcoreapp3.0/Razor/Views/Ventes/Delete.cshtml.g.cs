<<<<<<< HEAD
#pragma checksum "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c855351"
=======
#pragma checksum "C:\repos\OpticApp\Views\Ventes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c855351"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ventes_Delete), @"mvc.1.0.view", @"/Views/Ventes/Delete.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Repo\OpticApp\Views\_ViewImports.cshtml"
=======
#line 1 "C:\repos\OpticApp\Views\_ViewImports.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
using OpticApp;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Repo\OpticApp\Views\_ViewImports.cshtml"
=======
#line 2 "C:\repos\OpticApp\Views\_ViewImports.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
using OpticApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c855351", @"/Views/Ventes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f0f9be8a7bab4acb421542c68514daaa37a31a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ventes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpticApp.Models.Vente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 3 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Vente</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 15 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 15 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayNameFor(model => model.visite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 18 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 18 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayFor(model => model.visite.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 21 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 21 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayNameFor(model => model.article));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 24 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 24 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayFor(model => model.article.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 27 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 27 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayNameFor(model => model.articlePosition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 30 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 30 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayFor(model => model.articlePosition.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 33 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 33 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayNameFor(model => model.montant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 36 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 36 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
       Write(Html.DisplayFor(model => model.montant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c8553516967", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c8553517233", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c8553516979", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c8553517245", async() => {
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
<<<<<<< HEAD
#line 41 "C:\Repo\OpticApp\Views\Ventes\Delete.cshtml"
=======
#line 41 "C:\repos\OpticApp\Views\Ventes\Delete.cshtml"
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c8553518983", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbde9ad8cf5eb4b5aa6d57cb9d9f48d4c8553518996", async() => {
>>>>>>> beb0287ff857a1fd8c40ff4874feac5487ca0cf1
                    WriteLiteral("Retour à la Liste");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpticApp.Models.Vente> Html { get; private set; }
    }
}
#pragma warning restore 1591
