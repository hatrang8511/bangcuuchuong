namespace bangcuuchuong
{
    partial class Form1
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
            this.nudBangCuuChuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lsbKQ = new System.Windows.Forms.ListBox();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBangCuuChuong)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBangCuuChuong
            // 
            this.nudBangCuuChuong.Location = new System.Drawing.Point(270, 166);
            this.nudBangCuuChuong.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudBangCuuChuong.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBangCuuChuong.Name = "nudBangCuuChuong";
            this.nudBangCuuChuong.Size = new System.Drawing.Size(120, 26);
            this.nudBangCuuChuong.TabIndex = 0;
            this.nudBangCuuChuong.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH HIỂN THỊ BẢNG CỬU CHƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn bảng cửu chương";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(16, 246);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(0, 20);
            this.lblKQ.TabIndex = 2;
            // 
            // lsbKQ
            // 
            this.lsbKQ.FormattingEnabled = true;
            this.lsbKQ.ItemHeight = 20;
            this.lsbKQ.Location = new System.Drawing.Point(144, 232);
            this.lsbKQ.Name = "lsbKQ";
            this.lsbKQ.Size = new System.Drawing.Size(148, 224);
            this.lsbKQ.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(440, 159);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(118, 32);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lsbKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBangCuuChuong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudBangCuuChuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBangCuuChuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.ListBox lsbKQ;
        private System.Windows.Forms.Button btnTinh;
    }
}

