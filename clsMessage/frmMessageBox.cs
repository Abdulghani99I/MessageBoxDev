using DevExpress.Security;
using DevExpress.Utils.CommonDialogs.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpressInternal = DevExpress.Utils.CommonDialogs.Internal;

namespace clsMessageBox
{
    public partial class frmMessageBoxDev : DevExpress.XtraEditors.XtraForm
    {
        static private DevExpressInternal.DialogResult _DialogResult;


        public enum ModeDialog { Question, Information, Error, None}
        ModeDialog mode = ModeDialog.None;
        public enum Focus { btn1, btn2, none }

        Focus focus = Focus.none;

        public void PlaySound(byte[] NameFile)
        {
            // استخدام MemoryStream لقراءة بيانات الصوت من المصفوفة
            using (MemoryStream memoryStream = new MemoryStream(NameFile))
            {
                // إنشاء كائن SoundPlayer وتشغيل الصوت
                using (SoundPlayer player = new SoundPlayer(memoryStream))
                {
                    player.Play();
                }
            }
        }

        void RunMode(ModeDialog Mode)
        {
            switch (Mode)
            {
                case ModeDialog.Question:
                    pictureEditIcon.Image = Properties.Resources.question_32x32;
                    PlaySound(Properties.Resources.Question);
                    break;

                case ModeDialog.Error:
                    pictureEditIcon.Image = Properties.Resources.deletelist_32x32;
                    PlaySound(Properties.Resources.Error);
                    break;

                case ModeDialog.Information:
                    pictureEditIcon.Image = Properties.Resources.about_32x32;
                    PlaySound(Properties.Resources.Information);
                    break;


                case ModeDialog.None:
                default:
                    //pictureEditIcon.Image = Properties.Resources.deletelist_32x32;
                    //PlaySound(Properties.Resources.Error);
                    break;
            }
        }

        void SetFocusButton(Focus focus)
        {
            // set focus buttons.
            switch (focus)
            {
                case Focus.btn1:
                    btn1.TabStop = true;
                    //btn1.Focus();
                    break;
                case Focus.btn2:
                    btn2.TabStop = true;
                    //btn2.Focus();
                    break;

                default:
                    this.Focus(); // Set the focus to the form itself, canceling focus on other controls.
                    break;
            }
        }

        frmMessageBoxDev(string message, string title, string button1Text, string button2Text, ModeDialog Mode, Focus focus = Focus.none)
        {
            InitializeComponent();
            
            RunMode(Mode);

            _DialogResult = DevExpressInternal.DialogResult.None; // This line is important because is static and public.


            lblMessage.Text = message;
            this.Text = title;

            btn1.Text = button1Text;

            if (string.IsNullOrEmpty(button2Text))
            {
                // If there's only one button, hide the second one
                btn2.Visible = false;
                btn1.Left = (this.ClientSize.Width - btn1.Width) / 2; // Center the button
            }
            else
            {
                btn2.Text = button2Text;
            }

            SetFocusButton(focus);
        }

        frmMessageBoxDev(string message, string title, string button1Text, ModeDialog Mode, Focus focus = Focus.none)
        {
            InitializeComponent();

            RunMode(Mode);


            _DialogResult = DevExpressInternal.DialogResult.None; // This line is important because is static and public

            lblMessage.Text = message;
            this.Text = title;

            btn1.Text = button1Text;

            btn1.Left = (this.ClientSize.Width - btn1.Width) / 2; // Center the button
            btn2.Visible = false; // No Threre btn2 In this Constractor.

            SetFocusButton(focus);
        }

        public static DevExpressInternal.DialogResult ShowDialog(string message, string title, string button1Text, string button2Text, ModeDialog Mode, Focus focus = Focus.none)
        {
            frmMessageBoxDev msgBox = new frmMessageBoxDev(message, title, button1Text, button2Text, Mode, focus);
            msgBox.ShowDialog();
            return _DialogResult;
        }
        
        public static DevExpressInternal.DialogResult ShowDialog(string message, string title, string button1Text, ModeDialog Mode, Focus focus = Focus.none)
        {
            frmMessageBoxDev msgBox = new frmMessageBoxDev(message, title, button1Text, Mode, focus);
            msgBox.ShowDialog();
            return _DialogResult;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            _DialogResult = DevExpressInternal.DialogResult.Yes; // Default action for the first button
            this.Close();
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            _DialogResult = DevExpressInternal.DialogResult.No; // Default action for the second button
            this.Close();
        }
    }
}
