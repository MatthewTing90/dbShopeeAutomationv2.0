//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbShopeeAutomationV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TShopeeStockWarehouse
    {
        public int stock_warehouse_id { get; set; }
        public string name { get; set; }
        public string email_address { get; set; }
        public string phone_number { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Nullable<int> zip_code { get; set; }
        public string country { get; set; }
        public Nullable<int> detail_id { get; set; }

        public TShopeeStockWarehouse()
        {

        }
    }
}
