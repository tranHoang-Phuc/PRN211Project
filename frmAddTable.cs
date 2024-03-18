using WinFormsApp1.Controller;

namespace WinFormsApp1
{
    public partial class frmAddTable : Form
    {
        private TableController _tableController;
        private frmTable _fTable;
        public frmAddTable(frmTable _fTable)
        {
            InitializeComponent();
            _tableController = new TableController(this);
            this._fTable = _fTable;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                string nameTable = txtAddTableName.Text;
                _tableController.addTable(nameTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
