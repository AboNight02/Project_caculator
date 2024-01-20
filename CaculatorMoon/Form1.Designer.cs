namespace CaculatorMoon
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Control_panel = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButt = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Title = new System.Windows.Forms.Label();
            this.Menu = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Keep_on_Top = new Guna.UI2.WinForms.Guna2Button();
            this.caculatorStandard1 = new CaculatorMoon.caculatorStandard();
            this.Control_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Control_panel
            // 
            this.Control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Control_panel.Controls.Add(this.guna2ControlBox2);
            this.Control_panel.Controls.Add(this.label2);
            this.Control_panel.Controls.Add(this.CloseButt);
            this.Control_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_panel.Location = new System.Drawing.Point(0, 0);
            this.Control_panel.Name = "Control_panel";
            this.Control_panel.Size = new System.Drawing.Size(325, 34);
            this.Control_panel.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(235, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 34);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "caculator";
            // 
            // CloseButt
            // 
            this.CloseButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CloseButt.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.CloseButt.HoverState.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButt.IconColor = System.Drawing.Color.White;
            this.CloseButt.Location = new System.Drawing.Point(280, 0);
            this.CloseButt.Name = "CloseButt";
            this.CloseButt.Size = new System.Drawing.Size(45, 34);
            this.CloseButt.TabIndex = 0;
            this.CloseButt.Click += new System.EventHandler(this.CloseButt_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(37, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(93, 24);
            this.Title.TabIndex = 1;
            this.Title.Text = "Standard";
            // 
            // Menu
            // 
            this.Menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Image = global::CaculatorMoon.Properties.Resources.burger_bar;
            this.Menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(41, 40);
            this.Menu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.caculatorStandard1);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 441);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Keep_on_Top);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 40);
            this.panel1.TabIndex = 2;
            // 
            // Keep_on_Top
            // 
            this.Keep_on_Top.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Keep_on_Top.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Keep_on_Top.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Keep_on_Top.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Keep_on_Top.Dock = System.Windows.Forms.DockStyle.Right;
            this.Keep_on_Top.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Keep_on_Top.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Keep_on_Top.ForeColor = System.Drawing.Color.White;
            this.Keep_on_Top.Image = global::CaculatorMoon.Properties.Resources._1699976285308;
            this.Keep_on_Top.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Keep_on_Top.Location = new System.Drawing.Point(284, 0);
            this.Keep_on_Top.Name = "Keep_on_Top";
            this.Keep_on_Top.Size = new System.Drawing.Size(41, 40);
            this.Keep_on_Top.TabIndex = 3;
            this.Keep_on_Top.Click += new System.EventHandler(this.Keep_on_Top_Click);
            // 
            // caculatorStandard1
            // 
            this.caculatorStandard1.BackColor = System.Drawing.Color.Transparent;
            this.caculatorStandard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caculatorStandard1.Location = new System.Drawing.Point(0, 0);
            this.caculatorStandard1.Name = "caculatorStandard1";
            this.caculatorStandard1.Size = new System.Drawing.Size(326, 441);
            this.caculatorStandard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(325, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Control_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Control_panel.ResumeLayout(false);
            this.Control_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel Control_panel;
        private System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2Button Menu;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox CloseButt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Keep_on_Top;
        private caculatorStandard caculatorStandard1;
    }
}

