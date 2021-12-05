
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
            this.CheckMostrar.Location = new System.Drawing.Point(166, 104);
            this.CheckMostrar.Name = "CheckMostrar";
            this.CheckMostrar.Size = new System.Drawing.Size(159, 23);
            this.CheckMostrar.TabIndex = 19;
            this.CheckMostrar.Text = "Mostrar contraseña";
            this.CheckMostrar.UseVisualStyleBackColor = false;
            this.CheckMostrar.CheckedChanged += new System.EventHandler(this.CheckMostrar_CheckedChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(247, 141);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 37);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_contrasena.Location = new System.Drawing.Point(124, 64);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(235, 26);
            this.txt_contrasena.TabIndex = 16;
            this.txt_contrasena.Text = "1234";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_email.Location = new System.Drawing.Point(124, 24);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(235, 26);
            this.txt_email.TabIndex = 15;
            this.txt_email.Text = "Proyecto@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(141, 141);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(80, 37);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_G8.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(422, 213);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.CheckMostrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginView";
            this.Text = "Login";
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