namespace DevExp.QLNH.Properties
{
    partial class ucEmptyTable
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flpTable.Size = new System.Drawing.Size(405, 508);
            this.flpTable.TabIndex = 0;
            // 
            // ucEmptyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpTable);
            this.Name = "ucEmptyTable";
            this.Size = new System.Drawing.Size(816, 508);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}
