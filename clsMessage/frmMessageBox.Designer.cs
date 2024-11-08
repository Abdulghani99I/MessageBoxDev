namespace clsMessageBox
{
    partial class frmMessageBoxDev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureEditIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Location = new System.Drawing.Point(206, 147);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(91, 40);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Text = "Button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Location = new System.Drawing.Point(64, 147);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(91, 40);
            this.btn2.TabIndex = 1;
            this.btn2.TabStop = false;
            this.btn2.Text = "Button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.Location = new System.Drawing.Point(20, 54);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(336, 68);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Show Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureEditIcon
            // 
            this.pictureEditIcon.Location = new System.Drawing.Point(12, -4);
            this.pictureEditIcon.Name = "pictureEditIcon";
            this.pictureEditIcon.Size = new System.Drawing.Size(51, 66);
            this.pictureEditIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEditIcon.TabIndex = 7;
            this.pictureEditIcon.TabStop = false;
            // 
            // frmMessageBoxDev
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 202);
            this.Controls.Add(this.pictureEditIcon);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageBoxDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureEditIcon;
    }
}