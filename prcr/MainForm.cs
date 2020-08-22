using System;
using System.Windows.Forms;
using xNet;
using Fizzler.Systems.HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections.Generic;
using HtmlAgilityPack;
using System.Threading;

namespace prcr
{
    public partial class MainForm : Form
    {
        SqlConnection myConnection;
        Thread loadingThread;
        PrefsForm prefsForm = new PrefsForm();

        public MainForm()
        {
            InitializeComponent();
        }
        double parseDownfall(string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            String number = "0";
            Regex regex = new Regex(@"\([0-9]{1,3}.?[0-9]?");
            MatchCollection matches = regex.Matches(text);
            try { number = matches[0].Value.Substring(1).Replace('.', ','); }
            catch { };
            return (Convert.ToDouble(number));
        }
        private void createSQL(SqlConnection sqlconnection, string tablename)
        {
            var exist = "if exists(select * from sysobjects where name = '" + tablename + "' and xtype = 'U') BEGIN DROP TABLE " + tablename + " END ";
            var create = "CREATE TABLE " + tablename +
             " (Region NVarChar(100) NOT NULL, Area NVarChar(100) NOT NULL, Locality NVarChar(100) NOT NULL, Temperature_05 int, Temperature_11 int, Temperature_17 int, Temperature_23 int, " +
             "Pressure_05 int, Pressure_11 int, Pressure_17 int, Pressure_23 int, Wind05 int, Wind11 int, Wind17 int, Wind23 int, Wind_Napravlenie05 NVarChar(3), Wind_Napravlenie11 NVarChar(3), Wind_Napravlenie17 NVarChar(3), Wind_Napravlenie23 NVarChar(3), " +
             "Precipitation05 float, Precipitation11 float, Precipitation17 float, Precipitation23 float, Cloud05 int, Cloud11 int, Cloud17 int, Cloud23 int, PRIMARY KEY (Region, Area, Locality))";
            var query = exist + create;
            var cmd = new SqlCommand(query, myConnection);
            cmd.ExecuteNonQuery();
            return;
        }
        private void intoSQL(SqlConnection sqlconnection, string reg, string rayn, string name, int temp05, int temp11, int temp17, int temp23, int davl05, int davl11, int davl17, int davl23, int vetr05, int vetr11, int vetr17, int vetr23,
            string vetr_napr05, string vetr_napr11, string vetr_napr17, string vetr_napr23, double os05, double os11, double os17, double os23, int ob05, int ob11, int ob17, int ob23, string tablename)
        {
            string commText = "INSERT INTO " + tablename + " (Region, Area, Locality, Temperature_05, Temperature_11, Temperature_17, Temperature_23, Pressure_05, Pressure_11, Pressure_17, Pressure_23, " +
                "Wind05, Wind11, Wind17, Wind23, Wind_Napravlenie05, Wind_Napravlenie11, Wind_Napravlenie17, Wind_Napravlenie23, Precipitation05, Precipitation11, Precipitation17, Precipitation23, Cloud05, Cloud11, Cloud17, Cloud23) " +
                "VALUES (@Region, @Area, @Locality, @Temperature_05, @Temperature_11, @Temperature_17, @Temperature_23, @Pressure_05, @Pressure_11, @Pressure_17, @Pressure_23, @Wind05, @Wind11, @Wind17, @Wind23, " +
                "@Wind_Napravlenie05, @Wind_Napravlenie11, @Wind_Napravlenie17, @Wind_Napravlenie23, @Precipitation05, @Precipitation11, @Precipitation17, @Precipitation23, @Cloud05, @Cloud11, @Cloud17, @Cloud23)";
            SqlCommand comm = sqlconnection.CreateCommand();
            comm.CommandText = commText;
            comm.Parameters.AddWithValue("@Region", reg);
            comm.Parameters.AddWithValue("@Area", rayn);
            comm.Parameters.AddWithValue("@Locality", name);
            comm.Parameters.AddWithValue("@Temperature_05", temp05);
            comm.Parameters.AddWithValue("@Temperature_11", temp11);
            comm.Parameters.AddWithValue("@Temperature_17", temp17);
            comm.Parameters.AddWithValue("@Temperature_23", temp23);
            comm.Parameters.AddWithValue("@Pressure_05", davl05);
            comm.Parameters.AddWithValue("@Pressure_11", davl11);
            comm.Parameters.AddWithValue("@Pressure_17", davl17);
            comm.Parameters.AddWithValue("@Pressure_23", davl23);
            comm.Parameters.AddWithValue("@Wind05", vetr05);
            comm.Parameters.AddWithValue("@Wind11", vetr11);
            comm.Parameters.AddWithValue("@Wind17", vetr17);
            comm.Parameters.AddWithValue("@Wind23", vetr23);
            comm.Parameters.AddWithValue("@Wind_Napravlenie05", vetr_napr05);
            comm.Parameters.AddWithValue("@Wind_Napravlenie11", vetr_napr11);
            comm.Parameters.AddWithValue("@Wind_Napravlenie17", vetr_napr17);
            comm.Parameters.AddWithValue("@Wind_Napravlenie23", vetr_napr23);
            comm.Parameters.AddWithValue("@Precipitation05", os05);
            comm.Parameters.AddWithValue("@Precipitation11", os11);
            comm.Parameters.AddWithValue("@Precipitation17", os17);
            comm.Parameters.AddWithValue("@Precipitation23", os23);
            comm.Parameters.AddWithValue("@Cloud05", ob05);
            comm.Parameters.AddWithValue("@Cloud11", ob11);
            comm.Parameters.AddWithValue("@Cloud17", ob17);
            comm.Parameters.AddWithValue("@Cloud23", ob23);
            comm.ExecuteNonQuery();
        }
        public static int getMonth(string name)
        {
            switch (name)
            {
                case "января": return 1;
                case "февраля": return 2;
                case "марта": return 3;
                case "апреля": return 4;
                case "мая": return 5;
                case "июня": return 6;
                case "июля": return 7;
                case "августа": return 8;
                case "сентября": return 9;
                case "октября": return 10;
                case "ноября": return 11;
                case "декабря": return 12;
            }
            return 1;
        }
        void callTest()
        {
            parsestart = DateTime.Now;
            test();
            this.BeginInvoke(new InvokeDelegate(() => textboxConnection.Enabled = true));
            this.BeginInvoke(new InvokeDelegate(() => button1.Enabled = true));
            this.BeginInvoke(new InvokeDelegate(() => button2.Enabled = true));
            this.BeginInvoke(new InvokeDelegate(() => this.progressBar2.Value = 0));
            this.BeginInvoke(new InvokeDelegate(() => this.label1.Text = ""));
            this.BeginInvoke(new InvokeDelegate(() => this.label2.Text = ""));
            this.BeginInvoke(new InvokeDelegate(() => TopMost = true));
        }
        public delegate void InvokeDelegate();
        public void loadCitiesData(object links)
        {
            var sqlConnection = new SqlConnection(textboxConnection.Text);
            sqlConnection.Open();
            List<string> citilinks = (List<string>)links;
            string reg = "", rayn = "", name = "", date = "", temp = "", davl = "", vetr = "", osdk = "", oblach = "", prvr = "", prvr2 = "", prvr3 = "", finallink = "", vetr_napr = "";
            string response = "https://rp5.ru";
            DateTime dt = DateTime.Now;
            int days = dt.Day;
            int hour = dt.Hour;
            var day = "";
            var month = 0;
            var fulldate = "";
            DateTime fullDt = DateTime.Now;
            DateTime timeDT = DateTime.Now;
            double os = 0;
            int ob = 0;
            string tablename = "";
            string time = "";
            int temp05 = 0, temp11 = 0, temp17 = 0, temp23 = 0, davl05 = 0, davl11 = 0, davl17 = 0, davl23 = 0, vetr05 = 0, vetr11 = 0, vetr17 = 0, vetr23 = 0;
            string vetr_napr05 = "", vetr_napr11 = "", vetr_napr17 = "", vetr_napr23 = "";
            double os05 = 0, os11 = 0, os17 = 0, os23 = 0;
            int ob05 = 0, ob11 = 0, ob17 = 0, ob23 = 0;
            for (int f = 0; f < citilinks.Count; f++)
            {
                try
                {
                    finallink = response + "/" + citilinks[f].ToString();
                    var danni = new HttpRequest();
                    string response2 = danni.Get(finallink).ToString();
                    HtmlAgilityPack.HtmlDocument hap = new HtmlAgilityPack.HtmlDocument();
                    hap.LoadHtml(response2);
                    try
                    {
                        reg = hap.DocumentNode.QuerySelector("div > span > a:nth-child(5) > nobr").InnerText;
                        rayn = hap.DocumentNode.QuerySelector("div > span > a:nth-child(7) > nobr").InnerText;
                        name = hap.DocumentNode.QuerySelector("div > span > a:nth-child(9) > nobr").InnerText;
                    }
                    catch
                    {
                        rayn = hap.DocumentNode.QuerySelector("div > span > a:nth-child(7) > nobr").InnerText;
                        name = hap.DocumentNode.QuerySelector("div > span > a:nth-child(7) > nobr").InnerText;
                    }
                    try
                    {
                        prvr = hap.DocumentNode.QuerySelector("tr:nth-child(15) > td.title > a").InnerText;
                        prvr2 = hap.DocumentNode.QuerySelector("tr:nth-child(14) > td.title > a").InnerText;
                    }
                    catch { }
                    bool a = String.Equals(prvr, prvr2);
                    try { prvr3 = hap.DocumentNode.QuerySelector("tr:nth-child(14) > td.title > a").InnerText; } catch { }
                    int count = 0;
                    int b = 2;
                    int c = 6;
                    if (hour >= 5 && hour < 11) { count = 3; b = 3; c = 7; }
                    else if (hour >= 11 && hour < 17) { count = 2; b = 3; c = 7; }
                    else if (hour >= 17 && hour < 23) { count = 1; b = 3; c = 7; }
                    for (var i = b; i <= c; i++)
                    {
                        date = hap.DocumentNode.QuerySelector("tr.forecastDate > td:nth-child(" + i + ") > div > div > span.monthDay").InnerText;
                        var j = 0;
                        for (j = 0; j <= 3; j++)
                        {
                            var x = (i - b) * 4 + j + count + 2;
                            time = "05:00:00";
                            if (j == 1) time = "11:00:00";
                            else if (j == 2) time = "17:00:00";
                            else if (j == 3) time = "23:00:00";
                            try
                            {
                                oblach = hap.DocumentNode.QuerySelector("tr:nth-child(3) > td:nth-child(" + x + ") > div.cc_0 > div").GetAttributeValue("class", null);
                                osdk = hap.DocumentNode.QuerySelector("tr:nth-child(4) > td:nth-child(" + (x * 2 - 2) + ") > div.pr_0").GetAttributeValue("onmouseover", null);
                                try
                                {
                                    temp = hap.DocumentNode.QuerySelector("tr:nth-child(6) > td:nth-child(" + x + ") > div.t_0 > b").InnerText;
                                    if (a == true)
                                    {
                                        davl = hap.DocumentNode.QuerySelector("tr:nth-child(7) > td:nth-child(" + x + ") > div.p_0").InnerText;
                                        vetr = hap.DocumentNode.QuerySelector("tr:nth-child(8) > td:nth-child(" + x + ") > div.wv_0").InnerText;
                                        vetr_napr = hap.DocumentNode.QuerySelector("tr:nth-child(10) > td:nth-child(" + x + ")").InnerText;
                                    }
                                    else
                                    {
                                        davl = hap.DocumentNode.QuerySelector("tr:nth-child(8) > td:nth-child(" + x + ") > div.p_0").InnerText;
                                        vetr = hap.DocumentNode.QuerySelector("tr:nth-child(9) > td:nth-child(" + x + ") > div.wv_0").InnerText;
                                        vetr_napr = hap.DocumentNode.QuerySelector("tr:nth-child(11) > td:nth-child(" + x + ")").InnerText;
                                    }
                                }
                                catch
                                {
                                    temp = hap.DocumentNode.QuerySelector("tr:nth-child(5) > td:nth-child(" + x + ") > div.t_0 > b").InnerText;
                                    if (string.IsNullOrEmpty(prvr3))
                                    {
                                        davl = hap.DocumentNode.QuerySelector("tr:nth-child(6) > td:nth-child(" + x + ") > div.p_0").InnerText;
                                        vetr = hap.DocumentNode.QuerySelector("tr:nth-child(7) > td:nth-child(" + x + ") > div.wv_0").InnerText;
                                        vetr_napr = hap.DocumentNode.QuerySelector("tr:nth-child(9) > td:nth-child(" + x + ")").InnerText;
                                    }
                                    else
                                    {
                                        davl = hap.DocumentNode.QuerySelector("tr:nth-child(7) > td:nth-child(" + x + ") > div.p_0").InnerText;
                                        vetr = hap.DocumentNode.QuerySelector("tr:nth-child(8) > td:nth-child(" + x + ") > div.wv_0").InnerText;
                                        vetr_napr = hap.DocumentNode.QuerySelector("tr:nth-child(10) > td:nth-child(" + x + ")").InnerText;
                                    }
                                }
                                os = parseDownfall(osdk);
                                ob = Convert.ToInt16(oblach[2].ToString());
                            }
                            catch { }
                            if (String.IsNullOrEmpty(vetr) || vetr == "-") { vetr = "0"; }
                            if (j == 0) { temp05 = Convert.ToInt16(temp); davl05 = Convert.ToInt16(davl); vetr05 = Convert.ToInt16(vetr); vetr_napr05 = vetr_napr; os05 = os; ob05 = ob; }
                            if (j == 1) { temp11 = Convert.ToInt16(temp); davl11 = Convert.ToInt16(davl); vetr11 = Convert.ToInt16(vetr); vetr_napr11 = vetr_napr; os11 = os; ob11 = ob; }
                            if (j == 2) { temp17 = Convert.ToInt16(temp); davl17 = Convert.ToInt16(davl); vetr17 = Convert.ToInt16(vetr); vetr_napr17 = vetr_napr; os17 = os; ob17 = ob; }
                            if (j == 3) { temp23 = Convert.ToInt16(temp); davl23 = Convert.ToInt16(davl); vetr23 = Convert.ToInt16(vetr); vetr_napr23 = vetr_napr; os23 = os; ob23 = ob; }
                        }

                        day = date.Split(' ')[0];
                        month = getMonth(date.Split(' ')[1]);
                        fulldate = day + "." + month + "." + DateTime.Now.Year;
                        DateTime oDate = Convert.ToDateTime (fulldate);
                        fullDt = DateTime.Parse(fulldate);
                        timeDT = DateTime.Parse(time);
                        string newday = oDate.Day.ToString("00");
                        string newmonth = oDate.Month.ToString("00");
                        tablename = tableprefix + newday + "_" + newmonth + "_" + DateTime.Now.Year;
                        intoSQL(sqlConnection, reg, rayn, name, temp05, temp11, temp17, temp23, davl05, davl11, davl17, davl23,
                            vetr05, vetr11, vetr17, vetr23, vetr_napr05, vetr_napr11, vetr_napr17, vetr_napr23,
                            os05, os11, os17, os23, ob05, ob11, ob17, ob23, tablename);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Interlocked.Increment(ref finishedCityLinksCount);
                    updateCityProgress();
                }
            }
            sqlConnection.Close();
        }

        DateTime parsestart;

        void updateCityProgress()
        {
            int max = allCityLinks.Count;
            int count = finishedCityLinksCount;
            updateProgressElements("Спарсилось городов", count, max);
            if (max == count)
            {
                var time2 = DateTime.Now;
                double tm = (time2 - parsestart).TotalMinutes;
                int dd = (int)tm;
                messageboxOK(dd);
            }
        }
        void updateProgressElements(string text, int count, int max)
        {
            label1.BeginInvoke(new InvokeDelegate(() => {
                label1.Text = text + ": " + count + "/" + max;
                progressBar2.Maximum = max;
                progressBar2.Value = count;
            }));
        }
        string tableprefix = "paral_";
        void createSQLTables(SqlConnection sqlconnection)
        {
            var now = DateTime.Now;
            for (var i = 1; i < 6; i++)
            {
                var date = now.AddDays(i);
                string newday = date.Day.ToString("00");
                string newmonth = date.Month.ToString("00");
                var tablename = tableprefix + newday + "_" + newmonth + "_" + date.Year;
                createSQL(sqlconnection, tablename);
            }
        }
        List<string> allCityLinks = new List<string>();
        private int finishedCityLinksCount = 0;
        void parallelHandleCityLinks(int threadCount)
        {
            var cityCount = allCityLinks.Count;
            var linksPerThread = cityCount / threadCount;
            for (var i = 0; i < threadCount; i++)
            {
                var start = i * linksPerThread;
                var end = start + linksPerThread - 1;
                if (i == threadCount - 1)
                {
                    end = cityCount - 1;
                }
                var subList = allCityLinks.GetRange(start, end - start + 1);
                Thread thread = new Thread(loadCitiesData);
                thread.Name = "CityLinksHandler-" + i;
                thread.Start(subList);
            }
        }
        void test()
        {
            var sqlconnection = new SqlConnection(textboxConnection.Text);
            sqlconnection.Open();
            createSQLTables(sqlconnection);
            sqlconnection.Close();
            List<string> regionLinks = prefsForm.ssilki;
            updateProgressElements("Загружено ссылок", 0, regionLinks.Count);
            for (int g = 0; g < regionLinks.Count; g++)
            {

                progressBar2.BeginInvoke(new InvokeDelegate(() => progressBar2.Value = g));
                HtmlWeb hw = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc2 = hw.Load(regionLinks[g]);
                foreach (HtmlNode link2 in doc2.DocumentNode.SelectNodes("//div[@class='city_link']/a"))
                {
                    string hrefValue2 = link2.GetAttributeValue("href", string.Empty);
                    allCityLinks.Add(hrefValue2);
                }
                updateProgressElements("Загружено ссылок", g + 1, regionLinks.Count);
            }

            parallelHandleCityLinks(6);
        }
        void messageboxOK(int tm)
        {
            MessageBox.Show(
            "Парсинг успешно завершен за " + tm + "мин.",
            "Результат",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(textboxConnection.Text);
                myConnection.Open();
                loadingThread = new Thread(() => callTest());
                loadingThread.Start();
                button1.Enabled = false;
                button2.Enabled = false;
                textboxConnection.Enabled = false;
            }
            catch
            {
                MessageBox.Show(
                "Неверно указана строка подключения!",
                "Ошибка подключения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                TopMost = true;
            }
        }
        private void formClose(object sender, FormClosedEventArgs e)
        {
            if (myConnection != null) myConnection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textboxConnection, "НАПРИМЕР: Data Source=LAPTOP-0HTF03TT\\SQLEXPRESS;Initial Catalog = prcrDB; Integrated Security = True");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            prefsForm.Show();
        }
    }
}
