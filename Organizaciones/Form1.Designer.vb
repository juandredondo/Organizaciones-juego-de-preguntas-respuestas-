<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Clikderecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MostrarBarraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LblPuntoG4 = New System.Windows.Forms.Label
        Me.LblPuntoG3 = New System.Windows.Forms.Label
        Me.LblPuntoG5 = New System.Windows.Forms.Label
        Me.LblPuntoG2 = New System.Windows.Forms.Label
        Me.LblPuntoG1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ImgFondo = New System.Windows.Forms.PictureBox
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblTitulo1 = New System.Windows.Forms.Label
        Me.LblTitulo2 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCalificar = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestaurarJuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblTurno = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Clikderecho.SuspendLayout()
        CType(Me.ImgFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.OpionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1126, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 19)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'OpionesToolStripMenuItem
        '
        Me.OpionesToolStripMenuItem.Name = "OpionesToolStripMenuItem"
        Me.OpionesToolStripMenuItem.Size = New System.Drawing.Size(63, 19)
        Me.OpionesToolStripMenuItem.Text = "Opiones"
        '
        'Panel1
        '
        Me.Panel1.ContextMenuStrip = Me.Clikderecho
        Me.Panel1.Controls.Add(Me.LblPuntoG4)
        Me.Panel1.Controls.Add(Me.LblPuntoG3)
        Me.Panel1.Controls.Add(Me.LblPuntoG5)
        Me.Panel1.Controls.Add(Me.LblPuntoG2)
        Me.Panel1.Controls.Add(Me.LblPuntoG1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ImgFondo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 571)
        Me.Panel1.TabIndex = 1
        '
        'Clikderecho
        '
        Me.Clikderecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarBarraToolStripMenuItem})
        Me.Clikderecho.Name = "ContextMenuStrip1"
        Me.Clikderecho.Size = New System.Drawing.Size(146, 26)
        '
        'MostrarBarraToolStripMenuItem
        '
        Me.MostrarBarraToolStripMenuItem.Name = "MostrarBarraToolStripMenuItem"
        Me.MostrarBarraToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.MostrarBarraToolStripMenuItem.Text = "Mostrar Barra"
        '
        'LblPuntoG4
        '
        Me.LblPuntoG4.AutoSize = True
        Me.LblPuntoG4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntoG4.ForeColor = System.Drawing.Color.Blue
        Me.LblPuntoG4.Image = Global.Organizaciones.My.Resources.Resources.fondoPNG
        Me.LblPuntoG4.Location = New System.Drawing.Point(81, 410)
        Me.LblPuntoG4.Name = "LblPuntoG4"
        Me.LblPuntoG4.Size = New System.Drawing.Size(19, 22)
        Me.LblPuntoG4.TabIndex = 55
        Me.LblPuntoG4.Text = "0"
        '
        'LblPuntoG3
        '
        Me.LblPuntoG3.AutoSize = True
        Me.LblPuntoG3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntoG3.ForeColor = System.Drawing.Color.Blue
        Me.LblPuntoG3.Image = Global.Organizaciones.My.Resources.Resources.fondoPNG
        Me.LblPuntoG3.Location = New System.Drawing.Point(81, 387)
        Me.LblPuntoG3.Name = "LblPuntoG3"
        Me.LblPuntoG3.Size = New System.Drawing.Size(19, 22)
        Me.LblPuntoG3.TabIndex = 54
        Me.LblPuntoG3.Text = "0"
        '
        'LblPuntoG5
        '
        Me.LblPuntoG5.AutoSize = True
        Me.LblPuntoG5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntoG5.ForeColor = System.Drawing.Color.Blue
        Me.LblPuntoG5.Image = Global.Organizaciones.My.Resources.Resources.fondoPNG
        Me.LblPuntoG5.Location = New System.Drawing.Point(81, 433)
        Me.LblPuntoG5.Name = "LblPuntoG5"
        Me.LblPuntoG5.Size = New System.Drawing.Size(19, 22)
        Me.LblPuntoG5.TabIndex = 53
        Me.LblPuntoG5.Text = "0"
        '
        'LblPuntoG2
        '
        Me.LblPuntoG2.AutoSize = True
        Me.LblPuntoG2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntoG2.ForeColor = System.Drawing.Color.Blue
        Me.LblPuntoG2.Image = Global.Organizaciones.My.Resources.Resources.fondoPNG
        Me.LblPuntoG2.Location = New System.Drawing.Point(81, 364)
        Me.LblPuntoG2.Name = "LblPuntoG2"
        Me.LblPuntoG2.Size = New System.Drawing.Size(19, 22)
        Me.LblPuntoG2.TabIndex = 52
        Me.LblPuntoG2.Text = "0"
        '
        'LblPuntoG1
        '
        Me.LblPuntoG1.AutoSize = True
        Me.LblPuntoG1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntoG1.ForeColor = System.Drawing.Color.Blue
        Me.LblPuntoG1.Image = Global.Organizaciones.My.Resources.Resources.fondoPNG
        Me.LblPuntoG1.Location = New System.Drawing.Point(81, 341)
        Me.LblPuntoG1.Name = "LblPuntoG1"
        Me.LblPuntoG1.Size = New System.Drawing.Size(19, 22)
        Me.LblPuntoG1.TabIndex = 50
        Me.LblPuntoG1.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Image = Global.Organizaciones.My.Resources.Resources.kendris_fondo
        Me.Label5.Location = New System.Drawing.Point(52, 574)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Label5"
        '
        'ImgFondo
        '
        Me.ImgFondo.ContextMenuStrip = Me.Clikderecho
        Me.ImgFondo.Dock = System.Windows.Forms.DockStyle.Left
        Me.ImgFondo.Image = Global.Organizaciones.My.Resources.Resources.fondoPNG1
        Me.ImgFondo.Location = New System.Drawing.Point(0, 0)
        Me.ImgFondo.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgFondo.Name = "ImgFondo"
        Me.ImgFondo.Size = New System.Drawing.Size(203, 571)
        Me.ImgFondo.TabIndex = 0
        Me.ImgFondo.TabStop = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(243, 412)
        Me.RichTextBox1.MaxLength = 5000
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(384, 158)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(716, 412)
        Me.RichTextBox2.MaxLength = 1000
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(384, 158)
        Me.RichTextBox2.TabIndex = 22
        Me.RichTextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(142, 56)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 68)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(28, 124)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 68)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(378, 124)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 68)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(28, 56)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 68)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(260, 124)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 68)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(730, 160)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 74)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(260, 56)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 68)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(730, 86)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 74)
        Me.Button8.TabIndex = 30
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(613, 124)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 68)
        Me.Button9.TabIndex = 31
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(378, 56)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(88, 68)
        Me.Button10.TabIndex = 32
        Me.Button10.Text = "10"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(649, 533)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 39)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "="
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(28, 192)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(88, 68)
        Me.Button11.TabIndex = 34
        Me.Button11.Text = "11"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(378, 192)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(88, 68)
        Me.Button12.TabIndex = 35
        Me.Button12.Text = "12"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(496, 56)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(88, 68)
        Me.Button13.TabIndex = 36
        Me.Button13.Text = "13"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(613, 56)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(88, 68)
        Me.Button14.TabIndex = 37
        Me.Button14.Text = "14"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(496, 192)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(88, 68)
        Me.Button15.TabIndex = 38
        Me.Button15.Text = "15"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(260, 192)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(88, 68)
        Me.Button16.TabIndex = 39
        Me.Button16.Text = "16"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button17.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(496, 124)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(88, 68)
        Me.Button17.TabIndex = 40
        Me.Button17.Text = "17"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(613, 192)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(88, 68)
        Me.Button18.TabIndex = 41
        Me.Button18.Text = "18"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(142, 124)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(88, 68)
        Me.Button19.TabIndex = 42
        Me.Button19.Text = "19"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Transparent
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(142, 192)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(88, 68)
        Me.Button20.TabIndex = 43
        Me.Button20.Text = "20"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(654, 494)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 39)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "?"
        '
        'LblTitulo1
        '
        Me.LblTitulo1.AutoSize = True
        Me.LblTitulo1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo1.ForeColor = System.Drawing.Color.Blue
        Me.LblTitulo1.Location = New System.Drawing.Point(238, 371)
        Me.LblTitulo1.Name = "LblTitulo1"
        Me.LblTitulo1.Size = New System.Drawing.Size(27, 28)
        Me.LblTitulo1.TabIndex = 45
        Me.LblTitulo1.Text = "..."
        '
        'LblTitulo2
        '
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo2.ForeColor = System.Drawing.Color.Blue
        Me.LblTitulo2.Location = New System.Drawing.Point(711, 371)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(27, 28)
        Me.LblTitulo2.TabIndex = 46
        Me.LblTitulo2.Text = "..."
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'BtnCalificar
        '
        Me.BtnCalificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalificar.Enabled = False
        Me.BtnCalificar.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalificar.Image = Global.Organizaciones.My.Resources.Resources.EditarBtn_Image
        Me.BtnCalificar.Location = New System.Drawing.Point(646, 445)
        Me.BtnCalificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalificar.Name = "BtnCalificar"
        Me.BtnCalificar.Size = New System.Drawing.Size(49, 45)
        Me.BtnCalificar.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.BtnCalificar, "Calificar")
        Me.BtnCalificar.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.RestaurarJuegoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 48)
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'RestaurarJuegoToolStripMenuItem
        '
        Me.RestaurarJuegoToolStripMenuItem.Name = "RestaurarJuegoToolStripMenuItem"
        Me.RestaurarJuegoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RestaurarJuegoToolStripMenuItem.Text = "Restaurar Juego"
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button20)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button19)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button18)
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(243, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(825, 284)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'LblTurno
        '
        Me.LblTurno.AutoSize = True
        Me.LblTurno.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTurno.ForeColor = System.Drawing.Color.Blue
        Me.LblTurno.Location = New System.Drawing.Point(366, 328)
        Me.LblTurno.Name = "LblTurno"
        Me.LblTurno.Size = New System.Drawing.Size(27, 28)
        Me.LblTurno.TabIndex = 51
        Me.LblTurno.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(238, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 28)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Turno Equipo "
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnCalificar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1126, 596)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTurno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnCalificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblTitulo1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APLIQUEMOS LO APRENDIDO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Clikderecho.ResumeLayout(False)
        CType(Me.ImgFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImgFondo As System.Windows.Forms.PictureBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Clikderecho As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MostrarBarraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTitulo1 As System.Windows.Forms.Label
    Friend WithEvents LblTitulo2 As System.Windows.Forms.Label
    Friend WithEvents BtnCalificar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblPuntoG1 As System.Windows.Forms.Label
    Friend WithEvents LblPuntoG4 As System.Windows.Forms.Label
    Friend WithEvents LblPuntoG3 As System.Windows.Forms.Label
    Friend WithEvents LblPuntoG5 As System.Windows.Forms.Label
    Friend WithEvents LblPuntoG2 As System.Windows.Forms.Label
    Friend WithEvents LblTurno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RestaurarJuegoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
