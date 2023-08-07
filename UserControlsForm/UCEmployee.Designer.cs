namespace projectsales.UserControlsForm
{
    partial class UCEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEmployee));
            this.dateTimeEm = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewEm = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comBoxEGender = new System.Windows.Forms.ComboBox();
            this.txtEGmail = new System.Windows.Forms.TextBox();
            this.txtETel = new System.Windows.Forms.TextBox();
            this.txtEAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEm)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeEm
            // 
            this.dateTimeEm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeEm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEm.Location = new System.Drawing.Point(484, 32);
            this.dateTimeEm.Name = "dateTimeEm";
            this.dateTimeEm.Size = new System.Drawing.Size(150, 26);
            this.dateTimeEm.TabIndex = 25;
            // 
            // dataGridViewEm
            // 
            this.dataGridViewEm.AllowUserToAddRows = false;
            this.dataGridViewEm.AllowUserToDeleteRows = false;
            this.dataGridViewEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEm.Location = new System.Drawing.Point(16, 260);
            this.dataGridViewEm.Name = "dataGridViewEm";
            this.dataGridViewEm.ReadOnly = true;
            this.dataGridViewEm.RowTemplate.Height = 25;
            this.dataGridViewEm.Size = new System.Drawing.Size(691, 145);
            this.dataGridViewEm.TabIndex = 24;
            this.dataGridViewEm.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEm_CellMouseClick);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(559, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "  ບັນທຶກ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(478, 162);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "  ແກ້ໄຂ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(397, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = " ລຶບ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comBoxEGender
            // 
            this.comBoxEGender.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxEGender.FormattingEnabled = true;
            this.comBoxEGender.Items.AddRange(new object[] {
            "ຍິງ",
            "ຊາຍ"});
            this.comBoxEGender.Location = new System.Drawing.Point(177, 161);
            this.comBoxEGender.Name = "comBoxEGender";
            this.comBoxEGender.Size = new System.Drawing.Size(100, 32);
            this.comBoxEGender.TabIndex = 20;
            // 
            // txtEGmail
            // 
            this.txtEGmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEGmail.Location = new System.Drawing.Point(484, 98);
            this.txtEGmail.Multiline = true;
            this.txtEGmail.Name = "txtEGmail";
            this.txtEGmail.Size = new System.Drawing.Size(150, 24);
            this.txtEGmail.TabIndex = 18;
            this.txtEGmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEGmail_MouseDown);
            // 
            // txtETel
            // 
            this.txtETel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtETel.Location = new System.Drawing.Point(484, 65);
            this.txtETel.Multiline = true;
            this.txtETel.Name = "txtETel";
            this.txtETel.Size = new System.Drawing.Size(150, 24);
            this.txtETel.TabIndex = 17;
            this.txtETel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtETel_MouseDown);
            // 
            // txtEAddress
            // 
            this.txtEAddress.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEAddress.Location = new System.Drawing.Point(177, 131);
            this.txtEAddress.Multiline = true;
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.Size = new System.Drawing.Size(150, 24);
            this.txtEAddress.TabIndex = 19;
            this.txtEAddress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEAddress_MouseDown);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLName.Location = new System.Drawing.Point(177, 98);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(150, 24);
            this.txtLName.TabIndex = 16;
            this.txtLName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLName_MouseDown);
            // 
            // txtEName
            // 
            this.txtEName.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEName.Location = new System.Drawing.Point(177, 65);
            this.txtEName.Multiline = true;
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(150, 24);
            this.txtEName.TabIndex = 15;
            this.txtEName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEName_MouseDown);
            // 
            // txtEID
            // 
            this.txtEID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEID.Location = new System.Drawing.Point(177, 32);
            this.txtEID.Multiline = true;
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(150, 24);
            this.txtEID.TabIndex = 14;
            this.txtEID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEID_KeyPress);
            this.txtEID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEID_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(135, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "ເພດ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(368, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "ວັນ/ເດືອນ/ປີເກີດ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(432, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "ອີເມວ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(393, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "ເບີໂທລະສັບ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "ທີ່ຢູ່";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ນາມສະກຸນ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "ຊື່ພະນັກງານ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "ລະຫັດພະນັກງານ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(559, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 28);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "ຄົ້ນຫາ";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(397, 226);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 28);
            this.txtSearch.TabIndex = 26;
            // 
            // UCEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dateTimeEm);
            this.Controls.Add(this.dataGridViewEm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comBoxEGender);
            this.Controls.Add(this.txtEGmail);
            this.Controls.Add(this.txtETel);
            this.Controls.Add(this.txtEAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCEmployee";
            this.Size = new System.Drawing.Size(731, 418);
            this.Load += new System.EventHandler(this.UCEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimeEm;
        private DataGridView dataGridViewEm;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private ComboBox comBoxEGender;
        private TextBox txtEGmail;
        private TextBox txtETel;
        private TextBox txtEAddress;
        private TextBox txtLName;
        private TextBox txtEName;
        private TextBox txtEID;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
