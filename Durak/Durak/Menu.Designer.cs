
namespace Durak
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btNGame = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.btParam = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNGame
            // 
            this.btNGame.AutoSize = true;
            this.btNGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNGame.BackgroundImage")));
            this.btNGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNGame.ForeColor = System.Drawing.Color.Salmon;
            this.btNGame.Location = new System.Drawing.Point(292, 111);
            this.btNGame.Margin = new System.Windows.Forms.Padding(4);
            this.btNGame.Name = "btNGame";
            this.btNGame.Size = new System.Drawing.Size(200, 60);
            this.btNGame.TabIndex = 0;
            this.btNGame.Text = "Новая игра";
            this.btNGame.UseVisualStyleBackColor = false;
            this.btNGame.Click += new System.EventHandler(this.btNGame_Click);
            // 
            // btResume
            // 
            this.btResume.AutoSize = true;
            this.btResume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btResume.BackgroundImage")));
            this.btResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btResume.ForeColor = System.Drawing.Color.Salmon;
            this.btResume.Location = new System.Drawing.Point(292, 179);
            this.btResume.Margin = new System.Windows.Forms.Padding(4);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(200, 60);
            this.btResume.TabIndex = 1;
            this.btResume.Text = "Продолжить";
            this.btResume.UseVisualStyleBackColor = false;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // btParam
            // 
            this.btParam.AutoSize = true;
            this.btParam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btParam.BackgroundImage")));
            this.btParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btParam.ForeColor = System.Drawing.Color.Salmon;
            this.btParam.Location = new System.Drawing.Point(292, 247);
            this.btParam.Margin = new System.Windows.Forms.Padding(4);
            this.btParam.Name = "btParam";
            this.btParam.Size = new System.Drawing.Size(200, 60);
            this.btParam.TabIndex = 2;
            this.btParam.Text = "Настройки";
            this.btParam.UseVisualStyleBackColor = false;
            this.btParam.Click += new System.EventHandler(this.btParam_Click);
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExit.BackgroundImage")));
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.Color.Salmon;
            this.btExit.Location = new System.Drawing.Point(292, 381);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(200, 60);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(313, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результаты игр";
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbResult.ForeColor = System.Drawing.Color.Maroon;
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 16;
            this.lbResult.Location = new System.Drawing.Point(261, 536);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(264, 148);
            this.lbResult.TabIndex = 5;
            // 
            // btInfo
            // 
            this.btInfo.BackgroundImage = global::Durak.Properties.Resources._1612703153_8_p_zelenii_fon_poker_13;
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btInfo.ForeColor = System.Drawing.Color.Salmon;
            this.btInfo.Location = new System.Drawing.Point(292, 314);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(200, 60);
            this.btInfo.TabIndex = 6;
            this.btInfo.Text = "Информация";
            this.btInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 791);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btParam);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.btNGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Дурак";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNGame;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btParam;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btInfo;
    }
}

