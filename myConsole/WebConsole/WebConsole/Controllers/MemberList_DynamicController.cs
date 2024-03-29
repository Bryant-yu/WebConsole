﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebConsole.Models;
using WebConsole.Models.Model;
using WebConsole.Models.Model.Conf;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebConsole.Controllers
{
    public class MemberList_DynamicController : Controller
    {
        private readonly CommConf _appConf;
        public MemberList_DynamicController(IOptions<CommConf> options)        {            _appConf = options.Value;        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MemberAdd()
        {
            return View();
        }

        /// <summary>
        /// 新增数据，add
        /// </summary>
        /// <param name="username"></param>
        /// <param name="sex"></param>
        /// <param name="tel"></param>
        /// <param name="addr"></param>
        /// <param name="Static"></param>
        /// <returns></returns>
        public bool Add(string username, string sex, string tel, string addr, string states)
        {
            MemberList_DynamicStru MemberList_DynamicStru = new MemberList_DynamicStru();
            MemberList_DynamicStru.username = username;
            MemberList_DynamicStru.sex = sex;
            MemberList_DynamicStru.tel = tel;
            MemberList_DynamicStru.addr = addr;
            MemberList_DynamicStru.states = states;
            MemberList_DynamicViewModel dataInfo = new MemberList_DynamicViewModel();

            if (dataInfo.AddData(_appConf, MemberList_DynamicStru))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 接收前端传递来的，待修改页面数据,原样返回
        /// </summary>
        /// <param name="username"></param>
        /// <param name="sex"></param>
        /// <param name="tel"></param>
        /// <param name="addr"></param>
        /// <param name="Static"></param>
        /// <returns></returns>
        public IActionResult MemberEdit(string username, string sex, string tel, string addr, string states)
        {
            MemberList_DynamicStru MemberList_Dynamic = new MemberList_DynamicStru();
            MemberList_Dynamic.username = username;
            MemberList_Dynamic.sex = sex;
            MemberList_Dynamic.tel = tel;
            MemberList_Dynamic.addr = addr;
            MemberList_Dynamic.states = states;
            var resultModel = new MemberList_DynamicViewModel
            {
                memberlist_dynamic = MemberList_Dynamic
            };
            return View(resultModel);
        }

        public string GetJsonData(string page, string limit, string username, string sex, string tel, string addr, string states)
        {
            Dictionary<string, string> para = new Dictionary<string, string>();
            para.Add("page", page);
            para.Add("limit", limit);
            para.Add("username", username);
            para.Add("sex", sex);
            para.Add("tel", tel);
            para.Add("addr", addr);
            para.Add("states", states);
            MemberList_DynamicViewModel viewModelData = new MemberList_DynamicViewModel();
            string count = "0";
            var resultModel = new MemberList_DynamicViewModel
            {
                code = "0",
                msg = "",
                data = viewModelData.GetData(_appConf, para, ref count),
                count = count
            };
            string jsonData = JsonConvert.SerializeObject(resultModel);
            return jsonData;
        }



        /// <summary>
        /// 修改数据，Edit/Update
        /// </summary>
        /// <param name="username"></param>
        /// <param name="sex"></param>
        /// <param name="tel"></param>
        /// <param name="addr"></param>
        /// <param name="Static"></param>
        /// <returns></returns>
        public bool Update(string username, string sex, string tel, string addr, string states)
        {
            MemberList_DynamicStru MemberList_Dynamic = new MemberList_DynamicStru();
            MemberList_Dynamic.username = username;
            MemberList_Dynamic.sex = sex;
            MemberList_Dynamic.tel = tel;
            MemberList_Dynamic.addr = addr;
            MemberList_Dynamic.states = states;
            MemberList_DynamicViewModel dataInfo = new MemberList_DynamicViewModel();

            if (dataInfo.UpdateData(_appConf, MemberList_Dynamic))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删除数据，delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool Delete(string id, string username)
        {
            MemberList_DynamicStru MemberList_DynamicStru = new MemberList_DynamicStru();
            MemberList_DynamicStru.id = Convert.ToInt32(id);
            MemberList_DynamicStru.username = username;
            MemberList_DynamicViewModel dataInfo = new MemberList_DynamicViewModel();

            if (dataInfo.DeleteData(_appConf, MemberList_DynamicStru))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 批量删除数据，delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool DeleteAll(string[] ids)
        {
            MemberList_DynamicViewModel dataInfo = new MemberList_DynamicViewModel();

            if (dataInfo.DeleteDataAll(_appConf, ids))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 后台构造json对象，数据传到前台自动显示
        /// </summary>
        /// <returns></returns>
        public string GetData()
        {
            return "{\"code\":0,\"msg\":\"\",\"count\":1000,\"data\":[{\"id\":10000,\"username\":\"user-0\",\"sex\":\"女\",\"city\":\"城市-0\",\"sign\":\"签名-0\",\"experience\":255,\"logins\":24,\"wealth\":82830700,\"classify\":\"作家\",\"score\":57},{\"id\":10001,\"username\":\"user-1\",\"sex\":\"男\",\"city\":\"城市-1\",\"sign\":\"签名-1\",\"experience\":884,\"logins\":58,\"wealth\":64928690,\"classify\":\"词人\",\"score\":27},{\"id\":10002,\"username\":\"user-2\",\"sex\":\"女\",\"city\":\"城市-2\",\"sign\":\"签名-2\",\"experience\":650,\"logins\":77,\"wealth\":6298078,\"classify\":\"酱油\",\"score\":31},{\"id\":10003,\"username\":\"user-3\",\"sex\":\"女\",\"city\":\"城市-3\",\"sign\":\"签名-3\",\"experience\":362,\"logins\":157,\"wealth\":37117017,\"classify\":\"诗人\",\"score\":68},{\"id\":10004,\"username\":\"user-4\",\"sex\":\"男\",\"city\":\"城市-4\",\"sign\":\"签名-4\",\"experience\":807,\"logins\":51,\"wealth\":76263262,\"classify\":\"作家\",\"score\":6},{\"id\":10005,\"username\":\"user-5\",\"sex\":\"女\",\"city\":\"城市-5\",\"sign\":\"签名-5\",\"experience\":173,\"logins\":68,\"wealth\":60344147,\"classify\":\"作家\",\"score\":87},{\"id\":10006,\"username\":\"user-6\",\"sex\":\"女\",\"city\":\"城市-6\",\"sign\":\"签名-6\",\"experience\":982,\"logins\":37,\"wealth\":57768166,\"classify\":\"作家\",\"score\":34},{\"id\":10007,\"username\":\"user-7\",\"sex\":\"男\",\"city\":\"城市-7\",\"sign\":\"签名-7\",\"experience\":727,\"logins\":150,\"wealth\":82030578,\"classify\":\"作家\",\"score\":28},{\"id\":10008,\"username\":\"user-8\",\"sex\":\"男\",\"city\":\"城市-8\",\"sign\":\"签名-8\",\"experience\":951,\"logins\":133,\"wealth\":16503371,\"classify\":\"词人\",\"score\":14},{\"id\":10009,\"username\":\"user-9\",\"sex\":\"女\",\"city\":\"城市-9\",\"sign\":\"签名-9\",\"experience\":484,\"logins\":25,\"wealth\":86801934,\"classify\":\"词人\",\"score\":75},{\"id\":10010,\"username\":\"user-10\",\"sex\":\"女\",\"city\":\"城市-10\",\"sign\":\"签名-10\",\"experience\":1016,\"logins\":182,\"wealth\":71294671,\"classify\":\"诗人\",\"score\":34},{\"id\":10011,\"username\":\"user-11\",\"sex\":\"女\",\"city\":\"城市-11\",\"sign\":\"签名-11\",\"experience\":492,\"logins\":107,\"wealth\":8062783,\"classify\":\"诗人\",\"score\":6},{\"id\":10012,\"username\":\"user-12\",\"sex\":\"女\",\"city\":\"城市-12\",\"sign\":\"签名-12\",\"experience\":106,\"logins\":176,\"wealth\":42622704,\"classify\":\"词人\",\"score\":54},{\"id\":10013,\"username\":\"user-13\",\"sex\":\"男\",\"city\":\"城市-13\",\"sign\":\"签名-13\",\"experience\":1047,\"logins\":94,\"wealth\":59508583,\"classify\":\"诗人\",\"score\":63}]}";
        }
        
    }
}
