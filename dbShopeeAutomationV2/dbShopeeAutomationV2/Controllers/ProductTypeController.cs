﻿using DevExpress.Web.Mvc;
using dbShopeeAutomationV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbShopeeAutomationV2.Controllers
{
    public class ProductTypeController : AdminController
    {
        dbShopeeAutomationV2Entities db = new dbShopeeAutomationV2Entities();

        // GET: ProductType
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult ProductTypeGridViewPartial()
        {
            var model = db.TShopeeProductTypes;
            return PartialView("_ProductTypeGridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ProductTypeGridViewPartialAddNew(TShopeeProductType item)
        {
            string username = User.Identity.Name;

            item.name = (item.name == null) ? "product_type" : item.name;
            item.code = (item.code == null) ? "type_code" : item.code;

            dbStoredProcedure.productTypeInsert(item.name, item.code, username);
            db.SaveChanges();

            var model = db.TShopeeProductTypes;
            return PartialView("_ProductTypeGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult ProductTypeGridViewPartialUpdate(TShopeeProductType item)
        {
            string username = User.Identity.Name;

            item.name = (item.name == null) ? "product_type" : item.name;
            item.code = (item.code == null) ? "type_code" : item.code;

            dbStoredProcedure.productTypeUpdate(item.product_type_id, item.name, item.code, username);
            db.SaveChanges();

            var model = db.TShopeeProductTypes;
            return PartialView("_ProductTypeGridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ProductTypeGridViewPartialDelete(int product_type_id)
        {
            dbStoredProcedure.productTypeDelete(product_type_id);
            db.SaveChanges();

            var model = db.TShopeeProductTypes;
            return PartialView("_ProductTypeGridViewPartial", model.ToList());
        }
    }
}