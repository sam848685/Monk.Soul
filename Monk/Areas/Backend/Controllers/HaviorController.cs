﻿using System;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using SqlSugar;
using AutoMapper;
using AutoMapper.Configuration;
using Monk.Models;
using Monk.Areas.Backend.ViewModels;
using Monk.DbStore;
using Monk.Utils;
using Monk.Areas.Backend.App_Code;

namespace Monk.Areas.Backend.Controllers
{
    public class HaviorController : BaseController
    {
        public HaviorController(DbServices services) : base(services) { }

        [HttpGet]
        public ActionResult Select() { return View(); }

        [HttpGet]
        public JsonResult List(int? pageSize, int pageIndex = 0)
        {
            var clientResult = new JsonData<List<V_HaviorVM>>();
            var setVewModel = RouteData.DataTokens[Keys.SysSetInfoInjectionKey] as SysSetVM;
            pageSize = pageSize == null ? setVewModel.PageSize : pageSize;

            services.Command((db) =>
            {
                var query = db.Queryable<V_Havior>().Where(c => true);
                var total = query.Count();
                var list = query.OrderBy(u => u.SerialNo, OrderByType.desc).ToPageList(Convert.ToInt32(pageIndex + 1), Convert.ToInt32(pageSize));

                Mapper.Initialize(c => c.CreateMap<V_Havior, V_HaviorVM>());
                clientResult.SetClientData("y", "获取成功", Mapper.Map<List<V_HaviorVM>>(list), new { pageSize, pageIndex = Convert.ToInt32(pageIndex + 1), total });
            });
            return Json(clientResult, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            services.Command((db) =>
            {
                Mapper.Initialize(u => u.CreateMap<V_Module, V_ModuleVM>());
                ViewData["ModuleList"] = Common.ModuleDropDownList(Mapper.Map<List<V_ModuleVM>>(db.Queryable<V_Module>().Where(c => true).ToList()));
            });
            return View(new HaviorVM() { Enable = true, Route = true, Index = false, Area = "backend" });
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Insert(HaviorVM viewModel)
        {
            var clientResult = new JsonData<object>();
            var sessionModel = Session[Keys.SessionKey] as MemberSessionVM;
            viewModel.LogMemberID = sessionModel.MemberID;
            if (viewModel.Route == true)
            {
                viewModel.Area = string.IsNullOrEmpty(viewModel.Area) ? "" : viewModel.Area.ToLower();
                viewModel.Controller = string.IsNullOrEmpty(viewModel.Controller) ? "" : viewModel.Controller.ToLower();
                viewModel.Action = string.IsNullOrEmpty(viewModel.Action) ? "" : viewModel.Action.ToLower();
                viewModel.Url = Url.Action(viewModel.Action, viewModel.Controller, new { area = viewModel.Area, id = viewModel.Parameter });
            }

            Mapper.Initialize(u => u.CreateMap<HaviorVM, Havior>());
            var model = Mapper.Map<Havior>(viewModel);
            model.HaviorID = Guid.NewGuid();

            services.Command((db) =>
            {
                if (model.Index == true) db.Update<Havior>(new { Index = false }, u => u.ModuleID == model.ModuleID);
                db.Insert<Havior>(model);
                clientResult.SetClientData("y", "操作成功", new { id = model.HaviorID });
            });
            return Json(clientResult);
        }

        [HttpGet]
        public ActionResult Detail(Guid? id)
        {
            if (id == null) return Content("非法参数");
            var viewModel = new V_HaviorVM();
            services.Command((db) =>
            {
                Mapper.Initialize(c => c.CreateMap<V_Havior, V_HaviorVM>());
                viewModel = Mapper.Map<V_HaviorVM>(db.Queryable<V_Havior>().SingleOrDefault(u => u.HaviorID == id));
            });
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Update(Guid? id)
        {
            if (id == null) return Content("非法参数");
            var viewModel = new HaviorVM();
            services.Command((db) =>
            {
                var cfg = new MapperConfigurationExpression();
                cfg.CreateMap<Havior, HaviorVM>();
                cfg.CreateMap<V_Module, V_ModuleVM>();
                Mapper.Initialize(cfg);

                viewModel = Mapper.Map<HaviorVM>(db.Queryable<Havior>().InSingle(id));
                ViewData["ModuleList"] = Common.ModuleDropDownList(Mapper.Map<List<V_ModuleVM>>(db.Queryable<V_Module>().Where(c => true).ToList()), viewModel.ModuleID);
            });
            return View(viewModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Update(HaviorVM viewModel)
        {
            var clientResult = new JsonData<object>() { };
            if (viewModel.HaviorID == null) clientResult.SetClientData("n", "非法参数");
            if (viewModel.Route == true)
            {
                viewModel.Area = string.IsNullOrEmpty(viewModel.Area) ? "" : viewModel.Area.ToLower();
                viewModel.Controller = string.IsNullOrEmpty(viewModel.Controller) ? "" : viewModel.Controller.ToLower();
                viewModel.Action = string.IsNullOrEmpty(viewModel.Action) ? "" : viewModel.Action.ToLower();
                viewModel.Url = Url.Action(viewModel.Action, viewModel.Controller, new { area = viewModel.Area, id = viewModel.Parameter });
            }

            services.Command((db) =>
            {
                if (viewModel.Index == true) db.Update<Havior>(new { Index = false }, u => u.ModuleID == viewModel.ModuleID);
                db.Update<Havior>(new
                {
                    viewModel.Action,
                    viewModel.Area,
                    viewModel.Controller,
                    viewModel.FootCode,
                    viewModel.HeadCode,
                    viewModel.HttpMethod,
                    viewModel.Index,
                    viewModel.Layout,
                    viewModel.ModuleID,
                    viewModel.Name,
                    viewModel.Parameter,
                    viewModel.Remark,
                    viewModel.Route,
                    viewModel.Url,
                    viewModel.Enable,
                    UpdateTime = DateTime.Now
                }, u => u.HaviorID == viewModel.HaviorID);

                clientResult.SetClientData("y", "操作成功");
            });
            return Json(clientResult);
        }
    }
}