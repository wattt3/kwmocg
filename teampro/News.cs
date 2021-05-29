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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace teampro
{
    public partial class News : Form
    {
        public Form1 mainForm;

        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected ChromeDriver _driver = null;

        public News()
        {
            InitializeComponent();

            try
            {
                _driverService = ChromeDriverService.CreateDefaultService();
                _driverService.HideCommandPromptWindow = true;

                _options = new ChromeOptions();
                _options.AddArgument("disable-gpu");
            }
            catch (Exception exc)
            {
                Trace.WriteLine(exc.Message);
            }
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
    }
}
