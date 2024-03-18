using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controller
{
    public class TableController
    {
        private frmTable _fTable;
        private frmAddTable _fAddTable;
        private TableRepository _tableModel;

        public TableController(Form form)
        {
            if (form is frmTable)
            {
                _fTable = (frmTable)form;
                _fAddTable = null;
            }
            else if (form is frmAddTable)
            {
                _fTable = null;
                _fAddTable = (frmAddTable)form;
            }
            else
            {
                throw new ArgumentException("Invalid form type. The form must be either fTable or fBill.");
            }
            _tableModel = new TableRepository();
        }
        public void LoadTable()
        {
            List<TableFood> listTable = _tableModel.GetListTable();
            _fTable.LoadTable(listTable);
        }

        public void addTable(string tableName)
        {
            if (_tableModel.AddTable(tableName))
            {
                MessageBox.Show("Thêm bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
