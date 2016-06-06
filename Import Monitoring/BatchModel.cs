using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class BatchModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "ItemId")]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "InventBatchId")]
        public string InventBatchId { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "ProdDate", OutputFormat = "MM/dd/yyyy")]
        public DateTime ProdDate { get; set; }

    }
}
