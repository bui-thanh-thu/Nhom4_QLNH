namespace DevExp.QLNH.Properties
{
    partial class ucNonEmptyTable
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
            this.flpNonEmpty = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpNonEmpty
            // 
            this.flpNonEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpNonEmpty.Location = new System.Drawing.Point(0, 0);
            this.flpNonEmpty.Name = "flpNonEmpty";
            this.flpNonEmpty.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flpNonEmpty.Size = new System.Drawing.Size(405, 508);
            this.flpNonEmpty.TabIndex = 0;
            // 
            // ucNonEmptyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpNonEmpty);
            this.Name = "ucNonEmptyTable";
            this.Size = new System.Drawing.Size(816, 508);
            this.Load += new System.EventHandler(this.ucNonEmptyTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpNonEmpty;
    }
}
