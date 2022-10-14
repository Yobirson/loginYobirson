<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.ingresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.Label2.UseWaitCursor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        Me.Label3.UseWaitCursor = True
        '
        'usuario
        '
        Me.usuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.usuario.ForeColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.usuario, "usuario")
        Me.usuario.Name = "usuario"
        Me.usuario.UseWaitCursor = True
        '
        'contraseña
        '
        Me.contraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.contraseña.ForeColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.contraseña, "contraseña")
        Me.contraseña.Name = "contraseña"
        Me.contraseña.UseWaitCursor = True
        '
        'ingresar
        '
        resources.ApplyResources(Me.ingresar, "ingresar")
        Me.ingresar.Name = "ingresar"
        Me.ingresar.UseVisualStyleBackColor = True
        Me.ingresar.UseWaitCursor = True
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.ingresar)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.TopMost = True
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usuario As TextBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents ingresar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
