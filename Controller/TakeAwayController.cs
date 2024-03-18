using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controller
{
    public class TakeAwayController
    {
        private TakeAwayRepository takeAwayModel = new TakeAwayRepository();

        public List<Bill> GetListTakeAwaysBills_Waitting()
        {
            return takeAwayModel.GetListBillofTakeAway_Waitting();
        }
        //lấy danh sach bill của đơn hàng mang về đang chờ
        public List<Bill> GetListTakeAwaysBills_Finished()
        {
            return takeAwayModel.GetListBillofTakeAway_Finished();
        }
        //lấy danh sach bill của đơn hàng mang về đã hoàn thành
        public List<BillDetailsCTL> GetListBillDetails(int idB)
        {
            return takeAwayModel.GetBillDetail(idB);
        }
        //Lấy thông tin chi tiết của 1 đơn hàng dựa vào mã bill
        public void CheckOutTABill(int id)
        {
            takeAwayModel.CheckOutTABill(id);
        }
    }
}
