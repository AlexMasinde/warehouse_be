using JWarehouseSystem.Common.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace JWarehouseSystem.Common
{
    public static class Common
    {
        private static string _connectionString = "";
        public static SqlConnection SQLConnection
        {
            get
            {
                SqlConnection conn = new SqlConnection(SQLConnectionString);
                return conn;
            }
        }

        public static string SQLConnectionString => _connectionString;
        public static void SetSQLConnectionString(string connectionString) => _connectionString = connectionString;

    }

    public enum EntityType { User = 1, Customer = 2, Supplier = 3, Contact = 4, Driver = 5, Employee = 6 }
    public enum DockingType { InBoundDelivery = 1, OutBoundDelivery = 2 }
    public enum NotificationType { Email = 1, SMS = 2, Internal = 3 }
    public enum AreaStatus { Active = 1, InActive = 2, UnderRepair = 3, Suspended = 4, Decomissioned = 5 }

    public enum PickPackStatus { Initiated = 1, InProgress = 2, Completed = 3, Suspended = 4, UnKnown = 5 }
    public enum StockRequestType { Internal = 1, External = 2 }
    public enum RequestTransferStatus { NewRequest = 1, Picking = 2, InTransit = 3, Complete = 4 }
    public enum MovementType { Sale = 1, Receiving = 2, Shipping = 3, Transfer = 4 }
    public enum MovementStatus { New = 1, Active = 2, InActive = 3, Cancelled = 4, Completed = 5, InTransit = 6, Suspended = 7 }
    public enum DockType { Loading = 1, Receiving = 2 }
    public enum Position { North = 0, East = 90, South = 180, West = 270 }
    public enum UnloadingStatus { ToBeStarted = 1, Ongoing = 2, Completed = 3, Suspended = 4, Cancelled = 5 }
    public enum GoodsStatus { OK = 1, Damaged = 2, Missing = 3, Unknown = 4 }
    public enum ShipmentType { InBound = 1, OutBound = 2 }
    public enum Frequency { Daily = 1, Weekly = 2, BiWeekly = 3, Monthly = 4, Quarterly = 5, SemiAnnually = 6, Annually = 7, Custom = 8 }
    public enum StockCheckStatus { ToBeStarted = 1, Ongoing = 2, Completed = 3, OnHold = 4, Cancelled = 5 }
    public enum EventStatus { Open = 1, InProgress = 2, Resolved = 3, Closed = 4 }
    public enum StoreLayout { I_Shape = 1, E_Shape = 2, L_Shape = 3, U_Shape = 4 }
    public enum SortCriteria { Destination = 1, Size = 2, StockType = 3, Weight = 4, Priority = 5, DeliveryDate = 6, OrderSize = 7 }
    public enum ProductCodeType { RFID, Barcode, QRCode, Other, }
}
