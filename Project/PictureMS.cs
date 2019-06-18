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
    public partial class PictureMS : Form
    {
        public PictureMS()
        {
            InitializeComponent();
        }

        private void bttInsertPP_Click(object sender, EventArgs e)
        {
            insertPP();
            bttStart_Click(null, null);
        }

        public static string conmmsy = @"Data Source=PC-PC;Initial Catalog=ManagementSystemDataBase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private DataTable dtPP = new DataTable();//用来存放从数据库里查询出来的图片数据
        private static int i = 0;//用来存放显示第几张图片
        private static string id = "";//存放图片的ID

        //插入图片
        public void insertPP()
        {
            openFileDialog1.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";
            SqlConnection con = new SqlConnection(conmmsy);
            con.Open();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;//文件路径
                    //创建文件流，path参数是文件路径
                    FileStream fs = new FileStream(path, FileMode.Open);
                    int streamLength = (int)fs.Length;  //获取文件流的长度。
                    byte[] image = new byte[streamLength];    //声明字节数组，用于保存图片文件
                    fs.Read(image, 0, streamLength);    //把图片文件转换成为字节数组保存
                    fs.Close();
                    //插入Sql语句，@img是Sql语句参数。
                    string sql = string.Format("insert Image values(@image)", image);
                    SqlCommand com = new SqlCommand(sql, con); //con是一个有效的连接对象
                                                               //为命令对象添加参数，注意参数的类型
                    com.Parameters.Add(new SqlParameter("image", SqlDbType.Binary, image.Length,
                    ParameterDirection.Input, true, 0, 0, null, DataRowVersion.Default, image));
                    com.ExecuteNonQuery();   //执行
                    MessageBox.Show("插入成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "插入图片不成功");
            }
            finally
            {
                con.Close();
            }
        }

        //显示图片
        public void showPP(int i)
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

        private void bttStart_Click(object sender, EventArgs e)
        {
            if (dtPP != null)
            {
                showPP(0);
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

        private void bttShowPP_Click(object sender, EventArgs e)
        {
            if (dtPP != null)
            {
                showPP(0);
            }
        }

        private void PictureMS_Load(object sender, EventArgs e)
        {
            bttStart_Click(null, null);
        }

        private void bttDeletePP_Click(object sender, EventArgs e)
        {
            deletePP();
            if (dtPP != null)
            {
                if (i == 0)
                {
                    this.pictureBox1.Image = null;
                    return;
                }
                else
                {
                    i = i - 1;
                    showPP(i);
                }
            }
            else { this.pictureBox1.Image = null; return; }
        }

        //删除图片
        public void deletePP()
        {
            SqlConnection con = new SqlConnection(conmmsy);
            con.Open();
            try
            {
                string sqlstring = "delete Image where ID='" + id + "'";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗，失敗原因" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            updatePP(id);
            if (dtPP != null)
            {
                showPP(i);
            }
            else { MessageBox.Show("不好意思，您還未上傳圖片ㄛ"); }
        }

        public void updatePP(string id)
        {
            openFileDialog1.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";
            SqlConnection con = new SqlConnection(conmmsy);
            con.Open();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;//文件路径
                    //创建文件流，path参数是文件路径
                    FileStream fs = new FileStream(path, FileMode.Open);
                    int streamLength = (int)fs.Length;  //获取文件流的长度。
                    byte[] image = new byte[streamLength];    //声明字节数组，用于保存图片文件
                    fs.Read(image, 0, streamLength);    //把图片文件转换成为字节数组保存
                    fs.Close();
                    //插入Sql语句，@img是Sql语句参数。
                    string sql = string.Format("update Image set image=(@image) where ID='" + id + "'", image);
                    SqlCommand com = new SqlCommand(sql, con); //con是一个有效的连接对象
                    //为命令对象添加参数，注意参数的类型
                    com.Parameters.Add(new SqlParameter("image", SqlDbType.Binary, image.Length,
                    ParameterDirection.Input, true, 0, 0, null, DataRowVersion.Default, image));
                    com.ExecuteNonQuery();   //执行
                    MessageBox.Show("修改成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "修改圖片不成功");
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Width = 600;
            this.pictureBox1.Height = 400;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("真的要退出嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;
        }
    }
}