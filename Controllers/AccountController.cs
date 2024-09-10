using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AccountDetails.Data;
using AccountDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AccountDetails.Controllers
{
    public class AccountController : Controller
    {
        AccountDbContext context = new AccountDbContext();
        public ActionResult Index(){
            return View();
        }
        public ActionResult AccountView(){
            var res = context.accountData.ToList();
            return View(res);
        }
        public ActionResult Create(){
            return View();
        }
        public ActionResult ValidateCreate(AccountData ad){
            var res = context.accountData.Find(ad.AccountNumber);
            if(res == null){
                context.Add(ad);
                context.SaveChanges();
                return RedirectToAction("AccountView");
            }
            else{
                return RedirectToAction("Create");
            }
        }
        public ActionResult Edit(){
            return View();
        }
        public ActionResult ValidateEdit(AccountData ad){
            var res = context.accountData.Find(ad.AccountNumber);
            if(res == null){
                return RedirectToAction("Edit");
            }
            else{
                res.CurrentBalance = ad.CurrentBalance;
                context.SaveChanges();
                return RedirectToAction("AccountView");
            }
        }
        public ActionResult Delete(){
            return View();
        }
        public ActionResult ValidateDelete(AccountData ad){
            var res = context.accountData.Find(ad.AccountNumber);
            if(res == null){
                return RedirectToAction("Delete");
            }
            else{
                context.Remove(res);
                context.SaveChanges();
                return RedirectToAction("AccountView");
            }
        }

    }
}