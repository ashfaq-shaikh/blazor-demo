#pragma checksum "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4069d253ae66ebb8692e87dcca4909d0eb9cf550"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.LoadingIndicator
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class DefaultTemplate : LoadingIndicatorTemplateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "blazor-loadingindicator-loader-wrapper");
            __builder.AddMarkupContent(2, "\n    \n    ");
            __builder.AddMarkupContent(3, "<div style=\"width:100%; height:100%;\" class=\"lds-dual-ring blazor-loadingindicator-loader\">\n        <div></div>\n    </div>\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddAttribute(5, "style", "margin: 0;");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "style", "font-size: 1.5em");
            __builder.AddContent(9, 
#line 9 "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor"
                                         CurrentTask?.Maintext ?? "Loading ..."

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        <br>\n");
#line 11 "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor"
         if (CurrentTask?.ProgressMax != null)
        {

#line default
#line hidden
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "progress");
            __builder.AddAttribute(13, "value", 
#line 13 "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor"
                              CurrentTask?.ProgressValue

#line default
#line hidden
            );
            __builder.AddAttribute(14, "max", 
#line 13 "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor"
                                                                CurrentTask?.ProgressMax

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#line 14 "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "style", "font-size: 1.2em");
            __builder.AddContent(19, 
#line 17 "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor"
                                             CurrentTask?.Subtext ?? string.Empty

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#line 18 "E:\Working\Ashley Waterman\PAM Project - Blazor App Demo - Zobi Web Solutions\BlazorApp_Demo_ZobiWebSolutions\Blazor.LoadingIndicator\DefaultTemplate.razor"
        }

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
