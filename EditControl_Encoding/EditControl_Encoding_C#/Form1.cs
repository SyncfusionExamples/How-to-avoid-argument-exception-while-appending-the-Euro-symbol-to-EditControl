#region Copyright Syncfusion Inc. 2001 - 2020
//
//  Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace FindReplaceDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
    {
        private IContainer components = null;
        private EditControl editControl2;
        
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
           this.editControl2.Dock = DockStyle.Fill;

            this.editControl2.SetEncoding(Encoding.Default);
            this.editControl2.Text = "£££";

            //string inputPath = @"../../TextFile1.txt";
            //string outputPath = @"../../TextFile2.txt";

            //var fs = new FileStream(inputPath, FileMode.Open, FileAccess.Read,
            //                                  FileShare.ReadWrite | FileShare.Delete);
            //string content;
            //using (StreamReader reader = new StreamReader(fs, Encoding.Default))
            //{
            //    content = reader.ReadToEnd();
            //}

            //File.WriteAllText(outputPath, content, Encoding.Default);
            //this.editControl2.Text = content;

        }


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            this.editControl2 = new Syncfusion.Windows.Forms.Edit.EditControl();
            ((System.ComponentModel.ISupportInitialize)(this.editControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl2
            // 
            this.editControl2.AllowZoom = false;
            this.editControl2.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.editControl2.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl2.Configurator = config1;
            this.editControl2.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editControl2.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.editControl2.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.editControl2.ContextPromptBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.editControl2.ContextTooltipBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(236))))));
            this.editControl2.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl2.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editControl2.Location = new System.Drawing.Point(13, 13);
            this.editControl2.MarkerAreaWidth = 20;
            this.editControl2.Name = "editControl2";
            this.editControl2.RenderRightToLeft = false;
            this.editControl2.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl2.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.editControl2.Size = new System.Drawing.Size(553, 398);
            this.editControl2.StatusBarSettings.CoordsPanel.Width = 150;
            this.editControl2.StatusBarSettings.EncodingPanel.Width = 100;
            this.editControl2.StatusBarSettings.FileNamePanel.Width = 100;
            this.editControl2.StatusBarSettings.InsertPanel.Width = 33;
            this.editControl2.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.editControl2.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.editControl2.StatusBarSettings.StatusPanel.Width = 70;
            this.editControl2.StatusBarSettings.TextPanel.Width = 214;
            this.editControl2.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.editControl2.TabIndex = 0;
            this.editControl2.Text = "editControl2";
            this.editControl2.UseXPStyleBorder = true;
            this.editControl2.VisualColumn = 13;
            this.editControl2.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.editControl2.ZoomFactor = 1F;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.ClientSize = new System.Drawing.Size(560, 419);
            this.Controls.Add(this.editControl2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "EditControl_Encoding";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.editControl2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		} 

	}

}