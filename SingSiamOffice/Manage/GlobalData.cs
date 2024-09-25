namespace SingSiamOffice.Manage
{
    public class GlobalData
    {
        public int login_id { get;set; }
        public string username { get; set; }
        public string fullname { get; set; }
        public string role { get; set; }    
        public string branch_name { get; set; }
        public int branch_id { get; set; }
        public decimal RemainingPaid { get; set; }  = 0;
        public decimal paymentAmount { get; set; }
    }
    public class Collateral1 
    {
        public string? vehicle_brand { get; set; } = "-";
        public string? vehicle_color { get; set; } = "-";
        public string? chassisNo { get; set; } = "-";
        public string? vehicle_ver { get; set; } = "-";
        public string? plate { get; set; } = "-";
        public string? machineNo { get; set; } = "-";
        public string? vehicle_yr { get; set; } = "-";
        public string? tax_issue { get; set; } = "-";
    }
    public class Collateral2 
    {
        public string? deedType { get; set; }
        public string? deedNo { get; set; }
        public string? landType { get; set; }
        public string? mapsheet { get; set; }
        public string? parcelNo { get; set; }
        public string? volumn { get; set; }
        public string? page { get; set; }
        public string? pageInspect { get; set; }
        public string? landAmount { get; set; }
    }
    public class Collateral3 
    {
        public string? bookNo { get; set; }
        public string? farmerCode { get; set; }
        public string? fregisDate { get; set; }
        public string? docRight { get; set; }
        public string? fHolding { get; set; }
        public string? fActivity { get; set; }
        public string? fArea { get; set; }
        public string? fProduct { get; set; }
        public string? fLocate { get; set; }
    }
    public class CalculatePaymentPeriod
    {
        public string period_qty { get; set; }
        public string? period_price { get;set; }
    }
    public class payment 
    {
        //เลขที่ใบเสร็จ
        public string receipt_no { get; set; }
        //งวดที่ค้างชำระ
        public int overpay_qty { get; set; }
        //ยอดที่ต้องชำระ
        public string total_deptAmount { get; set; }
        //ยอดรับเงินฝาก
        public string total_deposit {  get; set; }
        //ค่าปรับ
        public string? origin_fine { get; set; } = "0";
        //ค่าปรับ กำหนดเอง
        public string? custom_fine { get; set; } = "0";
        //ทวงถาม ติดตาม
        public string total_Charge_follow {  get; set; }
        //ยอดที่ต้องชำระ
        public string customerPayAmount { get; set; } = "0";
        //วิธีการชำระ
        public int payment_Menthod { get; set; }
        //ยอดรับฝากเงิน
        public string depositAmount { get; set; }
        //เหตุผล
        public string otherReason { get; set; }
        //ชำระค่าปรับ
        public string paidfineAmount {  get; set; }
        //ชำระเงินต้น
        public string? paidprincipleAmount { get; set; }
        //ชำระดอกเบี้ย
        public string? paidinterestAmount { get; set; }
        //ค้างยอดชำระยกไป
        public string pending_payAmont {  get; set; }

        public string pending_amount { get; set; }

        public decimal base_temp_total_deptAmount { get; set; }

        public decimal base_temp_deptAmount { get; set; }


        //ปิดศัญญาก่อนกำหนด
        //งวดที่ค้างชำระ
        public int p_overpay_qty { get; set; }
        //ยอดรับเงินฝาก
        public string p_total_deposit { get; set; }

        //ค่าปรับ
        public string p_origin_fine { get; set; } = "0";
        //ค่าปรับ
        public string p_custom_fine { get; set; } = "0";

        //ทวงถาม ติดตาม
        public string p_total_Charge_follow { get; set; }

       public string? p_paidfineAmount { get; set; }

        //ยอดที่ต้องชำระ
        public string p_total_deptAmount { get; set; }
      

        public decimal p_pending_amount { get; set; }

        public decimal? p_paidprincipleAmount { get; set; }
        public decimal? p_paidinterestAmount { get; set; }

        public string p_close_type_status { get; set; }

        public decimal? intplus { get; set; } = 0m;
        public decimal? discount { get; set; } = 0m;
        public string pending_totalpayment { get; set; }    

        public decimal? Arbalance { get; set; } 
    }
}
