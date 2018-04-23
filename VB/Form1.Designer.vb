Imports Microsoft.VisualBasic
Imports System
Namespace MeasureString
	Partial Public Class Form1
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
				components.Dispose ()
			End If
			MyBase.Dispose (disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.btn_MeasureString1 = New System.Windows.Forms.Button()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.btn_MeasureString2 = New System.Windows.Forms.Button()
			Me.btn_MeasureString3 = New System.Windows.Forms.Button()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btn_MeasureString1
			' 
			Me.btn_MeasureString1.Location = New System.Drawing.Point(91, 45)
			Me.btn_MeasureString1.Name = "btn_MeasureString1"
			Me.btn_MeasureString1.Size = New System.Drawing.Size(117, 33)
			Me.btn_MeasureString1.TabIndex = 0
			Me.btn_MeasureString1.Text = "MeasureString1"
			Me.btn_MeasureString1.UseVisualStyleBackColor = True
'			Me.btn_MeasureString1.Click += New System.EventHandler(Me.btn_MeasureString1_Click);
			' 
			' btn_MeasureString2
			' 
			Me.btn_MeasureString2.Location = New System.Drawing.Point(91, 101)
			Me.btn_MeasureString2.Name = "btn_MeasureString2"
			Me.btn_MeasureString2.Size = New System.Drawing.Size(117, 33)
			Me.btn_MeasureString2.TabIndex = 1
			Me.btn_MeasureString2.Text = "MeasureString2"
			Me.btn_MeasureString2.UseVisualStyleBackColor = True
'			Me.btn_MeasureString2.Click += New System.EventHandler(Me.btn_MeasureString2_Click);
			' 
			' btn_MeasureString3
			' 
			Me.btn_MeasureString3.Location = New System.Drawing.Point(91, 156)
			Me.btn_MeasureString3.Name = "btn_MeasureString3"
			Me.btn_MeasureString3.Size = New System.Drawing.Size(117, 33)
			Me.btn_MeasureString3.TabIndex = 2
			Me.btn_MeasureString3.Text = "MeasureString3"
			Me.btn_MeasureString3.UseVisualStyleBackColor = True
'			Me.btn_MeasureString3.Click += New System.EventHandler(Me.btn_MeasureString3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 266)
			Me.Controls.Add(Me.btn_MeasureString3)
			Me.Controls.Add(Me.btn_MeasureString2)
			Me.Controls.Add(Me.btn_MeasureString1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private btn_MeasureString1 As System.Windows.Forms.Button
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private btn_MeasureString2 As System.Windows.Forms.Button
		Private btn_MeasureString3 As System.Windows.Forms.Button
	End Class
End Namespace

