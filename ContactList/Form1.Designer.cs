namespace ContactList
{
    partial class MainForm
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
            this.lbl_DSLH = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DSLH
            // 
            this.lbl_DSLH.AutoSize = true;
            this.lbl_DSLH.ForeColor = System.Drawing.Color.Gold;
            this.lbl_DSLH.Location = new System.Drawing.Point(527, 148);
            this.lbl_DSLH.Name = "lbl_DSLH";
            this.lbl_DSLH.Size = new System.Drawing.Size(241, 32);
            this.lbl_DSLH.TabIndex = 0;
            this.lbl_DSLH.Text = "Danh sách liên hệ";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(522, 486);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(232, 63);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm liên hệ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1349, 746);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_DSLH);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DSLH;
        private System.Windows.Forms.Button btn_Add;
    }
}

