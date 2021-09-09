
namespace MiniEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar_como = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Edicion = new System.Windows.Forms.ToolStripMenuItem();
            this.Deshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.Repetir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.Seleccionar_todo = new System.Windows.Forms.ToolStripMenuItem();
            this.Borrar_todo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Texto = new System.Windows.Forms.ToolStripMenuItem();
            this.Tipografia = new System.Windows.Forms.ToolStripMenuItem();
            this.Color = new System.Windows.Forms.ToolStripMenuItem();
            this.botCopiar = new System.Windows.Forms.ToolStripButton();
            this.botCortar = new System.Windows.Forms.ToolStripButton();
            this.botPegar = new System.Windows.Forms.ToolStripButton();
            this.TSComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Edicion,
            this.Texto});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir,
            this.toolStripSeparator1,
            this.Guardar,
            this.Guardar_como,
            this.toolStripSeparator2,
            this.Cerrar});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(60, 20);
            this.Archivo.Text = "Archivo";
            // 
            // Abrir
            // 
            this.Abrir.Name = "Abrir";
            this.Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir.Size = new System.Drawing.Size(180, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Guardar
            // 
            this.Guardar.Name = "Guardar";
            this.Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Guardar.Size = new System.Drawing.Size(180, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Guardar_como
            // 
            this.Guardar_como.Name = "Guardar_como";
            this.Guardar_como.Size = new System.Drawing.Size(180, 22);
            this.Guardar_como.Text = "Guardar como";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Cerrar
            // 
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.Cerrar.Size = new System.Drawing.Size(180, 22);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Edicion
            // 
            this.Edicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Deshacer,
            this.Repetir,
            this.toolStripSeparator3,
            this.Copiar,
            this.Cortar,
            this.Pegar,
            this.toolStripSeparator4,
            this.Seleccionar_todo,
            this.Borrar_todo});
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(58, 20);
            this.Edicion.Text = "Edición";
            // 
            // Deshacer
            // 
            this.Deshacer.Name = "Deshacer";
            this.Deshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Deshacer.Size = new System.Drawing.Size(202, 22);
            this.Deshacer.Text = "Deshacer";
            this.Deshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // Repetir
            // 
            this.Repetir.Name = "Repetir";
            this.Repetir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Repetir.Size = new System.Drawing.Size(202, 22);
            this.Repetir.Text = "Repetir";
            this.Repetir.Click += new System.EventHandler(this.Repetir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // Copiar
            // 
            this.Copiar.Name = "Copiar";
            this.Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copiar.Size = new System.Drawing.Size(202, 22);
            this.Copiar.Text = "Copiar";
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Cortar
            // 
            this.Cortar.Name = "Cortar";
            this.Cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cortar.Size = new System.Drawing.Size(202, 22);
            this.Cortar.Text = "Cortar";
            this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // Pegar
            // 
            this.Pegar.Name = "Pegar";
            this.Pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Pegar.Size = new System.Drawing.Size(202, 22);
            this.Pegar.Text = "Pegar";
            this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // Seleccionar_todo
            // 
            this.Seleccionar_todo.Name = "Seleccionar_todo";
            this.Seleccionar_todo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Seleccionar_todo.Size = new System.Drawing.Size(202, 22);
            this.Seleccionar_todo.Text = "Seleccionar todo";
            this.Seleccionar_todo.Click += new System.EventHandler(this.Seleccionar_todo_Click);
            // 
            // Borrar_todo
            // 
            this.Borrar_todo.Name = "Borrar_todo";
            this.Borrar_todo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.Borrar_todo.Size = new System.Drawing.Size(202, 22);
            this.Borrar_todo.Text = "Borrar todo";
            this.Borrar_todo.Click += new System.EventHandler(this.Borrar_todo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botCopiar,
            this.botCortar,
            this.botPegar,
            this.TSComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(701, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(676, 291);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Texto
            // 
            this.Texto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tipografia,
            this.Color});
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(48, 20);
            this.Texto.Text = "Texto";
            // 
            // Tipografia
            // 
            this.Tipografia.Name = "Tipografia";
            this.Tipografia.Size = new System.Drawing.Size(180, 22);
            this.Tipografia.Text = "Tipografía";
            this.Tipografia.Click += new System.EventHandler(this.Tipografia_Click);
            // 
            // Color
            // 
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(180, 22);
            this.Color.Text = "Color";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // botCopiar
            // 
            this.botCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botCopiar.Image = ((System.Drawing.Image)(resources.GetObject("botCopiar.Image")));
            this.botCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCopiar.Name = "botCopiar";
            this.botCopiar.Size = new System.Drawing.Size(23, 22);
            this.botCopiar.Text = "Copiar";
            this.botCopiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // botCortar
            // 
            this.botCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botCortar.Image = ((System.Drawing.Image)(resources.GetObject("botCortar.Image")));
            this.botCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCortar.Name = "botCortar";
            this.botCortar.Size = new System.Drawing.Size(23, 22);
            this.botCortar.Text = "Cortar";
            this.botCortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // botPegar
            // 
            this.botPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botPegar.Image = ((System.Drawing.Image)(resources.GetObject("botPegar.Image")));
            this.botPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botPegar.Name = "botPegar";
            this.botPegar.Size = new System.Drawing.Size(23, 22);
            this.botPegar.Text = "Pegar";
            this.botPegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // TSComboBox1
            // 
            this.TSComboBox1.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36",
            "40",
            "48"});
            this.TSComboBox1.Name = "TSComboBox1";
            this.TSComboBox1.Size = new System.Drawing.Size(121, 25);
            this.TSComboBox1.SelectedIndexChanged += new System.EventHandler(this.cambiar_tamaño);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 356);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mini Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Guardar_como;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.ToolStripMenuItem Edicion;
        private System.Windows.Forms.ToolStripMenuItem Deshacer;
        private System.Windows.Forms.ToolStripMenuItem Repetir;
        private System.Windows.Forms.ToolStripMenuItem Copiar;
        private System.Windows.Forms.ToolStripMenuItem Pegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Cortar;
        private System.Windows.Forms.ToolStripMenuItem Seleccionar_todo;
        private System.Windows.Forms.ToolStripMenuItem Borrar_todo;
        private System.Windows.Forms.ToolStripMenuItem Texto;
        private System.Windows.Forms.ToolStripMenuItem Tipografia;
        private System.Windows.Forms.ToolStripMenuItem Color;
        private System.Windows.Forms.ToolStripButton botCopiar;
        private System.Windows.Forms.ToolStripButton botCortar;
        private System.Windows.Forms.ToolStripButton botPegar;
        private System.Windows.Forms.ToolStripComboBox TSComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

