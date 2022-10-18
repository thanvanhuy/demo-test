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

namespace Load_Data_Gridview
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=192.188.0.12;Initial Catalog=VVAETCCenter;Persist Security Info=True;User ID=sa;Password=VVASQL$%^47");
        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btn_Seach_Click(object sender, EventArgs e)
        {
 
            search(txt_date.Text);
            txt_date.Text = "";
        }
        public void search(string text)
        {
           
            if (txt_date.Text.Length==0)
            {
                load();
            }    
            else if(txt_date.Text.Length>0)
            {
                DataSet ds_pn = new DataSet();
                SqlDataAdapter da;
                con.Open();
                da = new SqlDataAdapter("select TicketID,MaThe,BienSoETC,BienSoCabin,NgayQuaTram,GioQuaTram,Phi from tblXeVao where PTTT = 1 and NgayQuaTram = '" + text + "' or GioQuaTram = '"+text+ "' or CAST((NgayQuaTram) As Date)='"+text+"' ", con);
                da.Fill(ds_pn, "tblXeVao");
                if (ds_pn.Tables["tblXeVao"].Rows.Count > 0)
                {
                    
                    dataGridView1.DataSource = ds_pn.Tables["tblXeVao"];

                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                    txt_date.Text = "";
                }
           con.Close();
            }    
           
        }

public void load()
        {
            DataSet ds_pn = new DataSet();
            SqlDataAdapter da;
            con.Open();
            //da = new SqlDataAdapter("SELECT * FROM MONHOC WHERE MASOMON LIKE N'%" + maso + "%'", con);

            da = new SqlDataAdapter("select TicketID,MaThe,BienSoETC,BienSoCabin,NgayQuaTram,GioQuaTram,Phi from tblXeVao where PTTT =1", con);
            da.Fill(ds_pn, "tblXeVao");
            dataGridView1.DataSource = ds_pn.Tables["tblXeVao"];
            con.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt";
        }

        private void btn_xuatfile_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xuất file ko?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                           
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
            }
            else
            {
                return ;
            }    
        }

        private void txt_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Seach.PerformClick();
        }
        private void txt_date_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.V && e.Modifiers == Keys.Control)
                (sender as TextBox).Paste();
        }

    }
}
