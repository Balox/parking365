﻿namespace Sistema.Ventas
{
    partial class MDIMenu
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
            this.Alertas = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Alertas
            // 
            this.Alertas.Enabled = true;
            this.Alertas.Interval = 10800000;
            this.Alertas.Tick += new System.EventHandler(this.Alertas_Tick);
            // 
            // MDIMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.IsMdiContainer = true;
            this.Name = "MDIMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Alertas;

    }
}