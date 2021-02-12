#Region "Copyright Syncfusion Inc. 2001 - 2020"
'
'  Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.IO

Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Licensing
Imports Syncfusion.WinForms.Controls

Namespace FindReplaceDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits SfForm

		Private components As IContainer = Nothing
		Private editControl2 As EditControl

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
		   Me.editControl2.Dock = DockStyle.Fill

			'Me.editControl2.SetEncoding(Encoding.Default)
			'Me.editControl2.Text = "£££"

			Dim inputPath As String = "../../TextFile1.txt"
			Dim outputPath As String = "../../TextFile2.txt"

			Dim fs = New FileStream(inputPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite Or FileShare.Delete)
			Dim content As String
			Using reader As New StreamReader(fs, Encoding.Default)
				content = reader.ReadToEnd()
			End Using

			File.WriteAllText(outputPath, content, Encoding.Default)
			Me.editControl2.Text = content

		End Sub


		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim config1 As New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config()
			Me.editControl2 = New Syncfusion.Windows.Forms.Edit.EditControl()
			DirectCast(Me.editControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' editControl2
			' 
			Me.editControl2.AllowZoom = False
			Me.editControl2.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(238)))), (CInt((CByte(98)))))
			Me.editControl2.CodeSnipptSize = New System.Drawing.Size(100, 100)
			Me.editControl2.Configurator = config1
			Me.editControl2.ContextChoiceBackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.editControl2.ContextChoiceBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(233)))), (CInt((CByte(166)))), (CInt((CByte(50)))))
			Me.editControl2.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText
			Me.editControl2.ContextPromptBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255))))))
			Me.editControl2.ContextTooltipBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(232)))), (CInt((CByte(236))))))
			Me.editControl2.IndicatorMarginBackColor = System.Drawing.Color.Empty
			Me.editControl2.LineNumbersColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.editControl2.Location = New System.Drawing.Point(13, 13)
			Me.editControl2.MarkerAreaWidth = 20
			Me.editControl2.Name = "editControl2"
			Me.editControl2.RenderRightToLeft = False
			Me.editControl2.ScrollPosition = New System.Drawing.Point(0, 0)
			Me.editControl2.SelectionTextColor = System.Drawing.Color.FromArgb((CInt((CByte(173)))), (CInt((CByte(214)))), (CInt((CByte(255)))))
			Me.editControl2.Size = New System.Drawing.Size(553, 398)
			Me.editControl2.StatusBarSettings.CoordsPanel.Width = 150
			Me.editControl2.StatusBarSettings.EncodingPanel.Width = 100
			Me.editControl2.StatusBarSettings.FileNamePanel.Width = 100
			Me.editControl2.StatusBarSettings.InsertPanel.Width = 33
			Me.editControl2.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue
			Me.editControl2.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue
			Me.editControl2.StatusBarSettings.StatusPanel.Width = 70
			Me.editControl2.StatusBarSettings.TextPanel.Width = 214
			Me.editControl2.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default
			Me.editControl2.TabIndex = 0
			Me.editControl2.Text = "editControl2"
			Me.editControl2.UseXPStyleBorder = True
			Me.editControl2.VisualColumn = 13
			Me.editControl2.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate
			Me.editControl2.ZoomFactor = 1F
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
			Me.ClientSize = New System.Drawing.Size(560, 419)
			Me.Controls.Add(Me.editControl2)
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(10)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
			Me.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center
			Me.Text = "EditControl_Encoding"
			Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
			DirectCast(Me.editControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()

			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

	End Class

End Namespace