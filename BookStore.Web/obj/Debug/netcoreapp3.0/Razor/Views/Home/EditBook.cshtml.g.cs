#pragma checksum "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3add7e10e9cd3152aa0084789710f710cef71ec2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditBook), @"mvc.1.0.view", @"/Views/Home/EditBook.cshtml")]
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
#line 1 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\_ViewImports.cshtml"
using BookStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\_ViewImports.cshtml"
using BookStore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
using BookStore.Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3add7e10e9cd3152aa0084789710f710cef71ec2", @"/Views/Home/EditBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a02baff6454fdcb17aea482168d005cffcd9aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Web.Models.BookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
  
    ViewData["Title"] = "EditBook";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Update Book Information</h1>\r\n\r\n<hr />\r\n");
#nullable restore
#line 11 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
 using (Html.BeginForm(nameof(HomeController.EditBook), nameof(HomeController).Replace("Controller", string.Empty), FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <hr />\r\n        <input name=\"id\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 372, "\"", 389, 1);
#nullable restore
#line 15 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 380, Model.Id, 380, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 18 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 25 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 28 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.EditorFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 29 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.ValidationMessageFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 32 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 35 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 39 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 42 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.EditorFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 43 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1738, "\"", 1872, 1);
#nullable restore
#line 49 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 1745, Url.Action(action: nameof(HomeController.Index), controller: nameof(HomeController).Replace("Controller", string.Empty), null), 1745, 127, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-undo\"></i></a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\OlehB\source\repos\BookStore\BookStore.Web\Views\Home\EditBook.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        var originalNumber = $.validator.methods.number;
        var wrappedNumber = function (value, element) {
            var fixedValue = parseFloat(value.toString().replace("","", "".""));
            return originalNumber.call($.validator.prototype, fixedValue, element);     // Call function as if ""this"" is the original caller
        };
        $.validator.methods.number = wrappedNumber;
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Web.Models.BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
