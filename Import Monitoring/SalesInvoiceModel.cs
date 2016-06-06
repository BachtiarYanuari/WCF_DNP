using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class SalesInvoiceModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "InvoiceDate", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime InvoiceDate { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "CurrencyCode", CanBeNull = true)]
        public string CurrencyCode { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "TaxGroup", CanBeNull = true)]
        public string TaxGroup { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "TaxItemGroup", CanBeNull = true)]
        public string TaxItemGroup { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "InvoiceId", CanBeNull = true)]
        public string InvoiceId { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "PackingSlipId", CanBeNull = true)]
        public string PackingSlipId { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "InvoiceAcccount", CanBeNull = true)]
        public string InvoiceAcccount { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "SalesId", CanBeNull = true)]
        public string SalesId { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "ItemId", CanBeNull = true)]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "Qty", CanBeNull = true)]
        public decimal Qty { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "SalesUnit", CanBeNull = true)]
        public string SalesUnit { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "InventQty", CanBeNull = true)]
        public decimal InventQty { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "SalesPrice", CanBeNull = true)]
        public decimal SalesPrice { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "LineAmount", CanBeNull = true)]
        public decimal LineAmount { get; set; }

        [CsvColumn(FieldIndex = 15, Name = "LineAmountMST", CanBeNull = true)]
        public decimal LineAmountMST { get; set; }

        [CsvColumn(FieldIndex = 16, Name = "PostingProfile", CanBeNull = true)]
        public string PostingProfile { get; set; }

        [CsvColumn(FieldIndex = 17, Name = "RecId", CanBeNull = true)]
        public long RecId { get; set; }

    }
}
