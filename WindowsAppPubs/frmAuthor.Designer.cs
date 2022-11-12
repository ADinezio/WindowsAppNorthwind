namespace WindowsAppPubs
{
    partial class frmAuthor
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.btnTraerUno = new System.Windows.Forms.Button();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.lstAuthor = new System.Windows.Forms.ListBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.lblTraerUnAuthor = new System.Windows.Forms.Label();
            this.txtTraerUno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(26, 39);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(151, 43);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(26, 116);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 43);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(325, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(263, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerTodos.Location = new System.Drawing.Point(325, 256);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(263, 43);
            this.btnTraerTodos.TabIndex = 3;
            this.btnTraerTodos.Text = "Traer Todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // btnTraerUno
            // 
            this.btnTraerUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerUno.Location = new System.Drawing.Point(792, 69);
            this.btnTraerUno.Name = "btnTraerUno";
            this.btnTraerUno.Size = new System.Drawing.Size(240, 43);
            this.btnTraerUno.TabIndex = 4;
            this.btnTraerUno.Text = "Traer Uno";
            this.btnTraerUno.UseVisualStyleBackColor = true;
            this.btnTraerUno.Click += new System.EventHandler(this.btnTraerUno_Click);
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(26, 316);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.Size = new System.Drawing.Size(1006, 240);
            this.gridAuthor.TabIndex = 5;
            // 
            // lstAuthor
            // 
            this.lstAuthor.FormattingEnabled = true;
            this.lstAuthor.Location = new System.Drawing.Point(792, 139);
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.Size = new System.Drawing.Size(240, 160);
            this.lstAuthor.TabIndex = 6;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(219, 41);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(219, 15);
            this.lblEliminar.TabIndex = 7;
            this.lblEliminar.Text = "Ingrese ID  de Author a eliminar :";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(444, 39);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 8;
            // 
            // lblTraerUnAuthor
            // 
            this.lblTraerUnAuthor.AutoSize = true;
            this.lblTraerUnAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraerUnAuthor.Location = new System.Drawing.Point(637, 39);
            this.lblTraerUnAuthor.Name = "lblTraerUnAuthor";
            this.lblTraerUnAuthor.Size = new System.Drawing.Size(250, 15);
            this.lblTraerUnAuthor.TabIndex = 9;
            this.lblTraerUnAuthor.Text = "Ingrese ID  del Author que quiere ver :";
            // 
            // txtTraerUno
            // 
            this.txtTraerUno.Location = new System.Drawing.Point(893, 36);
            this.txtTraerUno.Name = "txtTraerUno";
            this.txtTraerUno.Size = new System.Drawing.Size(100, 20);
            this.txtTraerUno.TabIndex = 10;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 568);
            this.Controls.Add(this.txtTraerUno);
            this.Controls.Add(this.lblTraerUnAuthor);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lstAuthor);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.btnTraerUno);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmAuthor";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Button btnTraerUno;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.ListBox lstAuthor;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label lblTraerUnAuthor;
        private System.Windows.Forms.TextBox txtTraerUno;
    }
}