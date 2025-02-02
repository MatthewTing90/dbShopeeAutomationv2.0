﻿using dbShopeeAutomationV2.Models;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbShopeeAutomationV2.Controllers
{
    public class SupplierController : AdminController
    {
        // GET: Supplier
        public ActionResult Index()
        {
            return View();
        }

        dbShopeeAutomationV2Entities db = new dbShopeeAutomationV2Entities();

        [ValidateInput(false)]
        public ActionResult SupplierGridViewPartial()
        {
            var model = db.TShopeeSuppliers;
            return PartialView("_SupplierGridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult SupplierGridViewPartialAddNew(TShopeeSupplier item)
        {
            string username = User.Identity.Name;
            int supplier_num = db.TShopeeSuppliers.ToList().Count;

            item.name = (item.name == null) ? "supplier_name" : item.name;
            item.code = (item.code == null) ?  generalFunc.GenSupplierCode(supplier_num) : item.code;
            item.nation = (item.nation == null) ? "International" : item.nation;
            item.poc_name = (item.poc_name == null) ? "" : item.poc_name;
            item.poc_email = (item.poc_email == null) ? "" : item.poc_email;
            item.poc_phone_number = (item.poc_phone_number == null) ? "" : item.poc_phone_number;

            dbStoredProcedure.supplierInsert(
                item.name, item.code, item.nation, 
                item.poc_name, item.poc_email, item.poc_phone_number, 
                username);
            db.SaveChanges();

            var model = db.TShopeeSuppliers;
            return PartialView("_SupplierGridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult SupplierGridViewPartialUpdate(TShopeeSupplier item)
        {
            string username = User.Identity.Name;
            int supplier_num = db.TShopeeSuppliers.ToList().Count;

            item.name = (item.name == null) ? "supplier_name" : item.name;
            item.code = (item.code == null) ? generalFunc.GenSupplierCode(supplier_num) : item.code;
            item.nation = (item.nation == null) ? "International" : item.nation;
            item.poc_name = (item.poc_name == null) ? "" : item.poc_name;
            item.poc_email = (item.poc_email == null) ? "" : item.poc_email;
            item.poc_phone_number = (item.poc_phone_number == null) ? "" : item.poc_phone_number;

            dbStoredProcedure.supplierUpdate(
                item.supplier_id,
                item.name, item.code, item.nation,
                item.poc_name, item.poc_email, item.poc_phone_number,
                username);
            db.SaveChanges();

            var model = db.TShopeeSuppliers;
            return PartialView("_SupplierGridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult SupplierGridViewPartialDelete(int supplier_id)
        {
            dbStoredProcedure.supplierDelete(supplier_id);
            db.SaveChanges();

            var model = db.TShopeeSuppliers;
            return PartialView("_SupplierGridViewPartial", model.ToList());
        }
    }
}