using System;
using System.Drawing;
using System.Windows.Forms;

namespace emira.GUI
{
    public partial class CustomMsgBox : Form
    {
        bool bTogMove;
        int iValX;
        int iValY;
        static CustomMsgBox MsgBox;

        public CustomMsgBox()
        {
            InitializeComponent();
        }

        public DialogResult Show(string text, string caption, MsgBoxIcon icon, Button button = Button.Close)
        {
            DialogResult dlgResult = DialogResult.None;
            MsgBox = new CustomMsgBox();
            MsgBox.lCaption.Text = caption;
            MsgBox.lMessage.Text = text;

            switch (icon)
            {
                case MsgBoxIcon.None:
                    MsgBox.pbIcon.Visible = false;
                    break;
                case MsgBoxIcon.Information:
                    MsgBox.pbIcon.BackgroundImage = Properties.Resources.info_icon_color_48;
                    break;
                case MsgBoxIcon.Warning:
                    MsgBox.pbIcon.BackgroundImage = Properties.Resources.warning_icon_color_48;
                    break;
                case MsgBoxIcon.Error:
                    MsgBox.pbIcon.BackgroundImage = Properties.Resources.error_icon_color_48;
                    break;
                case MsgBoxIcon.Question:
                    MsgBox.pbIcon.BackgroundImage = Properties.Resources.question_icon_color_48;
                    break;
            }

            switch (button)
            {
                case Button.OK:
                    MsgBox.btnClose.Visible = true;
                    MsgBox.btnClose.Text = "&OK";

                    //// Resize the message box
                    Resize(MsgBox, false);
                    break;
                case Button.YesNo:
                    MsgBox.btnYes.Visible = true;
                    MsgBox.btnNo.Visible = true;

                    //// Resize the message box
                    Resize(MsgBox, true);
                    break;
                case Button.Close:
                    MsgBox.btnClose.Visible = true;
                    MsgBox.btnClose.Text = "&Bezárás";

                    //// Resize the message box
                    Resize(MsgBox, false);
                    break;
                default:
                    break;
            }

            dlgResult = MsgBox.ShowDialog();

            return dlgResult;
        }

        private new void Resize(CustomMsgBox MsgBox, bool YesNO)
        {
            // New MsgBox X coordinate
            int msgBoxXCoordinate = MsgBox.pbIcon.Width + MsgBox.lMessage.Width + 60;

            // New location for the Exit button
            MsgBox.btnExit.Location = new Point(msgBoxXCoordinate - MsgBox.btnExit.Width - 1, MsgBox.btnExit.Location.Y);

            // New size for the pHeader panel
            MsgBox.pHeader.Size = new Size(msgBoxXCoordinate - 2, MsgBox.pHeader.Height);

            // If the message bigger than the icon then the message is moved down the msgbox Y coordinate is also changed and the button(s) 
            if (MsgBox.lMessage.Height > MsgBox.pbIcon.Height)
            {
                int diff = MsgBox.lMessage.Height - MsgBox.pbIcon.Height;
                MsgBox.Size = new Size(msgBoxXCoordinate, MsgBox.Height + diff);
                MsgBox.lMessage.Location = new Point(MsgBox.lMessage.Location.X, MsgBox.pbIcon.Location.Y);
                if (YesNO)
                {
                    MsgBox.btnYes.Location = new Point((MsgBox.Width - MsgBox.btnYes.Width - MsgBox.btnNo.Width) / 3, MsgBox.btnYes.Location.Y + diff + 10);
                    MsgBox.btnNo.Location = new Point(MsgBox.btnYes.Location.X + MsgBox.btnYes.Width * 2, MsgBox.btnNo.Location.Y + diff + 10);
                }
                else
                {

                    MsgBox.btnClose.Location = new Point((MsgBox.Width - MsgBox.btnClose.Width) / 2, MsgBox.btnClose.Location.Y + diff + 10);
                }
            }
            else
            {
                MsgBox.Size = new Size(msgBoxXCoordinate, MsgBox.Height);
                MsgBox.lMessage.Location = new Point(MsgBox.lMessage.Location.X, MsgBox.pbIcon.Location.Y + MsgBox.pbIcon.Height / 2);
                if (YesNO)
                {
                    MsgBox.btnYes.Location = new Point((MsgBox.Width - MsgBox.btnYes.Width - MsgBox.btnNo.Width) / 3, MsgBox.btnYes.Location.Y);
                    MsgBox.btnNo.Location = new Point(MsgBox.btnYes.Location.X + MsgBox.btnYes.Width, MsgBox.btnNo.Location.Y);
                }
                else
                {
                    MsgBox.btnClose.Location = new Point((MsgBox.Width - MsgBox.btnClose.Width) / 2, MsgBox.btnClose.Location.Y);
                }
            }
        }

        public enum MsgBoxIcon
        {
            None = 0,
            Error = 1,
            Question = 2,
            Warning = 3,
            Information = 4
        }

        public enum Button
        {
            OK = 0,
            YesNo = 1,
            Close = 2
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pHeader_MouseUp(object sender, MouseEventArgs e)
        {
            bTogMove = false;
        }

        private void pHeader_MouseDown(object sender, MouseEventArgs e)
        {
            bTogMove = true;
            iValX = e.X;
            iValY = e.Y;
        }

        private void pHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (bTogMove)
            {
                SetDesktopLocation(MousePosition.X - iValX, MousePosition.Y - iValY);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle borderRectangle = new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            e.Graphics.DrawRectangle(Pens.Black, borderRectangle);
            base.OnPaint(e);
        }
    }
}
