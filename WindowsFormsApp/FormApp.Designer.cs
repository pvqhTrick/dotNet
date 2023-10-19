namespace WindowsFormsApp
{
    partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.rtbKq = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tính toán cơ bản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số thứ nhất : ";
            // 
            // txta
            // 
            this.txta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txta.Location = new System.Drawing.Point(190, 122);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(640, 20);
            this.txta.TabIndex = 0;
            this.txta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb.Location = new System.Drawing.Point(190, 173);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(640, 20);
            this.txtb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số thứ hai : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btncong
            // 
            this.btncong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncong.Location = new System.Drawing.Point(191, 231);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(144, 71);
            this.btncong.TabIndex = 2;
            this.btncong.Tag = "+";
            this.btncong.Text = "Cộng";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.Basic);
            // 
            // btntru
            // 
            this.btntru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntru.Location = new System.Drawing.Point(362, 231);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(144, 71);
            this.btntru.TabIndex = 3;
            this.btntru.Tag = "-";
            this.btntru.Text = "Trừ";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.Basic);
            // 
            // btnnhan
            // 
            this.btnnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhan.Location = new System.Drawing.Point(527, 231);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(144, 71);
            this.btnnhan.TabIndex = 4;
            this.btnnhan.Tag = "*";
            this.btnnhan.Text = "Nhân";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.Basic);
            // 
            // btnchia
            // 
            this.btnchia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchia.Location = new System.Drawing.Point(686, 231);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(144, 71);
            this.btnchia.TabIndex = 5;
            this.btnchia.Tag = "/";
            this.btnchia.Text = "Chia";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.Basic);
            // 
            // rtbKq
            // 
            this.rtbKq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbKq.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbKq.ForeColor = System.Drawing.SystemColors.Menu;
            this.rtbKq.Location = new System.Drawing.Point(190, 353);
            this.rtbKq.Name = "rtbKq";
            this.rtbKq.Size = new System.Drawing.Size(640, 88);
            this.rtbKq.TabIndex = 6;
            this.rtbKq.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kết quả: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(757, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Moi Moi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 511);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbKq);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình AI hack Nasa";
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.RichTextBox rtbKq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}