using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class ProdRouteModel : IModel
    {
     
        [CsvColumn(FieldIndex = 1, Name = "TransDate", OutputFormat = "MM/dd/yyyy")]
        public DateTime TransDate { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "ProdId")]
        public string ProdId { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "JournalNameId")]
        public string JournalNameId { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "QtyGood")]
        public decimal QtyGood { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "LineNo")]
        public int LineNo { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "OprNum")]
        public int OprNum { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "WrkCtrId")]
        public string WrkCtrId { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "OprId")]
        public string OprId { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "Hours")]
        public decimal Hours { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "CategoryHoursId")]
        public string CategoryHoursId { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "CategoryQtyId")]
        public string CategoryQtyId { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "OprFinished")]
        public int OprFinished { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "JobType")]
        public int JobType { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "HourlyPrice")]
        public Decimal HourlyPrice { get; set; }
    }
}
