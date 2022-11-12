namespace WindowsAppPubs
{
    partial class frmStore
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.gridStore = new System.Windows.Forms.DataGridView();
            this.btnTraerUno = new System.Windows.Forms.Button();
            this.lstTraeUno = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(12, 28);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 52);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 86);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 52);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 52);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(166, 28);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(110, 52);
            this.btnTraerTodos.TabIndex = 3;
            this.btnTraerTodos.Text = "Traer Todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // gridStore
            // 
            this.gridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStore.Location = new System.Drawing.Point(12, 230);
            this.gridStore.Name = "gridStore";
            this.gridStore.Size = new System.Drawing.Size(757, 180);
            this.gridStore.TabIndex = 4;
            // 
            // btnTraerUno
            // 
            this.btnTraerUno.Location = new System.Drawing.Point(166, 97);
            this.btnTraerUno.Name = "btnTraerUno";
            this.btnTraerUno.Size = new System.Drawing.Size(110, 52);
            this.btnTraerUno.TabIndex = 5;
            this.btnTraerUno.Text = "Traer Uno";
            this.btnTraerUno.UseVisualStyleBackColor = true;
            this.btnTraerUno.Click += new System.EventHandler(this.btnTraerUno_Click);
            // 
            // lstTraeUno
            // 
            this.lstTraeUno.FormattingEnabled = true;
            this.lstTraeUno.Location = new System.Drawing.Point(384, 28);
            this.lstTraeUno.Name = "lstTraeUno";
            this.lstTraeUno.Size = new System.Drawing.Size(249, 134);
            this.lstTraeUno.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTraeUno);
            this.Controls.Add(this.btnTraerUno);
            this.Controls.Add(this.gridStore);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.DataGridView gridStore;
        private System.Windows.Forms.Button btnTraerUno;
        private System.Windows.Forms.ListBox lstTraeUno;
    }
}