#pragma checksum "/Users/jinn/Documents/Projects/TODO/ToDoListServer/Pages/ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bf88d06fb4c9ba6072d8e52f84398636f51707"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
