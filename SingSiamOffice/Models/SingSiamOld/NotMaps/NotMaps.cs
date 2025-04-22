using System.ComponentModel.DataAnnotations.Schema;

namespace SingSiamOffice.Models.SingSiamOld
{

        public partial class Promise
    {
            [NotMapped]
            public string ProductName { get; set; }

        [NotMapped]
        public string CustomerNmae { get; set; }

    }
    public partial class Periodtran
    {
        //วันที่ล่าช้า
        [NotMapped]
        public int latedate { get; set; }
        [NotMapped]
        public DateTime currentdate { get; set; }

        //วันที่จ่ายแต่ละงวด
        [NotMapped]
        public DateTime tdate_pay { get; set; }
        [NotMapped]
        public string style_color { get; set; }
        [NotMapped]
        public List<Periodtran> listPeriodtran_overpay { get; set; }

        [NotMapped]
        public List<Receiptdesc> Receiptdescs { get; set; }

        //จำนวนคงเหลือ
        [NotMapped]
        public decimal amount_remain { get; set; }

        //จำนวนงวดที่ค้างชำระ
        [NotMapped]
        public int OverPayQty { get; set; }

        //จำนวนยอดรับฝากเงิน
        [NotMapped]
        public decimal total_deposit { get; set; }

        //ค่าปรับ
        [NotMapped]
        public decimal total_fee { get; set; }

        //จำนวนที่ต้องชำระ
        [NotMapped]
        public decimal total_deptAmount { get; set; }

        //ค่าทวงถามค่าติดตาม
        [NotMapped]
        public decimal total_charge_follow { get; set; }

        //เช็คงวดที่เกิดวันกำหนดชำระ
        [NotMapped]
        public bool check_overpay { get; set; }
        //ค้างชำระยกไป
        [NotMapped]
        public decimal pending_amount { get; set; }
        //รวมเงินต้นทั้งหมด
        [NotMapped]
        public decimal total_capital { get; set; }

        //รวมดอกเบี้ยทั้งหมด
        [NotMapped]
        public decimal total_interest { get; set; }

        //รวมงวดที่ต้องชำระที่เหลือทั้งหมด
        [NotMapped]
        public int total_periods_remain { get; set; }
        //รับฝากเงิน
        [NotMapped]
        public bool ck_deposit { get; set; }
        //ตรวจสอบ Slip
        [NotMapped]
        public bool ck_receipt { get; set; }
        //เช็คยอดเงิน
        [NotMapped]
        public bool ck_amount { get; set; }
        //จำนวนคงเหลือต่องวด
        [NotMapped]
        public decimal amount_remain_pay { get; set; }
        //ยอดที่ชำระ
        [NotMapped]
        public decimal amount_paid { get; set; }
        //เช็ค ReceiptNo
        [NotMapped]
        public bool ck_paid { get; set; }

        //ยอดที่ชำระรวมค่าปรับและค่าติดตาม
        [NotMapped]
        public decimal total_amount_per_period { get; set; }

        //ค่าปรับ
        [NotMapped]
        public decimal charage_origin { get; set; }


    }

}
