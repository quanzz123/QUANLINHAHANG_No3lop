using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ElipseControl : Component
{
    private Control control;
    private int cornerRadius = 30;
    private bool topLeft = true;
    private bool topRight = true;
    private bool bottomLeft = true;
    private bool bottomRight = true;

    public ElipseControl()
    {
    }

    public ElipseControl(IContainer container)
    {
        container.Add(this);
    }

    public Control TargetControl
    {
        get => control;
        set
        {
            control = value;
            if (control != null)
            {
                control.SizeChanged += Control_SizeChanged;
                UpdateControlRegion();
            }
        }
    }

    public int CornerRadius
    {
        get => cornerRadius;
        set
        {
            cornerRadius = value;
            UpdateControlRegion();
        }
    }

    public bool TopLeft
    {
        get => topLeft;
        set
        {
            topLeft = value;
            UpdateControlRegion();
        }
    }

    public bool TopRight
    {
        get => topRight;
        set
        {
            topRight = value;
            UpdateControlRegion();
        }
    }

    public bool BottomLeft
    {
        get => bottomLeft;
        set
        {
            bottomLeft = value;
            UpdateControlRegion();
        }
    }

    public bool BottomRight
    {
        get => bottomRight;
        set
        {
            bottomRight = value;
            UpdateControlRegion();
        }
    }

    private void Control_SizeChanged(object sender, EventArgs e)
    {
        UpdateControlRegion();
    }

    private void UpdateControlRegion()
    {
        if (control == null)
            return;

        using (GraphicsPath path = new GraphicsPath())
        {
            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);
            float radius = cornerRadius * 2;

            if (TopLeft)
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X + cornerRadius, rect.Y);

            if (TopRight)
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            else
                path.AddLine(rect.Right - cornerRadius, rect.Y, rect.Right, rect.Y);

            if (BottomRight)
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            else
                path.AddLine(rect.Right, rect.Bottom - cornerRadius, rect.Right, rect.Bottom);

            if (BottomLeft)
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            else
                path.AddLine(rect.X + cornerRadius, rect.Bottom, rect.X, rect.Bottom);

            path.CloseAllFigures();

            control.Region = new Region(path);
        }
    }
}
