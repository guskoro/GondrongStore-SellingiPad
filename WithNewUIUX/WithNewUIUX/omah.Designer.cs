namespace WithNewUIUX
{
    partial class omah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(omah));
            this.Form_Omah_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BuyForYou = new System.Windows.Forms.Button();
            this.btn_BuyForYourStore = new System.Windows.Forms.Button();
            this.Form_Omah_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Omah_Panel
            // 
            this.Form_Omah_Panel.Controls.Add(this.label2);
            this.Form_Omah_Panel.Controls.Add(this.label3);
            this.Form_Omah_Panel.Controls.Add(this.btn_BuyForYou);
            this.Form_Omah_Panel.Controls.Add(this.btn_BuyForYourStore);
            this.Form_Omah_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form_Omah_Panel.Location = new System.Drawing.Point(0, 0);
            this.Form_Omah_Panel.Name = "Form_Omah_Panel";
            this.Form_Omah_Panel.Size = new System.Drawing.Size(894, 644);
            this.Form_Omah_Panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 41);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buy for You";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buy for Your Store";
            // 
            // btn_BuyForYou
            // 
            this.btn_BuyForYou.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuyForYou.BackgroundImage")));
            this.btn_BuyForYou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuyForYou.Location = new System.Drawing.Point(121, 327);
            this.btn_BuyForYou.Name = "btn_BuyForYou";
            this.btn_BuyForYou.Size = new System.Drawing.Size(652, 288);
            this.btn_BuyForYou.TabIndex = 13;
            this.btn_BuyForYou.UseVisualStyleBackColor = true;
            this.btn_BuyForYou.Click += new System.EventHandler(this.btn_BuyForYou_Click_1);
            // 
            // btn_BuyForYourStore
            // 
            this.btn_BuyForYourStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuyForYourStore.BackgroundImage")));
            this.btn_BuyForYourStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuyForYourStore.Location = new System.Drawing.Point(121, 30);
            this.btn_BuyForYourStore.Name = "btn_BuyForYourStore";
            this.btn_BuyForYourStore.Size = new System.Drawing.Size(652, 264);
            this.btn_BuyForYourStore.TabIndex = 12;
            this.btn_BuyForYourStore.UseVisualStyleBackColor = true;
            this.btn_BuyForYourStore.Click += new System.EventHandler(this.btn_BuyForYourStore_Click_1);
            // 
            // omah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 644);
            this.Controls.Add(this.Form_Omah_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "omah";
            this.Text = "omah";
            this.Form_Omah_Panel.ResumeLayout(false);
            this.Form_Omah_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Form_Omah_Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BuyForYou;
        private System.Windows.Forms.Button btn_BuyForYourStore;
    }
}