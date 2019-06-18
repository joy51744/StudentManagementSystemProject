using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Project
{
    public partial class Picture : Form
    {
        public static string conmmsy = @"Data Source=PC-PC;Initial Catalog=ManagementSystemDataBase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private DataTable dtPP = new DataTable();//用来存放从数据库里查询出来的图片数据
        private static int i = 0;//用来存放显示第几张图片
        private static string id = "";//存放图片的ID

        public Picture()
        {
            InitializeComponent();
        }

        private void bttStart_Click(object sender, EventArgs e)
        {
            if (dtPP != null)
            {
                showPP(0);
            }
            else { MessageBox.Show("不好意思，您還未上傳圖片ㄛ"); }
        }

        private void showPP(int i)
        {
            SqlConnection con = new SqlConnection(conmmsy); //实例化SQLconnection类。连接数据库
            con.Open();
            try
            {
                string SQLstr = "select ID,image from Image";  //设置SQL语句
                SqlDataAdapter ada = new SqlDataAdapter(SQLstr, con);//建立SQL语句与数据库的连接
                DataSet ds = new DataSet();  //实例化Datatable类
                ada.Fill(ds); //添加SQL并且执行
                dtPP = ds.Tables[0];
                if (dtPP.Rows.Count >= 1)
                {
                    byte[] imagebytes = null;
                    imagebytes = (byte[])ds.Tables[0].Rows[i]["image"];
                    id = ds.Tables[0].Rows[i]["ID"].ToString().Trim();
                    MemoryStream ms = new MemoryStream(imagebytes);
                    Bitmap bmpt = new Bitmap(ms);
                    pictureBox1.Image = bmpt;
                    //dataGridView1.Columns["Ime"].DataPropertyName = "imagetxt"; //赋值到固定值
                    ////dataGridView1.Columns["khbh"].DataPropertyName = "khbh";
                    //this.dataGridView1.DataSource = ds.Tables[0].DefaultView;//显示数据
                }

                this.label1.Text = "第" + (i + 1).ToString().Trim() + "張圖片/共" + dtPP.Rows.Count.ToString() + "張圖片";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "不好意思，您還未上傳圖片ㄛ！請檢查下查詢條件!");
                return;
            }
            finally
            { con.Close(); }
        }

        private void bttUp_Click(object sender, EventArgs e)
        {
            if (dtPP != null)
            {
                if (i == 0)
                {
                    MessageBox.Show("已經是第一張圖片了");
                    return;
                }
                else
                {
                    i = i - 1;
                    showPP(i);
                }
            }
            else { MessageBox.Show("不好意思，您還未上傳圖片ㄛ"); }
        }

        private void bttDown_Click(object sender, EventArgs e)
        {
            int a = dtPP.Rows.Count - 1;
            if (dtPP != null)
            {
                if (i == a)
                {
                    MessageBox.Show("已經是最後一張圖片了");
                    return;
                }
                else
                {
                    i = i + 1;
                    showPP(i);
                }
            }
            else { MessageBox.Show("不好意思，您還未上傳圖片ㄛ"); }
        }

        private void bttEnd_Click(object sender, EventArgs e)
        {
            if (dtPP != null)
            {
                i = dtPP.Rows.Count - 1;
                if (i >= 0)
                {
                    showPP(i);
                }
                else
                {
                    return;
                }
            }
            else { MessageBox.Show("不好意思，您還未上傳圖片ㄛ"); }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}