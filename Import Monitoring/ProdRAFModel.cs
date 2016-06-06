using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class ProdRAFModel : IModel
    {
       
        [CsvColumn(FieldIndex = 1, Name = "TransDate", OutputFormat = "MM/dd/yyyy")]
        public DateTime TransDate { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "ProdId")]
        public string ProdId { get; set; }

        //[CsvColumn(FieldIndex = 3, Name = "JournalNameId")]
        //public string JournalNameId { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "ItemId")]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "InventBatchId", CanBeNull = true)]
        public string InventBatchId { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "QtyGood")]
        public decimal QtyGood { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "LineNo")]
        public string LineNo { get; set; }


        [CsvColumn(FieldIndex = 7, Name = "InventSiteId")]
        public string InventSiteId { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "InventLocationId", CanBeNull = true)]
        public string InventLocationId { get; set; }


        [CsvColumn(FieldIndex = 9, Name = "WmsLocationId", CanBeNull = true)]
        public string WmsLocationId { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "ProdFinished",CanBeNull=true)]
        public int ProdFinished { get; set; }
    }
}
