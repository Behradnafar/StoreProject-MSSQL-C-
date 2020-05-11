namespace SuperMarket
{
    partial class FReceipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSumPrice = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGoodsSearch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblItemPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblItemName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSearchCustomerId = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblCustomerTel = new System.Windows.Forms.Label();
            this.LblCustomerAddress = new System.Windows.Forms.Label();
            this.LblCustomerFamily = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblReceiptNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCommit = new System.Windows.Forms.Button();
            this.BtnNextReceipt = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(157, 472);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(143, 54);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete Item ?";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.LblSumPrice);
            this.groupBox6.Controls.Add(this.LblTotal);
            this.groupBox6.Location = new System.Drawing.Point(456, 472);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(504, 54);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(199, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "CAD";
            // 
            // LblSumPrice
            // 
            this.LblSumPrice.AutoSize = true;
            this.LblSumPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSumPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.LblSumPrice.Location = new System.Drawing.Point(82, 23);
            this.LblSumPrice.Name = "LblSumPrice";
            this.LblSumPrice.Size = new System.Drawing.Size(16, 22);
            this.LblSumPrice.TabIndex = 13;
            this.LblSumPrice.Text = ".";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(20, 23);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(56, 19);
            this.LblTotal.TabIndex = 12;
            this.LblTotal.Text = "Total :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(456, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(504, 437);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receipet";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(492, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 54);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnGoodsSearch);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.LblQuantity);
            this.groupBox4.Controls.Add(this.LblItemPrice);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.LblItemName);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(7, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(443, 193);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // BtnGoodsSearch
            // 
            this.BtnGoodsSearch.Location = new System.Drawing.Point(286, 14);
            this.BtnGoodsSearch.Name = "BtnGoodsSearch";
            this.BtnGoodsSearch.Size = new System.Drawing.Size(36, 22);
            this.BtnGoodsSearch.TabIndex = 7;
            this.BtnGoodsSearch.Text = "...";
            this.BtnGoodsSearch.UseVisualStyleBackColor = true;
            this.BtnGoodsSearch.Click += new System.EventHandler(this.BtnGoodsSearch_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblQuantity.Location = new System.Drawing.Point(382, 104);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(14, 19);
            this.LblQuantity.TabIndex = 4;
            this.LblQuantity.Text = ".";
            // 
            // LblItemPrice
            // 
            this.LblItemPrice.AutoSize = true;
            this.LblItemPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblItemPrice.Location = new System.Drawing.Point(162, 104);
            this.LblItemPrice.Name = "LblItemPrice";
            this.LblItemPrice.Size = new System.Drawing.Size(14, 19);
            this.LblItemPrice.TabIndex = 3;
            this.LblItemPrice.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Number of Order:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Item Quantity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Item Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Item Name:";
            // 
            // LblItemName
            // 
            this.LblItemName.AutoSize = true;
            this.LblItemName.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblItemName.Location = new System.Drawing.Point(162, 61);
            this.LblItemName.Name = "LblItemName";
            this.LblItemName.Size = new System.Drawing.Size(14, 19);
            this.LblItemName.TabIndex = 1;
            this.LblItemName.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Item Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSearchCustomerId);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.LblCustomerTel);
            this.groupBox3.Controls.Add(this.LblCustomerAddress);
            this.groupBox3.Controls.Add(this.LblCustomerFamily);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.LblCustomerName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 187);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // BtnSearchCustomerId
            // 
            this.BtnSearchCustomerId.Location = new System.Drawing.Point(280, 14);
            this.BtnSearchCustomerId.Name = "BtnSearchCustomerId";
            this.BtnSearchCustomerId.Size = new System.Drawing.Size(36, 22);
            this.BtnSearchCustomerId.TabIndex = 6;
            this.BtnSearchCustomerId.Text = "...";
            this.BtnSearchCustomerId.UseVisualStyleBackColor = true;
            this.BtnSearchCustomerId.Click += new System.EventHandler(this.BtnSearchCustomerId_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblCustomerTel
            // 
            this.LblCustomerTel.AutoSize = true;
            this.LblCustomerTel.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblCustomerTel.Location = new System.Drawing.Point(141, 147);
            this.LblCustomerTel.Name = "LblCustomerTel";
            this.LblCustomerTel.Size = new System.Drawing.Size(14, 19);
            this.LblCustomerTel.TabIndex = 5;
            this.LblCustomerTel.Text = ".";
            // 
            // LblCustomerAddress
            // 
            this.LblCustomerAddress.AutoSize = true;
            this.LblCustomerAddress.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblCustomerAddress.Location = new System.Drawing.Point(141, 106);
            this.LblCustomerAddress.Name = "LblCustomerAddress";
            this.LblCustomerAddress.Size = new System.Drawing.Size(14, 19);
            this.LblCustomerAddress.TabIndex = 4;
            this.LblCustomerAddress.Text = ".";
            this.LblCustomerAddress.Click += new System.EventHandler(this.label10_Click);
            // 
            // LblCustomerFamily
            // 
            this.LblCustomerFamily.AutoSize = true;
            this.LblCustomerFamily.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblCustomerFamily.Location = new System.Drawing.Point(378, 65);
            this.LblCustomerFamily.Name = "LblCustomerFamily";
            this.LblCustomerFamily.Size = new System.Drawing.Size(14, 19);
            this.LblCustomerFamily.TabIndex = 3;
            this.LblCustomerFamily.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tel. :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Customer Family:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Name:";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblCustomerName.Location = new System.Drawing.Point(141, 65);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(14, 19);
            this.LblCustomerName.TabIndex = 1;
            this.LblCustomerName.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblReceiptNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 57);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.DarkRed;
            this.LblDate.Location = new System.Drawing.Point(296, 23);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(14, 19);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = ".";
            this.LblDate.Click += new System.EventHandler(this.LblDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // LblReceiptNo
            // 
            this.LblReceiptNo.AutoSize = true;
            this.LblReceiptNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReceiptNo.ForeColor = System.Drawing.Color.Maroon;
            this.LblReceiptNo.Location = new System.Drawing.Point(142, 23);
            this.LblReceiptNo.Name = "LblReceiptNo";
            this.LblReceiptNo.Size = new System.Drawing.Size(16, 22);
            this.LblReceiptNo.TabIndex = 1;
            this.LblReceiptNo.Text = ".";
            this.LblReceiptNo.Click += new System.EventHandler(this.LblReceiptNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt Number:";
            // 
            // BtnCommit
            // 
            this.BtnCommit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCommit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommit.ForeColor = System.Drawing.Color.Maroon;
            this.BtnCommit.Location = new System.Drawing.Point(461, 550);
            this.BtnCommit.Name = "BtnCommit";
            this.BtnCommit.Size = new System.Drawing.Size(234, 38);
            this.BtnCommit.TabIndex = 1;
            this.BtnCommit.Text = "COMMIT Receipt && Close";
            this.BtnCommit.UseVisualStyleBackColor = false;
            this.BtnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            // 
            // BtnNextReceipt
            // 
            this.BtnNextReceipt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNextReceipt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextReceipt.ForeColor = System.Drawing.Color.Maroon;
            this.BtnNextReceipt.Location = new System.Drawing.Point(701, 550);
            this.BtnNextReceipt.Name = "BtnNextReceipt";
            this.BtnNextReceipt.Size = new System.Drawing.Size(258, 38);
            this.BtnNextReceipt.TabIndex = 2;
            this.BtnNextReceipt.Text = "COMMIT && NextReceipt >>";
            this.BtnNextReceipt.UseVisualStyleBackColor = false;
            this.BtnNextReceipt.Click += new System.EventHandler(this.BtnNextReceipt_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(16, 550);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(172, 38);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back to Main Menu";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FReceipt
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNextReceipt);
            this.Controls.Add(this.BtnCommit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.FReceipt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblCustomerFamily;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblReceiptNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCustomerAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblCustomerTel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblItemPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblItemName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label LblSumPrice;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearchCustomerId;
        private System.Windows.Forms.Button BtnGoodsSearch;
        private System.Windows.Forms.Button BtnCommit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNextReceipt;
        private System.Windows.Forms.Button BtnBack;
    }
}