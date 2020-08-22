using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prcr
{
    public partial class PrefsForm : Form
    {
        public List<string> ssilki = new List<string>();

        public PrefsForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Башкортостан");
            treeView1.Nodes.Add("Татарстан");
            treeView1.Nodes.Add("Оренбургская область");
            treeView1.Nodes.Add("Удмуртия");
            treeView1.Nodes.Add("Пермский край");
            treeView1.Nodes.Add("Свердловская область");
            treeView1.Nodes.Add("Челябинская область");

            treeView1.Nodes[0].Nodes.Add("Абзелиловский район");
            treeView1.Nodes[0].Nodes.Add("Агидель район");
            treeView1.Nodes[0].Nodes.Add("Альшеевский район");
            treeView1.Nodes[0].Nodes.Add("Архангельский район");
            treeView1.Nodes[0].Nodes.Add("Аскинский район");
            treeView1.Nodes[0].Nodes.Add("Аургазинский район");
            treeView1.Nodes[0].Nodes.Add("Баймакский район");
            treeView1.Nodes[0].Nodes.Add("Бакалинский район");
            treeView1.Nodes[0].Nodes.Add("Балтачевский район");
            treeView1.Nodes[0].Nodes.Add("Белебеевский район");
            treeView1.Nodes[0].Nodes.Add("Белокатайский район");
            treeView1.Nodes[0].Nodes.Add("Белорецкий район");
            treeView1.Nodes[0].Nodes.Add("Бижбулякский район");
            treeView1.Nodes[0].Nodes.Add("Бирский район");
            treeView1.Nodes[0].Nodes.Add("Бирск район");
            treeView1.Nodes[0].Nodes.Add("Благоварский район");
            treeView1.Nodes[0].Nodes.Add("Благовещенский район");
            treeView1.Nodes[0].Nodes.Add("Буздякский район");
            treeView1.Nodes[0].Nodes.Add("Бураевский район");
            treeView1.Nodes[0].Nodes.Add("Бурзянский район");
            treeView1.Nodes[0].Nodes.Add("Гафурийский район");
            treeView1.Nodes[0].Nodes.Add("Давлекановский район");
            treeView1.Nodes[0].Nodes.Add("Дуванский район");
            treeView1.Nodes[0].Nodes.Add("Дюртюлинский район");
            treeView1.Nodes[0].Nodes.Add("Дюртюли район");
            treeView1.Nodes[0].Nodes.Add("Ермекеевский район");
            treeView1.Nodes[0].Nodes.Add("Зианчуринский район");
            treeView1.Nodes[0].Nodes.Add("Зилаирский район");
            treeView1.Nodes[0].Nodes.Add("Иглинский район");
            treeView1.Nodes[0].Nodes.Add("Илишевский район");
            treeView1.Nodes[0].Nodes.Add("Ишимбайский район");
            treeView1.Nodes[0].Nodes.Add("Калтасинский район");
            treeView1.Nodes[0].Nodes.Add("Караидельский район");
            treeView1.Nodes[0].Nodes.Add("Кармаскалинский район");
            treeView1.Nodes[0].Nodes.Add("Кигинский район");
            treeView1.Nodes[0].Nodes.Add("Краснокамский район");
            treeView1.Nodes[0].Nodes.Add("Кугарчинский район");
            treeView1.Nodes[0].Nodes.Add("Кумертау район");
            treeView1.Nodes[0].Nodes.Add("Кушнаренковский район");
            treeView1.Nodes[0].Nodes.Add("Куюргазинский район");
            treeView1.Nodes[0].Nodes.Add("Межгорье район");
            treeView1.Nodes[0].Nodes.Add("Мелеузовский район");
            treeView1.Nodes[0].Nodes.Add("Мечетлинский район");
            treeView1.Nodes[0].Nodes.Add("Мишкинский район");
            treeView1.Nodes[0].Nodes.Add("Миякинский район");
            treeView1.Nodes[0].Nodes.Add("Нефтекамск район");
            treeView1.Nodes[0].Nodes.Add("Нуримановский район");
            treeView1.Nodes[0].Nodes.Add("Октябрьский район");
            treeView1.Nodes[0].Nodes.Add("Салаватский район");
            treeView1.Nodes[0].Nodes.Add("Салават район");
            treeView1.Nodes[0].Nodes.Add("Сибай район");
            treeView1.Nodes[0].Nodes.Add("Стерлибашевском район");
            treeView1.Nodes[0].Nodes.Add("Стерлитамакский район");
            treeView1.Nodes[0].Nodes.Add("Татышлинский район");
            treeView1.Nodes[0].Nodes.Add("Туймазинский район");
            treeView1.Nodes[0].Nodes.Add("Уфа район");
            treeView1.Nodes[0].Nodes.Add("Уфимский район");
            treeView1.Nodes[0].Nodes.Add("Учалинский район");
            treeView1.Nodes[0].Nodes.Add("Федоровский район");
            treeView1.Nodes[0].Nodes.Add("Хайбуллинский район");
            treeView1.Nodes[0].Nodes.Add("Чекмагушевский район");
            treeView1.Nodes[0].Nodes.Add("Чишминский район");
            treeView1.Nodes[0].Nodes.Add("Шаранский район");
            treeView1.Nodes[0].Nodes.Add("Янаульский район");
            
            treeView1.Nodes[1].Nodes.Add("Азнакаевский район");
            treeView1.Nodes[1].Nodes.Add("Актанышский район");
            treeView1.Nodes[1].Nodes.Add("Бавлинский район");
            treeView1.Nodes[1].Nodes.Add("Муслюмовский район");
            treeView1.Nodes[1].Nodes.Add("Ютазинский район");

            treeView1.Nodes[2].Nodes.Add("Адбулинский район");
            treeView1.Nodes[2].Nodes.Add("Гайский район");
            treeView1.Nodes[2].Nodes.Add("Кваркенский район");
            treeView1.Nodes[2].Nodes.Add("Кувандыкский район");
            treeView1.Nodes[2].Nodes.Add("Октябрьский район (Оренбург)");
            treeView1.Nodes[2].Nodes.Add("Пономарёвский район");
            treeView1.Nodes[2].Nodes.Add("Саракташский район");
            treeView1.Nodes[2].Nodes.Add("Тюльганский район");
            treeView1.Nodes[2].Nodes.Add("Шарлыкский район");

            treeView1.Nodes[3].Nodes.Add("Камбарский район");
            treeView1.Nodes[3].Nodes.Add("Каракулинский район");

            treeView1.Nodes[4].Nodes.Add("Куединский район");
            treeView1.Nodes[4].Nodes.Add("Октябрьский район (Пермь)");
            treeView1.Nodes[4].Nodes.Add("Чайковский район");
            treeView1.Nodes[4].Nodes.Add("Чернушинский район");

            treeView1.Nodes[5].Nodes.Add("Артинский район");
            treeView1.Nodes[5].Nodes.Add("Красноуфимский район");

            treeView1.Nodes[6].Nodes.Add("Агаповский район");
            treeView1.Nodes[6].Nodes.Add("Ашинский район");
            treeView1.Nodes[6].Nodes.Add("Верхнеуральский район");
            treeView1.Nodes[6].Nodes.Add("Магнитогорский район");
            treeView1.Nodes[6].Nodes.Add("Миасский район");
            treeView1.Nodes[6].Nodes.Add("Усть-Катавский  район");
            treeView1.Nodes[6].Nodes.Add("Катав-Ивановский район");
            treeView1.Nodes[6].Nodes.Add("Кизильский район");
            treeView1.Nodes[6].Nodes.Add("Кусинский район");
            treeView1.Nodes[6].Nodes.Add("Нязепетровский район");
            treeView1.Nodes[6].Nodes.Add("Саткинский район");
            treeView1.Nodes[6].Nodes.Add("Уйский район");
            treeView1.Nodes[6].Nodes.Add("Чебаркульский район");
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void node_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                node.Checked = true;
                CheckAllChildNodes(node, true);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                node.Checked = false;
                CheckAllChildNodes(node, false);
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            ssilki.Clear();
            GetCheckedNodes(treeView1.Nodes);
            for (int i = 0; i < ssilki.Count; i++)
            {
                Console.WriteLine(ssilki[i].ToString());
            }
            this.Hide();
        }

        public void GetCheckedNodes(TreeNodeCollection nodes) 
        {
            
            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                foreach (TreeNode subnode in aNode.Nodes)
                {
                    if (!subnode.Checked) //Доделал корректную выборку отдельных регионов
                        continue;
                    ssilki.Add(subnode.Text);
                }
            }

            for (int j = 0; j < ssilki.Count; j++) {
                switch (ssilki[j])
                {
                    case "Абзелиловский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%B1%D0%B7%D0%B5%D0%BB%D0%B8%D0%BB%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Агидель район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%B3%D0%B8%D0%B4%D0%B5%D0%BB%D0%B8,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Альшеевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%BB%D1%8C%D1%88%D0%B5%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Архангельский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D1%80%D1%85%D0%B0%D0%BD%D0%B3%D0%B5%D0%BB%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Аскинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D1%81%D0%BA%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Аургазинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D1%83%D1%80%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Баймакский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B0%D0%B9%D0%BC%D0%B0%D0%BA%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Бакалинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B0%D0%BA%D0%B0%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Балтачевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B0%D0%BB%D1%82%D0%B0%D1%87%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Белебеевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B5%D0%BB%D0%B5%D0%B1%D0%B5%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Белокатайский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B5%D0%BB%D0%BE%D0%BA%D0%B0%D1%82%D0%B0%D0%B9%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Белорецкий район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B5%D0%BB%D0%BE%D1%80%D0%B5%D1%86%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Бижбулякский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B8%D0%B6%D0%B1%D1%83%D0%BB%D1%8F%D0%BA%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Бирский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B8%D1%80%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Бирск район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B8%D1%80%D1%81%D0%BA%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Благоварский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%BB%D0%B0%D0%B3%D0%BE%D0%B2%D0%B0%D1%80%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Благовещенский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%BB%D0%B0%D0%B3%D0%BE%D0%B2%D0%B5%D1%89%D0%B5%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5,_%D0%91%D0%B0%D1%88%D0%BA%D0%BE%D1%80%D1%82%D0%BE%D1%81%D1%82%D0%B0%D0%BD"; break;
                    case "Буздякский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D1%83%D0%B7%D0%B4%D1%8F%D0%BA%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Бураевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D1%83%D1%80%D0%B0%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Бурзянский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D1%83%D1%80%D0%B7%D1%8F%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Гафурийский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%93%D0%B0%D1%84%D1%83%D1%80%D0%B8%D0%B9%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Давлекановский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%94%D0%B0%D0%B2%D0%BB%D0%B5%D0%BA%D0%B0%D0%BD%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Дуванский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%94%D1%83%D0%B2%D0%B0%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Дюртюлинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%94%D1%8E%D1%80%D1%82%D1%8E%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Дюртюли район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%94%D1%8E%D1%80%D1%82%D1%8E%D0%BB%D0%B8"; break;
                    case "Ермекеевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%95%D1%80%D0%BC%D0%B5%D0%BA%D0%B5%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Зианчуринский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%97%D0%B8%D0%B0%D0%BD%D1%87%D1%83%D1%80%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Зилаирский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%97%D0%B8%D0%BB%D0%B0%D0%B8%D1%80%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Иглинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%98%D0%B3%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Илишевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%98%D0%BB%D0%B8%D1%88%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Ишимбайский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%98%D1%88%D0%B8%D0%BC%D0%B1%D0%B0%D0%B9%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Калтасинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B0%D0%BB%D1%82%D0%B0%D1%81%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Караидельский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B0%D1%80%D0%B0%D0%B8%D0%B4%D0%B5%D0%BB%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кармаскалинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B0%D1%80%D0%BC%D0%B0%D1%81%D0%BA%D0%B0%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кигинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B8%D0%B3%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Краснокамский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%80%D0%B0%D1%81%D0%BD%D0%BE%D0%BA%D0%B0%D0%BC%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кугарчинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%83%D0%B3%D0%B0%D1%80%D1%87%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кумертау район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%83%D0%BC%D0%B5%D1%80%D1%82%D0%B0%D1%83,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Кушнаренковский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%83%D1%88%D0%BD%D0%B0%D1%80%D0%B5%D0%BD%D0%BA%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Куюргазинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%83%D1%8E%D1%80%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Межгорье район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B5%D0%B6%D0%B3%D0%BE%D1%80%D1%8C%D0%B5"; break;
                    case "Мелеузовский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B5%D0%BB%D0%B5%D1%83%D0%B7%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Мечетлинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B5%D1%87%D0%B5%D1%82%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Мишкинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B8%D1%88%D0%BA%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5,_%D0%91%D0%B0%D1%88%D0%BA%D0%BE%D1%80%D1%82%D0%BE%D1%81%D1%82%D0%B0%D0%BD"; break;
                    case "Миякинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B8%D1%8F%D0%BA%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Нефтекамск район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9D%D0%B5%D1%84%D1%82%D0%B5%D0%BA%D0%B0%D0%BC%D1%81%D0%BA%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Нуримановский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9D%D1%83%D1%80%D0%B8%D0%BC%D0%B0%D0%BD%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Октябрьский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9E%D0%BA%D1%82%D1%8F%D0%B1%D1%80%D1%8C%D1%81%D0%BA%D0%BE%D0%BC"; break;
                    case "Салаватский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%B0%D0%BB%D0%B0%D0%B2%D0%B0%D1%82%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Салават район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%B0%D0%BB%D0%B0%D0%B2%D0%B0%D1%82%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Сибай район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%B8%D0%B1%D0%B0%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Стерлибашевском район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D1%82%D0%B5%D1%80%D0%BB%D0%B8%D0%B1%D0%B0%D1%88%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Стерлитамакский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D1%82%D0%B5%D1%80%D0%BB%D0%B8%D1%82%D0%B0%D0%BC%D0%B0%D0%BA%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Татышлинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A2%D0%B0%D1%82%D1%8B%D1%88%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Туймазинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A2%D1%83%D0%B9%D0%BC%D0%B0%D0%B7%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Уфа район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A3%D1%84%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Уфимский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A3%D1%84%D0%B8%D0%BC%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Учалинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A3%D1%87%D0%B0%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Федоровский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A4%D0%B5%D0%B4%D0%BE%D1%80%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5,_%D0%91%D0%B0%D1%88%D0%BA%D0%BE%D1%80%D1%82%D0%BE%D1%81%D1%82%D0%B0%D0%BD"; break;
                    case "Хайбуллинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A5%D0%B0%D0%B9%D0%B1%D1%83%D0%BB%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Чекмагушевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A7%D0%B5%D0%BA%D0%BC%D0%B0%D0%B3%D1%83%D1%88%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Чишминский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A7%D0%B8%D1%88%D0%BC%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Шаранский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A8%D0%B0%D1%80%D0%B0%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Янаульский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%AF%D0%BD%D0%B0%D1%83%D0%BB%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;



                    case "Азнакаевский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%B7%D0%BD%D0%B0%D0%BA%D0%B0%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Актанышский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%BA%D1%82%D0%B0%D0%BD%D1%8B%D1%88%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Бавлинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%91%D0%B0%D0%B2%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Муслюмовский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D1%83%D1%81%D0%BB%D1%8E%D0%BC%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Ютазинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%AE%D1%82%D0%B0%D0%B7%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;

                    case "Адбулинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%B1%D0%B4%D1%83%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Гайский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%93%D0%B0%D0%B9%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кваркенский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B2%D0%B0%D1%80%D0%BA%D0%B5%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кувандыкский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%83%D0%B2%D0%B0%D0%BD%D0%B4%D1%8B%D0%BA%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Октябрьский район (Оренбург)":  ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9E%D0%BA%D1%82%D1%8F%D0%B1%D1%80%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5,_%D0%9E%D1%80%D0%B5%D0%BD%D0%B1%D1%83%D1%80%D0%B3%D1%81%D0%BA%D0%B0%D1%8F_%D0%BE%D0%B1%D0%BB%D0%B0%D1%81%D1%82%D1%8C"; break;
                    case "Пономарёвский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9F%D0%BE%D0%BD%D0%BE%D0%BC%D0%B0%D1%80%D0%B5%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Саракташский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%B0%D1%80%D0%B0%D0%BA%D1%82%D0%B0%D1%88%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Тюльганский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A2%D1%8E%D0%BB%D1%8C%D0%B3%D0%B0%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Шарлыкский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A8%D0%B0%D1%80%D0%BB%D1%8B%D0%BA%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;

                    case "Камбарский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B0%D0%BC%D0%B1%D0%B0%D1%80%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Каракулинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B0%D1%80%D0%B0%D0%BA%D1%83%D0%BB%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;

                    case "Куединский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%83%D0%B5%D0%B4%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Октябрьский район (Пермь)": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9E%D0%BA%D1%82%D1%8F%D0%B1%D1%80%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5,_%D0%9F%D0%B5%D1%80%D0%BC%D1%81%D0%BA%D0%B8%D0%B9_%D0%BA%D1%80%D0%B0%D0%B9"; break;
                    case "Чайковский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A7%D0%B0%D0%B9%D0%BA%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Чернушинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A7%D0%B5%D1%80%D0%BD%D1%83%D1%88%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;

                    case "Артинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D1%80%D1%82%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Красноуфимский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%80%D0%B0%D1%81%D0%BD%D0%BE%D1%83%D1%84%D0%B8%D0%BC%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;

                    case "Агаповский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%B3%D0%B0%D0%BF%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Ашинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D1%88%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Верхнеуральский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%92%D0%B5%D1%80%D1%85%D0%BD%D0%B5%D1%83%D1%80%D0%B0%D0%BB%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Магнитогорский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B0%D0%B3%D0%BD%D0%B8%D1%82%D0%BE%D0%B3%D0%BE%D1%80%D1%81%D0%BA%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Миасский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B8%D0%B0%D1%81%D1%81%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Усть-Катавский  район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A3%D1%81%D1%82%D1%8C-%D0%9A%D0%B0%D1%82%D0%B0%D0%B2%D0%B5,_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD"; break;
                    case "Катав-Ивановский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B0%D1%82%D0%B0%D0%B2-%D0%98%D0%B2%D0%B0%D0%BD%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кизильский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B8%D0%B7%D0%B8%D0%BB%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Кусинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%83%D1%81%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Нязепетровский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9D%D1%8F%D0%B7%D0%B5%D0%BF%D0%B5%D1%82%D1%80%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Саткинский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%B0%D1%82%D0%BA%D0%B8%D0%BD%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Уйский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A3%D0%B9%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                    case "Чебаркульский район": ssilki[j] = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A7%D0%B5%D0%B1%D0%B0%D1%80%D0%BA%D1%83%D0%BB%D1%8C%D1%81%D0%BA%D0%BE%D0%BC_%D1%80%D0%B0%D0%B9%D0%BE%D0%BD%D0%B5"; break;
                }
            }
            
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
