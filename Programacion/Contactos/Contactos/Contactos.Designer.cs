namespace Contactos
{
    partial class Contactos
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
            lblNombre = new Label();
            lblEdad = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btbAgregar = new Button();
            button1 = new Button();
            lstContactos = new ListBox();
            txtEdad = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(44, 114);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(44, 167);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(374, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(157, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(374, 27);
            txtTelefono.TabIndex = 4;
            // 
            // btbAgregar
            // 
            btbAgregar.Location = new Point(253, 220);
            btbAgregar.Name = "btbAgregar";
            btbAgregar.Size = new Size(94, 29);
            btbAgregar.TabIndex = 6;
            btbAgregar.Text = "Añadir";
            btbAgregar.UseVisualStyleBackColor = true;
            btbAgregar.Click += btbAgregar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(253, 450);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.Location = new Point(44, 313);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(487, 104);
            lstContactos.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(157, 107);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(374, 27);
            txtEdad.TabIndex = 9;
            // 
            // Contactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 619);
            Controls.Add(txtEdad);
            Controls.Add(lstContactos);
            Controls.Add(button1);
            Controls.Add(btbAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Contactos";
            Text = "Form1";
            FormClosed += Contactos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Button btbAgregar;
        private Button button1;
        private ListBox lstContactos;
        private TextBox txtEdad;
    }
}
