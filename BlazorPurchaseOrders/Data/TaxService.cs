using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorPurchaseOrders.Data
{
    public class TaxService : ITaxService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public TaxService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        // Add (create) a Tax table row (SQL Insert)
        // This only works if you're already created the stored procedure.
        public async Task<bool> TaxInsert(Tax tax)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("TaxDescription", tax.TaxDescription, DbType.String);
                parameters.Add("TaxRate", tax.TaxRate, DbType.Decimal);
                parameters.Add("TaxIsArchived", tax.TaxIsArchived, DbType.Boolean);

                // Stored procedure method
                await conn.ExecuteAsync("spTax_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
        // Get a list of tax rows (SQL Select)
        // This only works if you're already created the stored procedure.
        public async Task<IEnumerable<Tax>> TaxList()
        {
            IEnumerable<Tax> taxes;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                taxes = await conn.QueryAsync<Tax>("spTax_List", commandType: CommandType.StoredProcedure);
            }
            return taxes;
        }
      
        
        // Get one tax based on its TaxID (SQL Select)
        // This only works if you're already created the stored procedure.
        public async Task<Tax> Tax_GetOne(int @TaxID)
        {
            Tax tax = new Tax();
            var parameters = new DynamicParameters();
            parameters.Add("@TaxID", TaxID, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                tax = await conn.QueryFirstOrDefaultAsync<Tax>("spTax_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return tax;
        }
        // Update one Tax row based on its TaxID (SQL Update)
        // This only works if you're already created the stored procedure.
        public async Task<bool> TaxUpdate(Tax tax)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("TaxID", tax.TaxID, DbType.Int32);

                parameters.Add("TaxDescription", tax.TaxDescription, DbType.String);
                parameters.Add("TaxRate", tax.TaxRate, DbType.Decimal);
                parameters.Add("TaxIsArchived", tax.TaxIsArchived, DbType.Boolean);

                await conn.ExecuteAsync("spTax_Update", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }

    }
}