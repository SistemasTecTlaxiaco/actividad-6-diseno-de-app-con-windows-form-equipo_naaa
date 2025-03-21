namespace AppAgenda
{
    partial class Interfaz_Inicio
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
            panel1 = new Panel();
            rjButton1 = new CustomControls.RJControls.RJButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(rjButton1);
            panel1.Location = new Point(-11, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 1057);
            panel1.TabIndex = 1;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.CadetBlue;
            rjButton1.BackgroundColor = Color.CadetBlue;
            rjButton1.BorderColor = Color.SlateGray;
            rjButton1.BorderRadius = 60;
            rjButton1.BorderSize = 5;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(60, 43);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(149, 132);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Usuario";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(286, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 162);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PowderBlue;
            panel3.Location = new Point(15, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(882, 143);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PaleTurquoise;
            panel4.Location = new Point(916, 268);
            panel4.Name = "panel4";
            panel4.Size = new Size(534, 739);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.PaleTurquoise;
            panel5.Location = new Point(286, 268);
            panel5.Name = "panel5";
            panel5.Size = new Size(534, 739);
            panel5.TabIndex = 3;
            // 
            // Interfaz_Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 1044);
            Controls.Add(panel1);
            Name = "Interfaz_Inicio";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
    }
}