﻿namespace JackalHost.Monitors
{
    partial class TileControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblPirates = new System.Windows.Forms.Label();
			this.lblGold = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPirates
			// 
			this.lblPirates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPirates.ForeColor = System.Drawing.Color.White;
			this.lblPirates.Location = new System.Drawing.Point(3, 3);
			this.lblPirates.Name = "lblPirates";
			this.lblPirates.Size = new System.Drawing.Size(28, 28);
			this.lblPirates.TabIndex = 0;
			this.lblPirates.Text = "0";
			// 
			// lblGold
			// 
			this.lblGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGold.ForeColor = System.Drawing.Color.Gold;
			this.lblGold.Location = new System.Drawing.Point(26, 24);
			this.lblGold.Name = "lblGold";
			this.lblGold.Size = new System.Drawing.Size(28, 28);
			this.lblGold.TabIndex = 1;
			this.lblGold.Text = "0";
			// 
			// TileControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.lblGold);
			this.Controls.Add(this.lblPirates);
			this.Name = "TileControl";
			this.Size = new System.Drawing.Size(56, 56);
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblPirates;
        public System.Windows.Forms.Label lblGold;
    }
}