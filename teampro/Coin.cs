using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

// JSON
using Newtonsoft.Json.Linq;

// Reg & Admin
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;


// 코인폼 로드시 반복되는 레지스트리 저장 및 코인 정보 등록 때문에 처리가 늦어짐.
// 부모 폼에서 처리하는 방법 제안 (투명도, 창 순서 등 세팅 내용도 저장 가능)
// 또는 레지스트리 저장 제거

namespace teampro
{
    public partial class Coin : Form
    {
        //  **  --  --


        // 코인 정보 클래스
        public class coinInfo
        {

            // 현재가 정보 : https://docs.upbit.com/reference#ticker%ED%98%84%EC%9E%AC%EA%B0%80-%EB%82%B4%EC%97%AD
            // 마켓 코드 정보 : https://docs.upbit.com/reference#%EB%A7%88%EC%BC%93-%EC%BD%94%EB%93%9C-%EC%A1%B0%ED%9A%8C

            public string market_code;
            public string korean_name;

            public string change; // EVEN : 보합 RISE : 상승 FALL : 하락

            public double trade_price;
            public double change_price;

            // 초기화
            public coinInfo(string market_code, string korean_name)
            {
                this.market_code = market_code;
                this.korean_name = korean_name;
            }

            // 업데이트
            public void update()
            {
                try
                {
                    JArray coinJArray = JArray.Parse(coinUtil.CoinData(market_code));
                    this.change = coinJArray[0]["change"].ToString();
                    this.trade_price = Convert.ToDouble(coinJArray[0]["trade_price"]);
                    this.change_price = Convert.ToDouble(coinJArray[0]["change_price"]);
                }
                catch {
                    this.change = "ERROR";
                    this.trade_price = 0;
                    this.change_price = 0;
                }
            }
        }


        // 코인 유틸리티
        public class coinUtil
        {
            // 업비트 API URL
            static string marketDataURL = "https://api.upbit.com/v1/ticker";
            static string marketSearchURL = "https://api.upbit.com/v1/market/all";

            // 코인 정보 JSON 출력
            public static string CoinData(string coinName)
            {
                return requestUrlGet(marketDataURL + "?markets=" + coinName); ;
            }

            // 코인 리스트 JSON 출력
            public static string CoinSearch()
            {
                return requestUrlGet(marketSearchURL);
            }

            private static string requestUrlGet(string url)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string strResult = reader.ReadToEnd();

                // 정리
                reader.Close();
                dataStream.Close();
                response.Close();

                return strResult;
            }
        }


        //  **  --  --


        // 마켓 코인 리스트
        static private JArray randomMarketList = JArray.Parse(coinUtil.CoinSearch());
        static private JArray marketList = new JArray(randomMarketList.OrderBy(obj => (string)obj["korean_name"]));
        static private List<coinInfo> coinList = new List<coinInfo>();

        // 갱신 타이머
        private Timer ticker = null;
        private static int tickInterval = 1000; // 1000 : 1초


        //  **  --  --

        public Form1 mainForm;

        public Coin()
        {
            InitializeComponent();

            // 콤보 박스에 추가
            foreach (JToken coinToken in marketList)
            {
                cmbBoxCoinSearch.Items.Add(coinToken["korean_name"] + " [" + coinToken["market"] + "]");
            }
            cmbBoxCoinSearch.SelectedIndex = 0;

            // 타이머 작동
            ticker = new Timer();
            ticker.Tick += refreshTickerEvent;
            ticker.Interval = tickInterval;
            ticker.Start();

            CoinSearchForm_Load();
        }

        private void Coin_Load(object sender, EventArgs e)
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

        // 
        private void refreshTickerEvent(object sender, EventArgs e)
        {
            lvwCoinData.Items.Clear();

            // 리스트 뷰 및 코인 데이터 갱신
            foreach (coinInfo coinData in coinList)
            {
                ListViewItem lvwItem = new ListViewItem(new String[lvwCoinData.Columns.Count]);
                for (int i = 0; i < lvwCoinData.Columns.Count; i++) lvwItem.SubItems[i].Name = lvwCoinData.Columns[i].Name;
                coinData.update();
                lvwItem.SubItems[0].Text = coinData.korean_name + " [" + coinData.market_code + "]";
                lvwItem.SubItems[1].Text = coinData.trade_price.ToString();
                lvwItem.SubItems[2].Text = coinData.change_price.ToString();
                switch (coinData.change)
                {
                    case "RISE":
                        lvwItem.SubItems[2].Text = "▲ +" + lvwItem.SubItems[2].Text;
                        break;
                    case "FALL":
                        lvwItem.SubItems[2].Text = "▼ -" + lvwItem.SubItems[2].Text;
                        break;
                    case "ERROR":
                        lvwItem.SubItems[2].Text = "데이터 확인 불가";
                        break;
                    default:
                        break;
                }
                lvwCoinData.Items.Add(lvwItem);
            }
        }

