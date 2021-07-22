// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RVLiving.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using RVLiving;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using RVLiving.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Inventory.razor"
using RVLiving.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Inventory.razor"
using RVLiving.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Inventory.razor"
using RVLiving.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory")]
    public partial class Inventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Inventory.razor"
       
    private bool dialogIsOpen = false;
    private List<ItemModel> items;
    private DisplayItemModel newItem = new DisplayItemModel();

    private void OpenAddItemDialog()
    {
        dialogIsOpen = true;
        newItem = new DisplayItemModel();
    }

    private void NavigateToEditPage()
    {
        NavigationManager.NavigateTo("admin/editinventory");
    }

    protected override async Task OnInitializedAsync()
    {
        items = await _itemDb.GetItems();
    }

    private async Task InsertItem()
    {
        dialogIsOpen = false;

        // create new Item from the form values
        ItemModel i = new ItemModel
        {
            ItemName = newItem.ItemName,
            PurchasedFrom = newItem.PurchasedFrom,
            Category = newItem.Category,
            Price = newItem.Price,
            Notes = newItem.Notes
        };

        // insert item into the db
        await _itemDb.InsertItem(i);

        // display newly created without doing another call to the db
        items.Add(i);

        // clear the new item so it's ready for use again
        newItem = new DisplayItemModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemData _itemDb { get; set; }
    }
}
#pragma warning restore 1591