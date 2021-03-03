
namespace LightYearsToKiloMeters
{
    partial class LightYearsToKiloMeters
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKiloMeter = new System.Windows.Forms.Label();
            this.tbLightYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(230, 220);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LightYear :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KiloMeter :";
            // 
            // lbKiloMeter
            // 
            this.lbKiloMeter.AutoSize = true;
            this.lbKiloMeter.Location = new System.Drawing.Point(100, 130);
            this.lbKiloMeter.Name = "lbKiloMeter";
            this.lbKiloMeter.Size = new System.Drawing.Size(0, 13);
            this.lbKiloMeter.TabIndex = 3;
            // 
            // tbLightYear
            // 
            this.tbLightYear.Location = new System.Drawing.Point(100, 80);
            this.tbLightYear.Name = "tbLightYear";
            this.tbLightYear.Size = new System.Drawing.Size(205, 20);
            this.tbLightYear.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AstronomicUnit :";
            // 
            // lbAU
            // 
            this.lbAU.AutoSize = true;
            this.lbAU.Location = new System.Drawing.Point(100, 180);
            this.lbAU.Name = "lbAU";
            this.lbAU.Size = new System.Drawing.Size(0, 13);
            this.lbAU.TabIndex = 6;
            // 
            // LightYearsToKiloMeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.lbAU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLightYear);
            this.Controls.Add(this.lbKiloMeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Name = "LightYearsToKiloMeters";
            this.Text = "LightYearsToKiloMeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKiloMeter;
        private System.Windows.Forms.TextBox tbLightYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAU;
    }
}

