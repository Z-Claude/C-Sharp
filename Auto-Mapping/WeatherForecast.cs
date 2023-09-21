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
        /// ���ˡ���ҵ������ҵ
        /// </summary>
        public string Invoice { get; set; }
        /// <summary>
        /// ̧ͷ
        /// </summary>
        public string InvoiceHeader { get; set; }
        /// <summary>
        /// ˰��
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// ��˾��ַ
        /// </summary>
        public string CompanyAddress { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Bank { get; set; }
        /// <summary>
        /// ���п�
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
        /// ����ʱ��
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 1 ΢��;2 ֧����;3 �Թ�֧��(֧��ƾ֤)
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
        /// ���ˡ���ҵ������ҵ
        /// </summary>
        public string Invoice { get; set; }
        /// <summary>
        /// ̧ͷ
        /// </summary>
        public string InvoiceHeader { get; set; }
        /// <summary>
        /// ˰��
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// ��˾��ַ
        /// </summary>
        public string CompanyAddress { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Bank { get; set; }
        /// <summary>
        /// ���п�
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
        /// ����ʱ��
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 1 ΢��;2 ֧����;3 �Թ�֧��(֧��ƾ֤)
        /// </summary>
        public int? OrderType { get; set; }
        public string Applicant { get; set; }
        public string ApplicantNumber { get; set; }
    }

    public class Logistics : EntityBase
    {
        public Logistics() { }
        /// <summary>
        /// ���˷�
        /// </summary>
        public string Carrier { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string Orders { get; set; }
        public string Consignee { get; set; }
        public string ConsigneePhone { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string SenderPhone { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// ��ƷId
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        ///  ״̬
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