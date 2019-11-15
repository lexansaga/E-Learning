﻿namespace Elearning
{
    partial class HandoutViewer
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnStartQuiz = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 113);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(654, 557);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartQuiz.AutoSize = true;
            this.btnStartQuiz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartQuiz.Depth = 0;
            this.btnStartQuiz.Icon = global::Elearning.Properties.Resources.icons8_play_90;
            this.btnStartQuiz.Location = new System.Drawing.Point(540, 71);
            this.btnStartQuiz.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Primary = true;
            this.btnStartQuiz.Size = new System.Drawing.Size(126, 36);
            this.btnStartQuiz.TabIndex = 5;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // HandoutViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 682);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.webBrowser1);
            this.Name = "HandoutViewer";
            this.Text = "HandoutViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartQuiz;
    }
}