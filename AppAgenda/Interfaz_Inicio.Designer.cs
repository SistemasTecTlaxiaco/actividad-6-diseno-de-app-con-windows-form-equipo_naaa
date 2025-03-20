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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
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
            rjButton1.Location = new Point(42, 51);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(149, 132);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Usuario";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}