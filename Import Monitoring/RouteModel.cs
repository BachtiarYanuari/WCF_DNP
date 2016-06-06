using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class RouteModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "RouteName")]
        public string RouteName { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "ItemGroupId")]
        public string ItemGroupId { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "Approver")]
        public string Approver { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "ItemId")]
        public string ItemId { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "InventSiteId")]
        public string InventSiteId { get; set; }
        
        [CsvColumn(FieldIndex = 6, Name = "FromDate", OutputFormat = "MM/dd/yyyy")]
        public DateTime FromDate { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "LineNo")]
        public string LineNo { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "OprNum")]
        public int OprNum { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "OprNumNext")]
        public int OprNumNext { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "OprId")]
        public string OprId { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "SetupTime")]
        public decimal SetupTime { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "ProcessPerQty")]
        public decimal ProcessPerQty { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "ToHours_")]
        public decimal ToHours_ { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "SetUpCategoryId")]
        public string SetUpCategoryId { get; set; }

        [CsvColumn(FieldIndex = 15, Name = "ProcessCategoryId")]
        public string ProcessCategoryId { get; set; }

        [CsvColumn(FieldIndex = 16, Name = "QtyCategoryId")]
        public string QtyCategoryId { get; set; }

        [CsvColumn(FieldIndex = 17, Name = "RouteGroupId")]
        public string RouteGroupId { get; set; }

        [CsvColumn(FieldIndex = 18, Name = "WrkCtrIdCost")]
        public string WrkCtrIdCost { get; set; }

        [CsvColumn(FieldIndex = 19, Name = "ProcessTime")]
        public decimal ProcessTime { get; set; }

        [CsvColumn(FieldIndex = 20, Name = "RouteId")]
        public string RouteId { get; set; }

    }
}
