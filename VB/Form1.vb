Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
' ...

Namespace MeasureString
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btn_MeasureString1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim s As String = "Developer Express Inc."

			' Determine the visual dimensions of the string
			Dim sz As SizeF = brickGraph.MeasureString(s)

			' Start the report generation
			printingSystem1.Begin()

			' Specify a page area
			brickGraph.Modifier = BrickModifier.Detail

			' Create a rectangle of the calculated size plus the border dimensions
			Dim rect As New RectangleF(New PointF(0, 0), sz)
			rect = brickGraph.DefaultBrickStyle.InflateBorderWidth(rect, GraphicsDpi.Pixel)
			rect.Offset(-rect.X, -rect.Y)
			' Add a brick to the report
			visBrick = brickGraph.DrawString(s, Color.Black, rect, BorderSide.All)

			' Finish the report generation
			printingSystem1.End()

			' Preview the report
			printingSystem1.PreviewFormEx.Show()
		End Sub

		Private Sub btn_MeasureString2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim s As String = "Developer Express Inc."

			' Measure the string, specifying the maximum width
			Dim sz As SizeF = brickGraph.MeasureString(s, 75)

			' Start the report generation
			printingSystem1.Begin()

			' Specify a page area
			brickGraph.Modifier = BrickModifier.Detail

			' Create a rectangle of the calculated size plus the border dimensions
			Dim rect As New RectangleF(New PointF(0, 0), sz)
			rect = brickGraph.DefaultBrickStyle.InflateBorderWidth(rect, GraphicsDpi.Pixel)
			rect.Offset(-rect.X, -rect.Y)
			' Add a text brick to the report
			visBrick = brickGraph.DrawString(s, Color.Black, rect, BorderSide.All)

			' Finish the report generation
			printingSystem1.End()
			' Preview the report
			printingSystem1.PreviewFormEx.Show()
		End Sub


		Private Sub btn_MeasureString3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim s As String = "Developer Express Inc."

			' Specify the vertical alignment
			Dim sFormat As New StringFormat(StringFormatFlags.DirectionVertical)

			' Measure the string with the specified format and maximum width
			Dim sz As SizeF = brickGraph.MeasureString(s, 75, sFormat)

			' Start the report generation
			printingSystem1.Begin()

			' Specify a page area
			brickGraph.Modifier = BrickModifier.Detail

			' Set default vertical alignment for the text in bricks.
			brickGraph.DefaultBrickStyle.StringFormat = New BrickStringFormat(sFormat)

			' Create a rectangle of the calculated size plus the border dimensions
			Dim rect As New RectangleF(New PointF(0, 0), sz)
			rect = brickGraph.DefaultBrickStyle.InflateBorderWidth(rect, GraphicsDpi.Pixel)
			rect.Offset(-rect.X, -rect.Y)
			' Add a text brick to the report
			visBrick = brickGraph.DrawString(s, Color.Black, rect, BorderSide.All)

			' Finish the report generation
			printingSystem1.End()

			' Preview the report
			printingSystem1.PreviewFormEx.Show()
		End Sub

	End Class
End Namespace