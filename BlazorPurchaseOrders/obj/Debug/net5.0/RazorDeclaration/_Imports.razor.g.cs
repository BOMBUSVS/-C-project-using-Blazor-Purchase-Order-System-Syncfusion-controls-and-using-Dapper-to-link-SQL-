// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPurchaseOrders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Microsoft.JSInterop;

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
#line 18 "C:\Users\1\source\repos\BlazorPurchaseOrders\BlazorPurchaseOrders\_Imports.razor"
using Syncfusion.Blazor.Navigations;

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
    public partial class _Imports : System.Object
    {
        #pragma warning disable 1998
        protected void Execute()
        {
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
