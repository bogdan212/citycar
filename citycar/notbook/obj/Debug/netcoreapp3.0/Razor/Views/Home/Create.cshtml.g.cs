#pragma checksum "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6ae758d61a1f0c0c5f261ad31acf6c1522b2c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
#line 1 "C:\Users\Боря\source\repos\citycar\notbook\Views\_ViewImports.cshtml"
using notbook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Боря\source\repos\citycar\notbook\Views\_ViewImports.cshtml"
using notbook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6ae758d61a1f0c0c5f261ad31acf6c1522b2c1", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e4e1d9bb1afe1e04425bb0563cd5fd6d2bcc74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<notbook.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n");
#nullable restore
#line 3 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
  
ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Создать заказ</h1>\r\n<style>\r\n    body {\r\n        background: #FFFFE0; /* Цвет фона */\r\n        color: #000000; /* Цвет текста */\r\n    }\r\n</style>\r\n");
#nullable restore
#line 14 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 17 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.LabelFor(model => model.Secondname, "фамилия "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 20 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.EditorFor(model => model.Secondname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 23 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.LabelFor(model => model.Firstname, "имя"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 26 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.EditorFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.LabelFor(model => model.Birthday, "дата выезда"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 32 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.EditorFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n   <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
       Write(Html.LabelFor(model => model.City1, "город выезда"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 38 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.EditorFor(model => model.City1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 41 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.LabelFor(model => model.City2, "город прибытия"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 44 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.EditorFor(model => model.City2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 47 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.LabelFor(model => model.sizecar, "размр автомобиля"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 50 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
   Write(Html.EditorFor(model => model.sizecar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <br />\r\n    <input  class=\"form-control form-control-lg\"  placeholder=\".form-control-lg\"type=\"submit\" value=\"Добавить\" />\r\n");
#nullable restore
#line 54 "C:\Users\Боря\source\repos\citycar\notbook\Views\Home\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<notbook.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
