﻿
namespace Durak
{
    partial class RuleGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.tbRules = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(214, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Правила игры";
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.BackgroundImage = global::Durak.Properties.Resources._1612703153_8_p_zelenii_fon_poker_13;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.Color.Salmon;
            this.btExit.Location = new System.Drawing.Point(219, 512);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(126, 55);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbRules
            // 
            this.tbRules.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tbRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRules.ForeColor = System.Drawing.Color.Maroon;
            this.tbRules.Location = new System.Drawing.Point(57, 130);
            this.tbRules.Multiline = true;
            this.tbRules.Name = "tbRules";
            this.tbRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRules.Size = new System.Drawing.Size(478, 343);
            this.tbRules.TabIndex = 2;
            // 
            // RuleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Durak.Properties.Resources.fon_600kh600;
            this.ClientSize = new System.Drawing.Size(588, 592);
            this.Controls.Add(this.tbRules);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.Name = "RuleGame";
            this.Text = "Дурак";
            this.Load += new System.EventHandler(this.RuleGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbRules;
    }
}