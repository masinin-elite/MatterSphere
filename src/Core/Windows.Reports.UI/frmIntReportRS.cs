namespace FWBS.OMS.UI.Windows.Reports
{
    /// <summary>
    /// Summary description for frmIntReport.
    /// </summary>
    public class frmIntReportRS : FWBS.OMS.UI.Windows.BaseForm
    {
        public ucReportsViewRS ucReportsView1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmIntReportRS(IMainParent mainparent)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntReportRS));
            this.ucReportsView1 = new FWBS.OMS.UI.Windows.Reports.ucReportsViewRS();
            this.SuspendLayout();
            // 
            // ucReportsView1
            // 
            this.ucReportsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReportsView1.Location = new System.Drawing.Point(0, 0);
            this.ucReportsView1.Name = "ucReportsView1";
            this.ucReportsView1.Size = new System.Drawing.Size(784, 501);
            this.ucReportsView1.TabIndex = 1;
            // 
            // frmIntReportRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.ucReportsView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmIntReportRS";
            this.Text = "Reports";
            this.ResumeLayout(false);

		}
		#endregion
	}
}
