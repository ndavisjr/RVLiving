// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RVLiving.Pages.Admin
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
#line 3 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditInventory.razor"
using RVLiving.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditInventory.razor"
using RVLiving.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditInventory.razor"
using RVLiving.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/editinventory")]
    public partial class EditInventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "c:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditInventory.razor"
       
    private bool dialogIsOpen, deleteDialogIsOpen = false;
    private ItemModel editItem = new ItemModel();

    private void OpenEditItemDialog(ItemModel item)
    {
        this.editItem = item;
        dialogIsOpen = true;
    }

    private void ConfirmDelete(ItemModel item)
    {
        this.editItem = item;
        deleteDialogIsOpen = true;
    }

    private List<ItemModel> items;

    protected override async Task OnInitializedAsync()
    {
        items = await _itemDb.GetItems();
    }

    private async Task DeleteItem(ItemModel item)
    {
        deleteDialogIsOpen = false;

        // delete item from db
        await _itemDb.DeleteItem(item);

        // display new list minus deleted item without doing another call to the db
        items.Remove(item);
    }

    private async Task UpdateItem(ItemModel item)
    {
        dialogIsOpen = false;

        // update item in db
        await _itemDb.UpdateItem(item);

        //update the view
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemData _itemDb { get; set; }
    }
}
#pragma warning restore 1591
