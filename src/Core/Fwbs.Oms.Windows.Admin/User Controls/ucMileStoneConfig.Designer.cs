﻿namespace FWBS.OMS.UI.Windows.Admin
{
    partial class ucMileStoneConfig
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
            this.enquiryForm1 = new FWBS.OMS.UI.Windows.EnquiryForm();
            this.tpList.SuspendLayout();
            this.tpEdit.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.enquiryForm1);
            this.BresourceLookup1.SetLookup(this.tpEdit, new FWBS.OMS.UI.Windows.ResourceLookupItem("Edit", "Edit", ""));
            this.tpEdit.Controls.SetChildIndex(this.pnlEdit, 0);
            this.tpEdit.Controls.SetChildIndex(this.enquiryForm1, 0);
            // 
            // tbSave
            // 
            this.BresourceLookup1.SetLookup(this.tbSave, new FWBS.OMS.UI.Windows.ResourceLookupItem("Save", "Save", ""));
            // 
            // tbReturn
            // 
            this.BresourceLookup1.SetLookup(this.tbReturn, new FWBS.OMS.UI.Windows.ResourceLookupItem("Return", "Return", ""));
            // 
            // enquiryForm1
            // 
            this.enquiryForm1.AllowDrop = true;
            this.enquiryForm1.AutoScroll = true;
            this.enquiryForm1.BackColor = System.Drawing.Color.White;
            this.enquiryForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enquiryForm1.IsDirty = false;
            this.enquiryForm1.Location = new System.Drawing.Point(0, 50);
            this.enquiryForm1.Name = "enquiryForm1";
            this.enquiryForm1.Size = new System.Drawing.Size(549, 333);
            this.enquiryForm1.TabIndex = 1;
            this.enquiryForm1.ToBeRefreshed = false;
            this.enquiryForm1.Dirty += new System.EventHandler(this.enquiryForm1_Dirty);
            // 
            // ucMileStoneConfig
            // 
            this.Name = "ucMileStoneConfig";
            this.tpList.ResumeLayout(false);
            this.tpEdit.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EnquiryForm enquiryForm1;
    }
}
