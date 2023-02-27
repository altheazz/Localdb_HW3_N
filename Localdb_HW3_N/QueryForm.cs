using Localdb_HW3_N.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Localdb_HW3_N
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ContactsModel context = new ContactsModel();
               


                var pdid = context.Table.Where((x) => x.Id == textBox1.Text);
                
                
               
                    dataGridView1.DataSource = pdid.ToList();
                
                    

                


               
                context.SaveChanges();
                //MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.ToString()}");
            }
        }
        //private void BindData()
        //{
        //    var context = new ContactsModel();
        //    var list = context.Table.ToList();
        //    dataGridView1.DataSource= list;
        //}
        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }

        
    }
}
