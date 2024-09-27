using JWarehouseSystem.Common.Interfaces;
using JWarehouseSystem.Common;


namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IProductCode : IUserAudit
    {
        int ID { get; set; }
        byte[] Code { get; set; }
        ProductCodeType Type { get; set; }
        string CodeString { get; set; }
        int ProductId { get; set; }
    }
}