        // 추가 버튼
        private void btnCoinSearchAdd_Click(object sender, EventArgs e)
        {
            if (coinList.Count < 10)
            {
                try
                {
                    string koreanName = marketList[cmbBoxCoinSearch.SelectedIndex]["korean_name"].ToString();
                    string marketCode = marketList[cmbBoxCoinSearch.SelectedIndex]["market"].ToString();
                    foreach (coinInfo coinData in coinList)
                    {
                        if (coinData.market_code == marketCode)
                        {
                            MessageBox.Show("이미 존재하는 정보입니다.", "알림");
                            return;
                        }
                    }
                    coinList.Add(new coinInfo(marketCode, koreanName));
                    //MessageBox.Show("추가되었습니다.", "알림");
                }
                catch
                {
                    MessageBox.Show("입력 값을 확인바랍니다.", "알림");
                }
            }else MessageBox.Show("최대 10개까지 등록 가능합니다.", "알림");
        }

        // 제거 버튼
        private void btnCoinSearchDel_Click(object sender, EventArgs e)
        {
            
            try
            {
                string marketCode = marketList[cmbBoxCoinSearch.SelectedIndex]["market"].ToString();
                foreach (coinInfo coinData in coinList)
                {
                    if (coinData.market_code == marketCode)
                    {
                        coinList.Remove(coinData);
                        //MessageBox.Show("제거되었습니다.", "알림");
                        return;
                    }
                }
                MessageBox.Show("존재하지 않는 정보입니다..", "알림");
            }
            catch
            {
                MessageBox.Show("입력 값을 확인바랍니다.", "알림");
            }
            
        }

        // 레지스트리 불러오기
        private void CoinSearchForm_Load()
        {
            if (IsAdministrator() == false)
            {
                try
                {
                    if (MessageBox.Show("정보 저장을 위해 관리자 권한을 요청하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // 승격 요청
                        ProcessStartInfo procInfo = new ProcessStartInfo();
                        procInfo.UseShellExecute = true;
                        procInfo.FileName = Application.ExecutablePath;
                        procInfo.WorkingDirectory = Environment.CurrentDirectory;
                        procInfo.Verb = "runas";
                        Process.Start(procInfo);
                        Application.Exit();
                    }else MessageBox.Show("관리자 권한 획득 거부하셨습니다. 저장되지 않을 수 있습니다.", "알림");
                }
                catch
                {
                    // 승격 실패
                    MessageBox.Show("관리자 권한 획득에 실패했습니다. 저장되지 않을 수 있습니다.", "알림");
                }
            }
            else
            {
                // 레지스터리로부터 이전 기록 파싱 및 적용
                string regSaveData="[]";
                RegistryKey reg;
                reg = Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("CoinDataSave");
                object tempData = reg.GetValue("coinList");
                if (tempData != null) regSaveData = tempData.ToString();
                reg.Close();

                JArray savedMarketList = JArray.Parse(regSaveData);

                foreach (JToken coinToken in savedMarketList)
                {
                    coinList.Add(new coinInfo(coinToken["market"].ToString(), coinToken["korean_name"].ToString()));
                }
            }
        }


        private void CoinSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsAdministrator())
            {
                //JSON 형태로 저장
                string regSaveData = "[";
                foreach (coinInfo coinData in coinList)
                {
                    regSaveData += "{\"market\":\"" + coinData.market_code + "\",\"korean_name\":\"" + coinData.korean_name + "\" },";
                }
                regSaveData = regSaveData.Substring(0, Math.Max(1, regSaveData.Length - 1)) + "]";
                RegistryKey reg;
                reg = Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("CoinDataSave");
                reg.SetValue("coinList", regSaveData);
                reg.Close();
            }

            // 타이머 종료
            ticker.Stop();// ----------- 경고 -----------
            ticker.Dispose();// ----------- 경고 -----------

            // 코인 리스트 정리
            coinList.Clear();// ----------- 경고 -----------
        }

        // 어드민 승격 확인
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            if (identity != null)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            return false;
        }
    }
}
