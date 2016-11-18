using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id,string name,string title)
        {
            ViewBag.ID = id;
            List<Models.Album> list = new List<Models.Album>();


            var item = new Models.Album();

            item.Name = "胡汶宏";
            item.Number = "1103105338";
            item.A = "對於未來，完成大學的學業後，希望繼續升上研究所，在電機的領域深造，得到更多的知識，也提升自身的競爭力。在工作方面，希望能在電機產業的公司上班，發揮自己所長，並不負社會的期許以積極認真的態度，發揮所學，讓公司能夠獲得最大利潤。";
            item.Picture = "/picture/10.jpg";
            list.Add(item);

            var item2 = new Models.Album();

            item2.Name = "張敬華";
            item2.Number = "1103105315";
            item2.A = "在求學中的自主學習、接收新的資訊、並加強自己在專業領域的能力，並藉由團隊的合 作、相互幫忙，來讓能力提升的更為快速，並且勇於迎接每個不同階段的挑戰。  謝謝主管們在百忙之中挪出時間閱讀這篇自傳，希望可以給予我面試的機會，讓我有可以 服務貴公司的機會。";
            item2.Picture = "/picture/11.jpg";
            list.Add(item2);
            ViewBag.ListDatas = list;

            var item3 = new Models.Album();

            item3.Name = "劉宇桐";
            item3.Number = "1103105320";
            item3.A = "我的人生道路走得並不順遂，也因此我體驗到了更多別人學習不到的人生旅程，儘管艱辛但卻踏實，儘管曾經一度跌入失敗的深淵，但我也努力的爬起來繼續面對我的人生旅途，很慶幸藉由這次的推甄資料，讓我重新整理自己人生的記錄，面對以後的未知道路，很多事是我們都沒辦法掌控的，唯一能做的就是把握當下，堅持自己正面的人生態度觀，並且像我家庭給我的觀念一樣:「彩繪自己人生的色彩」。";
            item3.Picture = "/picture/12.jpg";
            list.Add(item3);
            ViewBag.ListDatas = list;

            var item4 = new Models.Album();

            item4.Name = "王嘉志";
            item4.Number = "1103105324";
            item4.A = "我認為與電子相關的工作，需要的就是終身學習，因為人要不斷的學習，科技才會不斷的進步，所以我進入職場後，依然會閱讀相關書籍以及增強英語能力，也會持續增加自己的人脈，提升自己的競爭力。";
            item4.Picture = "/picture/13.jpg";
            list.Add(item4);
            ViewBag.ListDatas = list;

            var item5 = new Models.Album();
            item5.Name = "";
            item5.Number = "";
            item5.Picture = "";
            list.Add(item5);

            var item6 = new Models.Album();
            item6.Name = "";
            item6.Number = "";
            item6.Picture = "";
            list.Add(item6);
            
            return View();
            //return Content("<h1>hello world</h1>" + id);
        }
    }
}