﻿namespace AppAgenda
{
    partial class Interfaz_Contraseña
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(-11, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 1057);
            panel1.TabIndex = 1;
            // 
            // Interfaz_Contraseña
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 1044);
            Controls.Add(panel1);
            Name = "Interfaz_Contraseña";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}