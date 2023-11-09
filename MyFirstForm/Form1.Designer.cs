namespace MyFirstForm
{
    partial class MyNewForm
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
            btnOk = new Button();
            btnCancel = new Button();
            txtFrase = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(96, 117);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(106, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Iniciar Debulha";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += BtnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(456, 117);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(96, 42);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(435, 23);
            txtFrase.TabIndex = 3;
            txtFrase.Text = "Digite uma frase";
            txtFrase.Visible = false;
            txtFrase.TextChanged += TxtFrase_TextChanged;
            // 
            // MyNewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 324);
            Controls.Add(txtFrase);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "MyNewForm";
            Text = "Aplicação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private TextBox txtFrase;
    }
}