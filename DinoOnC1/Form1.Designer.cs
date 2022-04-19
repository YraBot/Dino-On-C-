namespace DinoOnC1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            road2 = new System.Windows.Forms.Label();
            road1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // road2
            // 
            road2.AutoSize = true;
            road2.Image = ((System.Drawing.Image)(resources.GetObject("road2.Image")));
            road2.Location = new System.Drawing.Point(739, 364);
            road2.Name = "road2";
            road2.Size = new System.Drawing.Size(1000, 13);
            road2.TabIndex = 1;
            road2.Text = resources.GetString("road2.Text");
            // 
            // road1
            // 
            road1.AutoSize = true;
            road1.Image = ((System.Drawing.Image)(resources.GetObject("road1.Image")));
            road1.Location = new System.Drawing.Point(-4, 364);
            road1.Name = "road1";
            road1.Size = new System.Drawing.Size(1000, 13);
            road1.TabIndex = 2;
            road1.Text = resources.GetString("road1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(road1);
            this.Controls.Add(road2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        static private System.Windows.Forms.Label road2;
        static private System.Windows.Forms.Label road1;
    }
}

