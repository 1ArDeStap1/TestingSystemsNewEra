using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tester.AnimationClasses;

namespace Tester
{
    public class CustomButton : Control
    {

        private bool roundingEnabled = false;
        public bool RoundingEnabled
        {
            get => roundingEnabled;
            set 
            { 
                roundingEnabled = value;
                Refresh();
            }
        }


        private int roundingPercent = 100;
        public int RoundingPercent
        {
            get => roundingPercent;
            set
            {
                if(value >= 0 && value <= 100)
                {
                    roundingPercent = value;
                    Refresh();
                }
            }
        }

        private StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        private bool MouseClicked = false;

        Animation ButtonAnimation = new Animation();
        Animation RippleButtonAnimation = new Animation();

        Point clickLocation = new Point();

        public CustomButton() 
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);
            
            BackColor = Color.Aqua;
            ForeColor = Color.Crimson;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

        }

        protected override void OnPaint(PaintEventArgs e)
        {            
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            g.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width-1, Height-1);
            Rectangle rectAnim = new Rectangle(0, 0, (int)ButtonAnimation.Value , Height - 1);
            Rectangle rectRipple = new Rectangle(
                clickLocation.X - (int)RippleButtonAnimation.Value / 2, clickLocation.Y - (int)RippleButtonAnimation.Value / 2,
                (int)RippleButtonAnimation.Value, (int)RippleButtonAnimation.Value);

            float RoundValue = 0.1F;
            if (roundingEnabled && roundingPercent > 0)
            {
                RoundValue = Height / 100F * roundingPercent;
            }
            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, RoundValue);

            g.SetClip(rectPath);

            g.DrawPath(new Pen(BackColor), rectPath);
            g.FillPath(new SolidBrush(BackColor), rectPath);

            g.DrawRectangle(new Pen(Color.FromArgb(100, Color.White)), rectAnim);
            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.White)), rectAnim);


            


/*            if (MouseClicked)
            {
                g.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                g.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);

            }*/

            if (RippleButtonAnimation.Value > 0 && RippleButtonAnimation.Value < RippleButtonAnimation.TargetValue)
            {
                g.DrawEllipse(new Pen(Color.FromArgb(30, Color.White)), rectRipple);
                g.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.White)), rectRipple);
            } else if (RippleButtonAnimation.Value < RippleButtonAnimation.TargetValue)
            {
                RippleButtonAnimation.Value = 0;
            }

            g.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            //ButtonAnimationAction();

            //Invalidate();
        }

        /*private void ButtonAnimationAction()
        {
            if (MouseEntered)
            {

                ButtonAnimation = new Animation("ButtonAnim_" + Handle, Invalidate, ButtonAnimation.Value, Width - 1);

            }
            else {

                ButtonAnimation = new Animation("ButtonAnim_" + Handle, Invalidate, ButtonAnimation.Value, 0);

            }

            Animator.Request(ButtonAnimation, true);
        }*/

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            //ButtonAnimationAction();
            //Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MouseClicked = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MouseClicked = true;
            //Invalidate();

            ButtonAnimation.Value = ButtonAnimation.TargetValue;

            clickLocation = e.Location;

            StartRippleAnimation();

            Focus();

        }

        private void StartRippleAnimation()
        {
            RippleButtonAnimation = new Animation("ButtonRipple_" + Handle, Invalidate, 0, Width);

            Animator.Request(RippleButtonAnimation, true);
        }
    }
}
