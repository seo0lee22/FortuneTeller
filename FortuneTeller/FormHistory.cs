using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class FormHistory : Form
    {
        List<string> history;
        Form1 form1;

        public FormHistory(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();
            UpdateHistory();
        }

        public void UpdateHistory()
        {
            LoadHistory();
            IbHistory.Items.Clear();
            IbHistory.Items.AddRange(history.ToArray());
        }

        private void LoadHistory()
        {
            try
            {
                string filename = "history.csv";
                history = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없어요.\n{ex.Message}", "파일 없음");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없어요.\n{ex.Message}", "권한 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefrsh_Click(object sender, EventArgs e)
        {
            UpdateHistory();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = history[IbHistory.SelectedIndex];
            form1.LoadHistory(message);
        }
    }
}
