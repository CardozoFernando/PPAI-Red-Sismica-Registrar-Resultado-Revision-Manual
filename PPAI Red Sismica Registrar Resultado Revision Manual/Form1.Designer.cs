namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual
{
    partial class VentanaRedSismica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegResRevMan = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegResRevMan
            // 
            btnRegResRevMan.Location = new Point(318, 244);
            btnRegResRevMan.Name = "btnRegResRevMan";
            btnRegResRevMan.Size = new Size(192, 81);
            btnRegResRevMan.TabIndex = 0;
            btnRegResRevMan.Text = "Registrar";
            btnRegResRevMan.UseVisualStyleBackColor = true;
            btnRegResRevMan.Click += BtnRegResRevMan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 188);
            label1.Name = "label1";
            label1.Size = new Size(391, 25);
            label1.TabIndex = 1;
            label1.Text = "¿Desea Registrar Resultado de Revision Manual?";
            // 
            // VentanaRedSismica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 548);
            Controls.Add(label1);
            Controls.Add(btnRegResRevMan);
            Name = "VentanaRedSismica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Red Sismica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegResRevMan;
        private Label label1;
    }
}
