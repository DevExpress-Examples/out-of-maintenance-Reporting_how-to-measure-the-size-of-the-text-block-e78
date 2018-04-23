using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
// ...

namespace MeasureString {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_MeasureString1_Click(object sender, EventArgs e) {
            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;
            string s = "Developer Express Inc.";

            // Determine the visual dimensions of the string
            SizeF sz = brickGraph.MeasureString(s);

            // Start the report generation
            printingSystem1.Begin();

            // Specify a page area
            brickGraph.Modifier = BrickModifier.Detail;

            // Create a rectangle of the calculated size plus the border dimensions
            RectangleF rect = new RectangleF(new PointF(0, 0), sz);
            rect = brickGraph.DefaultBrickStyle.InflateBorderWidth(rect, GraphicsDpi.Pixel);
            rect.Offset(-rect.X, -rect.Y);
            // Add a brick to the report
            visBrick = brickGraph.DrawString(s, Color.Black, rect, BorderSide.All);

            // Finish the report generation
            printingSystem1.End();

            // Preview the report
            printingSystem1.PreviewFormEx.Show();
        }

        private void btn_MeasureString2_Click(object sender, EventArgs e) {
            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;
            string s = "Developer Express Inc.";

            // Measure the string, specifying the maximum width
            SizeF sz = brickGraph.MeasureString(s, 75);

            // Start the report generation
            printingSystem1.Begin();

            // Specify a page area
            brickGraph.Modifier = BrickModifier.Detail;

            // Create a rectangle of the calculated size plus the border dimensions
            RectangleF rect = new RectangleF(new PointF(0, 0), sz);
            rect = brickGraph.DefaultBrickStyle.InflateBorderWidth(rect, GraphicsDpi.Pixel);
            rect.Offset(-rect.X, -rect.Y);
            // Add a text brick to the report
            visBrick = brickGraph.DrawString(s, Color.Black, rect, BorderSide.All);

            // Finish the report generation
            printingSystem1.End();
            // Preview the report
            printingSystem1.PreviewFormEx.Show();
        }


        private void btn_MeasureString3_Click(object sender, EventArgs e) {
            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;
            string s = "Developer Express Inc.";

            // Specify the vertical alignment
            StringFormat sFormat = new StringFormat(StringFormatFlags.DirectionVertical);

            // Measure the string with the specified format and maximum width
            SizeF sz = brickGraph.MeasureString(s, 75, sFormat);

            // Start the report generation
            printingSystem1.Begin();

            // Specify a page area
            brickGraph.Modifier = BrickModifier.Detail;

            // Set default vertical alignment for the text in bricks.
            brickGraph.DefaultBrickStyle.StringFormat = new BrickStringFormat(sFormat);

            // Create a rectangle of the calculated size plus the border dimensions
            RectangleF rect = new RectangleF(new PointF(0, 0), sz);
            rect = brickGraph.DefaultBrickStyle.InflateBorderWidth(rect, GraphicsDpi.Pixel);
            rect.Offset(-rect.X, -rect.Y);
            // Add a text brick to the report
            visBrick = brickGraph.DrawString(s, Color.Black, rect, BorderSide.All);

            // Finish the report generation
            printingSystem1.End();

            // Preview the report
            printingSystem1.PreviewFormEx.Show();
        }

    }
}