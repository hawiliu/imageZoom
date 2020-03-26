namespace imageZoom
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Width = new System.Windows.Forms.TextBox();
            this.tb_Height = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Width
            // 
            this.tb_Width.Location = new System.Drawing.Point(81, 13);
            this.tb_Width.Name = "tb_Width";
            this.tb_Width.Size = new System.Drawing.Size(100, 22);
            this.tb_Width.TabIndex = 0;
            this.tb_Width.Text = "90";
            // 
            // tb_Height
            // 
            this.tb_Height.Location = new System.Drawing.Point(81, 41);
            this.tb_Height.Name = "tb_Height";
            this.tb_Height.Size = new System.Drawing.Size(100, 22);
            this.tb_Height.TabIndex = 1;
            this.tb_Height.Text = "120";
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(187, 13);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 2;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height：";
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "jpg",
            "png"});
            this.cb_Type.Location = new System.Drawing.Point(81, 69);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(100, 20);
            this.cb_Type.TabIndex = 5;
            this.cb_Type.Text = "jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "SaveType：";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 103);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.tb_Height);
            this.Controls.Add(this.tb_Width);
            this.Name = "mainForm";
            this.Text = "ImageZoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Width;
        private System.Windows.Forms.TextBox tb_Height;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Label label3;
    }
}

