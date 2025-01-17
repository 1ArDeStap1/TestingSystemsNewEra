using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class FormsStyle : Component
    {
        #region Variables

        public Color HeaderColor = Color.FromArgb(0, 0, 60);
        public int HeaderHeight = 40;
        public Form form { get; set; }

        public StringFormat SF = new StringFormat();
        private Font font = new Font("Roboto", 8.75F, FontStyle.Regular);

        private Size IconSize = new Size(15, 15);

        Pen WhitePen = new Pen(Color.White) { Width=1.55F };

        bool MousePressed = false;
        Point ClickPosition;
        Point moveStartPosition;

        Rectangle BtnExit = new Rectangle();
        bool BtnExitHovered = false;

        #endregion

        #region Values

        /*private fStyle formStyle = fStyle.None;
        public fStyle formStyle
        {
            get => formStyle;
            set
            {
                formStyle = value;
                Sign();
            }

        }

        public enum fStyle { 
            None,

            Simple
        }*/

        #endregion

        public void Sign()
        {
            if (form != null)
            {
                form.Load += Form_Load;
            }
        }

        public void Apply(bool ChangePosition = true)
        {
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

            form.FormBorderStyle = FormBorderStyle.None;

            setDoubleBuffer(form);

            if (ChangePosition)
                OffsetHeaderControl();
            else form.Refresh();

            form.Paint += Form_Paint;
            form.MouseDown += Form_MouseDown;
            form.MouseUp += Form_MouseUp;
            form.MouseMove += Form_MouseMove;
            form.MouseLeave += Form_MouseLeave;
        }


        public void OffsetHeaderControl()
        {

            form.Height = form.Height + HeaderHeight;
            
            foreach(Control ctrl in form.Controls)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + HeaderHeight);
                ctrl.Refresh();
            }


        }


        public FormsStyle()
        {
            Sign();
            InitializeComponent();
        }

        public FormsStyle(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }


        #region FormEvents

        private void Form_Load(object sender, EventArgs e)
        {

            Apply();

        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                Size formOffset = new Size(Point.Subtract(Cursor.Position, new Size(ClickPosition)));
                form.Location = Point.Add(moveStartPosition, formOffset);
            }
            else
            {
                if (BtnExit.Contains(e.Location))
                {
                    if (!BtnExitHovered)
                    {
                        BtnExitHovered = true;
                        form.Invalidate();
                    }
                    
                }
                else
                {
                    BtnExitHovered = false;
                    form.Invalidate();
                }
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;

            if (e.Button == MouseButtons.Left)
            {
                if (BtnExit.Contains(e.Location))
                {
                    form.Close();
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= HeaderHeight)
            {
                MousePressed = true;
                ClickPosition = Cursor.Position;
                moveStartPosition = form.Location;
            }
        }

        private void Form_MouseLeave(object sender, EventArgs e)
        {
            BtnExitHovered = false;
            form.Invalidate();
        }

        #endregion

        private void DrawStyle(Graphics gr)
        {
            gr.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectHeader = new Rectangle(0, 0, form.Width - 1, HeaderHeight);
            Rectangle rectHeaderBorder = new Rectangle(0, 0, form.Width - 1, HeaderHeight-1);

            Rectangle RectTitle = new Rectangle(rectHeader.X, rectHeader.Y, rectHeader.Width, rectHeader.Height);

            Rectangle RectIcon = new Rectangle(
                rectHeader.Height / 4 - IconSize.Width / 3,
                rectHeader.Height / 4 - IconSize.Height / 3,
                IconSize.Width*2, IconSize.Height*2
                );

            Rectangle rectCrosshair = new Rectangle(
                BtnExit.X + BtnExit.Width / 2 - 5,
                BtnExit.Height / 2 - 5,
                10, 10
                );
            


            BtnExit = new Rectangle(rectHeader.Width - rectHeader.Height, rectHeader.Y, rectHeader.Height, rectHeader.Height);

            gr.DrawRectangle(new Pen(HeaderColor), rectHeader);
            gr.FillRectangle(new SolidBrush(HeaderColor), rectHeader);

            gr.DrawRectangle(new Pen(BtnExitHovered ? Color.Red : HeaderColor), BtnExit);
            gr.FillRectangle(new SolidBrush(BtnExitHovered ? Color.Red : HeaderColor), BtnExit);
            DrawCross(gr, rectCrosshair, WhitePen);

            gr.DrawRectangle(new Pen(form.ForeColor), rectHeaderBorder);

            gr.DrawString(form.Text, font, new SolidBrush(Color.White), RectTitle, SF);

            gr.DrawImage(form.Icon.ToBitmap(), RectIcon);

           
            
        }

        private void DrawCross(Graphics graph, Rectangle rect, Pen pen)
        {
            graph.DrawLine(pen, rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
            graph.DrawLine(pen, rect.X + rect.Width, rect.Y, rect.X, rect.Y + rect.Height);
        }


        public void setDoubleBuffer(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo pDoubleBuffered =
                typeof(Control).GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance
                    );

            pDoubleBuffered.SetValue(c, true, null);

        }

    }
}
