namespace AppGraficar
{
    partial class FrmLv
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.LSTV1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(111, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(93, 40);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(12, 3);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(93, 40);
            this.BtnAbrir.TabIndex = 3;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // LSTV1
            // 
            this.LSTV1.HideSelection = false;
            this.LSTV1.Location = new System.Drawing.Point(3, 49);
            this.LSTV1.Name = "LSTV1";
            this.LSTV1.Size = new System.Drawing.Size(785, 389);
            this.LSTV1.TabIndex = 5;
            this.LSTV1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmLv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LSTV1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAbrir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLv";
            this.Text = "FrmLv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.ListView LSTV1;
    }
}