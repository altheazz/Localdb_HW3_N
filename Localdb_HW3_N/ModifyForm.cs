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

namespace Localdb_HW3_N
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ContactsModel context = new ContactsModel();
               


                var pdid = context.Table.Where((x) => x.Id == textBox1.Text);
                foreach (var item in pdid)
                {
                    
                    item.Id = textBox1.Text;
                    item.Name = textBox2.Text;
                    item.Num = textBox3.Text;
                    item.Price= textBox4.Text;
                    item.Pdtype = textBox5.Text;

                }


               
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.ToString()}");
            }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
