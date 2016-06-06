using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class InventJournalModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "ExtRecId",CanBeNull = true)]
        public long ExtRecId {get;set;}

        [CsvColumn(FieldIndex = 2, Name = "JournalId")]
        public string JournalId{get;set;}

        [CsvColumn(FieldIndex = 3, Name = "JournalNameId")]
        public string JournalNameId{get;set;}

        [CsvColumn(FieldIndex = 4, Name = "Voucher")]
        public string Voucher{get;set;}

        [CsvColumn(FieldIndex = 5, Name = "TransDate")]
        public DateTime TransDate{get;set;}

        [CsvColumn(FieldIndex = 6, Name = "LineNum")]
        public decimal LineNum{get;set;}

        [CsvColumn(FieldIndex = 7, Name = "ItemId")]
        public string ItemId{get;set;}

        [CsvColumn(FieldIndex = 8, Name = "Qty")]
        public decimal Qty{ get; set; }

        [CsvColumn(FieldIndex = 9, Name = "CostPrice")]
        public decimal CostPrice{ get; set; }

        [CsvColumn(FieldIndex = 10, Name = "CostAmount")]
        public decimal CostAmount{ get; set; }

        [CsvColumn(FieldIndex = 11, Name = "LedgerDimension")]
        public string LedgerDimension { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "InventSiteId")]
        public string InventSiteId{ get; set; }

        [CsvColumn(FieldIndex = 13, Name = "InventLocationId")]
        public string InventLocationId{ get; set; }

        [CsvColumn(FieldIndex = 14, Name = "WMSLocationId")]
        public string WMSLocationId{get;set;}

        [CsvColumn(FieldIndex = 15, Name = "InventBatchId")]
        public string InventBatchId{get;set;}

        [CsvColumn(FieldIndex = 16, Name = "InventSizeId")]
        public string InventSizeId { get; set; }

        [CsvColumn(FieldIndex = 17, Name = "InventStyleId")]
        public string InventStyleId { get; set; }

        [CsvColumn(FieldIndex = 18, Name = "ToInventSiteId")]
        public string ToInventSiteId{get;set;}

        [CsvColumn(FieldIndex = 19, Name = "ToInventLocationId")]
        public string ToInventLocationId{get;set;}

        [CsvColumn(FieldIndex = 20, Name = "ToWMSLocationId")]
        public string ToWMSLocationId{get;set;}

        [CsvColumn(FieldIndex = 21, Name = "ToInventBatchId")]
        public string ToInventBatchId { get; set; }

        [CsvColumn(FieldIndex = 22, Name = "ToInventSizeId")]
        public string ToInventSizeId { get; set; }

        [CsvColumn(FieldIndex = 23, Name = "ToInventStyleId")]
        public string ToInventStyleId { get; set; }

        [CsvColumn(FieldIndex = 24, Name = "BomLine")]
        public int BomLine { get; set; }

        [CsvColumn(FieldIndex = 25, Name = "InventTransIdFather")]
        public long InventTransIdFather { get; set; }
    }
}
