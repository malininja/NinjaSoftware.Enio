using NinjaSoftware.Enio.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using Moq;
using System.Web;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using System.Collections.Generic;
using NinjaSoftware.Enio.Models;
using System.Linq;
using NinjaSoftware.Enio.CoolJ.HelperClasses;

namespace NinjaSoftware.Tests
{
    /// <summary>
    ///This is a test class for HomeControllerTest and is intended
    ///to contain all HomeControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HomeControllerTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private DataAccessAdapterBase _adapter = Helper.GetDataAccessAdapterFactory("ninja");
        private HomeController _homeController = new HomeController();

        private string FetchPage(string action)
        {
            return FetchPage(action, new Dictionary<string, string>());
        }

        private string FetchPage(string action, Dictionary<string, string> routeValues)
        {
            return FetchPage("Home", action, routeValues);
        }

        private string FetchPage(string controller, string action, Dictionary<string, string> routeValues)
        {
            string link = string.Format("http://localhost:64614/Account/Login?ReturnUrl=%2f{0}%2f{1}", controller, action);
            foreach (KeyValuePair<string, string> keyValuePair in routeValues)
            {
                link = string.Format("{0}%3f{1}%3d{2}", link, keyValuePair.Key, keyValuePair.Value);
            }

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(link);

            //this values will change depending on the website
            string values = "UserName=ninja&Password=123456";

            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = values.Length;
            CookieContainer a = new CookieContainer();
            req.CookieContainer = a;
            System.Net.ServicePointManager.Expect100Continue = false; // prevents 417 error
            using (StreamWriter writer = new StreamWriter(req.GetRequestStream(), System.Text.Encoding.ASCII))
            {
                writer.Write(values);
            }
            HttpWebResponse c = (HttpWebResponse)req.GetResponse();
            Stream ResponseStream = c.GetResponseStream();
            StreamReader LeerResult = new StreamReader(ResponseStream);
            string source = LeerResult.ReadToEnd();
            
            return source;
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        public void ArtiklEditTest()
        {
            string page = FetchPage("ArtiklEdit");
        }

        [TestMethod()]
        public void ArtiklEditTest1()
        {
            ArtiklViewModel artiklViewModel = new ArtiklViewModel(_adapter, null);
            artiklViewModel.Artikl.Naziv = "ArtiklEditTest1";
            artiklViewModel.Artikl.Jm = "kom";
            artiklViewModel.Artikl.PdvId = PdvEntity.FetchPdvCollection(_adapter, null, null).First().PdvId;

            artiklViewModel.Save(_adapter);

            Dictionary<string,string> routeValues = new Dictionary<string,string>();
            routeValues.Add("artiklId", artiklViewModel.Artikl.ArtiklId.ToString());

            string page = FetchPage("ArtiklEdit", routeValues);
        }

        [TestMethod()]
        public void ArtiklListTest()
        {
            string page = FetchPage("ArtiklList");
        }

        [TestMethod()]
        public void CjenikEditTest()
        {
            Dictionary<string, string> routeValues = new Dictionary<string, string>();
            long partnerId = PartnerEntity.FetchPartnerCollection(_adapter, null, null).First().PartnerId;
            routeValues.Add("partnerId", partnerId.ToString());

            string page = FetchPage("CjenikEdit", routeValues);
        }

        [TestMethod()]
        public void CjenikEditTest1()
        {
            long partnerId = PartnerEntity.FetchPartnerCollection(_adapter, null, null).First().PartnerId;

            CjenikViewModel cjenikViewModel = new CjenikViewModel(_adapter, null, partnerId);

            RelationPredicateBucket bucket = new RelationPredicateBucket(CjenikFields.PartnerId == partnerId);
            EntityCollection<CjenikEntity> cjenikCollection = CjenikEntity.FetchCjenikCollection(_adapter, bucket, null);

            long[] artiklIdArray = cjenikCollection.Select(c => c.ArtiklId).ToArray();
            bucket = new RelationPredicateBucket(ArtiklFields.ArtiklId != artiklIdArray);
            long artiklId = ArtiklEntity.FetchArtiklCollection(_adapter, bucket, null).First().ArtiklId;

            cjenikViewModel.Cjenik.ArtiklId = artiklId;
            cjenikViewModel.Cjenik.Cijena = 23.45M;

            cjenikViewModel.Save(_adapter);

            Dictionary<string, string> routeValues = new Dictionary<string, string>();
            routeValues.Add("cjenikId", cjenikViewModel.Cjenik.CjenikId.ToString());

            string page = FetchPage("CjenikEdit", routeValues);
        }

        [TestMethod()]
        public void CjenikListTest()
        {
            long partnerId = PartnerEntity.FetchPartnerCollection(_adapter, null, null).First().PartnerId;
            Dictionary<string, string> routeValues = new Dictionary<string, string>();
            routeValues.Add("partnerId", partnerId.ToString());

            string page = FetchPage("CjenikList", routeValues);
        }

        [TestMethod()]
        public void PartnerEditTest()
        {
            string page = FetchPage("PartnerEdit");
        }

        [TestMethod()]
        public void PartnerEditTest1()
        {
            PartnerEntity partner = new PartnerEntity();
            partner.Naziv = "naziv partnera";
            partner.Oib = "12345678901";
            partner.Adresa = "partnerova adresa";
            partner.Posta = "10000";
            partner.Mjesto = "partnerovo mjesto";
            partner.Valuta = 30;
            partner.IsActive = true;

            partner.Save(_adapter, true, false);

            Dictionary<string, string> routeValues = new Dictionary<string, string>();
            routeValues.Add("partnerId", partner.PartnerId.ToString());

            string page = FetchPage("PartnerEdit", routeValues);
        }

        [TestMethod()]
        public void PartnerListTest()
        {
            string page = FetchPage("PartnerList");
        }

        [TestMethod()]
        public void PdvEditTest()
        {
            string page = FetchPage("PdvEdit");
        }

        [TestMethod()]
        public void PdvEditTest1()
        {
            PdvEntity pdv = new PdvEntity();
            pdv.Naziv = "test pdv";
            pdv.Stopa = 22.22M;

            pdv.Save(_adapter, true, false);

            Dictionary<string, string> routeValues = new Dictionary<string, string>();
            routeValues.Add("pdvId", pdv.PdvId.ToString());

            string page = FetchPage("PdvEdit", routeValues);
        }

        [TestMethod()]
        public void PdvListTest()
        {
            string page = FetchPage("PdvList");
        }

        [TestMethod()]
        public void TarifaEditTest()
        {
            string page = FetchPage("TarifaEdit");
        }

        [TestMethod()]
        public void TarifaEditTest1()
        {
            TarifaEntity tarifa = new TarifaEntity();
            tarifa.Naziv = "test tarifa";
            tarifa.Stopa = 55.55M;
            tarifa.IsActive = true;

            tarifa.Save(_adapter, true, false);

            Dictionary<string, string> routeValues = new Dictionary<string, string>();
            routeValues.Add("tarifaId", tarifa.TarifaId.ToString());

            string page = FetchPage("TarifaEdit", routeValues);
        }

        [TestMethod()]
        public void TarifaListTest()
        {
            string page = FetchPage("TarifaList");
        }
    }
}
