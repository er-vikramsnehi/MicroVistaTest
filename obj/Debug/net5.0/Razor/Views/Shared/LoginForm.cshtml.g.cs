#pragma checksum "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e568a30643bc093c34237c51f72ff66165a6b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LoginForm), @"mvc.1.0.view", @"/Views/Shared/LoginForm.cshtml")]
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
#line 1 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\_ViewImports.cshtml"
using MicroVistaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\_ViewImports.cshtml"
using MicroVistaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e568a30643bc093c34237c51f72ff66165a6b30", @"/Views/Shared/LoginForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bccf762af5c0955e29b184d2769bac2bc86ad886", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_LoginForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MicroVistaMVC.Models.StudentClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""modal fade"" id=""exampleModalToggle"" aria-hidden=""true"" aria-labelledby=""exampleModalToggleLabel"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header btn-outline-warning "">
                <h5 class=""modal-title btn-outline-warning "" id=""exampleModalToggleLabel"">Registration</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">

");
#nullable restore
#line 13 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                 using (Html.BeginForm("Registration", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b304610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 15 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                    <div class=\"mb-3\">\r\n                        <label for=\"StudentMail\" class=\"form-label\">Full Name </label>\r\n                        ");
#nullable restore
#line 20 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.TextBoxFor(x => x.StudentName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br /> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b306770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 21 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.ValidationMessageFor(x => x.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral(@"                    <div class=""mb-3"">
                        <label for=""StudentMail"" class=""form-label"">Date of Birth </label>
                        <input type=""date"" class=""form-control"" name=""StudentDOB"" id=""StudentDOB"" />
                        <br /> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b308951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 28 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentDOB);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 29 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.ValidationMessageFor(x => x.StudentDOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-3\">\r\n                        <label for=\"StudentMail\" class=\"form-label\">Email address</label>\r\n                        ");
#nullable restore
#line 35 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.TextBoxFor(x => x.StudentMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b3011356", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 36 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentMail);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 37 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.ValidationMessageFor(x => x.StudentMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-3\">\r\n                        <label for=\"StudentPassword\" class=\"form-label\">Password</label>\r\n                        ");
#nullable restore
#line 44 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.PasswordFor(x => x.StudentPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b3013768", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 45 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentPassword);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 46 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.ValidationMessageFor(x => x.StudentPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-3\">\r\n                        <label for=\"StudentAddress\" class=\"form-label\">Student Address </label>\r\n                        ");
#nullable restore
#line 52 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.TextAreaFor(x => x.StudentAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br /> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b3016195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 53 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentAddress);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 54 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.ValidationMessageFor(x => x.StudentAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 62 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-white btn-outline-primary\"> <i class=\"fas fa-sign-in-alt fa-x\"></i>   Submit </button>\r\n");
#nullable restore
#line 65 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-white btn-outline-secondary"" data-bs-target=""#exampleModalToggle2"" data-bs-toggle=""modal"">Already have an Account? -- > </button>
            </div>
        </div>
    </div>
</div>






<div class=""modal fade"" id=""exampleModalToggle2"" aria-hidden=""true"" aria-labelledby=""exampleModalToggleLabel2"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalToggleLabel2"">Login</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">








");
#nullable restore
#line 97 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                 using (Html.BeginForm("Login", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mb-3\">\r\n                        <label for=\"StudentMail\" class=\"form-label\">Email address</label>\r\n                        ");
#nullable restore
#line 101 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.TextBoxFor(x => x.StudentMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b3020389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 102 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentMail);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 103 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.ValidationMessageFor(x => x.StudentMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-3\">\r\n                        <label for=\"StudentPassword\" class=\"form-label\">Password</label>\r\n                        ");
#nullable restore
#line 108 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.PasswordFor(x => x.StudentPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e568a30643bc093c34237c51f72ff66165a6b3022804", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 109 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentPassword);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 110 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                   Write(Html.ValidationMessageFor(x => x.StudentPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 113 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-white btn-outline-primary\"> <i class=\"fas fa-sign-in-alt fa-x\"></i>  Submit </button>\r\n");
#nullable restore
#line 116 "X:\Practical Task Asp. Net MVC Developer - MicroVista\MicroVistaMVC\Views\Shared\LoginForm.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-white btn-outline-success"" data-bs-target=""#exampleModalToggle"" data-bs-toggle=""modal"">  <i class=""fas fa-user-graduate fa-x""></i>   < -- Register Here. -- > </button>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MicroVistaMVC.Models.StudentClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
