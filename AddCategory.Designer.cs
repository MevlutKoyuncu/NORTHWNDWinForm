namespace NORTHWNDWinForm
{
    partial class AddCategory
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
            this.btn_catadd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_catdesc = new System.Windows.Forms.TextBox();
            this.tb_catno = new System.Windows.Forms.TextBox();
            this.tb_catname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_catedit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_catadd
            // 
            this.btn_catadd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_catadd.Location = new System.Drawing.Point(377, 264);
            this.btn_catadd.Name = "btn_catadd";
            this.btn_catadd.Size = new System.Drawing.Size(120, 53);
            this.btn_catadd.TabIndex = 0;
            this.btn_catadd.Text = "Kategoriyi Ekle";
            this.btn_catadd.UseVisualStyleBackColor = true;
            this.btn_catadd.Click += new System.EventHandler(this.btn_catadd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_catdesc);
            this.groupBox1.Controls.Add(this.tb_catno);
            this.groupBox1.Controls.Add(this.tb_catname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // tb_catdesc
            // 
            this.tb_catdesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_catdesc.Location = new System.Drawing.Point(162, 113);
            this.tb_catdesc.MaximumSize = new System.Drawing.Size(307, 88);
            this.tb_catdesc.MinimumSize = new System.Drawing.Size(307, 88);
            this.tb_catdesc.Multiline = true;
            this.tb_catdesc.Name = "tb_catdesc";
            this.tb_catdesc.Size = new System.Drawing.Size(307, 88);
            this.tb_catdesc.TabIndex = 2;
            // 
            // tb_catno
            // 
            this.tb_catno.Enabled = false;
            this.tb_catno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_catno.Location = new System.Drawing.Point(162, 30);
            this.tb_catno.Name = "tb_catno";
            this.tb_catno.Size = new System.Drawing.Size(307, 32);
            this.tb_catno.TabIndex = 1;
            // 
            // tb_catname
            // 
            this.tb_catname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_catname.Location = new System.Drawing.Point(162, 70);
            this.tb_catname.Name = "tb_catname";
            this.tb_catname.Size = new System.Drawing.Size(307, 32);
            this.tb_catname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aciklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Ismi";
            // 
            // btn_catedit
            // 
            this.btn_catedit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_catedit.Location = new System.Drawing.Point(377, 264);
            this.btn_catedit.Name = "btn_catedit";
            this.btn_catedit.Size = new System.Drawing.Size(120, 53);
            this.btn_catedit.TabIndex = 0;
            this.btn_catedit.Text = "Kategoriyi Duzenle";
            this.btn_catedit.UseVisualStyleBackColor = true;
            this.btn_catedit.Click += new System.EventHandler(this.btn_catedit_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_catadd);
            this.Controls.Add(this.btn_catedit);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_catadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_catname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_catdesc;
        private System.Windows.Forms.TextBox tb_catno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_catedit;
    }
}