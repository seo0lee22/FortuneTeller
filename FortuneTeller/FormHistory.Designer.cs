namespace FortuneTeller
{
    partial class FormHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRefrsh = new System.Windows.Forms.Button();
            this.IbHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonRefrsh
            // 
            this.buttonRefrsh.Location = new System.Drawing.Point(557, 12);
            this.buttonRefrsh.Name = "buttonRefrsh";
            this.buttonRefrsh.Size = new System.Drawing.Size(231, 65);
            this.buttonRefrsh.TabIndex = 0;
            this.buttonRefrsh.Text = "새로 불러오기";
            this.buttonRefrsh.UseVisualStyleBackColor = true;
            this.buttonRefrsh.Click += new System.EventHandler(this.buttonRefrsh_Click);
            // 
            // IbHistory
            // 
            this.IbHistory.FormattingEnabled = true;
            this.IbHistory.ItemHeight = 12;
            this.IbHistory.Items.AddRange(new object[] {
            "2025-08-04 13:12:11 dd",
            "2025-08-04 13:12:11 dd",
            "2025-08-04 13:12:11 dd",
            "2025-08-04 13:12:11 dd",
            "2025-08-04 13:12:11 dd"});
            this.IbHistory.Location = new System.Drawing.Point(12, 84);
            this.IbHistory.Name = "IbHistory";
            this.IbHistory.Size = new System.Drawing.Size(776, 352);
            this.IbHistory.TabIndex = 1;
            this.IbHistory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IbHistory);
            this.Controls.Add(this.buttonRefrsh);
            this.Name = "FormHistory";
            this.Text = "FromHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRefrsh;
        private System.Windows.Forms.ListBox IbHistory;
    }
}