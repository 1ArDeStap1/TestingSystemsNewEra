using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tester.AnimationClasses;

namespace Tester.CustomStyles
{
    public partial class CustomTextBox : Control
    {

        #region Variables

        StringFormat SF = new StringFormat();
        int TopBorderOffset = 0;

        public int VerticalOffset { get; set; } = 8;

        TextBox tbInput = new TextBox();

        Animation TextPopUp = new Animation();
        Animation FontSizeChanger = new Animation();

        #endregion

        #region Properties

        public string TextPreview { get; set; } = "Input Text";
        public Font FontTextPreview { get; set; } = new Font("Arial", 8, FontStyle.Bold);

        public Color BorderColor { get; set; } = Color.DarkBlue;
        public Color BorderColorNotActive { get; set; } = Color.DarkGray;
        
        public string TextInput
        {
            get => tbInput.Text;
            set => tbInput.Text = value;
        }

        public bool UseSystemPasswordChars
        {
            get => tbInput.UseSystemPasswordChar;
            set => tbInput.UseSystemPasswordChar = value;
        }

/*        public int verticalOffset
        {
            get => verticalOffset;
            set { verticalOffset = value; }
        }*/

        [Browsable(false)]
        public new string Text { get; set; }

        #endregion


        public CustomTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(150, 40);
            Font = new Font("Arial", 11.5F, FontStyle.Regular);

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

            ForeColor = Color.Black;
            BackColor = Color.White;

            AdjustTextBoxInput();
            Controls.Add(tbInput);

            TextPopUp.Value = tbInput.Location.Y;
            FontSizeChanger.Value = Font.Size;
        }

        private void AdjustTextBoxInput()
        {
            tbInput = new TextBox();
            tbInput.BorderStyle = BorderStyle.None;
            tbInput.Name = "InputBox";
            tbInput.BackColor = BackColor;
            tbInput.ForeColor = ForeColor;
            tbInput.Font = Font;

            int offset = TextRenderer.MeasureText(TextPreview, FontTextPreview).Height / 2;
            tbInput.Location = new Point(10, Height / 2 - offset + VerticalOffset);
            tbInput.Size = new Size(Width - 10, tbInput.Height);


            tbInput.LostFocus += Tb_LostFocus;
        }

        private void Tb_LostFocus(object sender, EventArgs e)
        {
            TextPreviewAction(false);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            
            TextPreviewAction(TextInput.Length > 0);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            tbInput.BackColor = BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            tbInput.ForeColor = ForeColor;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            tbInput.Font = Font;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            g.Clear(Parent.BackColor);

            TopBorderOffset = g.MeasureString(TextPreview, FontTextPreview).ToSize().Height / 2;

            Font ActualFontTextPrev = new Font(FontTextPreview.FontFamily, FontSizeChanger.Value, FontTextPreview.Style);

            if (tbInput.Visible == false && ActualFontTextPrev.Size <= FontTextPreview.Size) 
            {
                tbInput.Visible = true;
                tbInput.Focus();
            }
            else if (tbInput.Visible == true && ActualFontTextPrev.Size > FontTextPreview.Size)
            {
                tbInput.Visible = false;
            }


            Rectangle rectBase = new Rectangle(0, TopBorderOffset, Width - 1, Height - 1 - TopBorderOffset);

            Size TextPreviewRectSize = g.MeasureString(TextPreview, ActualFontTextPrev).ToSize();
            Rectangle rectTextPreview = new Rectangle(5, (int)TextPopUp.Value, TextPreviewRectSize.Width + 3, TextPreviewRectSize.Height);

            g.DrawRectangle(new Pen(tbInput.Focused ? BorderColor : BorderColorNotActive), rectBase);


            g.DrawRectangle(new Pen(Parent.BackColor), rectTextPreview);    
            g.FillRectangle(new SolidBrush(Parent.BackColor), rectTextPreview);

            g.FillRectangle(new SolidBrush(BackColor), rectBase);

            g.DrawString(TextPreview, ActualFontTextPrev, new SolidBrush(tbInput.Focused ? BorderColor : BorderColorNotActive), rectTextPreview, SF);
        }

        private void TextPreviewAction(bool OTop)
        {
            if (OTop)
            {
                if (!tbInput.Visible) { 
                TextPopUp = new Animation("TextPreviewLocationY_"+Handle, Invalidate, TextPopUp.Value, 0);
                FontSizeChanger = new Animation("FontSizeChangerY_" + Handle, Invalidate, FontSizeChanger.Value, FontTextPreview.Size);
                }
                else
                {
                    tbInput.Focus();
                    return;
                }
            }
            else
            {
                if (TextInput.Length == 0)
                {
                    TextPopUp = new Animation("TextPreviewLocationY_" + Handle, Invalidate, TextPopUp.Value, tbInput.Location.Y);
                    FontSizeChanger = new Animation("FontSizeChangerY_" + Handle, Invalidate, FontSizeChanger.Value, Font.Size);
                }
                else
                {
                    return;
                }
            }

            TextPopUp.StepDivider = 4;
            FontSizeChanger.StepDivider = 4;

            Animator.Request(TextPopUp, true);
            Animator.Request(FontSizeChanger, true);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            TextPreviewAction(true);
        }

    }
}
