using System.ComponentModel.DataAnnotations;

namespace Auto_Mapping
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class MakeInvoiceModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 个人、企业、非企业
        /// </summary>
        public string Invoice { get; set; }
        /// <summary>
        /// 抬头
        /// </summary>
        public string InvoiceHeader { get; set; }
        /// <summary>
        /// 税号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 公司地址
        /// </summary>
        public string CompanyAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 银行
        /// </summary>
        public string Bank { get; set; }
        /// <summary>
        /// 银行卡
        /// </summary>
        public string BankNumber { get; set; }

        public int OrdersId { get; set; }
        public string OrderNo { get; set; }
        public decimal Amount { get; set; }

        public string Consignee { get; set; }
        public string ConsigneePhone { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        /// <summary>
        /// 寄送时间
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 1 微信;2 支付宝;3 对公支付(支付凭证)
        /// </summary>
        public int? OrderType { get; set; }


        public string Applicant { get; set; }
        public string ApplicantNumber { get; set; }
        public OrderProduct[] OrderProducts { get; set; }
        public Logistics Logistics { get; set; }
        public DateTime CreatedAt { get; set; }

    }
    public class MakeInvoice : EntityBase
    {
        /// <summary>
        /// 个人、企业、非企业
        /// </summary>
        public string Invoice { get; set; }
        /// <summary>
        /// 抬头
        /// </summary>
        public string InvoiceHeader { get; set; }
        /// <summary>
        /// 税号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 公司地址
        /// </summary>
        public string CompanyAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 银行
        /// </summary>
        public string Bank { get; set; }
        /// <summary>
        /// 银行卡
        /// </summary>
        public string BankNumber { get; set; }

        public int OrdersId { get; set; }
        public string OrderNo { get; set; }
        public decimal Amount { get; set; }

        public string Consignee { get; set; }
        public string ConsigneePhone { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        /// <summary>
        /// 寄送时间
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 1 微信;2 支付宝;3 对公支付(支付凭证)
        /// </summary>
        public int? OrderType { get; set; }
        public string Applicant { get; set; }
        public string ApplicantNumber { get; set; }
    }

    public class Logistics : EntityBase
    {
        public Logistics() { }
        /// <summary>
        /// 承运方
        /// </summary>
        public string Carrier { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string Orders { get; set; }
        public string Consignee { get; set; }
        public string ConsigneePhone { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// 发件人
        /// </summary>
        public string SenderPhone { get; set; }
        /// <summary>
        /// 发件人
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// 物品Id
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        ///  状态
        /// </summary>
        public bool Status { get; set; }
    }
    public class OrderProduct : EntityBase
    {
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public decimal PayMoney { get; set; }
        public string CategoryName { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? PayTime { get; set; }
        public int Count { get; set; }

    }
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}