#pragma checksum "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bf88d06fb4c9ba6072d8e52f84398636f51707"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoListServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using ToDoListServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/_Imports.razor"
using ToDoListServer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Todo (");
            __builder.AddContent(2, 
#nullable restore
#line 3 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
           todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "placeholder", "Something todo");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
                                           newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n");
            __builder.OpenElement(14, "ul");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 9 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "checkbox");
            __builder.AddAttribute(19, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
                                      todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
                      todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
#nullable restore
#line 13 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor"
       
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;
    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
