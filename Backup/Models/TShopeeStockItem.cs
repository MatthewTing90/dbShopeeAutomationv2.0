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
    
    public partial class TShopeeStockItem
    {
        public int stock_item_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<int> stock_quantity { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> stock_warehouse_id { get; set; }
        public Nullable<int> detail_id { get; set; }
    }
}