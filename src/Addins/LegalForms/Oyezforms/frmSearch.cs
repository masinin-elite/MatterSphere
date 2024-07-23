using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace FWBS.OMS.UI.Windows
{
    /// <summary>
    /// This is a globally used search from that holds the search user control.
    /// </summary>
    public class frmSearch : System.Windows.Forms.Form
	{
		#region Fields
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtFldAlias;
		private System.Windows.Forms.TextBox txtFldDesc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblFldDesc;
		private System.Windows.Forms.Button btnSelect;
		private string _title;
		private DataTable _tblFields;
		private System.Windows.Forms.IWin32Window _parent;
		private System.Windows.Forms.TextBox txtFldconstant;
		private System.Windows.Forms.Label label1;
		private FWBS.OMS.UI.Windows.ucSearchControl ucSearchCtrl;
		protected FWBS.OMS.UI.Windows.ResourceLookup resourceLookup1;
		private OyezFrms.IOyezAutomation _activeform;
		private int _parentHandle;


		#endregion

		#region Constructors & Destructors

		/// <summary>
		/// Opens for with passsed OYEZ form name
		/// </summary>
		/// <param name="title">Name Of Oyez Form</param>
		internal frmSearch(string title)
		{
			InitializeComponent();
			Global.RightToLeftFormConverter(this);
			
			FWBS.Common.KeyValueCollection param = new FWBS.Common.KeyValueCollection();
			param.Add("FORM_NAME",title);
			ucSearchCtrl.SetSearchList(FWBS.OMS.Session.CurrentSession.DefaultSystemSearchList(FWBS.OMS.SystemSearchLists.OyezAliases),null,param);
			_title = title;
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSearch));
			this.label2 = new System.Windows.Forms.Label();
			this.lblFldDesc = new System.Windows.Forms.Label();
			this.btnSelect = new System.Windows.Forms.Button();
			this.txtFldAlias = new System.Windows.Forms.TextBox();
			this.txtFldDesc = new System.Windows.Forms.TextBox();
			this.txtFldconstant = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ucSearchCtrl = new FWBS.OMS.UI.Windows.ucSearchControl();
			this.resourceLookup1 = new FWBS.OMS.UI.Windows.ResourceLookup(this.components);
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.Location = new System.Drawing.Point(7, 392);
			this.resourceLookup1.SetLookup(this.label2, new FWBS.OMS.UI.Windows.ResourceLookupItem("FLDALIAS", "Field Alias", ""));
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 19);
			this.label2.TabIndex = 10;
			this.label2.Text = "Field Alias";
			// 
			// lblFldDesc
			// 
			this.lblFldDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblFldDesc.Location = new System.Drawing.Point(7, 368);
			this.resourceLookup1.SetLookup(this.lblFldDesc, new FWBS.OMS.UI.Windows.ResourceLookupItem("FLDDESC", "Field Description", ""));
			this.lblFldDesc.Name = "lblFldDesc";
			this.lblFldDesc.Size = new System.Drawing.Size(146, 19);
			this.lblFldDesc.TabIndex = 9;
			this.lblFldDesc.Text = "Field Description";
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSelect.Location = new System.Drawing.Point(401, 392);
			this.resourceLookup1.SetLookup(this.btnSelect, new FWBS.OMS.UI.Windows.ResourceLookupItem("SELECT", "Select", ""));
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(79, 26);
			this.btnSelect.TabIndex = 3;
			this.btnSelect.Text = "Select";
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// txtFldAlias
			// 
			this.txtFldAlias.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtFldAlias.Location = new System.Drawing.Point(120, 392);
			this.txtFldAlias.Name = "txtFldAlias";
			this.txtFldAlias.Size = new System.Drawing.Size(272, 20);
			this.txtFldAlias.TabIndex = 2;
			this.txtFldAlias.Text = "";
			// 
			// txtFldDesc
			// 
			this.txtFldDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtFldDesc.Location = new System.Drawing.Point(120, 368);
			this.txtFldDesc.Name = "txtFldDesc";
			this.txtFldDesc.Size = new System.Drawing.Size(272, 20);
			this.txtFldDesc.TabIndex = 1;
			this.txtFldDesc.Text = "";
			// 
			// txtFldconstant
			// 
			this.txtFldconstant.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtFldconstant.Location = new System.Drawing.Point(120, 416);
			this.txtFldconstant.Name = "txtFldconstant";
			this.txtFldconstant.Size = new System.Drawing.Size(272, 20);
			this.txtFldconstant.TabIndex = 4;
			this.txtFldconstant.Text = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Location = new System.Drawing.Point(7, 418);
			this.resourceLookup1.SetLookup(this.label1, new FWBS.OMS.UI.Windows.ResourceLookupItem("FLDCONST", "Field Constant", ""));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 19);
			this.label1.TabIndex = 14;
			this.label1.Text = "Field Constant";
			// 
			// ucSearchCtrl
			// 
			this.ucSearchCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSearchCtrl.DockPadding.All = 5;
			this.ucSearchCtrl.DoubleClickAction = "None";
			this.ucSearchCtrl.Location = new System.Drawing.Point(2, 0);
			this.ucSearchCtrl.Name = "ucSearchCtrl";
			this.ucSearchCtrl.NavCommandPanel = null;
			this.ucSearchCtrl.Size = new System.Drawing.Size(492, 358);
			this.ucSearchCtrl.TabIndex = 15;
			this.ucSearchCtrl.ToBeRefreshed = false;
			this.ucSearchCtrl.TypeSelectorVisible = false;
			this.ucSearchCtrl.SearchCompleted += new FWBS.OMS.UI.Windows.SearchCompletedEventHandler(this.ucSearchCtrl_SearchCompleted);
			this.ucSearchCtrl.SearchButtonCommands += new FWBS.OMS.UI.Windows.SearchButtonEventHandler(this.ucSearchCtrl_SearchButtonCommands);
			// 
			// frmSearch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(492, 447);
			this.ControlBox = false;
			this.Controls.Add(this.ucSearchCtrl);
			this.Controls.Add(this.txtFldconstant);
			this.Controls.Add(this.txtFldAlias);
			this.Controls.Add(this.txtFldDesc);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblFldDesc);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "OMS Search";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmSearch_Closing);
			this.ResumeLayout(false);

		}
		#endregion


		#endregion

		#region Properties

		/// <summary>
		/// Having real trouble itentifying the paren of this form Oyez App so need to do capture handle
		/// </summary>
		public int ParentHandle
		{
			set
			{
				_parentHandle = value;
			}
		}
		
		/// <summary>
		/// Gets the current selected values that have been picked from the searched list.
		/// </summary>
		public FWBS.Common.KeyValueCollection ReturnValues
		{
			get
			{
				return ucSearchCtrl.ReturnValues;
			}
		}
		
		
		public System.Windows.Forms.IWin32Window ParentWindow
		{
			get
			{
				return _parent;
			}
			set
			{
				_parent = value;
			}
		}

		
		/// <summary>
		/// allows passing a refernce of the OYEZ form for use while editing
		/// </summary>
		public OyezFrms.IOyezAutomation ActiveDoc
		{
			set
			{
				_activeform = value;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Select a system field from the standard OMS Field picker
		/// </summary>
		private void btnSelect_Click(object sender, System.EventArgs e)
		{
		
			string sNewVal = FWBS.OMS.UI.Windows.Services.AddField(null,null);

			if(sNewVal.Length > 0)
			{
				//put new value in text box
				txtFldAlias.Text = sNewVal;
			}
		}

		
		/// <summary>
		/// Performs the required data binding and sets local datatable variable
		/// </summary>
		private void ucSearchCtrl_SearchCompleted(object sender, SearchCompletedEventArgs e)
		{
			//grab a reference to the search lists datatable
			_tblFields = ucSearchCtrl.SearchList.DataTable;
			
			//bind text boxes
			txtFldAlias.DataBindings.Add("Text",_tblFields,"fldAlias");
			txtFldDesc.DataBindings.Add("Text",_tblFields,"fldDesc");
			txtFldconstant.DataBindings.Add("Text",_tblFields,"fldConstant");

		}


		/// <summary>
		/// handles responses from search controls buttons
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ucSearchCtrl_SearchButtonCommands(object sender, SearchButtonEventArgs e)
		{
			switch( e.ButtonName)
			{
				case "btnAddFields":
				{
					//gets fields from Oyez form and populates data table
					PopulateMissingFields();
					return;
				}
				case "btnSave":
				{
					//saves changes down to database via business layer
					SaveData();
					return;
				}
				case "btnOK":
				{
					//
					CheckChanges();
					this.Close();
					//close Oyez
					_activeform.exit();
                    FWBS.Common.COM.DisposeObject(_activeform);

					try
					{
						Process[] procs = Process.GetProcesses();

						foreach(Process proc in procs)
						{
							if(proc.ProcessName.ToUpper() == "OYEZFRMS")
							{
								proc.CloseMainWindow();
								//to enfore application being killed
								System.Windows.Forms.Application.DoEvents();
								CheckProcessIsKilled("OyezFrms");
							}
						}
					}
					catch{}
					return;

				}
			}
		}
		
		
		/// <summary>
		/// Checks the process is really dead and kills
		/// </summary>
		/// <param name="processname"></param>
		private void CheckProcessIsKilled(string processname)
		{
			Process[] procs = Process.GetProcesses();

			foreach(Process proc in procs)
			{
				if(proc.ProcessName.ToUpper() == processname.ToUpper())
				{
					//Close the process
					//13/12/2004 ParentWindow is forced during form create now to enable reliable shutting down
					IntPtr hWnd = this.ParentWindow.Handle;

					FWBS.Common.Functions.CloseProcess(hWnd);

					//check if has gone
					procs = null;
					procs = Process.GetProcesses();
					foreach(Process proc1 in procs)
					{
						//if still there kill it
						if(proc1.ProcessName.ToUpper() == processname.ToUpper())
						{
							FWBS.Common.Functions.KillProcess(hWnd);
							return;
						}
					}
				}
			}
		}
		/// <summary>
		/// passes the update to search list for handling.
		/// </summary>
		private void SaveData()
		{
			
			try
			{
				//this line forces the update of the currrent row
				this.BindingContext[ucSearchCtrl.SearchList.DataTable].EndCurrentEdit();

				//add this to capture any pending chnages possible a quirk of bound controls
				for(int ctr = _tblFields.Rows.Count -1 ;ctr >= 0; ctr--)
				{
					
					DataRow row = _tblFields.Rows[ctr];

					//if there is no data do not store 
					if(Convert.ToString(row["fldAlias"]) == "" 
						&& Convert.ToString(row["fldConstant"]) == "" && Convert.ToString(row["fldDesc"]) == "")
						row.Delete();
				}
			
				ucSearchCtrl.SearchList.UpdateData("select * from dboyezaliases");
			
				MessageBox.ShowInformation("FLDUPDATED","Fields updated",null);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex);
			}

		}
		
		
		/// <summary>
		/// checks if any rows have changed used when closing form
		/// </summary>
		private void CheckChanges()
		{
			//add this to capture any pending changes possible a quirk of bound controls
			foreach(DataRow row in _tblFields.Rows)
			{
				row.EndEdit();
			}

			DataTable tbl = _tblFields.GetChanges();
					
			if(tbl != null)
			{
				DialogResult result = MessageBox.ShowYesNoQuestion("OYEZSAVEPROMPT","Changes detected,  do you wish to save changes",true,null);
						
				if(result == DialogResult.Yes)
				{
					SaveData();
				}
			}
		}



		/// <summary>
		/// Populate missing fields into search list datatable from loaded OYEZ form
		/// </summary>
		private void PopulateMissingFields()
		{
			int icount = 0;
			try
			{			
				//we have to iterate all the pages a oyez quirk
				for(int iPage = 1; iPage < (_activeform.Pages + 1) ; iPage++)
				{
				
					_activeform.selectpage(iPage);						  
					
					//get all fields from the OYEZ form page
					string s = _activeform.FieldList;
					
					//put into array
					string delim = ",";
					string[] sArr = s.Split(delim.ToCharArray());
					
					//iterate all fields to see if datatable already contains them
					for(int i = 0; i < sArr.Length; i++)
					{
						//get field
						string sField = sArr[i].ToString();
					
						//build a filter
						string sFilter = @"frmName = '" + _title + "' and fldName = '" + sField + "' and fldPage = " + iPage.ToString();

						//filter table into a datarows collection
						DataRow[] rows = _tblFields.Select(sFilter);
					
						//check if any rows returned IE field exists
						if(rows.Length == 0)
						{
							//if not add it
							DataRow newrow = _tblFields.NewRow();
						
							//set inital values
							newrow["frmName"] = _title;
							newrow["fldName"] = sField;
							//this field may need to be revised but currently just clone values
							newrow["frmAlias"] = _title;
							newrow["fldDesc"] = "";
							newrow["fldAlias"] = "";
							newrow["fldConstant"] = "";
							newrow["fldPage"] = iPage;

							_tblFields.Rows.Add(newrow);
							icount++;
						}
					}
				}
				if(icount > 1)
				{
					string[] prms = new string[1];
					prms[0] = icount.ToString();
					MessageBox.ShowInformation("OYEZFLDADDED","%1% fields added to list.",prms);
				}
				else
				{
					MessageBox.ShowInformation("OYEZFLDOK","Field list already complete.",null);
				}
			}
			catch(Exception ex)
			{
				string[] prms = new string[1];
				prms[0] = ex.Message;
				MessageBox.ShowInformation("OYEZPROCFAIL","Process Failed %1%",prms);	    
			}
		}
		
		private void frmSearch_Closing(object sender, CancelEventArgs e)
		{
			CheckChanges();
			_activeform.exit();
		}
		
		#endregion

		
	}
}
