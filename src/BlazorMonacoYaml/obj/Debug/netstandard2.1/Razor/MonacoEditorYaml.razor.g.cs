#pragma checksum "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b255ece9d186be44e5394119adfe4c0c8b4ab73"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMonacoYaml
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\_Imports.razor"
using BlazorMonaco;

#line default
#line hidden
#nullable disable
    public partial class MonacoEditorYaml : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorMonaco.MonacoEditor>(0);
            __builder.AddAttribute(1, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor"
                   Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ConstructionOptions", new System.Func<BlazorMonaco.MonacoEditor, BlazorMonaco.Bridge.StandaloneEditorConstructionOptions>(
#nullable restore
#line 3 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor"
                                    EditorConstructionOptions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnKeyUp", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMonaco.Bridge.KeyboardEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMonaco.Bridge.KeyboardEvent>(this, 
#nullable restore
#line 4 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor"
                        OnKeyUp

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnDidPaste", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMonaco.Bridge.PasteEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMonaco.Bridge.PasteEvent>(this, 
#nullable restore
#line 5 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor"
                          ((e) => DoOnDidPaste(e))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnDidInit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMonaco.MonacoEditorBase>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMonaco.MonacoEditorBase>(this, 
#nullable restore
#line 6 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor"
                         DoOnDidInit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "CssClass", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor"
                         CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 1 "C:\Users\Grizzzzly\source\repos\BlazorMonacoYaml\src\BlazorMonacoYaml\MonacoEditorYaml.razor"
                    MonacoEditor = (BlazorMonaco.MonacoEditor)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
