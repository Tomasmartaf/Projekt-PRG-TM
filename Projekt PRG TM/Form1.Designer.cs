namespace Projekt_PRG_TM
{
    partial class Form1
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
            Nadpis = new Label();
            SuspendLayout();
            // 
            // Nadpis
            // 
            Nadpis.AutoSize = true;
            Nadpis.BackColor = Color.Transparent;
            Nadpis.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Nadpis.ForeColor = SystemColors.Control;
            Nadpis.Location = new Point(225, 9);
            Nadpis.Name = "Nadpis";
            Nadpis.Size = new Size(328, 89);
            Nadpis.TabIndex = 0;
            Nadpis.Text = "ŠIBENICE";
            Nadpis.Click += Nadpis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Nadpis);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nadpis;
    }
}
