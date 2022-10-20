namespace Activity_14
{
    partial class Form1
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
            this.uninstall = new System.Windows.Forms.RadioButton();
            this.reinstall = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.CheckBox();
            this.reasonList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uninstall
            // 
            this.uninstall.AutoSize = true;
            this.uninstall.Location = new System.Drawing.Point(16, 122);
            this.uninstall.Name = "uninstall";
            this.uninstall.Size = new System.Drawing.Size(79, 20);
            this.uninstall.TabIndex = 0;
            this.uninstall.TabStop = true;
            this.uninstall.Text = "Uninstall";
            this.uninstall.UseVisualStyleBackColor = true;
            // 
            // reinstall
            // 
            this.reinstall.AutoSize = true;
            this.reinstall.Location = new System.Drawing.Point(16, 148);
            this.reinstall.Name = "reinstall";
            this.reinstall.Size = new System.Drawing.Size(80, 20);
            this.reinstall.TabIndex = 1;
            this.reinstall.TabStop = true;
            this.reinstall.Text = "Reinstall";
            this.reinstall.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(142, 178);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(74, 20);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.CheckedChanged += new System.EventHandler(this.confirm_CheckedChanged);
            // 
            // reasonList
            // 
            this.reasonList.FormattingEnabled = true;
            this.reasonList.ItemHeight = 16;
            this.reasonList.Items.AddRange(new object[] {
            "Missing features",
            "Too expensive",
            "other "});
            this.reasonList.Location = new System.Drawing.Point(16, 32);
            this.reasonList.Name = "reasonList";
            this.reasonList.Size = new System.Drawing.Size(309, 84);
            this.reasonList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Uninstall reason:";
            // 
            // Continue
            // 
            this.Continue.Enabled = false;
            this.Continue.Location = new System.Drawing.Point(222, 175);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(103, 23);
            this.Continue.TabIndex = 6;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 210);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonList);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.reinstall);
            this.Controls.Add(this.uninstall);
            this.Name = "Form1";
            this.Text = "Uninstall Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton uninstall;
        private System.Windows.Forms.RadioButton reinstall;
        private System.Windows.Forms.CheckBox confirm;
        private System.Windows.Forms.ListBox reasonList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button @continue;
        private System.Windows.Forms.Button Continue;
    }
}

