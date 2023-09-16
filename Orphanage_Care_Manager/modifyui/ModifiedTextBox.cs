using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModifiedTextBox : TextBox
{
    private int cornerRadius = 100;
    private int textBoxHeight = 30; // Default height

    public int CornerRadius
    {
        get { return cornerRadius; }
        set { cornerRadius = value; Invalidate(); }
    }

    public int TextBoxHeight
    {
        get { return textBoxHeight; }
        set { textBoxHeight = value; Height = value; Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a rounded rectangle for the textbox
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            // Draw the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(ForeColor, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
