namespace WinFormsIntro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_clickMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EnterLeave = new System.Windows.Forms.Button();
            this.btn_State = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clickMe
            // 
            this.btn_clickMe.AutoSize = true;
            this.btn_clickMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clickMe.Location = new System.Drawing.Point(924, 261);
            this.btn_clickMe.Name = "btn_clickMe";
            this.btn_clickMe.Size = new System.Drawing.Size(133, 62);
            this.btn_clickMe.TabIndex = 0;
            this.btn_clickMe.Text = "Click me";
            this.btn_clickMe.UseVisualStyleBackColor = true;
            this.btn_clickMe.Click += new System.EventHandler(this.btn_clickMe_Click);
            this.btn_clickMe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_clickMe_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(352, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baki vaxti ile";
            // 
            // btn_EnterLeave
            // 
            this.btn_EnterLeave.AutoSize = true;
            this.btn_EnterLeave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EnterLeave.Location = new System.Drawing.Point(909, 52);
            this.btn_EnterLeave.Name = "btn_EnterLeave";
            this.btn_EnterLeave.Size = new System.Drawing.Size(148, 67);
            this.btn_EnterLeave.TabIndex = 2;
            this.btn_EnterLeave.Text = "EnterLeave";
            this.btn_EnterLeave.UseVisualStyleBackColor = true;
            this.btn_EnterLeave.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btn_EnterLeave.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btn_State
            // 
            this.btn_State.Location = new System.Drawing.Point(938, 492);
            this.btn_State.Name = "btn_State";
            this.btn_State.Size = new System.Drawing.Size(108, 62);
            this.btn_State.TabIndex = 3;
            this.btn_State.Text = "State";
            this.btn_State.UseVisualStyleBackColor = true;
            this.btn_State.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(21, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Label";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsIntro.Properties.Resources.Flag_map_of_Azerbaijan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1088, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_State);
            this.Controls.Add(this.btn_EnterLeave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clickMe);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_clickMe;
        private Label label1;
        private Button btn_EnterLeave;
        private Button btn_State;
        private Button button1;
    }
}