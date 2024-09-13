namespace Practica2UI.encapsulamineto
{
    partial class EncapsulamientoForm
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
            Titlelabel = new Label();
            InputTextBox = new TextBox();
            depositButton = new Button();
            withdrawButton = new Button();
            balanceButton = new Button();
            SuspendLayout();
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Titlelabel.Location = new Point(227, 54);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(270, 20);
            Titlelabel.TabIndex = 0;
            Titlelabel.Text = "ingrese el monto a depositar o retirar";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(279, 105);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(125, 27);
            InputTextBox.TabIndex = 1;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(142, 177);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(94, 29);
            depositButton.TabIndex = 2;
            depositButton.Text = "depositar";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(310, 177);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(94, 29);
            withdrawButton.TabIndex = 3;
            withdrawButton.Text = "retirar";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // balanceButton
            // 
            balanceButton.Location = new Point(503, 177);
            balanceButton.Name = "balanceButton";
            balanceButton.Size = new Size(94, 29);
            balanceButton.TabIndex = 4;
            balanceButton.Text = "saldo";
            balanceButton.UseVisualStyleBackColor = true;
            balanceButton.Click += balanceButton_Click;
            // 
            // EncapsulamientoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 387);
            Controls.Add(balanceButton);
            Controls.Add(withdrawButton);
            Controls.Add(depositButton);
            Controls.Add(InputTextBox);
            Controls.Add(Titlelabel);
            Name = "EncapsulamientoForm";
            Text = "EncapsulamientoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titlelabel;
        private TextBox InputTextBox;
        private Button depositButton;
        private Button withdrawButton;
        private Button balanceButton;
    }
}