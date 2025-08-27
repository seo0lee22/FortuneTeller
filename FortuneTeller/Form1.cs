using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class Form1 : Form
    {
        List<string> results;
        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string filename = "result.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show($"파일을 불러올 수 없습니다.\n{ex.Message}", "파일 없음.")
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근권한이 없습니다.\n{ex.Message}", "권한 문제.")
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "알 수 없는 오류.")
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory();
                form.Show();
            }
        }

        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 표춘텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout from = new FormAbout();
            from.ShowDialog();
        }
    }
}
