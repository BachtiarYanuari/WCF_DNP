using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class ProdEndModel : IModel
    {
      
        [CsvColumn(FieldIndex = 1, Name = "TransDate" ,OutputFormat = "MM/dd/yyyy")]
        public DateTime TransDate { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "ProdId")]
        public string ProdId { get; set; }

       
    }
}
