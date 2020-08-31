namespace DevExp.QLNH.Properties
{
    partial class ucFood
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFood));
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaHangDataSet = new DevExp.QLNH.QuanLyNhaHangDataSet();
            this.foodTableAdapter = new DevExp.QLNH.QuanLyNhaHangDataSetTableAdapters.FoodTableAdapter();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new DevExpress.XtraEditors.ButtonEdit();
            this.btnDelete = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.quanLyNhaHangDataSet;
            // 
            // quanLyNhaHangDataSet
            // 
            this.quanLyNhaHangDataSet.DataSetName = "QuanLyNhaHangDataSet";
            this.quanLyNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.idCategory,
            this.Price});
            this.dgvFood.Location = new System.Drawing.Point(38, 83);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(553, 383);
            this.dgvFood.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên món";
            this.Name.Name = "Name";
            this.Name.Width = 200;
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
            this.Price.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.EditValue = "SAVE";
            this.btnSave.Location = new System.Drawing.Point(617, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Properties.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Properties.Appearance.Options.UseBackColor = true;
            this.btnSave.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSave.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSave.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Properties.ContextImageOptions.Image")));
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.EditValue = "DELETE";
            this.btnDelete.Location = new System.Drawing.Point(617, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Properties.Appearance.Options.UseBackColor = true;
            this.btnDelete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDelete.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Properties.ContextImageOptions.Image")));
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.EditValueChanged += new System.EventHandler(this.buttonEdit1_EditValueChanged);
            // 
            // ucFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvFood);
            
            this.Size = new System.Drawing.Size(756, 424);
            this.Load += new System.EventHandler(this.ucFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource foodBindingSource;
        private QuanLyNhaHangDataSet quanLyNhaHangDataSet;
        private QuanLyNhaHangDataSetTableAdapters.FoodTableAdapter foodTableAdapter;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.ButtonEdit btnSave;
        private DevExpress.XtraEditors.ButtonEdit btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
