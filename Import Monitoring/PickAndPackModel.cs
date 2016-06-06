using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV; 

namespace Import_Monitoring
{
    public class PickAndPackModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "SalesId", CanBeNull = true)]
        public string SalesId { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "DeliveryDate", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime DeliveryDate { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "LineNum",  CanBeNull = true)]
        public string LineNum { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "ItemId", CanBeNull = true)]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "SalesLine_LineNum", CanBeNull = true)]
        public decimal SalesLine_LineNum { get; set; }
        
        [CsvColumn(FieldIndex = 6, Name = "InventSiteId",  CanBeNull = true)]
        public string InventSiteId { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "InventLocationId", CanBeNull = true)]
        public string InventLocationId { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "WMSLocationId",  CanBeNull = true)]
        public string WMSLocationId { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "InventBatchId",  CanBeNull = true)]
        public string InventBatchId {get;set;}

        [CsvColumn(FieldIndex = 10, Name = "Qty", CanBeNull = true)]
        public decimal Qty { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "SpecQty", CanBeNull = true)]
        public string SpecQty { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "PackingSlipId", CanBeNull = true)]
        public string PackingSlipId { get; set; }
    }
}
