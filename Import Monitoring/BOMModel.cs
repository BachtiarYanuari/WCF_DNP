using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class BOMModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "BomName")]
        public string BomName { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "InventSiteId")]
        public string InventSiteId { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "ItemGroupId")]
        public string ItemGroupId { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "Approver")]
        public string Approver { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "ItemIdVer")]
        public string ItemIdVer { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "FromDate", OutputFormat = "MM/dd/yyyy")]
        public DateTime FromDate { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "FromQty")]
        public decimal FromQty { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "ApproverVer")]
        public string ApproverVer { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "LineNo")]
        public string LineNo { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "ItemIdBOM")]
        public string ItemIdBOM { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "InventLocationId")]
        public string InventLocationId { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "InventStyleId")]
        public string InventStyleId { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "BomQty")]
        public decimal BOMQty_ { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "BomQtySerie")]
        public decimal BOMQtySerie { get; set; }

        [CsvColumn(FieldIndex = 15, Name = "UnitId")]
        public string UnitId { get; set; }
        
        [CsvColumn(FieldIndex = 16, Name = "BomId")]
        public string BomId { get; set; }
        
    }
}
