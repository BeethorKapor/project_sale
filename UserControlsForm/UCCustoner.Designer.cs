namespace projectsales.UserControlsForm
{
    partial class UCCustoner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustoner));
            this.dataGridViewCus = new System.Windows.Forms.DataGridView();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comBoxCGender = new System.Windows.Forms.ComboBox();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCSearch = new System.Windows.Forms.Button();
            this.txtCSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCus
            // 
            this.dataGridViewCus.AllowUserToAddRows = false;
            this.dataGridViewCus.AllowUserToDeleteRows = false;
            this.dataGridViewCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCus.Location = new System.Drawing.Point(43, 230);
            this.dataGridViewCus.Name = "dataGridViewCus";
            this.dataGridViewCus.ReadOnly = true;
            this.dataGridViewCus.RowTemplate.Height = 25;
            this.dataGridViewCus.Size = new System.Drawing.Size(644, 162);
            this.dataGridViewCus.TabIndex = 22;
            this.dataGridViewCus.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCus_CellMouseClick);
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.CustomFormat = "dd-MM-yyyy";
            this.dateTimeDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDOB.Location = new System.Drawing.Point(505, 73);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(151, 26);
            this.dateTimeDOB.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(414, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 28);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "ບັນທຶກ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(323, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 28);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "ແກ້ໄຂ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(231, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = " ລຶບ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comBoxCGender
            // 
            this.comBoxCGender.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxCGender.FormattingEnabled = true;
            this.comBoxCGender.Items.AddRange(new object[] {
            "ຍິງ",
            "ຊາຍ",
            "ບໍ່ລະບຸເພດ"});
            this.comBoxCGender.Location = new System.Drawing.Point(505, 38);
            this.comBoxCGender.Name = "comBoxCGender";
            this.comBoxCGender.Size = new System.Drawing.Size(150, 32);
            this.comBoxCGender.TabIndex = 17;
            // 
            // txtCAddress
            // 
            this.txtCAddress.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCAddress.Location = new System.Drawing.Point(156, 106);
            this.txtCAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCAddress.Multiline = true;
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(150, 24);
            this.txtCAddress.TabIndex = 13;
            this.txtCAddress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCAddress_MouseDown);
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCName.Location = new System.Drawing.Point(156, 70);
            this.txtCName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCName.Multiline = true;
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(150, 24);
            this.txtCName.TabIndex = 14;
            this.txtCName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCName_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(384, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "ວັນ/ເດືອນ/ປີເກີດ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGreen;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(458, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "ເພດ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(113, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "ທີ່ຢູ່:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "ຊື່:";
            // 
            // txtCTel
            // 
            this.txtCTel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCTel.Location = new System.Drawing.Point(506, 105);
            this.txtCTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCTel.Multiline = true;
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(150, 24);
            this.txtCTel.TabIndex = 15;
            this.txtCTel.TextChanged += new System.EventHandler(this.txtCTel_TextChanged);
            this.txtCTel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCTel_MouseDown);
            // 
            // txtCID
            // 
            this.txtCID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCID.Location = new System.Drawing.Point(156, 38);
            this.txtCID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCID.Multiline = true;
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(150, 24);
            this.txtCID.TabIndex = 16;
            this.txtCID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCID_KeyPress);
            this.txtCID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCID_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(409, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "ເບີໂທລະສັບ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "ລະຫັດລູກຄ້າ:";
            // 
            // btnCSearch
            // 
            this.btnCSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSearch.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCSearch.Image")));
            this.btnCSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSearch.Location = new System.Drawing.Point(574, 196);
            this.btnCSearch.Name = "btnCSearch";
            this.btnCSearch.Size = new System.Drawing.Size(81, 28);
            this.btnCSearch.TabIndex = 24;
            this.btnCSearch.Text = "ຄົ້ນຫາ";
            this.btnCSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCSearch.UseVisualStyleBackColor = true;
            this.btnCSearch.Click += new System.EventHandler(this.btnCSearch_Click);
            // 
            // txtCSearch
            // 
            this.txtCSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCSearch.Location = new System.Drawing.Point(413, 196);
            this.txtCSearch.Multiline = true;
            this.txtCSearch.Name = "txtCSearch";
            this.txtCSearch.Size = new System.Drawing.Size(155, 28);
            this.txtCSearch.TabIndex = 23;
            // 
            // UCCustoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.btnCSearch);
            this.Controls.Add(this.txtCSearch);
            this.Controls.Add(this.dataGridViewCus);
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comBoxCGender);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCTel);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "UCCustoner";
            this.Size = new System.Drawing.Size(731, 418);
            this.Load += new System.EventHandler(this.UCCustoner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewCus;
        private DateTimePicker dateTimeDOB;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private ComboBox comBoxCGender;
        private TextBox txtCAddress;
        private TextBox txtCName;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtCTel;
        private TextBox txtCID;
        private Label label6;
        private Label label1;
        private Button btnCSearch;
        private TextBox txtCSearch;
    }
}
