﻿#region References
using System;
using System.Activities;
using System.ComponentModel;
using System.Drawing;
#endregion

namespace FWBS.WF.OMS.ActivityLibrary
{
    [ToolboxBitmap(typeof(ResourceFinder), "FWBS.WF.OMS.ActivityLibrary.ShowFile.ShowFileToolboxIcon.bmp")]
	[Description("Shows a File")]
	[Designer(typeof(ShowFileDesigner))]
	public sealed class ShowFile : CodeActivity
	{
		#region Arguments
		[RequiredArgument]
		public InArgument<FWBS.OMS.OMSFile> File { get; set; }
		#endregion

		#region Constructor
		public ShowFile()
		{
			this.DisplayName = "Show File";
		}
		#endregion

		#region Overrides
        /// <summary>
        /// CacheMetadata
        /// </summary>
        /// <param name="metadata"></param>
        protected override void CacheMetadata(CodeActivityMetadata metadata)
		{
			RuntimeArgument argument = new RuntimeArgument("File", typeof(FWBS.OMS.OMSFile), ArgumentDirection.In, true);
			metadata.Bind(this.File, argument);
			metadata.AddArgument(argument);
		}

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="context"></param>
		protected override void Execute(CodeActivityContext context)
		{
			FWBS.OMS.OMSFile file = File.Get(context);

			if (file == null)
			{
				string errMsg = string.Format("Activity Name='{0}' Argument='{1}.File' ID={2}", this.DisplayName, this.GetType().Name, this.Id);
				throw new ArgumentNullException(errMsg);
			}
			else
			{
				FWBS.OMS.UI.Windows.Services.ShowFile(file);
			}
		}
		#endregion
	}
}
