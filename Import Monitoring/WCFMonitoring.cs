using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Import_Monitoring.ServiceReference;
using LINQtoCSV;

namespace Import_Monitoring
{
    public enum Module
    {
        All = ~0,
        PurchOrder = 10,
        PurchReceipt = 11,
        PurchInvoice = 12,
        SalesOrder = 20,
        SalesDelivery = 21,
        SalesInvoice = 22,

        Bom = 30,
        Route = 31,
        ProdOrder = 32,
        ProdRouteCard = 33,
        ProdPickList = 34,
        ProdRaf = 35,
        ProdEnd = 36,

        InventBatch = 40,
        InventMovement = 41,
        InventTransfer = 42,
        InventAdjust = 43,
        InventBomJour = 44,
        InventCounting = 45
    };

    public enum Status
    {
        All = ~0,
        NotTransfer = 0,
        SuccesTransfer = 1,
        ErrorTransfer = 2,
        ErrorPosting = 3
    };

    public enum Action
    {
        All = ~0,
        None = 0,
        New = 1,
        Update = 2,
        Delete = 3,
        Cancel = 4
    };

    public partial class WCFMonitoring : Form
    {
        BindingList<ImportStaging> srcLst;
        public WCFMonitoring()
        {
            InitializeComponent();
            cmbAction.DataSource = Enum.GetValues(typeof(Action));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
            cmbModule.DataSource = Enum.GetValues(typeof(Module));

            LoadData();
        }

        void LoadDetail(ImportStaging current)
        {
            if (current == null)
                return;
            IEnumerable<IModel> result = null;

            switch ((Module)current.Module)
            {
                case Module.InventBatch:
                    result = Parsing<BatchModel>(current.Data);
                    break;

                case Module.InventMovement:
                    result = Parsing<InventJournalModel>(current.Data);
                    break;

                case Module.InventTransfer:
                    result = Parsing<InventJournalModel>(current.Data);
                    break;

                case Module.InventAdjust:
                    result = Parsing<InventJournalModel>(current.Data);
                    break;

                case Module.InventCounting:
                    result = Parsing<InventJournalModel>(current.Data);
                    break;

                case Module.SalesOrder:
                    result = Parsing<SalesOrderModel>(current.Data);
                    break;

                case Module.SalesDelivery:
                    result = Parsing<PickAndPackModel>(current.Data);
                    break;

                case Module.PurchReceipt:
                    result = Parsing<ProductReceiptModel>(current.Data);
                    break;

                case Module.ProdOrder:
                    result = Parsing<ProdModel>(current.Data);
                    break;

                case Module.ProdPickList:
                    result = Parsing<ProdPickListModel>(current.Data);
                    break;

                case Module.ProdRouteCard:
                    result = Parsing<ProdRouteModel>(current.Data);
                    break;

                case Module.ProdRaf:
                    result = Parsing<ProdRAFModel>(current.Data);
                    break;

                case Module.ProdEnd:
                    result = Parsing<ProdEndModel>(current.Data);
                    break;

                case Module.Bom:
                    result = Parsing<BOMModel>(current.Data);
                    break;

                case Module.Route:
                    result = Parsing<RouteModel>(current.Data);
                    break;
            }
            dataGridView2.DataSource = result;
        }

        IEnumerable<T> Parsing<T>(byte[] source)
            where T : class, IModel, new()
        {
            IEnumerable<T> temp = null; ;
            try
            {
                using (var ms = new MemoryStream(source))
                using (var st = new StreamReader(ms, Encoding.Unicode))
                {
                    temp = new CsvContext().Read<T>(
                        st,
                        new CsvFileDescription()
                        {
                            //EnforceCsvColumnAttribute = true, 
                            SeparatorChar = '|',
                            FirstLineHasColumnNames = true,
                            FileCultureInfo = System.Globalization.CultureInfo.InvariantCulture,
                            IgnoreUnknownColumns = true
                        }).ToList();
                    st.Close();
                    st.Dispose();
                    ms.Close();
                    ms.Dispose();
                }
            }
            catch
            {
                throw;
            }
            return temp;
        }

        void LoadData()
        {
            ImportClient client = new ImportClient("NetHttpBinding_IImport");
            client.Open();
            srcLst = new BindingList<ImportStaging>(client.getAllData());
            client.Close();
            var filter = srcLst?
                .Where(_ => (int)cmbAction.SelectedValue == ~0 ? true : _.Action == (int)cmbAction.SelectedValue)
                .Where(_ => (int)cmbModule.SelectedValue == ~0 ? true : _.Module == (int)cmbModule.SelectedValue)
                .Where(_ => (int)cmbStatus.SelectedValue == ~0 ? true : _.Status == (int)cmbStatus.SelectedValue)
                .ToList();
            dataGridView1.DataSource = filter;
            dataGridView1.Columns["Data"].Visible = false;
        }

        long id;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = (long)((DataGridView)sender).CurrentRow.Cells["CommonKey"].Value;
            ImportStaging current = srcLst.FirstOrDefault(_ => _.CommonKey == id);
            LoadDetail(current);
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = new List<ImportStaging>();

            filter = srcLst?
                .Where( _ => (int)cmbAction.SelectedValue == ~0 ? true : _.Action == (int)cmbAction.SelectedValue )
                .Where( _ => (int)cmbModule.SelectedValue == ~0 ? true : _.Module == (int)cmbModule.SelectedValue )
                .Where( _ => (int)cmbStatus.SelectedValue == ~0 ? true : _.Status == (int)cmbStatus.SelectedValue )
                .ToList();

            dataGridView1.DataSource = filter;
            
            if (dataGridView1.RowCount == 0)
                dataGridView2.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                button1.Text = "Cancel";
                button2.Enabled = true;
            }
            else
            {
                dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
                button1.Text = "Edit";
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
} 
