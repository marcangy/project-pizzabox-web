#pragma checksum "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72e0e6093c3074b07380314fa3aef0ee04afb45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ModifyPizza), @"mvc.1.0.view", @"/Views/Shared/ModifyPizza.cshtml")]
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
#line 1 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72e0e6093c3074b07380314fa3aef0ee04afb45a", @"/Views/Shared/ModifyPizza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ModifyPizza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("order/order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
  
  ViewData["Title"] = "Modify Pizza";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n  <h1 class=\"display-4\">Welcome</h1>\n  <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72e0e6093c3074b07380314fa3aef0ee04afb45a5150", async() => {
                WriteLiteral("\n  <meta charset=\"UTF-8\">\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n  <title>PizzaBox</title>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72e0e6093c3074b07380314fa3aef0ee04afb45a6298", async() => {
                WriteLiteral("\n\n\n  <main></main>\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n\n\n");
#nullable restore
#line 35 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
 foreach (var item in Model.CurrentOrder.Pizzas)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <label");
            BeginWriteAttribute("for", " for=\"", 661, "\"", 672, 1);
#nullable restore
#line 37 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
WriteAttributeValue("", 667, item, 667, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
                Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 698, "\"", 710, 1);
#nullable restore
#line 37 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
WriteAttributeValue("", 705, item, 705, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 711, "\"", 721, 1);
#nullable restore
#line 37 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
WriteAttributeValue("", 716, item, 716, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 722, "\"", 735, 1);
#nullable restore
#line 37 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
WriteAttributeValue("", 730, item, 730, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\n");
#nullable restore
#line 38 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<button> Select</button>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72e0e6093c3074b07380314fa3aef0ee04afb45a9357", async() => {
                WriteLiteral("\n  ");
#nullable restore
#line 43 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n  <div>\n\n\n\n\n\n\n    <div>\n");
#nullable restore
#line 52 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
       foreach (var item in Model.Crusts)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72e0e6093c3074b07380314fa3aef0ee04afb45a10134", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 54 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
                           Write(item);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72e0e6093c3074b07380314fa3aef0ee04afb45a10601", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedCrust);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
                                                                            WriteLiteral(item);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 54 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 55 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("      ");
#nullable restore
#line 56 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedCrust));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <div>\n");
#nullable restore
#line 59 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
       foreach (var item in Model.Sizes)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72e0e6093c3074b07380314fa3aef0ee04afb45a15038", async() => {
#nullable restore
#line 61 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
                          Write(item);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72e0e6093c3074b07380314fa3aef0ee04afb45a15465", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 61 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedSize);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
                                                                          WriteLiteral(item);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 61 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 62 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"

      }

#line default
#line hidden
#nullable disable
                WriteLiteral("      ");
#nullable restore
#line 64 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedSize));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n\n    <div>\n");
#nullable restore
#line 68 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
       foreach (var item in Model.Toppings)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label");
                BeginWriteAttribute("for", " for=\"", 1409, "\"", 1420, 1);
#nullable restore
#line 70 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
WriteAttributeValue("", 1415, item, 1415, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 70 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
                      Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"checkbox\" name=\"SelectedToppings\"");
                BeginWriteAttribute("id", " id=\"", 1473, "\"", 1483, 1);
#nullable restore
#line 70 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
WriteAttributeValue("", 1478, item, 1478, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1484, "\"", 1497, 1);
#nullable restore
#line 70 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
WriteAttributeValue("", 1492, item, 1492, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></label>\n");
#nullable restore
#line 71 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"


      }

#line default
#line hidden
#nullable disable
                WriteLiteral("      ");
#nullable restore
#line 74 "/home/marc/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/ModifyPizza.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedToppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <button type=\"submit\">Add Changes to Order</button>\n  </div>\n\n");
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
