using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPurchaseOrders.Data
{
    // Each item below provides an interface to a method in TaxServices.cs
    public interface ITaxService
    {
        Task<bool> TaxInsert(Tax tax);
        Task<IEnumerable<Tax>> TaxList();
        Task<Tax> Tax_GetOne(int TaxID);
        Task<bool> TaxUpdate(Tax tax);

    }
}