namespace DesignerResposivo
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
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuEsquerdo = new System.Windows.Forms.Panel();
            this.menuSuperior = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Location = new System.Drawing.Point(563, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 126);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // menuEsquerdo
            // 
            this.menuEsquerdo.BackColor = System.Drawing.Color.CadetBlue;
            this.menuEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.menuEsquerdo.Name = "menuEsquerdo";
            this.menuEsquerdo.Size = new System.Drawing.Size(155, 454);
            this.menuEsquerdo.TabIndex = 1;
            // 
            // menuSuperior
            // 
            this.menuSuperior.BackColor = System.Drawing.Color.Fuchsia;
            this.menuSuperior.Location = new System.Drawing.Point(176, 12);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(530, 120);
            this.menuSuperior.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuSuperior);
            this.Controls.Add(this.menuEsquerdo);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Panel menuEsquerdo;
        private Panel menuSuperior;
    }
}