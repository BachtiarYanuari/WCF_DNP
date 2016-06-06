using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class ProdPickListModel : IModel
    {
       

        [CsvColumn(FieldIndex = 1, Name = "TransDate", OutputFormat = "MM/dd/yyyy")]
        public DateTime TransDate { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "ProdId")]
        public string ProdId { get; set; }

        //[CsvColumn(FieldIndex = 3, Name = "JournalNameId")]
        //public string JournalNameId { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "ItemId")]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "BOMUnitId")]
        public string BOMUnitId { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "InventBatchId",CanBeNull = true)]
        public string InventBatchId { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "BOMConsump")]
        public decimal BOMConsump { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "InventConsump")]
        public decimal InventConsump { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "LineNo")]
        public string LineNo { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "InventSiteId")]
        public string InventSiteId { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "InventLocationId")]
        public string InventLocationId { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "WmsLocationId", CanBeNull = true)]
        public string WmsLocationId { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "InventSizeId", CanBeNull = true)]
        public string InventSizeId { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "InventStyleId", CanBeNull = true)]
        public string InventStyleId { get; set; }
    }
}
