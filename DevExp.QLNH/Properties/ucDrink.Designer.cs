namespace DevExp.QLNH.Properties
{
    partial class ucDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDrink));
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.btnSave = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrink
            // 
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.idCategory,
            this.Price});
            this.dgvDrink.Location = new System.Drawing.Point(52, 54);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.Size = new System.Drawing.Size(449, 271);
            this.dgvDrink.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.EditValue = "SAVE";
            this.btnSave.Location = new System.Drawing.Point(596, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Properties.Appearance.Options.UseBackColor = true;
            this.btnSave.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSave.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSave.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Properties.ContextImageOptions.Image")));
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 1;
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.EditValue = "DELETE";
            this.buttonEdit2.Location = new System.Drawing.Point(596, 169);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit2.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit2.Properties.ContextImageOptions.Image")));
            this.buttonEdit2.Size = new System.Drawing.Size(100, 36);
            this.buttonEdit2.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên món";
            this.Name.Name = "Name";
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Category";
            this.idCategory.Name = "idCategory";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            // 
            // ucDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEdit2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDrink);
         //   this.Name = "ucDrink";
            this.Size = new System.Drawing.Size(749, 406);
            this.Load += new System.EventHandler(this.ucDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrink;
        private DevExpress.XtraEditors.ButtonEdit btnSave;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
