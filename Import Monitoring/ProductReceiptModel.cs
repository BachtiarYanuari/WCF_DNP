using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class ProductReceiptModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "PurchId", CanBeNull = true)]
        public string PurchId { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "ReceiptDate", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime ReceiptDate { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "PackingSlipId", CanBeNull = true)]
        public string PackingSlipId { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "LineNum", CanBeNull = true)]
        public long LineNum { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "PurhLine_LineNum", CanBeNull = true)]
        public long PurhLine_LineNum { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "ItemId", CanBeNull = true)]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "InventSiteId", CanBeNull = true)]
        public string InventSiteId { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "InventLocationId", CanBeNull = true)]
        public string InventLocationId { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "WMSLocationId", CanBeNull = true)]
        public string WMSLocationId { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "InventBatchId", CanBeNull = true)]
        public string InventBatchId { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "InventSizeId", CanBeNull = true)]
        public string InventSizeId { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "InventStyleId", CanBeNull = true)]
        public string InventStyleId { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "PurchQty", CanBeNull = true)]
        public decimal PurchQty { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "InventQty", CanBeNull = true)]
        public decimal InventQty { get; set; }

        [CsvColumn(FieldIndex = 15, Name = "SpecQty", CanBeNull = true)]
        public string SpecQty { get; set; }

    }
}
