using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    
    public class SalesOrderModel : IModel
    {
        [CsvColumn(FieldIndex = 0, Name = "ExtRecId", CanBeNull = true)]
        public string ExtRecId { get; set; }

        [CsvColumn(FieldIndex = 1, Name = "RecordFlag", CanBeNull = true)]
        public RecordFlag RecordFlag { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "CurrencyCode",  CanBeNull = true)]
        public string CurrencyCode { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "CustAccount",  CanBeNull = true)]
        public string CustAccount { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "InvoiceAccount",  CanBeNull = true)]
        public string InvoiceAccount { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "CustomerRef", CanBeNull = true)]
        public string CustomerRef { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "CustGroup", CanBeNull = true)]
        public string CustGroup { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "LineNum",  CanBeNull = true)]
        public decimal LineNum { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "SalesId",  CanBeNull = true)]
        public string SalesId { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "ShippingDateRequested", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime ShippingDateRequested { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "ItemId",  CanBeNull = true)]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "Name", CanBeNull = true)]
        public string Name { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "SalesQty", CanBeNull = true)]
        public decimal SalesQty { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "SalesUnit", CanBeNull = true)]
        public string SalesUnit { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "SalesPrice", CanBeNull = true)]
        public decimal SalesPrice { get; set; }

        [CsvColumn(FieldIndex = 15, Name = "LineAmount", CanBeNull = true)]
        public decimal LineAmount { get; set; }

        [CsvColumn(FieldIndex = 16, Name = "PostingProfile", CanBeNull = true)]
        public string PostingProfile { get; set; }

        [CsvColumn(FieldIndex = 17, Name = "InventSiteId", CanBeNull = true)]
        public string InventSiteId { get; set; }

        [CsvColumn(FieldIndex = 18, Name = "InventLocationId", CanBeNull = true)]
        public string InventLocationId { get; set; }

        [CsvColumn(FieldIndex = 19, Name = "WorkerSalesResponsible", CanBeNull = true)]
        public string WorkerSalesResponsible { get; set; }

        [CsvColumn(FieldIndex = 20, Name = "WorkerSalesTaker", CanBeNull = true)]
        public string WorkerSalesTaker { get; set; }

        [CsvColumn(FieldIndex = 21, Name = "SalesPoolId", CanBeNull = true)]
        public string SalesPoolId { get; set; }
        
    }
}
