using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class PurchOrderModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "RecId", CanBeNull = true)]
        public long RecId{get;set;}

        [CsvColumn(FieldIndex = 2, Name = "LineNumber", CanBeNull = true)]
        public long LineNumber{get;set;}

        [CsvColumn(FieldIndex = 3, Name = "AccountingDate", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime AccountingDate { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "PurchId", CanBeNull = true)]
        public string PurchId { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "PurchaseType", CanBeNull = true)]
        public string PurchaseType { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "InvoiceAccount", CanBeNull = true)]
        public string InvoiceAccount { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "PurchName", CanBeNull = true)]
        public string PurchName { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "PostingProfile", CanBeNull = true)]
        public string PostingProfile { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "CurrencyCode", CanBeNull = true)]
        public string CurrencyCode{get;set;}

        [CsvColumn(FieldIndex = 10, Name = "CustomerRef", CanBeNull = true)]
        public string CustomerRef{get;set;}

        [CsvColumn(FieldIndex = 11, Name = "ItemId", CanBeNull = true)]
        public string ItemId{get;set;}

        [CsvColumn(FieldIndex = 12, Name = "InventSiteId", CanBeNull = true)]
        public string InventSiteId{get;set;}

        [CsvColumn(FieldIndex = 13, Name = "InventLocationId", CanBeNull = true)]
        public string InventLocationId{get;set;}

        [CsvColumn(FieldIndex = 14, Name = "inventBatchId", CanBeNull = true)]
        public string InventBatchId{get;set;}
        
        [CsvColumn(FieldIndex = 15, Name = "InventSizeId", CanBeNull = true)]
        public string InventSizeId { get; set; }

        [CsvColumn(FieldIndex = 16, Name = "InventStyleId", CanBeNull = true)]
        public string InventStyleId { get; set; }
        
        [CsvColumn(FieldIndex = 17, Name = "PurchQty", CanBeNull = true)]
        public decimal PurchQty{get;set;}

        [CsvColumn(FieldIndex = 18, Name = "PurchUnit", CanBeNull = true)]
        public string PurchUnit{get;set;}

        [CsvColumn(FieldIndex = 19, Name = "PurchPrice", CanBeNull = true)]
        public decimal PurchPrice{get;set;}

        [CsvColumn(FieldIndex = 20, Name = "LineAmount", CanBeNull = true)]
        public decimal LineAmount { get; set; }

        [CsvColumn(FieldIndex = 21, Name = "Requester", CanBeNull = true)]
        public string Requester { get; set; }

        [CsvColumn(FieldIndex = 22, Name = "PurchStatus", CanBeNull = true)]
        public string PurchStatus { get; set; }

        [CsvColumn(FieldIndex = 23, Name = "DeliveryDate", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime DeliveryDate { get; set; }

        [CsvColumn(FieldIndex = 24, Name = "Payment", CanBeNull = true)]
        public string Payment { get; set; }

        [CsvColumn(FieldIndex = 25, Name = "TransactionCode", CanBeNull = true)]
        public string TransactionCode { get; set; }

        [CsvColumn(FieldIndex = 26, Name = "DlvTerm", CanBeNull = true)]
        public string DlvTerm { get; set; }

        [CsvColumn(FieldIndex = 27, Name = "PaymMode", CanBeNull = true)]
        public string PaymMode { get; set; }

        [CsvColumn(FieldIndex = 28, Name = "TaxItemGroup", CanBeNull = true)]
        public string TaxItemGroup { get; set; }

        [CsvColumn(FieldIndex = 29, Name = "ItemBuyerGroupId", CanBeNull = true)]
        public string ItemBuyerGroupId { get; set; }

        [CsvColumn(FieldIndex = 30, Name = "Orderer", CanBeNull = true)]
        public string Orderer { get; set; }

        [CsvColumn(FieldIndex = 31, Name = "PurchReqId", CanBeNull = true)]
        public string PurchReqId { get; set; }

        [CsvColumn(FieldIndex = 32, Name = "DefaultDimension", CanBeNull = true)]
        public string DefaultDimension { get; set; }

        [CsvColumn(FieldIndex = 33, Name = "ExternalItemId", CanBeNull = true)]
        public string ExternalItemId { get; set; }

        [CsvColumn(FieldIndex = 34, Name = "ReqAttention", CanBeNull = true)]
        public string ReqAttention { get; set; }

        [CsvColumn(FieldIndex = 35, Name = "Name", CanBeNull = true)]
        public string Name { get; set; }

        [CsvColumn(FieldIndex = 36, Name = "BankLCNumber", CanBeNull = true)]
        public string BankLCNumber { get; set; }

        [CsvColumn(FieldIndex = 37, Name = "PurchOrderVersion", CanBeNull = true)]
        public string PurchOrderVersion { get; set; }

        [CsvColumn(FieldIndex = 38, Name = "VersionDateTime",OutputFormat = "MM/dd/yyyy HH:mm:ss", CanBeNull = true)]
        public DateTime VersionDateTime { get; set; }

        [CsvColumn(FieldIndex = 39, Name = "OrderAccount", CanBeNull = true)]
        public string OrderAccount { get; set; }

        [CsvColumn(FieldIndex = 40, Name = "VendorReference", CanBeNull = true)]
        public string VendorReference { get; set; }

        public string PurchOrderId { get; set; }

        public int IsArchived { get; set; }

        public int IsDeleted{get;set;}
    }
}
