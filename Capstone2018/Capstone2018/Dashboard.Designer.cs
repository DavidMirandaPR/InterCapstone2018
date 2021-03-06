﻿namespace Capstone2018
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunScript = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentEnv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShapeDetectedLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // RunScript
            // 
            this.RunScript.Location = new System.Drawing.Point(230, 36);
            this.RunScript.Name = "RunScript";
            this.RunScript.Size = new System.Drawing.Size(75, 23);
            this.RunScript.TabIndex = 1;
            this.RunScript.Text = "Run Script";
            this.RunScript.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RunScript.UseVisualStyleBackColor = true;
            this.RunScript.Click += new System.EventHandler(this.RunScript_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RunScript);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 108);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CurrentEnv
            // 
            this.CurrentEnv.AutoSize = true;
            this.CurrentEnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentEnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CurrentEnv.Location = new System.Drawing.Point(154, 317);
            this.CurrentEnv.Name = "CurrentEnv";
            this.CurrentEnv.Size = new System.Drawing.Size(89, 17);
            this.CurrentEnv.TabIndex = 3;
            this.CurrentEnv.Text = "CurrentEnv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Environment:";
            // 
            // ShapeDetectedLabel
            // 
            this.ShapeDetectedLabel.AutoSize = true;
            this.ShapeDetectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeDetectedLabel.Location = new System.Drawing.Point(15, 285);
            this.ShapeDetectedLabel.Name = "ShapeDetectedLabel";
            this.ShapeDetectedLabel.Size = new System.Drawing.Size(118, 17);
            this.ShapeDetectedLabel.TabIndex = 2;
            this.ShapeDetectedLabel.Text = "Shape Detected: ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 343);
            this.Controls.Add(this.ShapeDetectedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentEnv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Modular Sorting Line";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button RunScript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentEnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShapeDetectedLabel;
    }
}

