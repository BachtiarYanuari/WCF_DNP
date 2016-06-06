using System;
using System.Collections.Generic;
using System.Text;

using LINQtoCSV;

namespace Import_Monitoring
{
    public class ProdModel : IModel
    {
        //[CsvColumn(FieldIndex = 1, Name = "GROF")]
        //public string GROF { get; set; }

        [CsvColumn(FieldIndex = 1, Name = "ProdId")]
        public string PRODID { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "InventSiteId")]
        public string INVENTSITEID { get; set; }
        //use
        [CsvColumn(FieldIndex = 3, Name = "DlvDate", OutputFormat = "MM/dd/yyyy")]
        public DateTime DLVDATE { get; set; }
        //use
        [CsvColumn(FieldIndex = 4, Name = "ItemId")]
        public string ITEMID { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "QtySched")]
        public decimal QTYSCHED { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "BomId")]
        public string BOMID { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "RouteId")]
        public string ROUTEID { get; set; }
    
             
       
    }
}
