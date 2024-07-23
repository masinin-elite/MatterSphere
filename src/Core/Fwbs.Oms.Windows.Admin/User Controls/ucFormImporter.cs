using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FWBS.OMS.Data.Exceptions;

namespace FWBS.OMS.UI.Windows.Admin
{
    /// <summary>
    /// Summary description for ucFormImporter.
    /// </summary>
    public class ucFormImporter : System.Windows.Forms.UserControl, IOBjectDirty
	{
		#region Fields
		
		protected FWBS.OMS.UI.Windows.ResourceLookup resourceLookup1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lstForms;
		private System.Windows.Forms.RadioButton optOyez;
		private System.Windows.Forms.RadioButton optLaser;
		private System.Windows.Forms.Button btnGetList;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.TextBox txtLibrary;
		private System.Windows.Forms.TextBox txtCategory;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btnImportAll;
		private System.Windows.Forms.ProgressBar progbar1;

		/// <summary>
		/// counter variables for displaying information
		/// </summary>
		private int _precadded = 0;
		private System.Windows.Forms.Label lblInfo;
		private int _subcatsadded = 0;

		#endregion
		
		#region Constructors and Destructors

		public ucFormImporter()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitializeComponent call
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

		
		#endregion

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.resourceLookup1 = new FWBS.OMS.UI.Windows.ResourceLookup(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.optOyez = new System.Windows.Forms.RadioButton();
			this.optLaser = new System.Windows.Forms.RadioButton();
			this.btnGetList = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.txtLibrary = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnImportAll = new System.Windows.Forms.Button();
			this.lstForms = new System.Windows.Forms.ListBox();
			this.progbar1 = new System.Windows.Forms.ProgressBar();
			this.lblInfo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 32);
			this.resourceLookup1.SetLookup(this.label1, new FWBS.OMS.UI.Windows.ResourceLookupItem("FORMSMENU", "Forms Menu", ""));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Forms Menu";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.optOyez);
			this.groupBox1.Controls.Add(this.optLaser);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(325, 29);
			this.resourceLookup1.SetLookup(this.groupBox1, new FWBS.OMS.UI.Windows.ResourceLookupItem("INSTALLEDLIB", "Installed Library", ""));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(412, 93);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Installed Library";
			// 
			// optOyez
			// 
			this.optOyez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.optOyez.Location = new System.Drawing.Point(12, 56);
			this.resourceLookup1.SetLookup(this.optOyez, new FWBS.OMS.UI.Windows.ResourceLookupItem("OYEZFORMS", "Oyez Forms", ""));
			this.optOyez.Name = "optOyez";
			this.optOyez.Size = new System.Drawing.Size(355, 24);
			this.optOyez.TabIndex = 1;
			this.optOyez.Text = "Oyez Forms";
			this.optOyez.CheckedChanged += new System.EventHandler(this.optOyez_CheckedChanged);
			// 
			// optLaser
			// 
			this.optLaser.Checked = true;
			this.optLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.optLaser.Location = new System.Drawing.Point(12, 24);
			this.resourceLookup1.SetLookup(this.optLaser, new FWBS.OMS.UI.Windows.ResourceLookupItem("LASERFORMS", "LaserForms", ""));
			this.optLaser.Name = "optLaser";
			this.optLaser.Size = new System.Drawing.Size(354, 24);
			this.optLaser.TabIndex = 0;
			this.optLaser.TabStop = true;
			this.optLaser.Text = "LaserForms";
			this.optLaser.CheckedChanged += new System.EventHandler(this.optLaser_CheckedChanged);
			// 
			// btnGetList
			// 
			this.btnGetList.Location = new System.Drawing.Point(326, 132);
			this.resourceLookup1.SetLookup(this.btnGetList, new FWBS.OMS.UI.Windows.ResourceLookupItem("GETLIBRARYLIST", "Get list from selected library", ""));
			this.btnGetList.Name = "btnGetList";
			this.btnGetList.Size = new System.Drawing.Size(208, 33);
			this.btnGetList.TabIndex = 3;
			this.btnGetList.Text = "Get list from selected library";
			this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtCategory);
			this.groupBox2.Controls.Add(this.txtLibrary);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(327, 193);
			this.resourceLookup1.SetLookup(this.groupBox2, new FWBS.OMS.UI.Windows.ResourceLookupItem("IMPORTINTO", "Import into these precedent categories", ""));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(410, 124);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Import into these precedent categories";
			// 
			// txtCategory
			// 
			this.txtCategory.Enabled = false;
			this.txtCategory.Location = new System.Drawing.Point(129, 76);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(262, 20);
			this.txtCategory.TabIndex = 5;
			this.txtCategory.Text = "";
			// 
			// txtLibrary
			// 
			this.txtLibrary.Enabled = false;
			this.txtLibrary.Location = new System.Drawing.Point(129, 40);
			this.txtLibrary.Name = "txtLibrary";
			this.txtLibrary.Size = new System.Drawing.Size(262, 20);
			this.txtLibrary.TabIndex = 4;
			this.txtLibrary.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 73);
			this.resourceLookup1.SetLookup(this.label3, new FWBS.OMS.UI.Windows.ResourceLookupItem("CATEGORY", "Category", ""));
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "Category";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.resourceLookup1.SetLookup(this.label2, new FWBS.OMS.UI.Windows.ResourceLookupItem("LIBRARY", "Library", ""));
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Library";
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(326, 328);
			this.resourceLookup1.SetLookup(this.btnImport, new FWBS.OMS.UI.Windows.ResourceLookupItem("IMPORTSELECTED", "Import selected forms", ""));
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(208, 33);
			this.btnImport.TabIndex = 5;
			this.btnImport.Text = "Import selected forms";
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnImportAll
			// 
			this.btnImportAll.Location = new System.Drawing.Point(326, 369);
			this.resourceLookup1.SetLookup(this.btnImportAll, new FWBS.OMS.UI.Windows.ResourceLookupItem("IMPORTALLFORMS", "Import all forms", ""));
			this.btnImportAll.Name = "btnImportAll";
			this.btnImportAll.Size = new System.Drawing.Size(208, 33);
			this.btnImportAll.TabIndex = 7;
			this.btnImportAll.Text = "Import all forms";
			this.btnImportAll.Click += new System.EventHandler(this.btnImportAll_Click);
			// 
			// lstForms
			// 
			this.lstForms.Location = new System.Drawing.Point(17, 61);
			this.lstForms.Name = "lstForms";
			this.lstForms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstForms.Size = new System.Drawing.Size(280, 433);
			this.lstForms.TabIndex = 6;
			this.lstForms.SelectedIndexChanged += new System.EventHandler(this.lstForms_SelectedIndexChanged);
			// 
			// progbar1
			// 
			this.progbar1.Location = new System.Drawing.Point(326, 460);
			this.progbar1.Name = "progbar1";
			this.progbar1.Size = new System.Drawing.Size(409, 31);
			this.progbar1.Step = 1;
			this.progbar1.TabIndex = 8;
			this.progbar1.Visible = false;
			// 
			// lblInfo
			// 
			this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(327, 436);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(407, 22);
			this.lblInfo.TabIndex = 9;
			// 
			// ucFormImporter
			// 
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.progbar1);
			this.Controls.Add(this.btnImportAll);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnGetList);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstForms);
			this.Controls.Add(this.label1);
			this.resourceLookup1.SetLookup(this, new FWBS.OMS.UI.Windows.ResourceLookupItem("ucFormImporter", "", ""));
			this.Name = "ucFormImporter";
			this.Size = new System.Drawing.Size(785, 526);
			this.Load += new System.EventHandler(this.ucFormImporter_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		
		#endregion
		
		#region Shared Methods
		
		/// <summary>
		/// Adds a code lookup for the category of sub category
		/// </summary>
		/// <param name="type">PRECCAT or PRECSUBCAT</param>
		/// <param name="code">Resource code</param>
		/// <param name="description">Resource description</param>
		private void AddCodeLookup(string type,string code,string description)
		{
			//need a try catch as if the code exists an error is thrown
			try
			{
				FWBS.OMS.CodeLookup.Create(type,code,description,"",FWBS.OMS.Session.CurrentSession.CurrentUser.PreferedCulture,false,false,true);
			}	
			catch{}
		}
		
		/// <summary>
		/// Creates a code from a passed string value
		/// </summary>
		/// <param name="fullstring"></param>
		private string CreateCode(string fullstring)
		{
			//codes need to be uppercase 
			string ucode = fullstring.ToUpper();	
			//remove any character wasting spaces
			string spacestripped = ucode.Replace(" ",""); 
			//also remove dashes
			string dashstripped = spacestripped.Replace("-","");
			//remove the brackets
			string nobrackets = dashstripped.Replace("(","");
			nobrackets = nobrackets.Replace(")","");
			//trim to max length of 15 characters
			string retval = TrimString(nobrackets,15);
			//return the cleaned and stripped code
			return retval;
		}


		/// <summary>
		/// gets all files in specified dirctory
		/// </summary>
		/// <param name="path">folder path to query</param>
		/// <returns>string array of files within path</returns>
		private string[] GetFiles(string path)
		{
			//check it exists
			if(System.IO.Directory.Exists(path))
			{
				string[] strret = System.IO.Directory.GetFiles(path);
				return strret;
			}
			else
				return null;
		}
		
		
		/// <summary>
		/// Cuts a passed string to the required length ignoring is shorter 
		/// </summary>
		/// <param name="val">string to examine</param>
		/// <param name="length">max length string can be</param>
		/// <returns>Shortened string if less than specified length</returns>
		private string TrimString(string val,int length)
		{
			if(val.Length <= length)
				return val;
			else
			{
				string retval;
				retval = val.Substring(0,length);
				return retval;
			}
		}

		
		/// <summary>
		/// Returns an array of all folders in a passed folder
		/// </summary>
		/// <param name="path">folder to interrogate</param>
		/// <returns>string array of folder names</returns>
		private string[] GetFolders(string path)
		{
            //check it exists
			if(Directory.Exists(path))
			{
                string[] dirs = Directory.GetDirectories(path);

                System.Collections.Generic.List<string> retVal = new System.Collections.Generic.List<string>();

                foreach(string s in dirs)
                {
                    DirectoryInfo d = new DirectoryInfo(s);
                    retVal.Add(d.Name);
                }

                return retVal.ToArray();

			}
			else
				return null;
		}

		
		/// <summary>
		///	displays a message box with the number of precedents imported 
		/// </summary>
		private void DisplayTotals()
		{
			//if any were added display totals
			if(_precadded > 0)
			{
				if(_subcatsadded > 0)
				{
					string[] param = new string[2];
					param[0] = _precadded.ToString();
					param[1] = _subcatsadded.ToString();
					MessageBox.ShowInformation("LASERADDED","%1% Precedents added in %2% sub-categories.",param);
				}
				else
				{
					//used by OYEZ as it does not distingish sub categories
					string[] param = new string[1];
					param[0] = _precadded.ToString();
					MessageBox.ShowInformation("PRECADDED","%1% Precedents added to precedent library.",param);
				}
			}
			else //display message to indicate no new precedents were added
			{
				MessageBox.ShowInformation("NOLASERADDED","No new Precedents added at this time.");
			}
		}
		
		/// <summary>
		/// cosmetic function used when status changes with option controls
		/// </summary>
		private void ClearControls()
		{
			lstForms.Items.Clear();
			txtCategory.Text = "";
			txtLibrary.Text = "";
		}

		#endregion
		
		#region Laserform Methods
		
		/// <summary>
		/// Populates list view with a list of installed Laserform categories
		/// </summary>
		private void PopulateLaserList()
		{
			try
			{

				//get laserforms explorer folder from registry			
				string explorer = GetLFExplorerFolder();

				if(explorer == null)
				{
					MessageBox.ShowInformation("NOLASER","Unable to retrive Laserforms installation location, please check Laserforms are installed correctly.");
					return;
				}
				
				//iterate explorer directory returning all folder names (categories)
				string[] folders = GetFolders(explorer);
				
				//populate list of categories
				if(folders != null)
				{
                    foreach(string s in folders)
					{
						lstForms.Items.Add(s);	
					}
					lstForms.SelectedIndex = 0;
				}
				else
				{
					string[] param = new string[1];
					param[0] = explorer;
					MessageBox.ShowInformation("NOLFFOLDERS","Unable to retrive Laserforms folders at location '%1%'",param);
					return;
				}

			}
			catch(Exception ex)
			{
				MessageBox.ShowInformation(ex.Message);
			}
		}
		
		
		/// <summary>
		/// The description of a laserform item is held within a shortcut's description
		/// This function extracts the part that we are intrested in from the full description
		/// </summary>
		/// <param name="fulldesc">Full description from shortcut</param>
		/// <returns>Short title of form</returns>			  
		private string GetFileLongTitle(string fulldesc)
		{
			string sreturn;
			string ssearch = "FormLongTitle=";

			//get the index within the sring of the formlongtitle text
			int startindex = fulldesc.LastIndexOf(ssearch) + ssearch.Length;
			int length = fulldesc.Length - (startindex + 1); 

			//trim out the string for the title itself
			sreturn = fulldesc.Substring(startindex,length);
			
			return sreturn;

		}

		
		/// <summary>
		/// gets the explorer folder for laserfors from the current users registry setting
		/// </summary>
		/// <returns>Path to the explorer folder</returns>
		private string GetLFExplorerFolder()
		{
			string val = (string)FWBS.Common.RegistryAccess.GetSetting(Microsoft.Win32.RegistryHive.CurrentUser
				,@"Software\Laserform\Laserform\Paths","Explorer");
			return val;
		}

		
		/// <summary>
		/// Gets the LFData directory for Laserforms installation where frmrpt.txt file is located
		/// </summary>
		/// <returns>folder of LFData directory</returns>
		private string GetLFDataFolder()
		{
			string val = (string)FWBS.Common.RegistryAccess.GetSetting(Microsoft.Win32.RegistryHive.CurrentUser
				,@"Software\Laserform\Laserform\Paths","Data");
			return val;
		}
		
		
		/// <summary>
		/// The title of a laserform item is held within a shortcut's description
		/// This function extracts the part that we are intrested in from the full description
		/// </summary>
		/// <param name="fulldesc">Full description from shortcut</param>
		/// <returns>Short title of form</returns>
		private string GetFormTitle(string fulldesc)
		{
			string sreturn;
			string ssearch = "Original Name=";

			//get the index within the sring of the formlongtitle text
			int startindex = fulldesc.LastIndexOf(ssearch) + ssearch.Length;
			int endindex = fulldesc.IndexOf("~",startindex);
			int length = endindex - startindex; 

			//trim out the string for the title itself
			sreturn = fulldesc.Substring(startindex,length);
			
			return sreturn;
		}
		
		
		/// <summary>
		/// Gets the full description of a particular form from the 
		/// Shortcut to the form by creating a ShortcutInfo object 
		/// </summary>
		/// <param name="filename">Filename of the shortcut</param>
		/// <returns>full description from the shortcut</returns>
		private string GetFileInfo(string filename)
		{
			try
			{
				//create instance of shortcut info class		
				ShortcutInfo link = new ShortcutInfo(); 
			
				// opens a shortcut file
				link.Open(filename);
			
				//get the full description from the shortcut
				string fulldesc = link.Description;

				link.Dispose();
			
				return fulldesc;
			}
			catch
			{
				throw new OMSException2("LINKOPENERR","Error opening shortcut file " + filename);
			}
		}
		
		
		/// <summary>
		/// Imports the laserfors of the selected category
		/// </summary>
		/// <param name="category">Category Name</param>
		private void ImportLaser(string category)
		{
			string catcode = CreateCode(category);

			if(category ==null || category == "")
				return;
			
			//add the category code for added precedent
			AddCodeLookup("PRECCAT",catcode,category);

			//Get the laserforms main folder folder
			string explorer = GetLFExplorerFolder();
			if(explorer == "")
			{
				MessageBox.ShowInformation("NOLASER","Unable to retrive Laserforms installation location, please check Laserforms are installed.");
				return;
			}

            string dir = Path.Combine(explorer, category);

			//get all folders(sub ctegories) is this Category
			string[] folders = GetFolders(dir);

			if(folders == null)
			{
				MessageBox.ShowInformation("NOSUBFOLDERS1","No sub categories under this category, no forms will be imported.");
				return;
			}
			
			try
			{

				//loop around all folders getting infomation about the files
				for(int i = 0; i < folders.Length; i++)
				{
					//get individual sub directory
					string subdir = folders[i].ToString();
					//string subcat = subdir.Remove(0,dir.Length + 1);
                    string subcatcode = CreateCode(subdir);
                    string minorcatcode = CreateCode(subcatcode);

                    //add subcategory code if it doesn't already exist
                    AddCodeLookup("PRECSUBCAT", subcatcode, subdir);
                    AddCodeLookup("PRECMINORCAT", minorcatcode, subcatcode);

                    //capture a counter variable
                    int tempcount = _precadded;			

					//get array of files in directory
                    string filesPath = Path.Combine(dir, subdir);
                    string[] files = GetFiles(filesPath);
			
					if(files!= null)
					{
						for(int n = 0; n < files.Length;n++)
						{
							string filename = files[n];

							//get the full description of the form
							string fulldescription = GetFileInfo(filename);
							//get the descriptive title
							string description = TrimString(GetFileLongTitle(fulldescription),100);
							//get the name of the form
							string title = TrimString(GetFormTitle(fulldescription),50);
						
							//add the precedent to the OMS system checking it doesnt already exist
							FWBS.OMS.Precedent precedent = new FWBS.OMS.Precedent(title.ToUpper(),"FORM",description,"lpd",0);

							//set values of other fields
							precedent.Library = "LF";
							precedent.Category = catcode;
							precedent.SubCategory = subcatcode;
                            precedent.MinorCategory = minorcatcode;
                            precedent.PublishersName = "Laserforms";
							//this is required by the OMS engine to validate the Laser dll
							precedent.SetExtraInfo("precprogtype",5);
						
							//try and perform the update this will error if a precedent already exists with the same information
							//this is enforced by a unique index on the precedent table
							try
							{
								//perform the update if already exists then it will error
								precedent.Update();
								//now update path as the update routine inserts a irrelevant path
								precedent.SetExtraInfo("precpath",title.ToUpper());
								precedent.Update();
								//increment the new entry counter
								_precadded++;
							}
							catch (ConnectionException cex)
							{
								CheckForAllowedConstraintException(cex, ParentForm);
							}
							//catch any other possible exception
							catch (Exception ex)
							{
								ErrorBox.Show(ParentForm, ex);
							}
							finally
							{
								//clean up
								precedent.Dispose();
							}
						}
						//just a cosmetic item if precedent count has gone up increment sub category counter
						if(_precadded > tempcount)
							_subcatsadded++;
					}
				
				}
			}
			catch(Exception ex)
			{
				ErrorBox.Show(ParentForm, ex);
			}
		}
	
		
		#endregion

		#region Event Handlers
		
		/// <summary>
		/// Sets control properties when form loads 
		/// </summary>
		private void ucFormImporter_Load(object sender, System.EventArgs e)
		{
			txtCategory.BackColor = Color.White;
			txtCategory.ForeColor = Color.Black;
			txtLibrary.BackColor = Color.White;
			txtLibrary.ForeColor = Color.Black;
		}


		/// <summary>
		/// clear controls when option button changes 
		/// </summary>
		private void optLaser_CheckedChanged(object sender, System.EventArgs e)
		{
			ClearControls();
		}
		
		
		/// <summary>
		/// clear controls when option button changes
		/// </summary>
		private void optOyez_CheckedChanged(object sender, System.EventArgs e)
		{
			ClearControls();
		}

		
		/// <summary>
		/// Populates the list control 
		/// </summary>
		private void btnGetList_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			
			//clear the list
			lstForms.Items.Clear();
			
			if(optLaser.Checked)
			{
				//get a list of Laser form categories	
				PopulateLaserList();
			}
			else
			{
				//get a list of Oyez form categories
				PopulateOyezList();
			}

			this.Cursor = Cursors.Default;
		}

		
		/// <summary>
		/// responds to changes in the list control 
		/// </summary>
		private void lstForms_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(optLaser.Checked)
			{
				//get a list of Laser form categories	
				txtLibrary.Text = "Laserforms";
			}
			else
			{
				//get a list of Oyez form categories
				txtLibrary.Text = "Oyez forms";
			}
			if(lstForms.SelectedItems.Count ==1)
				txtCategory.Text = Convert.ToString(lstForms.SelectedItem);
			else
				txtCategory.Text = "";
		}
		
		
		/// <summary>
		/// Performs the import routine for any selected items in the list
		/// </summary>
		private void btnImport_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			//reset counters
			_precadded = 0;
			_subcatsadded = 0;

			//capture a variable for the progress bar
			int prog = lstForms.SelectedItems.Count;
			//if more than 1 item display the progress bar
			if(prog > 1)
			{
				progbar1.Maximum = prog;
				progbar1.Value = 0;
				progbar1.Visible = true;
				Application.DoEvents();
			}

			//loop around the whole list view
			foreach(object item in lstForms.SelectedItems)
			{
				string category = Convert.ToString(item);
				lblInfo.Text = category + ".....";
				progbar1.PerformStep();
				Application.DoEvents();
				
				if(optLaser.Checked)
				{
					//Import selected laserforms
					ImportLaser(category);
				}
				else
				{
					//Import selected Oyez
					ImportOyez(category);
				}
			}
			//set cursor back to normal
			this.Cursor = Cursors.Default;
			//display an information message box
			progbar1.Visible = false;
			lblInfo.Text = "";
			DisplayTotals();
		}
		
			
		/// <summary>
		/// imports all forms categories currently in the list view
		/// </summary>
		private void btnImportAll_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			//reset counters
			_precadded = 0;
			_subcatsadded = 0;

			//capture a variable for the progress bar
			int prog = lstForms.Items.Count;
			progbar1.Maximum = prog;
			progbar1.Value = 0;
			progbar1.Visible = true;
			Application.DoEvents();

			//loop around the whole list view
            foreach(object item in lstForms.Items)
			{
				string category = Convert.ToString(item);
				lblInfo.Text = category + ".....";
				progbar1.PerformStep();
				Application.DoEvents();
				
				if(optLaser.Checked)
				{
					//Import selected laserforms
					ImportLaser(category);
				}
				else
				{
					//Import selected Oyez
					ImportOyez(category);
				}
			}
			//set cursor back to normal
			this.Cursor = Cursors.Default;
			//display an information message box
			progbar1.Visible = false;
			lblInfo.Text = "";
			DisplayTotals();
		}

		#endregion
		
		#region Oyez Methods

		/// <summary>
		/// gets the explorer folder for laserfors from the current users registry setting
		/// </summary>
		/// <returns>Path to the explorer folder</returns>
		private string GetOyezDBPath()
		{
			string val = (string)FWBS.Common.RegistryAccess.GetSetting(Microsoft.Win32.RegistryHive.CurrentUser
				,@"Software\oyez\Oyez Legal Forms\User","OyezDatabasePath");
			//append database name if registry key returned a value
			if(val != null)
				val = val + "MastLibr.mdb";
			
			return val;
		}

        /// <summary>
        /// Forms connection string to Access database file.
        /// Since Microsoft.Jet.OLEDB.4.0 doesn't exist in 64-bit configuration, you may need to install
        /// Microsoft Access Database Engine 2010 x64 Redistributable from https://www.microsoft.com/en-us/download/details.aspx?id=13255.
        /// <see href="https://stackoverflow.com/questions/1991643/microsoft-jet-oledb-4-0-provider-is-not-registered-on-the-local-machine"/>
        /// </summary>
        /// <param name="dbPath">Path to local database file.</param>
        /// <returns>Connection string.</returns>
        private string GetConnectionString(string dbPath)
        {
            return string.Format("Provider={1};Data Source={0}", dbPath,
                Environment.Is64BitProcess ? "Microsoft.ACE.OLEDB.12.0" : "Microsoft.Jet.OLEDB.4.0");
        }
		
		/// <summary>
		/// populates list view with list of Oyez categories
		/// </summary>
		private void PopulateOyezList()
		{
			try
			{
				//get path to access database that holds form names and categories
				string dbpath = GetOyezDBPath();
				
				//returns an empty string if location is not in the registry
				if(dbpath == null)
				{
					MessageBox.ShowInformation("OYEZINSTALL","unable to retrive location of Oyez database please check OYEZ is installed correctly.");
					return;
				}
				
				string cnnstr = GetConnectionString(dbpath);

				//open the database
				OleDbConnection cnn = new OleDbConnection(cnnstr);
				cnn.Open();

				//get a list of the categories
				OleDbDataAdapter da = new OleDbDataAdapter("select * from categories order by category",cnn);
				DataSet ds = new DataSet();
				da.Fill(ds,"categories");
				
				cnn.Close();
				
				//populate the list with the categories
				foreach(DataRow row in ds.Tables["categories"].Rows)
				{
					lstForms.Items.Add(row["category"]);
				}

				//clean up
				ds.Dispose();
				cnn.Dispose();
			}
			catch(Exception ex)
			{
				MessageBox.ShowInformation(ex.Message);
			}
		}
		
		
		/// <summary>
		/// Gets the ID value of the passed category
		/// </summary>
		/// <param name="category">name of categroy</param>
		/// <returns>ID value</returns>
		private int GetOyezCatID(string category)
		{
			int retval = 0;

			try
			{
				//get path to access database that holds form names and categories
				string dbpath = GetOyezDBPath();
				if(dbpath == null)
					return 0;

				string cnnstr = GetConnectionString(dbpath);
				string sql = @"select * from categories where category = '" + category + "'";
				
				//open the database
				OleDbConnection cnn = new OleDbConnection(cnnstr);
				cnn.Open();

				//get a list of the categories
				OleDbDataAdapter da = new OleDbDataAdapter(sql,cnn);
				DataSet ds = new DataSet();
				da.Fill(ds,"categories");
				
				cnn.Close();
				
				DataTable dtcat = ds.Tables["categories"];
				
				if(dtcat.Rows.Count < 1)
					//no rows returned
					retval = 0;
				if(dtcat.Rows.Count > 1)
					//more than 1 row returned cannot be specific
					retval = 0;
				
				if(dtcat.Rows.Count == 1)
				{
					DataRow row = dtcat.Rows[0];
					retval = Convert.ToInt32(row["CategoryID"]);
				}

				//clean up
				ds.Dispose();
				cnn.Dispose();
			}
			catch(Exception ex)
			{
				MessageBox.ShowInformation(ex.Message);
				retval = 0;
			}
			return retval;
		}

		
		/// <summary>
		/// Gets a data table of Oyez forms under passed category ID
		/// </summary>
		/// <param name="categoryid">ID of category to return forms for</param>
		/// <returns>data Table of form records</returns>
		private DataTable GetOyezForms(int categoryid)
		{
			DataTable retval;

			try
			{
				//get path to access database that holds form names and categories
				string dbpath = GetOyezDBPath();
				if(dbpath == null)
					return null;
				
				string cnnstr = GetConnectionString(dbpath);
				//SQL statement has to use a max clause on the revision field to avoid duplicates
				string sql = @"SELECT CategoryID,FormName,Description, Max(Revision) AS MaxOfRevision from LegalForms WHERE LegalForms.Pages <>-2 GROUP BY LegalForms.CategoryID, LegalForms.FormName, LegalForms.Description having(((categoryid) = " + categoryid + ")) order by FormName";
				
				//open the database
				OleDbConnection cnn = new OleDbConnection(cnnstr);
				cnn.Open();

				//get a list of the categories
				OleDbDataAdapter da = new OleDbDataAdapter(sql,cnn);
				DataSet ds = new DataSet();
				da.Fill(ds,"legalforms");
				
				cnn.Close();
				
				//assign data table to return value
				retval = ds.Tables["legalforms"];
				
				//clean up
				ds.Dispose();
				cnn.Dispose();
			}
			catch(Exception ex)
			{
				MessageBox.ShowInformation(ex.Message);
				retval = null;
			}
			return retval;

		}


		/// <summary>
		/// imports all forms within selected category
		/// </summary>
		/// <param name="category">category name</param>
		private void ImportOyez(string category)
		{
			DataTable tblforms;
			
			if(category ==null || category == "")
				return;

			//create a category code for pased category
			string catcode = CreateCode(category);
			
			//add the category code for added precedent
			AddCodeLookup("PRECCAT",catcode,category);

			//Get ID of selectd category
			int categoryid = GetOyezCatID(category);

			//if 0 is rturned there was a problem accessing the category ID
			if(categoryid == 0)
			{
				MessageBox.ShowInformation("NOOYEZCAT","Unable to retrive category information for selected category: " + category);
				return;
			}

			//Using this category ID get a datatable of forms
			tblforms = GetOyezForms(categoryid);
			
			//check that a datatable has been returned
			if(tblforms == null)
			{
				MessageBox.ShowInformation("NOOYEZDATA","Unable to retrive data for selected category: " + category);
				return;
			}
			
			//loop around all folders getting infomation about the files
			foreach(DataRow row in tblforms.Rows)
			{
				
				string title = TrimString(Convert.ToString(row["FormName"]),50);
				string description = TrimString(Convert.ToString(row["Description"]),100);
						
				//Create a precedent object using constructor to pass details
				FWBS.OMS.Precedent precedent = new FWBS.OMS.Precedent(title.ToUpper(),"FORM",description,"olf",0);

				//update extra values
				precedent.Library = "OYEZ";
				precedent.Category = catcode;
				
				precedent.PublishersName = "OyezForms";
				//prog type is used by the security features to check the OYEZ library against DB entry GUID
				precedent.SetExtraInfo("precprogtype",4);
				
				//try and perform the update this will error if a precedent already exists with the same information
				//this is enforced by a unique index on the precedent table
				try
				{
					//perform the update if already exists then it will error
					precedent.Update();
					//now update path as the update routine inserts a irrelevant path
					precedent.SetExtraInfo("precpath",title.ToUpper());
					precedent.Update();
					//increment the new entry counter
					_precadded++;


				}
				catch(ConnectionException cex)
				{
					CheckForAllowedConstraintException(cex, ParentForm);					
				}
				//catch any other possible exception
				catch(Exception ex)
				{
					ErrorBox.Show(ParentForm, ex);	
				}
				finally
				{
					//clean up
					precedent.Dispose();
				}
			}
		}

		private static void CheckForAllowedConstraintException(ConnectionException cex, IWin32Window owner = null)
		{
			SqlException sqlex = cex.InnerException as SqlException;
			if (sqlex == null || sqlex.Number != 2627) // "Violation of .... constraint '....'. Cannot insert duplicate key in object 'dbPrecedents'."
			{
				//if the error is not the expected violation of unique index
				ErrorBox.Show(owner, cex);
			}
		}
		
		#endregion

        #region IObjectDirty Implementation

        private bool isdirty;
        public bool IsDirty { get { return isdirty; } }

        public bool IsObjectDirty()
        {
            return true;
        }

        #endregion
    }
	
	/// <summary>
	/// Class used to interrogate shortcut information
	/// </summary>
	internal class ShortcutInfo : IDisposable
	{
			
		#region Member Variables
		// Use Unicode (W) under NT, otherwise use ANSI		
		private IShellLinkW linkW;
		private IShellLinkA linkA;
		private string shortcutFile;
		
		#endregion
		
		#region Constructor
        
		public ShortcutInfo()
		{
			if (System.Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				linkW = (IShellLinkW)new CShellLink();
			}
			else
			{
				linkA = (IShellLinkA)new CShellLink();
			}
		}
		
		#endregion

		#region Shortcut Open Methods

		/// <summary>
		/// Loads a shortcut from the specified file
		/// </summary>
		/// <param name="linkFile">The shortcut file (.lnk) to load</param>
		public void Open(string linkFile)
		{
			// Increased timeout to 5 seconds as errored at site
			Open(linkFile, IntPtr.Zero, (EShellLinkResolveFlags.SLR_ANY_MATCH | EShellLinkResolveFlags.SLR_NO_UI),5000);
		}
		
		/// <summary>
		/// Loads a shortcut from the specified file, and allows flags controlling
		/// the UI behaviour if the shortcut's target isn't found to be set.  If
		/// no SLR_NO_UI is specified, you can also specify a timeout.
		/// </summary>
		/// <param name="linkFile">The shortcut file (.lnk) to load</param>
		/// <param name="hWnd">The window handle of the application's UI, if any</param>
		/// <param name="resolveFlags">Flags controlling resolution behaviour</param>
		/// <param name="timeOut">Timeout if SLR_NO_UI is specified, in ms.</param>
		public void Open(string linkFile,IntPtr hWnd, EShellLinkResolveFlags resolveFlags,ushort timeOut)
		{
			uint flags;
			
			//determine if we should prompt on no existence of file
			if ((resolveFlags & EShellLinkResolveFlags.SLR_NO_UI)== EShellLinkResolveFlags.SLR_NO_UI)
			{
				flags = (uint)((int)resolveFlags | (timeOut << 16));
			}
			else
			{
				flags = (uint)resolveFlags;
			}

			if (linkA == null)
			{
				((IPersistFile)linkW).Load(linkFile, 0);
				linkW.Resolve(hWnd, flags);
			}
			else
			{
				((IPersistFile)linkA).Load(linkFile, 0);
				linkA.Resolve(hWnd, flags);
			}
			this.shortcutFile = linkFile;
		}
		
		
		
		#endregion
		
		#region IShellLink Interface and ShellLinkCoClass
		
		[ComImportAttribute()]
			[GuidAttribute("000214EE-0000-0000-C000-000000000046")]
			[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
			private interface IShellLinkA
		{
			//[helpstring("Retrieves the path and filename of a shell link object")]
			void GetPath(
				[Out(), MarshalAs(UnmanagedType.LPStr)] StringBuilder pszFile, 
				int cchMaxPath, 
				ref _WIN32_FIND_DATAA pfd, 
				uint fFlags);

			//[helpstring("Retrieves the list of shell link item identifiers")]
			void GetIDList(out IntPtr ppidl);

			//[helpstring("Sets the list of shell link item identifiers")]
			void SetIDList(IntPtr pidl);

			//[helpstring("Retrieves the shell link description string")]
			void GetDescription(
				[Out(), MarshalAs(UnmanagedType.LPStr)] StringBuilder pszFile,
				int cchMaxName);
		
			//[helpstring("Sets the shell link description string")]
			void SetDescription(
				[MarshalAs(UnmanagedType.LPStr)] string pszName);

			//[helpstring("Retrieves the name of the shell link working directory")]
			void GetWorkingDirectory(
				[Out(), MarshalAs(UnmanagedType.LPStr)] StringBuilder pszDir,
				int cchMaxPath);

			//[helpstring("Sets the name of the shell link working directory")]
			void SetWorkingDirectory(
				[MarshalAs(UnmanagedType.LPStr)] string pszDir);

			//[helpstring("Retrieves the shell link command-line arguments")]
			void GetArguments(
				[Out(), MarshalAs(UnmanagedType.LPStr)] StringBuilder pszArgs, 
				int cchMaxPath);

			//[helpstring("Sets the shell link command-line arguments")]
			void SetArguments(
				[MarshalAs(UnmanagedType.LPStr)] string pszArgs);

			//[helpstring("Retrieves or sets the shell link hot key")]
			void GetHotkey(out short pwHotkey);
			//[helpstring("Retrieves or sets the shell link hot key")]
			void SetHotkey(short pwHotkey);

			//[helpstring("Retrieves or sets the shell link show command")]
			void GetShowCmd(out uint piShowCmd);
			//[helpstring("Retrieves or sets the shell link show command")]
			void SetShowCmd(uint piShowCmd);

			//[helpstring("Retrieves the location (path and index) of the shell link icon")]
			void GetIconLocation(
				[Out(), MarshalAs(UnmanagedType.LPStr)] StringBuilder pszIconPath, 
				int cchIconPath, 
				out int piIcon);
		
			//[helpstring("Sets the location (path and index) of the shell link icon")]
			void SetIconLocation(
				[MarshalAs(UnmanagedType.LPStr)] string pszIconPath, 
				int iIcon);

			//[helpstring("Sets the shell link relative path")]
			void SetRelativePath(
				[MarshalAs(UnmanagedType.LPStr)] string pszPathRel, 
				uint dwReserved);

			//[helpstring("Resolves a shell link. The system searches for the shell link object and updates the shell link path and its list of identifiers (if necessary)")]
			void Resolve(
				IntPtr hWnd, 
				uint fFlags);

			//[helpstring("Sets the shell link path and filename")]
			void SetPath(
				[MarshalAs(UnmanagedType.LPStr)] string pszFile);
		}


		[ComImportAttribute()]
			[GuidAttribute("000214F9-0000-0000-C000-000000000046")]
			[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
			private interface IShellLinkW
		{
			//[helpstring("Retrieves the path and filename of a shell link object")]
			void GetPath([Out(), MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, 
				ref _WIN32_FIND_DATAW pfd, uint fFlags);

			//[helpstring("Retrieves the list of shell link item identifiers")]
			void GetIDList(out IntPtr ppidl);

			//[helpstring("Sets the list of shell link item identifiers")]
			void SetIDList(IntPtr pidl);

			//[helpstring("Retrieves the shell link description string")]
			void GetDescription([Out(), MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile,int cchMaxName);
		
			//[helpstring("Sets the shell link description string")]
			void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);

			//[helpstring("Retrieves the name of the shell link working directory")]
			void GetWorkingDirectory([Out(), MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir,
				int cchMaxPath);

			//[helpstring("Sets the name of the shell link working directory")]
			void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);

			//[helpstring("Retrieves the shell link command-line arguments")]
			void GetArguments([Out(), MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);

			//[helpstring("Sets the shell link command-line arguments")]
			void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);

			//[propget, helpstring("Retrieves or sets the shell link hot key")]
			void GetHotkey(out short pwHotkey);
			//[propput, helpstring("Retrieves or sets the shell link hot key")]
			void SetHotkey(short pwHotkey);

			//[propget, helpstring("Retrieves or sets the shell link show command")]
			void GetShowCmd(out uint piShowCmd);
			//[propput, helpstring("Retrieves or sets the shell link show command")]
			void SetShowCmd(uint piShowCmd);

			//[helpstring("Retrieves the location (path and index) of the shell link icon")]
			void GetIconLocation([Out(), MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, 
				int cchIconPath, out int piIcon);
		
			//[helpstring("Sets the location (path and index) of the shell link icon")]
			void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);

			//[helpstring("Sets the shell link relative path")]
			void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, uint dwReserved);

			//[helpstring("Resolves a shell link. The system searches for the shell link object and updates the shell link path and its list of identifiers (if necessary)")]
			void Resolve(IntPtr hWnd,uint fFlags);

			//[helpstring("Sets the shell link path and filename")]
			void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
		}
		
		
		[GuidAttribute("00021401-0000-0000-C000-000000000046")]
			[ClassInterfaceAttribute(ClassInterfaceType.None)]
			[ComImportAttribute()]
			private class CShellLink{}

		#endregion
		
		#region IShellLink Private structs and enums

		[StructLayoutAttribute(LayoutKind.Sequential, Pack=4, Size=0, CharSet=CharSet.Unicode)]
			private struct _WIN32_FIND_DATAW
		{
			public uint dwFileAttributes;
			public _FILETIME ftCreationTime;
			public _FILETIME ftLastAccessTime;
			public _FILETIME ftLastWriteTime;
			public uint nFileSizeHigh;
			public uint nFileSizeLow;
			public uint dwReserved0;
			public uint dwReserved1;
			[MarshalAs(UnmanagedType.ByValTStr , SizeConst = 260)] // MAX_PATH
			public string cFileName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
			public string cAlternateFileName;
		}

		[StructLayoutAttribute(LayoutKind.Sequential, Pack=4, Size=0, CharSet=CharSet.Ansi)]
			private struct _WIN32_FIND_DATAA
		{
			public uint dwFileAttributes;
			public _FILETIME ftCreationTime;
			public _FILETIME ftLastAccessTime;
			public _FILETIME ftLastWriteTime;
			public uint nFileSizeHigh;
			public uint nFileSizeLow;
			public uint dwReserved0;
			public uint dwReserved1;
			[MarshalAs(UnmanagedType.ByValTStr , SizeConst = 260)] // MAX_PATH
			public string cFileName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
			public string cAlternateFileName;
		}

		[StructLayoutAttribute(LayoutKind.Sequential, Pack=4, Size=0)]
			private struct _FILETIME 
		{
			public uint dwLowDateTime;
			public uint dwHighDateTime;
		}  
		
		public enum EShellLinkResolveFlags : uint
		{
			/// <summary>
			/// Allow any match during resolution.  Has no effect
			/// on ME/2000 or above, use the other flags instead.
			/// </summary>
			SLR_ANY_MATCH = 0x2,
			/// <summary>
			/// Call the Microsoft Windows Installer. 
			/// </summary>
			SLR_INVOKE_MSI = 0x80,
			/// <summary>
			/// Disable distributed link tracking. By default, 
			/// distributed link tracking tracks removable media 
			/// across multiple devices based on the volume name. 
			/// It also uses the UNC path to track remote file 
			/// systems whose drive letter has changed. Setting 
			/// SLR_NOLINKINFO disables both types of tracking.
			/// </summary>
			SLR_NOLINKINFO = 0x40,
			/// <summary>
			/// Do not display a dialog box if the link cannot be resolved. 
			/// When SLR_NO_UI is set, a time-out value that specifies the 
			/// maximum amount of time to be spent resolving the link can 
			/// be specified in milliseconds. The function returns if the 
			/// link cannot be resolved within the time-out duration. 
			/// If the timeout is not set, the time-out duration will be 
			/// set to the default value of 3,000 milliseconds (3 seconds). 
			/// </summary>										    
			SLR_NO_UI = 0x1,
			/// <summary>
			/// Not documented in SDK.  Assume same as SLR_NO_UI but 
			/// intended for applications without a hWnd.
			/// </summary>
			SLR_NO_UI_WITH_MSG_PUMP = 0x101,
			/// <summary>
			/// Do not update the link information. 
			/// </summary>
			SLR_NOUPDATE = 0x8,
			/// <summary>
			/// Do not execute the search heuristics. 
			/// </summary>																																																																																																																																																																																																														
			SLR_NOSEARCH = 0x10,
			/// <summary>
			/// Do not use distributed link tracking. 
			/// </summary>
			SLR_NOTRACK = 0x20,
			/// <summary>
			/// If the link object has changed, update its path and list 
			/// of identifiers. If SLR_UPDATE is set, you do not need to 
			/// call IPersistFile::IsDirty to determine whether or not 
			/// the link object has changed. 
			/// </summary>
			SLR_UPDATE  = 0x4
		}


		
		#endregion

		#region IPersistFile Interface
		[ComImportAttribute()]
			[GuidAttribute("0000010B-0000-0000-C000-000000000046")]
			[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
			private interface IPersistFile
		{
			// can't get this to go if I extend IPersist, so put it here:
			[PreserveSig]
			void GetClassID(out Guid pClassID);

			//[helpstring("Checks for changes since last file write")]		
			void IsDirty();

			//[helpstring("Opens the specified file and initializes the object from its contents")]		
			void Load(
				[MarshalAs(UnmanagedType.LPWStr)] string pszFileName, 
				uint dwMode);

			//[helpstring("Saves the object into the specified file")]		
			void Save(
				[MarshalAs(UnmanagedType.LPWStr)] string pszFileName, 
				[MarshalAs(UnmanagedType.Bool)] bool fRemember);

			//[helpstring("Notifies the object that save is completed")]		
			void SaveCompleted(
				[MarshalAs(UnmanagedType.LPWStr)] string pszFileName);

			//[helpstring("Gets the current name of the file associated with the object")]		
			void GetCurFile(
				[MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);
		}
		
		#endregion


		#region Properties
		public string Description
		{
			get
			{
				StringBuilder description = new StringBuilder(1024, 1024);
				if (linkA == null)
				{
					linkW.GetDescription(description, description.Capacity);
				}
				else
				{
					linkA.GetDescription(description, description.Capacity);
				}
				return description.ToString();
			}
		}
		#endregion

		#region Destructor and Dispose
		/// <summary>
		/// Call dispose just in case it hasn't happened yet
		/// </summary>
		~ShortcutInfo()
		{
			Dispose();
		}

		/// <summary>
		/// Dispose the object, releasing the COM ShellLink object
		/// </summary>
		public void Dispose()
		{
			if (linkW != null ) 
			{
				Marshal.ReleaseComObject(linkW);
				linkW = null;
			}
			if (linkA != null)
			{
				Marshal.ReleaseComObject(linkA);
				linkA = null;
			}
		}
		#endregion

	}
}