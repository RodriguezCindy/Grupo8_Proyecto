
namespace ProyectoFinal_G8.Vistas
{
    partial class LoginView
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
            this.CheckMostrar = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckMostrar
            // 
            this.CheckMostrar.AutoSize = true;
            this.CheckMostrar.BackColor = System.Drawing.Color.Transparent;
            this.CheckMostrar.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMostrar.ForeColor = System.Drawing.Color.Black;
            this.CheckMostrar.Location = new System.Drawing.Point(222, 128);
            this.CheckMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.CheckMostrar.Name = "CheckMostrar";
            this.CheckMostrar.Size = new System.Drawing.Size(200, 28);
            this.CheckMostrar.TabIndex = 19;
            this.CheckMostrar.Text = "Mostrar contraseña";
            this.CheckMostrar.UseVisualStyleBackColor = false;
            this.CheckMostrar.CheckedChanged += new System.EventHandler(this.CheckMostrar_CheckedChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(329, 174);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 46);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_contrasena.Location = new System.Drawing.Point(165, 79);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(312, 30);
            this.txt_contrasena.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_email.Location = new System.Drawing.Point(165, 30);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(312, 30);
            this.txt_email.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_aceptar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(188, 174);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(107, 46);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_G8.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(563, 262);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.CheckMostrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox CheckMostrar;
        public System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.TextBox txt_contrasena;
        public System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_aceptar;
    }
}