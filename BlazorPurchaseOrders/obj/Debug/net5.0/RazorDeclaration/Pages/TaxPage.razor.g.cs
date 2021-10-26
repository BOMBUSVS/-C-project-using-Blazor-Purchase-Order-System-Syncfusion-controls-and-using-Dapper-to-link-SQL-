// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPurchaseOrders.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 7 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using BlazorPurchaseOrders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using BlazorPurchaseOrders.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\Pages\TaxPage.razor"
using BlazorPurchaseOrders.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\Pages\TaxPage.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tax")]
    public partial class TaxPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\Pages\TaxPage.razor"
       

    IEnumerable<Tax> tax;
    private List<ItemModel> Toolbaritems = new List<ItemModel>();

    SfDialog DialogAddEditTax;
    Tax addeditTax = new Tax();
    string HeaderText = "";

    protected override async Task OnInitializedAsync()
    {
        //Populate the list of VAT objects from the VAT table.
        tax = await TaxService.TaxList();

        Toolbaritems.Add(new ItemModel() { Text = "Add", TooltipText = "Add a new Tax Rate", PrefixIcon = "e-add" });
        Toolbaritems.Add(new ItemModel() { Text = "Edit", TooltipText = "Edit selected Tax Rate", PrefixIcon = "e-edit" });
        Toolbaritems.Add(new ItemModel() { Text = "Delete", TooltipText = "Delete selected Tax Rate", PrefixIcon = "e-delete" });
    }

    public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Text == "Add")
        {
            //Code for adding goes here
            addeditTax = new Tax();             // Ensures a blank form when adding
            HeaderText = "Add Tax Rate";
            await this.DialogAddEditTax.Show();
        }
        if (args.Item.Text == "Edit")
        {
            //Code for editing goes here
        }
        if (args.Item.Text == "Delete")
        {
            //code for deleting goes here
        }
    }

    protected async Task TaxSave()
    {
        if (addeditTax.TaxID == 0)
        {
            // Insert if TaxID is zero.

        }
        else
        {
            // Item is being edited
        }

        //Close Dialog
        await CloseDialog();
        //Reset addeditTax
        addeditTax = new Tax();
        //Refresh datagrid
        tax = await TaxService.TaxList();
        StateHasChanged();
    }

    private async Task CloseDialog()
    {
        await this.DialogAddEditTax.Hide();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaxService TaxService { get; set; }
    }
}
#pragma warning restore 1591
