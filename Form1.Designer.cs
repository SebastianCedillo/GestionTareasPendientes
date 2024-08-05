namespace GestionTareasPendientes
{
    partial class Form_Tareas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Tarea = new System.Windows.Forms.TextBox();
            this.btn_AgregarTarea = new System.Windows.Forms.Button();
            this.lst_Tareas = new System.Windows.Forms.ListBox();
            this.btn_EliminarTarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Tarea
            // 
            this.txt_Tarea.Location = new System.Drawing.Point(256, 36);
            this.txt_Tarea.Name = "txt_Tarea";
            this.txt_Tarea.Size = new System.Drawing.Size(192, 20);
            this.txt_Tarea.TabIndex = 0;
            this.txt_Tarea.TextChanged += new System.EventHandler(this.txt_Tarea_TextChanged);
            // 
            // btn_AgregarTarea
            // 
            this.btn_AgregarTarea.Location = new System.Drawing.Point(256, 76);
            this.btn_AgregarTarea.Name = "btn_AgregarTarea";
            this.btn_AgregarTarea.Size = new System.Drawing.Size(113, 28);
            this.btn_AgregarTarea.TabIndex = 1;
            this.btn_AgregarTarea.Text = "Agregar Tarea";
            this.btn_AgregarTarea.UseVisualStyleBackColor = true;
            this.btn_AgregarTarea.Click += new System.EventHandler(this.btn_AgregarTarea_Click);
            // 
            // lst_Tareas
            // 
            this.lst_Tareas.FormattingEnabled = true;
            this.lst_Tareas.Location = new System.Drawing.Point(256, 117);
            this.lst_Tareas.Name = "lst_Tareas";
            this.lst_Tareas.Size = new System.Drawing.Size(479, 290);
            this.lst_Tareas.TabIndex = 2;
            this.lst_Tareas.SelectedIndexChanged += new System.EventHandler(this.lst_Tareas_SelectedIndexChanged);
            // 
            // btn_EliminarTarea
            // 
            this.btn_EliminarTarea.Location = new System.Drawing.Point(256, 443);
            this.btn_EliminarTarea.Name = "btn_EliminarTarea";
            this.btn_EliminarTarea.Size = new System.Drawing.Size(113, 30);
            this.btn_EliminarTarea.TabIndex = 3;
            this.btn_EliminarTarea.Text = "Eliminar Tarea";
            this.btn_EliminarTarea.UseVisualStyleBackColor = true;
            this.btn_EliminarTarea.Click += new System.EventHandler(this.btn_EliminarTarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese las tareas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_EliminarTarea);
            this.Controls.Add(this.lst_Tareas);
            this.Controls.Add(this.btn_AgregarTarea);
            this.Controls.Add(this.txt_Tarea);
            this.Name = "Form_Tareas";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.Form_Tareas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Tarea;
        private System.Windows.Forms.Button btn_AgregarTarea;
        private System.Windows.Forms.ListBox lst_Tareas;
        private System.Windows.Forms.Button btn_EliminarTarea;
        private System.Windows.Forms.Label label1;
    }
}

