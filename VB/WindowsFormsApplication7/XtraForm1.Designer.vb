﻿Imports Microsoft.VisualBasic
Imports System
Imports MyCustomXtraTabbedMdiManager

Namespace WindowsFormsApplication7
	Partial Public Class XtraForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.myXtraTabbedMdiManager1 = New MyXtraTabbedMdiManager(Me.components)
			CType(Me.myXtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myXtraTabbedMdiManager1
			' 
			Me.myXtraTabbedMdiManager1.MdiParent = Me
			' 
			' XtraForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(417, 307)
			Me.IsMdiContainer = True
			Me.Name = "XtraForm1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.myXtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myXtraTabbedMdiManager1 As MyXtraTabbedMdiManager

	End Class
End Namespace

