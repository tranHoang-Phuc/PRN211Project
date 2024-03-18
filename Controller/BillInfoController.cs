using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;

namespace WinFormsApp1.Controller
{
    public class BillInfoController
    {
        private BillInfoRepository _billInfoModel;

        public BillInfoController()
        {
            _billInfoModel = new BillInfoRepository();
        }

        public void insertBillInfo(int idBill, int idFood, int count)
        {
            _billInfoModel.InseartOrUpdateBillInfo(idBill, idFood, count);
        }
    }
}
