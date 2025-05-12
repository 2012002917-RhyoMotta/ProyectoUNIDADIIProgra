namespace Proyecto
{
    partial class SUBMENU15
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
            lblRespuesta = new Label();
            lblIngreso = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(150, 182);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(0, 37);
            lblRespuesta.TabIndex = 11;
            // 
            // lblIngreso
            // 
            lblIngreso.Location = new Point(132, 101);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(340, 43);
            lblIngreso.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(132, 37);
            label3.TabIndex = 9;
            label3.Text = "Mililitros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(107, 74);
            label2.TabIndex = 8;
            label2.Text = "Onza\r\nlíquida:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 23);
            label1.Name = "label1";
            label1.Size = new Size(306, 37);
            label1.TabIndex = 7;
            label1.Text = "Onza líquida a Mililitros";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(12, 257);
            button1.Name = "button1";
            button1.Size = new Size(460, 69);
            button1.TabIndex = 6;
            button1.Text = "CONVERTIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SUBMENU15
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(484, 336);
            Controls.Add(lblRespuesta);
            Controls.Add(lblIngreso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(7);
            Name = "SUBMENU15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fl oz a mL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRespuesta;
        private TextBox lblIngreso;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}