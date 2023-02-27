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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Table data = new Table()
            //{
            //    Id = textBox1.Text.Trim()

            //};
            try
            {
                ContactsModel context = new ContactsModel();
                //var pdid = context.Table.ToList();

                //Table tb = context.Table.Where((x) => x.Id == textBox1.Text).FirstOrDefault();
                //if (tb != null)
                //{
                //    context.Table.Remove(tb);
                //    context.SaveChanges();
                //    MessageBox.Show("存檔完成");
                //    ClearTextBoxes();
                //}

                var pdid = context.Table.Where((x) => x.Id == textBox1.Text);
                foreach (var item in pdid)
                {
                    context.Table.Remove(item);
                }


                //context.Table.Remove(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.ToString()}");
            }
        }
    }
}
