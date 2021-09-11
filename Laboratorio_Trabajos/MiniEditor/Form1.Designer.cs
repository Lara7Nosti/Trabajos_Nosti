
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.botGuardar = new System.Windows.Forms.ToolStripButton();
            this.botGuardar_como = new System.Windows.Forms.ToolStripButton();
            this.botCopiar = new System.Windows.Forms.ToolStripButton();
            this.botCortar = new System.Windows.Forms.ToolStripButton();
            this.botPegar = new System.Windows.Forms.ToolStripButton();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar_como = new System.Windows.Forms.ToolStripMenuItem();
            this.Opciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Deshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.Repetir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Seleccionar_todo = new System.Windows.Forms.ToolStripMenuItem();
            this.Borrar_todo = new System.Windows.Forms.ToolStripMenuItem();
            this.Insertar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tipografia = new System.Windows.Forms.ToolStripMenuItem();
            this.Color = new System.Windows.Forms.ToolStripMenuItem();
            this.Fondo = new System.Windows.Forms.ToolStripMenuItem();
            this.Imagen = new System.Windows.Forms.ToolStripMenuItem();
            this.botDeshacer = new System.Windows.Forms.ToolStripButton();
            this.botRepetir = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Opciones,
            this.Insertar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botGuardar,
            this.botGuardar_como,
            this.TSComboBox1,
            this.botCopiar,
            this.botCortar,
            this.botPegar,
            this.botDeshacer,
            this.botRepetir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(511, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(511, 308);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RTF files (*.rtf)|*.rtf|TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf|TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // botGuardar
            // 
            this.botGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botGuardar.Image = global::MiniEditor.Properties.Resources.Guardar;
            this.botGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(23, 22);
            this.botGuardar.Text = "Guardar";
            // 
            // botGuardar_como
            // 
            this.botGuardar_como.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botGuardar_como.Image = global::MiniEditor.Properties.Resources.Guardar_como;
            this.botGuardar_como.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botGuardar_como.Name = "botGuardar_como";
            this.botGuardar_como.Size = new System.Drawing.Size(23, 22);
            this.botGuardar_como.Text = "Guardar como";
            // 
            // botCopiar
            // 
            this.botCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botCopiar.Image = global::MiniEditor.Properties.Resources.Copiar;
            this.botCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCopiar.Name = "botCopiar";
            this.botCopiar.Size = new System.Drawing.Size(23, 22);
            this.botCopiar.Text = "Copiar";
            this.botCopiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // botCortar
            // 
            this.botCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botCortar.Image = global::MiniEditor.Properties.Resources.Cortar;
            this.botCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCortar.Name = "botCortar";
            this.botCortar.Size = new System.Drawing.Size(23, 22);
            this.botCortar.Text = "Cortar";
            this.botCortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // botPegar
            // 
            this.botPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botPegar.Image = global::MiniEditor.Properties.Resources.Pegar;
            this.botPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botPegar.Name = "botPegar";
            this.botPegar.Size = new System.Drawing.Size(23, 22);
            this.botPegar.Text = "Pegar";
            this.botPegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir,
            this.Nuevo,
            this.toolStripSeparator1,
            this.Guardar,
            this.Guardar_como});
            this.Archivo.Image = global::MiniEditor.Properties.Resources.Archivo;
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(76, 20);
            this.Archivo.Text = "Archivo";
            // 
            // Abrir
            // 
            this.Abrir.Image = global::MiniEditor.Properties.Resources.Abrir;
            this.Abrir.Name = "Abrir";
            this.Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir.Size = new System.Drawing.Size(156, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Image = global::MiniEditor.Properties.Resources.Nuevo;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Nuevo.Size = new System.Drawing.Size(156, 22);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::MiniEditor.Properties.Resources.Guardar;
            this.Guardar.Name = "Guardar";
            this.Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Guardar.Size = new System.Drawing.Size(156, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Guardar_como
            // 
            this.Guardar_como.Image = global::MiniEditor.Properties.Resources.Guardar_como;
            this.Guardar_como.Name = "Guardar_como";
            this.Guardar_como.Size = new System.Drawing.Size(156, 22);
            this.Guardar_como.Text = "Guardar como";
            this.Guardar_como.Click += new System.EventHandler(this.Guardar_como_Click);
            // 
            // Opciones
            // 
            this.Opciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Deshacer,
            this.Repetir,
            this.toolStripSeparator3,
            this.Copiar,
            this.Cortar,
            this.Pegar,
            this.toolStripSeparator4,
            this.Seleccionar_todo,
            this.Borrar_todo});
            this.Opciones.Image = global::MiniEditor.Properties.Resources.Opciones;
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(85, 20);
            this.Opciones.Text = "Opciones";
            // 
            // Deshacer
            // 
            this.Deshacer.Image = global::MiniEditor.Properties.Resources.Deshacer;
            this.Deshacer.Name = "Deshacer";
            this.Deshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Deshacer.Size = new System.Drawing.Size(202, 22);
            this.Deshacer.Text = "Deshacer";
            this.Deshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // Repetir
            // 
            this.Repetir.Image = global::MiniEditor.Properties.Resources.Repetir;
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
            this.Copiar.Image = global::MiniEditor.Properties.Resources.Copiar;
            this.Copiar.Name = "Copiar";
            this.Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copiar.Size = new System.Drawing.Size(202, 22);
            this.Copiar.Text = "Copiar";
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Cortar
            // 
            this.Cortar.Image = global::MiniEditor.Properties.Resources.Cortar;
            this.Cortar.Name = "Cortar";
            this.Cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cortar.Size = new System.Drawing.Size(202, 22);
            this.Cortar.Text = "Cortar";
            this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // Pegar
            // 
            this.Pegar.Image = global::MiniEditor.Properties.Resources.Pegar;
            this.Pegar.Name = "Pegar";
            this.Pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Pegar.Size = new System.Drawing.Size(202, 22);
            this.Pegar.Text = "Pegar";
            this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
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
            this.Borrar_todo.Image = global::MiniEditor.Properties.Resources.Borrar_todo;
            this.Borrar_todo.Name = "Borrar_todo";
            this.Borrar_todo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.Borrar_todo.Size = new System.Drawing.Size(202, 22);
            this.Borrar_todo.Text = "Borrar todo";
            this.Borrar_todo.Click += new System.EventHandler(this.Borrar_todo_Click);
            // 
            // Insertar
            // 
            this.Insertar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tipografia,
            this.Color,
            this.Fondo,
            this.Imagen});
            this.Insertar.Image = global::MiniEditor.Properties.Resources.Insertar;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(74, 20);
            this.Insertar.Text = "Insertar";
            // 
            // Tipografia
            // 
            this.Tipografia.Image = global::MiniEditor.Properties.Resources.Tipografía;
            this.Tipografia.Name = "Tipografia";
            this.Tipografia.Size = new System.Drawing.Size(180, 22);
            this.Tipografia.Text = "Tipografía";
            this.Tipografia.Click += new System.EventHandler(this.Tipografia_Click);
            // 
            // Color
            // 
            this.Color.Image = global::MiniEditor.Properties.Resources.Color_L;
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(180, 22);
            this.Color.Text = "Color de letra";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Fondo
            // 
            this.Fondo.Image = global::MiniEditor.Properties.Resources.Color_F;
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(180, 22);
            this.Fondo.Text = "Color de fondo";
            this.Fondo.Click += new System.EventHandler(this.Fondo_Click);
            // 
            // Imagen
            // 
            this.Imagen.Image = global::MiniEditor.Properties.Resources.Imagen;
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(180, 22);
            this.Imagen.Text = "Imagen";
            this.Imagen.Click += new System.EventHandler(this.Imagen_Click_1);
            // 
            // botDeshacer
            // 
            this.botDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botDeshacer.Image = global::MiniEditor.Properties.Resources.Deshacer;
            this.botDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botDeshacer.Name = "botDeshacer";
            this.botDeshacer.Size = new System.Drawing.Size(23, 22);
            this.botDeshacer.Text = "Deshacer";
            this.botDeshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // botRepetir
            // 
            this.botRepetir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botRepetir.Image = global::MiniEditor.Properties.Resources.Repetir;
            this.botRepetir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botRepetir.Name = "botRepetir";
            this.botRepetir.Size = new System.Drawing.Size(23, 22);
            this.botRepetir.Text = "Repetir";
            this.botRepetir.Click += new System.EventHandler(this.Repetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 357);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mini Editor de Texto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem Opciones;
        private System.Windows.Forms.ToolStripMenuItem Deshacer;
        private System.Windows.Forms.ToolStripMenuItem Repetir;
        private System.Windows.Forms.ToolStripMenuItem Copiar;
        private System.Windows.Forms.ToolStripMenuItem Pegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Cortar;
        private System.Windows.Forms.ToolStripMenuItem Seleccionar_todo;
        private System.Windows.Forms.ToolStripMenuItem Borrar_todo;
        private System.Windows.Forms.ToolStripMenuItem Insertar;
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
        private System.Windows.Forms.ToolStripMenuItem Fondo;
        private System.Windows.Forms.ToolStripMenuItem Nuevo;
        private System.Windows.Forms.ToolStripMenuItem Imagen;
        private System.Windows.Forms.ToolStripButton botGuardar;
        private System.Windows.Forms.ToolStripButton botGuardar_como;
        private System.Windows.Forms.ToolStripButton botDeshacer;
        private System.Windows.Forms.ToolStripButton botRepetir;
    }
}

