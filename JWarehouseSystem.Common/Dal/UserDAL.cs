using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JWarehouseSystem.Common.Dal
{
    public class UserDAL : BaseDAL, IUserDAL
    {
     //   SqlConnection _conn;
        public void Delete(IUser user) => Delete(user, user.ID);

        public void Delete(IUser user,int ID)
        {
            using (SqlConnection connection = Common.SQLConnection)
            {
                connection.Open();

                // Start a local transaction.
                SqlTransaction transaction = connection.BeginTransaction("Begin Deleting a user"); ;
                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "spDeleteUser";
                    //Assign Parameters
                    command.Parameters.Add("@EntityID", SqlDbType.Int).Value = ID;

                    try
                    {

                        command.ExecuteNonQuery();
                        command.CommandText = "spDeleteEntity";
                        command.ExecuteNonQuery();

                        // Attempt to commit the transaction.
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        // Attempt to roll back the transaction.
                        transaction.Rollback();
                        throw ex;
                    }

                }
            }
        }
       
        public DataTable Get(IUser user)
        {
            return GetListData(user,user.ID);

        }

        public IUser Get(ref IUser t)
        {
            DataTable dt = GetListData(t, t.ID);
            using (dt) {
                DataRow row = dt.Rows[0];
                //Get User Specific data
                t.ChangePasswordRequired =(bool)IfDBNull(row, "ChangePasswordRequired",false) ;
                t.LastPasswordChange =(DateTime)IfDBNull(row, "LastPasswordChange", DateTime.MinValue); 
                t.PasswordChangedBy =(int)IfDBNull(row, "PasswordChangedBy", 0); 
                t.PasswordChangeVerificationCode =(string) IfDBNull(row, "PasswordChangeVerificationCode", "");
                t.Username = (string)IfDBNull(row, "Username", "");
              //  t.Password = (string)IfDBNull(row, "Password", "");
                t.VerificationCodeEffectiveDate = (DateTime)IfDBNull(row, "VerificationCodeEffectiveDate", DateTime.MinValue); 
                t.VerificationCodeExpiryDate = (DateTime)IfDBNull(row, "VerificationCodeExpiryDate", DateTime.MinValue); 
                t.VerificationCodeUsageDate = (DateTime)IfDBNull(row, "VerificationCodeUsageDate", DateTime.MinValue);

                //Get Entity data
                GetEntityValues(row, t);
                //Get User Audit data
                GetAuditValues(row,  t);
            }

            return t;

        }

        public IUser GetFromEmail(string email, string password)
        {
            throw new NotImplementedException();
        }

        public IUser GetFromUsername(string email, string password)
        {
            throw new NotImplementedException();
        }

        public DataTable GetListData()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Common.SQLConnection)
            {
                connection.Open();

                // Start a local transaction.
                SqlTransaction transaction = connection.BeginTransaction("Begin getting list of users"); ;
                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "spGetUsers";
                    //Assign Parameters
                  

                    try
                    {
                       SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        adapter.Fill(dataTable);
                      // Attempt to commit the transaction.
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        // Attempt to roll back the transaction.
                        transaction.Rollback();
                        throw ex;
                    }

                }
            }

            return dataTable;
        }
    

        public DataTable GetListData(IUser user, int ID)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Common.SQLConnection)
            {
                connection.Open();

                // Start a local transaction.
                SqlTransaction transaction = connection.BeginTransaction("Begin getting list of users"); ;
                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "spGetUsers";
                    //Assign Parameters
                    command.Parameters.Add("@EntityID", SqlDbType.Int).Value = ID;

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        adapter.Fill(dataTable);
                        // Attempt to commit the transaction.
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        // Attempt to roll back the transaction.
                        transaction.Rollback();
                        throw ex;
                    }

                }
            }

            return dataTable;
        }

        public DataTable GetUIDataPaged(IUser user, object[] args)
        {
            throw new NotImplementedException();
        }

        public int Save(IUser user)
        {
            using (SqlConnection connection = Common.SQLConnection)
            {
                connection.Open();

                // Start a local transaction.
                SqlTransaction transaction = connection.BeginTransaction("Begin saving a user"); ;
                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "spSaveUser";

                //Assign Entity Parameters
                SetEntityValues(ref command, user);
                //Set Audit properties
                SetAuditValues(ref command, user);

                //Assign User Parameters
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
                command.Parameters.Add("@ChangePasswordRequired", SqlDbType.Bit).Value = user.ChangePasswordRequired;
                command.Parameters.Add("@LastPasswordChange", SqlDbType.DateTime).Value = user.LastPasswordChange;
                command.Parameters.Add("@PasswordChangedBy", SqlDbType.Int).Value = user.PasswordChangedBy;
                command.Parameters.Add("@PasswordChangeVerificationCode", SqlDbType.VarChar).Value = user.PasswordChangeVerificationCode;
                command.Parameters.Add("@VerificationCodeEffectiveDate", SqlDbType.DateTime).Value = user.VerificationCodeEffectiveDate;
                command.Parameters.Add("@VerificationCodeExpiryDate", SqlDbType.DateTime).Value = user.VerificationCodeExpiryDate;
                command.Parameters.Add("@VerificationCodeUsageDate", SqlDbType.DateTime).Value = user.VerificationCodeUsageDate;

                try
                {

                    user.ID = (int)command.ExecuteScalar();
                    // Attempt to commit the transaction.
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    // Attempt to roll back the transaction.
                    transaction.Rollback();
                    throw ex;
                }

            }

            return user.ID;
        }

       

    }
}
