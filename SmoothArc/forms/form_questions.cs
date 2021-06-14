using SmoothArc.forms;
using SmoothArc.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothArc
{

    public partial class form_questions : Form
    {
        DataTable sorular = new DataTable();
        DBconnection connection = new DBconnection();
        bool teachermode = Properties.Settings.Default.TeacherMode;
        bool currentTeacherMode = false;
        String url;
        public form_questions()
        {
            InitializeComponent();
            if (teachermode == true) TeacherMode();
            combobox_fill();
            if (GetUserLectures().Count > 0)
            {
                string baslik = connection.query("SELECT `baslik` FROM `hedef_turler` WHERE `id`=" + GetUserLectures().First()).Rows[0].ItemArray[0].ToString();
                for (int i = 0; i < ComboBox.Items.Count; i++)
                {

                    if (ComboBox.Items[i].ToString() == baslik)
                    {
                        ComboBox.SelectedIndex = i;
                        break;
                    }
                    else ComboBox.SelectedIndex = 0;
                }
            }

            else ComboBox.SelectedIndex = 0;


        }
        public void TeacherMode()
        {
            listBox1.Height = 210;
            listbox_panel.Height = 240;
            textbox_questions.Text = "";
            textbox_teachermode.Text = "";
            textbox_questions.PlaceholderText = "Cevap...";
            btn_save.Text = "Yayınla";
            textbox_teachermode.Visible = true;
            currentTeacherMode = true;
       
        }
        public void StudentMode()
        {
            listBox1.Height = 291;
            listbox_panel.Height = 328;
            textbox_questions.PlaceholderText = "Soru...";
            btn_save.Text = "Gönder";
            textbox_teachermode.Visible = false;
            currentTeacherMode = false;
          
        }

        public void CustomizePanel(int id)
        {
            String name = connection.query("SELECT `baslik` FROM `hedef_turler` WHERE `id`=" + id).Rows[0].ItemArray[0].ToString().ToLower();
            char[] tr = { '!', '’', '”', '“', '"', '%', '`', '&', '+', '?', 'ş', 'Ş', 'ı', 'I', 'İ', 'ğ', 'Ğ', 'ü', 'Ü', 'ö', 'Ö', 'Ç', 'ç', '(', ')', '/', ':', ',' };
            char[] eng = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 's', 's', 'i', 'i', 'i', 'g', 'g', 'u', 'u', 'o', 'o', 'c', 'c', ' ', ' ', ' ', ' ', ' ' };
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < tr.Length; j++)
                {
                    name = name.Replace(tr[j], eng[j]);
                }
            }
            name = name.TrimEnd();
            name = name.Replace(" ", "-");
            name = name.ToLower();
            Console.WriteLine(name);
            url = "https://online.smoothacademy.org/kategoriler/" + id + "/" + name;
        }
        public List<string> GetUserLectures()
        {
            DataTable egitimler = new DataTable();
            if (teachermode)
            {
                egitimler = connection.query("SELECT `kategori_id` FROM `egitimler` WHERE `egitmen_id`=" + Properties.Settings.Default.id);

            }
            else
            {
                egitimler = connection.query("SELECT `kategori_id` FROM `egitimler` INNER JOIN `siparisler` ON `siparisler`.`egitim_id`=`egitimler`.`id` WHERE `siparisler`.`musteri_id`= '" + Properties.Settings.Default.id + "' AND `siparisler`.`durum`= 1");
            }
            List<string> kategori = new List<string>();

            for (int i = 0; i < egitimler.Rows.Count; i++)
            {
                kategori.Add(egitimler.Rows[i].ItemArray[0].ToString());
            }
            int count = 0;
            for (int i = 0; i < kategori.Count; i++)
            {
                for (int j = 0; j < kategori.Count; j++)
                {
                    if (kategori[i] == kategori[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    kategori.Remove(kategori[i]);
                }
            }
            return kategori;
        }
        public void combobox_fill()
        {
            DataTable kategoriler = connection.query("SELECT `baslik` FROM `hedef_turler`");
            for (int i = 0; i < kategoriler.Rows.Count; i++)
            {
                ComboBox.Items.Add(kategoriler.Rows[i].ItemArray[0]);
            }
        }
        public int getHedefid()
        {
            int Id;
            DataTable id = connection.query("SELECT `id` FROM `hedef_turler` WHERE `baslik`= '" + ComboBox.SelectedItem + "'");
            Id = int.Parse(id.Rows[0].ItemArray[0].ToString());
            id.Clear();
            return Id;
        }
        public void listbox_fill()
        {
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            List<string> UserKategori = GetUserLectures();


            if (teachermode == true)
            {
                bool isTaken = false;
                for (int i = 0; i < UserKategori.Count; i++)
                {
                    if (UserKategori[i].ToString() == getHedefid().ToString())
                    {
                        isTaken = true;
                    }

                }
                if (isTaken)
                {
                    TeacherMode();
                    sorular = connection.query("Select * from sorular where `cevaplanmis`= 0 and `hedefid`=" + getHedefid());
                    for (int i = 0; i < sorular.Rows.Count; i++)
                    {
                        listBox1.Items.Add("-?-");
                        listBox1.Items.Add("+  " + sorular.Rows[i].ItemArray[1].ToString());
                    }
                }
                else
                {
                    StudentMode();
                    panel1.Visible = false;
                    sorular = connection.query("Select * from sorular where `cevaplanmis`= 1 and`hedefid`=" + getHedefid());
                    for (int i = 0; i < sorular.Rows.Count; i++)
                    {
                        listBox1.Items.Add("-?-");
                        listBox1.Items.Add("+  " + sorular.Rows[i].ItemArray[1].ToString());
                        listBox1.Items.Add("-  " + sorular.Rows[i].ItemArray[2].ToString());
                    }
                }

            }
            else
            {
                bool isTaken = false;

                for (int i = 0; i < UserKategori.Count; i++)
                {
                    if (UserKategori[i].ToString() == getHedefid().ToString())
                    {
                        isTaken = true;
                    }

                }
                if (isTaken)
                {
                    panel1.Visible = false;
                    sorular = connection.query("Select * from sorular where `cevaplanmis`= 1 and`hedefid`=" + getHedefid());
                    for (int i = 0; i < sorular.Rows.Count; i++)
                    {
                        listBox1.Items.Add("-?-");
                        listBox1.Items.Add("+  " + sorular.Rows[i].ItemArray[1].ToString());
                        listBox1.Items.Add("-  " + sorular.Rows[i].ItemArray[2].ToString());
                    }
                }
                else
                {
                    CustomizePanel(getHedefid());
                    panel1.Visible = true;
                    listBox1.Items.Clear();
                }
            }
        }

        private void textbox_question_TextChanged(object sender, EventArgs e)
        {
            int length = textbox_questions.Text.Length;
            if (length < 45)
            {
                textbox_questions.ShadowDecoration.BorderRadius = 19;
                textbox_questions.Height = 40;
            }
            if (length > 45 && length < 90)
            {
                textbox_questions.ShadowDecoration.BorderRadius = 39;
                textbox_questions.Height = 80;
            }
            if (length > 90)
            {
                textbox_questions.ShadowDecoration.BorderRadius = 41;
                textbox_questions.Height = 85;
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (teachermode == false)
            {
                try
                {
                    if (!String.IsNullOrEmpty(textbox_questions.Text))
                    {
                        if (ComboBox.Items.Count != 0)
                        {
                            connection.NonQuery("INSERT INTO `sorular`(`soru`,`hedefid`) VALUES ('" + textbox_questions.Text + "'," + getHedefid() + ")");
                            new form_message("Sorunuz Alındı!", false).Show();

                            textbox_questions.Text = "";
                        }

                    }

                }
                catch (Exception UploadEx)
                {
                    Console.WriteLine(UploadEx);
                    new form_message("Bir Hata Oluştu \n Soru Yüklenemedi!", false).Show();
                }


            }
            else
            {
                if (btn_save.Text == "Yayınla")
                {
                    try
                    {
                        if ((!String.IsNullOrEmpty(textbox_questions.Text) && (!String.IsNullOrEmpty(textbox_teachermode.Text))))
                        {

                            if (listBox1.SelectedItems.Count == 0)
                            {
                                Console.WriteLine("insert");
                                connection.NonQuery("INSERT INTO `sorular`( `soru`, `cevap`, `hedefid`, `cevaplanmis`) VALUES ('" + textbox_teachermode.Text + "','" + textbox_questions.Text + "',10,1)");
                                new form_message("Cevap Yayınlandı!", false).Show();
                                textbox_questions.Text = "";
                                textbox_teachermode.Text = "";
                            }
                            else if ((listBox1.SelectedItem.ToString().Substring(1).TrimStart() != textbox_teachermode.Text))
                            {
                                Console.WriteLine("insert");
                                connection.NonQuery("INSERT INTO `sorular`( `soru`, `cevap`, `hedefid`, `cevaplanmis`) VALUES ('" + textbox_teachermode.Text + "','" + textbox_questions.Text + "',10,1)");
                                new form_message("Cevap Yayınlandı!", false).Show();
                                textbox_questions.Text = "";
                                textbox_teachermode.Text = "";
                            }
                            else
                            {
                                Console.WriteLine("update");
                                connection.NonQuery("UPDATE `sorular` SET `soru`='" + textbox_teachermode.Text + "',`cevap`='" + textbox_questions.Text + "',`hedefid`='" + getHedefid() + "',`cevaplanmis`='1' WHERE `id`=" + sorular.Rows[(listBox1.SelectedIndex - 3) / 4].ItemArray[0]);
                                new form_message("Cevap Yayınlandı!", false).Show();
                                textbox_questions.Text = "";
                                textbox_teachermode.Text = "";
                            }
                        }
                    }
                    catch (Exception UploadEx)
                    {
                        Console.WriteLine(UploadEx.Message);
                        new form_message("Bir Hata Oluştu \n Soru Yüklenemedi!", false).Show();
                    }
                }
                else
                {
                    try
                    {
                        if (!String.IsNullOrEmpty(textbox_questions.Text))
                        {
                            if (ComboBox.Items.Count != 0)
                            {
                                connection.NonQuery("INSERT INTO `sorular`(`soru`,`hedefid`) VALUES ('" + textbox_questions.Text + "'," + getHedefid() + ")");
                                new form_message("Sorunuz Alındı!", false).Show();

                                textbox_questions.Text = "";
                            }

                        }

                    }
                    catch (Exception UploadEx)
                    {
                        Console.WriteLine(UploadEx);
                        new form_message("Bir Hata Oluştu \n Soru Yüklenemedi!", false).Show();
                    }
                }
            }
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string str = listBox1.Items[e.Index].ToString();

            SizeF stringSize = e.Graphics.MeasureString(str, listBox1.Font);

            PointF pos = new PointF((e.Bounds.Width / 2) - (stringSize.Width / 2), e.Bounds.Y);
            if (teachermode == false)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e = new DrawItemEventArgs(e.Graphics,
                                              e.Font,
                                              e.Bounds,
                                              e.Index,
                                              e.State ^ DrawItemState.Selected,
                                              Color.Black,
                                              Color.FromArgb(234, 234, 234));
            }
            else
            {
                if (currentTeacherMode)
                {
                    if (e.Index % 2 == 1)
                    {
                        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                            e = new DrawItemEventArgs(e.Graphics,
                                                      e.Font,
                                                      e.Bounds,
                                                      e.Index,
                                                      e.State ^ DrawItemState.Selected,
                                                      Color.Black,
                                                      Color.FromArgb(112, 112, 112));
                    }
                    else
                    {
                        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                            e = new DrawItemEventArgs(e.Graphics,
                                                      e.Font,
                                                      e.Bounds,
                                                      e.Index,
                                                      e.State ^ DrawItemState.Selected,
                                                      Color.Black,
                                                      Color.FromArgb(234, 234, 234));
                    }
                }
                else
                {
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        e = new DrawItemEventArgs(e.Graphics,
                                                  e.Font,
                                                  e.Bounds,
                                                  e.Index,
                                                  e.State ^ DrawItemState.Selected,
                                                  Color.Black,
                                                  Color.FromArgb(234, 234, 234));
                }

            }


            e.DrawBackground();
            if (teachermode == true)
            {
                if (currentTeacherMode)
                {
                    if (e.Index % 2 == 0) e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), pos);
                    else e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);

                }
                else
                {
                    if (e.Index % 3 == 0) e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), pos);
                    else e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);

                }

            }
            else
            {
                if (e.Index % 3 == 0) e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), pos);
                else e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        private void textbox_teachermode_TextChanged(object sender, EventArgs e)
        {
            int length = textbox_teachermode.Text.Length;
            if (length < 45)
            {
                textbox_teachermode.Location = new Point(26, 345);
                textbox_teachermode.ShadowDecoration.BorderRadius = 19;
                textbox_teachermode.Height = 40;
            }
            if (length > 45 && length < 90)
            {
                textbox_teachermode.Location = new Point(26, 305);
                textbox_teachermode.ShadowDecoration.BorderRadius = 39;
                textbox_teachermode.Height = 80;
            }
            if (length > 90)
            {
                textbox_teachermode.Location = new Point(26, 305);
                textbox_teachermode.ShadowDecoration.BorderRadius = 41;
                textbox_teachermode.Height = 85;
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getHedefid();
            listBox1.Items.Clear();
            listbox_fill();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex % 2 == 1)
            {
                textbox_teachermode.Text = listBox1.SelectedItem.ToString().Substring(1).TrimStart();
            }
        }
        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            ListBox searchList = new ListBox();
            searchList.Items.Clear();
            List<int> addedItems = new List<int>();
            Boolean isExists = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToUpper().Contains(textbox_search.Text.ToUpper()))
                {
                    for (int j = 0; j < addedItems.Count; j++)
                    {
                        if (addedItems[j] == i)
                        {
                            isExists = true;
                        }
                    }
                    if (isExists == false)
                    {
                        if (currentTeacherMode == true)
                        {
                            addedItems.Add(i);
                            addedItems.Add(i - 1);
                            searchList.Items.Add(listBox1.Items[i - 1]);
                            searchList.Items.Add(listBox1.Items[i]);
                        }
                        else
                        {
                            if (i % 3 == 1)
                            {
                                addedItems.Add(i - 1);
                                addedItems.Add(i);
                                addedItems.Add(i + 1);
                                searchList.Items.Add(listBox1.Items[i - 1]);
                                searchList.Items.Add(listBox1.Items[i]);
                                searchList.Items.Add(listBox1.Items[i + 1]);
                            }
                            if (i % 3 == 2)
                            {
                                addedItems.Add(i - 2);
                                addedItems.Add(i - 1);
                                addedItems.Add(i);
                                searchList.Items.Add(listBox1.Items[i - 2]);
                                searchList.Items.Add(listBox1.Items[i - 1]);
                                searchList.Items.Add(listBox1.Items[i]);
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(textbox_search.Text))
            {
                searchList.Items.Clear();
                listBox1.Items.Clear();
                listbox_fill();
            }
            else
            {
                listBox1.Items.Clear();
                for (int i = 0; i < searchList.Items.Count; i++)
                {
                    listBox1.Items.Add(searchList.Items[i]);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
