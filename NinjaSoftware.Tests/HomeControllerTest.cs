﻿using NinjaSoftware.Enio.Controllers;
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

namespace NinjaSoftware.Enio.Tests
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

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);

            //this values will change depending on the website
            string values = "UserName=ninja&Password=123456";

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = values.Length;
            request.CookieContainer = new CookieContainer();
            System.Net.ServicePointManager.Expect100Continue = false; // prevents 417 error
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII))
            {
                writer.Write(values);
            }
            HttpWebResponse c = (HttpWebResponse)request.GetResponse();
            Stream responseStream = c.GetResponseStream();
            StreamReader resultStream = new StreamReader(responseStream);
            string source = resultStream.ReadToEnd();
            
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

        [TestMethod()]
        public void RacunGlavaListTest()
        {
            string page = FetchPage("RacunGlavaList");
        }

        [TestMethod()]
        public void RacunEditTest()
        {
            string page = FetchPage("RacunEdit");
        }
    }
}
