using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.Common.Domain
{
    public class Entity : IEntity
    {
        public Entity()
        {
           
        }
        public Entity(UserAudit userAudit)
        {
           // UserAudit = userAudit ?? throw new ArgumentNullException(nameof(userAudit));
        }

        public int ID { get; set; }
        public EntityType EntityType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public bool Enabled { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Other { get; set; }
        public int CreatedByID { get; set; }
        public virtual User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public virtual User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
