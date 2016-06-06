using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace Import_Monitoring
{
    public class LedgerJournalModel : IModel
    {
        [CsvColumn(FieldIndex = 1, Name = "ExtRecId", CanBeNull = true)]
        public long ExtRecId { get; set; }

        [CsvColumn(FieldIndex = 2, Name = "TransDate", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime TransDate { get; set; }

        [CsvColumn(FieldIndex = 3, Name = "JournalName", CanBeNull = true)]
        public string JournalName { get; set; }

        [CsvColumn(FieldIndex = 4, Name = "JournalNum", CanBeNull = true)]
        public string JournalNum { get; set; }

        [CsvColumn(FieldIndex = 5, Name = "LineNum", CanBeNull = true)]
        public string LineNum { get; set; }

        [CsvColumn(FieldIndex = 6, Name = "CurrencyCode", CanBeNull = true)]
        public string CurrencyCode { get; set; }

        [CsvColumn(FieldIndex = 7, Name = "Voucher", CanBeNull = true)]
        public string Voucher { get; set; }

        [CsvColumn(FieldIndex = 8, Name = "AccountType", CanBeNull = true)]
        public string AccountType { get; set; }

        [CsvColumn(FieldIndex = 9, Name = "LedgerDimension", CanBeNull = true)]
        public string LedgerDimension { get; set; }

        [CsvColumn(FieldIndex = 10, Name = "PostingProfile", CanBeNull = true)]
        public string PostingProfile { get; set; }

        [CsvColumn(FieldIndex = 11, Name = "Invoice", CanBeNull = true)]
        public string Invoice { get; set; }

        [CsvColumn(FieldIndex = 12, Name = "TXT", CanBeNull = true)]
        public string TXT { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "Payment", CanBeNull = true)]
        public string Payment { get; set; }

        [CsvColumn(FieldIndex = 14, Name = "Document", CanBeNull = true)]
        public string Document { get; set; }

        [CsvColumn(FieldIndex = 15, Name = "DocumentDate", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime DocumentDate { get; set; }

        [CsvColumn(FieldIndex = 16, Name = "Due", OutputFormat = "MM/dd/yyyy", CanBeNull = true)]
        public DateTime Due { get; set; }

        [CsvColumn(FieldIndex = 17, Name = "AmountCurDebit", CanBeNull = true)]
        public string AmountCurDebit { get; set; }

        [CsvColumn(FieldIndex = 18, Name = "AmountCurCredit", CanBeNull = true)]
        public string AmountCurCredit { get; set; }

        [CsvColumn(FieldIndex = 19, Name = "OffsetAccountType", CanBeNull = true)]
        public string OffsetAccountType { get; set; }

        [CsvColumn(FieldIndex = 20, Name = "OffsetLedgerDimension", CanBeNull = true)]
        public string OffsetLedgerDimension { get; set; }

        [CsvColumn(FieldIndex = 21, Name = "ExchRate", CanBeNull = true)]
        public string ExchRate { get; set; }

        [CsvColumn(FieldIndex = 22, Name = "TaxCode", CanBeNull = true)]
        public string TaxCode { get; set; }

        [CsvColumn(FieldIndex = 23, Name = "TaxGroup", CanBeNull = true)]
        public string TaxGroup { get; set; }

        [CsvColumn(FieldIndex = 24, Name = "PaymId", CanBeNull = true)]
        public string PaymId { get; set; }

        [CsvColumn(FieldIndex = 25, Name = "PaymReference", CanBeNull = true)]
        public string PaymReference { get; set; }

        [CsvColumn(FieldIndex = 26, Name = "PaymMode", CanBeNull = true)]
        public string PaymMode { get; set; }

        [CsvColumn(FieldIndex = 27, Name = "MarkedInvoice", CanBeNull = true)]
        public string MarkedInvoice { get; set; }

        public string OffsetTXT { get; set; }

        [CsvColumn(FieldIndex = 28, Name = "CreatedBy", CanBeNull = true)]
        public string  CreatedBy { get; set; }

        [CsvColumn(FieldIndex = 29, Name = "ModifiedBy", CanBeNull = true)]
        public string ModifiedBy { get; set; }

        [CsvColumn(FieldIndex = 30, Name = "VatForm", CanBeNull = true)]
        public string VatForm { get; set; }

        //[CsvColumn(FieldIndex = 30, Name = "VendTransId", CanBeNull = true)]
        public long VendTransId { get; set; }


    }
}
