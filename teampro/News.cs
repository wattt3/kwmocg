using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace teampro
{
    public partial class News : Form
    {
        public Form1 mainForm;

        const string _apiUrl = "https://openapi.naver.com/v1/search/news.json";
        const string _clientId = "An56e7PSVEZf_WqoRy0Q";
        const string _clientSecret = "b_2M25JUw7";

        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected ChromeDriver _driver = null;

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string results = getResults();
                results = results.Replace("<b>", "");
                results = results.Replace("</b>", "");
                results = results.Replace("&lt;", "<");
                results = results.Replace("&gt;", ">");

                var parseJson = JObject.Parse(results);
                var countsOfDisplay = Convert.ToInt32(parseJson["display"]);
                var countsOfResults = Convert.ToInt32(parseJson["total"]);

                lvw_Result.Items.Clear();
                for (int i = 0; i < countsOfDisplay; i++)
                {
                    ListViewItem item = new ListViewItem((i + 1).ToString());

                    var title = parseJson["items"][i]["title"].ToString();
                    title = title.Replace("&quot;", "\"");

                    var link = parseJson["items"][i]["link"].ToString();

                    item.SubItems.Add(title);
                    item.SubItems.Add(link);

                    lvw_Result.Items.Add(item);
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }
        }

        string _link1, _link2, _link3;

        private string getResults()
        {
            string keyword = txt_Keyword.Text;
            string display = "5";
            string sort = "sim";

            string query = string.Format("?query={0}&display={1}sort={2}", keyword, display, sort);

            WebRequest request = WebRequest.Create(_apiUrl + query);
            request.Headers.Add("X-Naver-Client-Id", _clientId);
            request.Headers.Add("X-Naver-Client-Secret", _clientSecret);

            string requestResult = "";
            using (var response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(dataStream))
                    {
                        requestResult = reader.ReadToEnd();
                    }
                }
            }
            return requestResult;
        } 

        public News()
        {
            InitializeComponent();

            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("headless");
            IWebDriver _driver = new ChromeDriver(_driverService, _options);
            _driver.Url = "https://news.naver.com/main/home.nhn";

            lbl1.Text = _driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[1]/div[1]/a")).Text;
            _link1 = _driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[1]/div[1]/a")).GetAttribute("href");
            lbl2.Text = _driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[2]/div[1]/a")).Text;
            _link2 = _driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[2]/div[1]/a")).GetAttribute("href");
            lbl3.Text = _driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[3]/div[1]/a")).Text;
            _link3 = _driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[3]/div[1]/a")).GetAttribute("href");
        }

        private void News_Load(object sender, EventArgs e)
        {
            if (mainForm.darkMode)
            {
                this.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
            {
                this.BackColor = Color.FromArgb(95, 158, 160);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_link1);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_link2);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_link3);
        }
    }
}
