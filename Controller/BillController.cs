using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1.Controller
{
    public class BillController
    {
        private frmTable _fTable;
        private frmBill _fBill;
        private BillRepository _billModel;
        private List<BillDetail> listBill;
        public BillController(Form form)
        {
            if (form is frmTable)
            {
                _fTable = (frmTable)form;
                _fBill = null;
            }
            else if (form is frmBill)
            {
                _fTable = null;
                _fBill = (frmBill)form;
            }
            else
            {
                throw new ArgumentException("Invalid form type. The form must be either fTable or fBill.");
            }
            _billModel = new BillRepository();
        }
        public BillController()
        {
            _billModel = new BillRepository();
        }
        public int GetUnCheckBill(int id)
        {
            return _billModel.GetUnCheckBillIDByTableId(id);
        }

        public int getMaxIdBill()
        {
            return _billModel.GetMaxIDBill();
        }

        public void insertBill(int idTable)
        {
            _billModel.InsertBill(idTable);
        }


        public List<Menu> getListMenuTable(int id)
        {
            return _billModel.GetListMenuTable(id);
        }

        public List<Menu> getListMenuBill(int idBill)
        {
            return _billModel.GetListMenuBill(idBill);
        }

        public void checkOut(int id)
        {
            _billModel.CheckOut(id);
        }

        public List<BillDetail> getListBillOfDate(DateTime selectedDateStart, DateTime selectedDateEnd)
        {
            return _billModel.GetAllBillCheckoutOfDate(selectedDateStart.Date, selectedDateEnd.Date);
        }
        public void DeleteTakeAwayBill(int idB)
        {
            _billModel.DeleteTakeAwayBill(idB);
        }
    }
}
