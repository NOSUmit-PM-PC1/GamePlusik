namespace GamePlusik
{
    partial class FormGame
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMulty = new System.Windows.Forms.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelCountSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(78, 58);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(163, 167);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMulty
            // 
            this.buttonMulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMulty.Location = new System.Drawing.Point(530, 58);
            this.buttonMulty.Name = "buttonMulty";
            this.buttonMulty.Size = new System.Drawing.Size(163, 167);
            this.buttonMulty.TabIndex = 1;
            this.buttonMulty.Text = "х2";
            this.buttonMulty.UseVisualStyleBackColor = true;
            this.buttonMulty.Click += new System.EventHandler(this.buttonMulty_Click);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTarget.Location = new System.Drawing.Point(365, 73);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(60, 42);
            this.labelTarget.TabIndex = 2;
            this.labelTarget.Text = "15";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.BackColor = System.Drawing.Color.Yellow;
            this.labelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrent.Location = new System.Drawing.Point(365, 183);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(39, 42);
            this.labelCurrent.TabIndex = 3;
            this.labelCurrent.Text = "1";
            // 
            // labelCountSteps
            // 
            this.labelCountSteps.AutoSize = true;
            this.labelCountSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelCountSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountSteps.Location = new System.Drawing.Point(78, 299);
            this.labelCountSteps.Name = "labelCountSteps";
            this.labelCountSteps.Size = new System.Drawing.Size(274, 31);
            this.labelCountSteps.TabIndex = 4;
            this.labelCountSteps.Text = "Количество шагов: 0";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCountSteps);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.buttonMulty);
            this.Controls.Add(this.buttonPlus);
            this.Name = "FormGame";
            this.Text = "Игра ПЛЮСИК";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMulty;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelCountSteps;
    }
}

