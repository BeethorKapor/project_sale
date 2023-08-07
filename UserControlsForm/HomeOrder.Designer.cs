namespace projectsales.UserControlsForm
{
    partial class HomeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeOrder));
            this.btnMCustomer = new System.Windows.Forms.Button();
            this.btnGCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMCustomer
            // 
            this.btnMCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMCustomer.Font = new System.Drawing.Font("Saysettha OT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnMCustomer.Image")));
            this.btnMCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMCustomer.Location = new System.Drawing.Point(38, 169);
            this.btnMCustomer.Name = "btnMCustomer";
            this.btnMCustomer.Size = new System.Drawing.Size(294, 125);
            this.btnMCustomer.TabIndex = 0;
            this.btnMCustomer.Text = "ລູກຄ້າສະມາຊິກ";
            this.btnMCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMCustomer.UseVisualStyleBackColor = false;
            this.btnMCustomer.Click += new System.EventHandler(this.btnMCustomer_Click);
            // 
            // btnGCustomer
            // 
            this.btnGCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGCustomer.BackColor = System.Drawing.Color.Chartreuse;
            this.btnGCustomer.Font = new System.Drawing.Font("Saysettha OT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnGCustomer.Image")));
            this.btnGCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGCustomer.Location = new System.Drawing.Point(373, 169);
            this.btnGCustomer.Name = "btnGCustomer";
            this.btnGCustomer.Size = new System.Drawing.Size(294, 125);
            this.btnGCustomer.TabIndex = 0;
            this.btnGCustomer.Text = "ລູກຄ້າທົ່ວໄປ";
            this.btnGCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGCustomer.UseVisualStyleBackColor = false;
            this.btnGCustomer.Click += new System.EventHandler(this.btnGCustomer_Click);
            // 
            // HomeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnGCustomer);
            this.Controls.Add(this.btnMCustomer);
            this.Name = "HomeOrder";
            this.Size = new System.Drawing.Size(731, 418);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMCustomer;
        private Button btnGCustomer;
    }
}
