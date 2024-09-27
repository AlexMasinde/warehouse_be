using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.Common.Dal
{
    public class BaseDAL 
    {
        public void SetEntityValues(ref SqlCommand command, IEntity entity)
        {
            if (command == null)
            {
                throw new System.ArgumentNullException(nameof(command));
            }

            command.Parameters.Add("@ID", SqlDbType.Int).Value = entity.ID;
           // command.Parameters.Add("@EntityType", SqlDbType.Int).Value = (int)entity.EntityType;
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = entity.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = entity.LastName;
            command.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = entity.MiddleName;
            command.Parameters.Add("@Title", SqlDbType.VarChar).Value = entity.Title;
            command.Parameters.Add("@Enabled", SqlDbType.Bit).Value = entity.Enabled;
            command.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = entity.Telephone;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = entity.Email;
            command.Parameters.Add("@WebSite", SqlDbType.VarChar).Value = entity.Website;
            command.Parameters.Add("@Other", SqlDbType.VarChar).Value = entity.Other;
        }

        public void SetAuditValues(ref SqlCommand cmd, IUser audit)
        {
            cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = audit.CreatedBy;
            cmd.Parameters.Add("@CreateOn", SqlDbType.DateTime).Value = audit.CreateOn;
            cmd.Parameters.Add("@ModifiedBy", SqlDbType.Int).Value = audit.ModifiedBy;
            cmd.Parameters.Add("@ModifiedOn", SqlDbType.DateTime).Value = audit.ModifiedOn;
        }
        public void GetEntityValues(DataRow row, IEntity entity)
        {
            if (row == null)
            {
                throw new System.ArgumentNullException(nameof(row));
            }

            entity.ID = (int)IfDBNull(row, "ID", 0);
           // entity.EntityType = (EntityType)IfDBNull(row, "EntityType",EntityType.User);
            entity.FirstName = (string)IfDBNull(row, "FirstName", "");
            entity.LastName = (string)IfDBNull(row, "LastName", "");
            entity.MiddleName = (string)IfDBNull(row, "MiddleName", "");
            entity.Title = (string)IfDBNull(row, "Title", "");
            entity.Enabled = (bool)IfDBNull(row, "Enabled", false);
            entity.Telephone = (string)IfDBNull(row, "Telephone", "");
            entity.Email = (string)IfDBNull(row, "Email", "");
            entity.Website = (string)IfDBNull(row, "WebSite", "");
            entity.Other = (string)IfDBNull(row, "Other", "");
            
        }
        public void GetAuditValues(DataRow row, IUser audit)
        {
            if (row == null)
            {
                throw new System.ArgumentNullException(nameof(row));
            }
            audit.CreatedBy = (int)IfDBNull(row, "CreatedBy", 0);
            audit.CreateOn = (DateTime)IfDBNull(row, "CreateOn", DateTime.MinValue);
            audit.ModifiedBy = (int)IfDBNull(row, "ModifiedBy", 0);
            audit.ModifiedOn = (DateTime)IfDBNull(row, "ModifiedOn", DateTime.MinValue);
        }
        public object IfDBNull(DataRow row, string column, object defaultValue)
        {
            if (row.IsNull(column))
            {
                return defaultValue;
            }
            else {

                return row[column];
            }
        }
    }

}
