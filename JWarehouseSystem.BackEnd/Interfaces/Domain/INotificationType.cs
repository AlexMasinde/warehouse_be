using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface INotificationType:IUserAudit
    {
        int ID { get; set; }
        string Name { get; set; }
       
    }
}