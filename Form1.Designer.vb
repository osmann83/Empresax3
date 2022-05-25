<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtCod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCos = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDes = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtObs = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNue = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGua = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMod = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEli = New Guna.UI2.WinForms.Guna2Button()
        Me.GridDatosInv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtBus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSal = New Guna.UI2.WinForms.Guna2Button()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridDatosInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCod
        '
        Me.txtCod.AutoRoundedCorners = True
        Me.txtCod.BackColor = System.Drawing.Color.Transparent
        Me.txtCod.BorderColor = System.Drawing.Color.White
        Me.txtCod.BorderRadius = 22
        Me.txtCod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod.DefaultText = ""
        Me.txtCod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCod.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtCod.ForeColor = System.Drawing.Color.Black
        Me.txtCod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCod.Location = New System.Drawing.Point(42, 47)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCod.PlaceholderText = "Codigo del Producto"
        Me.txtCod.SelectedText = ""
        Me.txtCod.Size = New System.Drawing.Size(295, 47)
        Me.txtCod.TabIndex = 0
        '
        'txtNom
        '
        Me.txtNom.AutoRoundedCorners = True
        Me.txtNom.BackColor = System.Drawing.Color.Transparent
        Me.txtNom.BorderRadius = 22
        Me.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNom.DefaultText = ""
        Me.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtNom.ForeColor = System.Drawing.Color.Black
        Me.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNom.Location = New System.Drawing.Point(42, 104)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.PlaceholderText = "Nombre del Producto"
        Me.txtNom.SelectedText = ""
        Me.txtNom.Size = New System.Drawing.Size(295, 47)
        Me.txtNom.TabIndex = 1
        '
        'txtCos
        '
        Me.txtCos.AutoRoundedCorners = True
        Me.txtCos.BackColor = System.Drawing.Color.Transparent
        Me.txtCos.BorderRadius = 22
        Me.txtCos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCos.DefaultText = ""
        Me.txtCos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtCos.ForeColor = System.Drawing.Color.Black
        Me.txtCos.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCos.Location = New System.Drawing.Point(42, 219)
        Me.txtCos.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCos.Name = "txtCos"
        Me.txtCos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCos.PlaceholderText = "Costo del Producto"
        Me.txtCos.SelectedText = ""
        Me.txtCos.Size = New System.Drawing.Size(295, 47)
        Me.txtCos.TabIndex = 3
        '
        'txtDes
        '
        Me.txtDes.AutoRoundedCorners = True
        Me.txtDes.BackColor = System.Drawing.Color.Transparent
        Me.txtDes.BorderRadius = 22
        Me.txtDes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes.DefaultText = ""
        Me.txtDes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDes.ForeColor = System.Drawing.Color.Black
        Me.txtDes.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDes.Location = New System.Drawing.Point(42, 162)
        Me.txtDes.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDes.PlaceholderText = "Descripción del Producto"
        Me.txtDes.SelectedText = ""
        Me.txtDes.Size = New System.Drawing.Size(295, 47)
        Me.txtDes.TabIndex = 2
        '
        'txtNum
        '
        Me.txtNum.AutoRoundedCorners = True
        Me.txtNum.BackColor = System.Drawing.Color.Transparent
        Me.txtNum.BorderRadius = 22
        Me.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum.DefaultText = ""
        Me.txtNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNum.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtNum.ForeColor = System.Drawing.Color.Black
        Me.txtNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNum.Location = New System.Drawing.Point(42, 330)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNum.PlaceholderText = "Número de Existencia"
        Me.txtNum.SelectedText = ""
        Me.txtNum.Size = New System.Drawing.Size(295, 47)
        Me.txtNum.TabIndex = 5
        '
        'txtPre
        '
        Me.txtPre.AutoRoundedCorners = True
        Me.txtPre.BackColor = System.Drawing.Color.Transparent
        Me.txtPre.BorderRadius = 22
        Me.txtPre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPre.DefaultText = ""
        Me.txtPre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtPre.ForeColor = System.Drawing.Color.Black
        Me.txtPre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPre.Location = New System.Drawing.Point(42, 273)
        Me.txtPre.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPre.Name = "txtPre"
        Me.txtPre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPre.PlaceholderText = "Precio del Producto"
        Me.txtPre.SelectedText = ""
        Me.txtPre.Size = New System.Drawing.Size(295, 47)
        Me.txtPre.TabIndex = 4
        '
        'txtObs
        '
        Me.txtObs.AutoRoundedCorners = True
        Me.txtObs.BackColor = System.Drawing.Color.Transparent
        Me.txtObs.BorderRadius = 22
        Me.txtObs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObs.DefaultText = ""
        Me.txtObs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtObs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtObs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtObs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtObs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtObs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtObs.ForeColor = System.Drawing.Color.Black
        Me.txtObs.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtObs.Location = New System.Drawing.Point(42, 387)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObs.PlaceholderText = "Observación"
        Me.txtObs.SelectedText = ""
        Me.txtObs.Size = New System.Drawing.Size(295, 47)
        Me.txtObs.TabIndex = 6
        '
        'btnNue
        '
        Me.btnNue.Animated = True
        Me.btnNue.AutoRoundedCorners = True
        Me.btnNue.BackColor = System.Drawing.Color.Transparent
        Me.btnNue.BorderRadius = 22
        Me.btnNue.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNue.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnNue.ForeColor = System.Drawing.Color.White
        Me.btnNue.Location = New System.Drawing.Point(646, 47)
        Me.btnNue.Name = "btnNue"
        Me.btnNue.Size = New System.Drawing.Size(180, 47)
        Me.btnNue.TabIndex = 7
        Me.btnNue.Text = "Nuevo"
        Me.btnNue.UseTransparentBackground = True
        '
        'btnGua
        '
        Me.btnGua.Animated = True
        Me.btnGua.AutoRoundedCorners = True
        Me.btnGua.BackColor = System.Drawing.Color.Transparent
        Me.btnGua.BorderRadius = 21
        Me.btnGua.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGua.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGua.Enabled = False
        Me.btnGua.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnGua.ForeColor = System.Drawing.Color.White
        Me.btnGua.Location = New System.Drawing.Point(646, 104)
        Me.btnGua.Name = "btnGua"
        Me.btnGua.Size = New System.Drawing.Size(180, 45)
        Me.btnGua.TabIndex = 8
        Me.btnGua.Text = "Guardar"
        '
        'btnMod
        '
        Me.btnMod.Animated = True
        Me.btnMod.AutoRoundedCorners = True
        Me.btnMod.BackColor = System.Drawing.Color.Transparent
        Me.btnMod.BorderRadius = 21
        Me.btnMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMod.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnMod.ForeColor = System.Drawing.Color.White
        Me.btnMod.Location = New System.Drawing.Point(646, 162)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(180, 45)
        Me.btnMod.TabIndex = 9
        Me.btnMod.Text = "Modificar"
        '
        'btnEli
        '
        Me.btnEli.Animated = True
        Me.btnEli.AutoRoundedCorners = True
        Me.btnEli.BackColor = System.Drawing.Color.Transparent
        Me.btnEli.BorderRadius = 21
        Me.btnEli.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEli.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEli.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnEli.ForeColor = System.Drawing.Color.White
        Me.btnEli.Location = New System.Drawing.Point(646, 219)
        Me.btnEli.Name = "btnEli"
        Me.btnEli.Size = New System.Drawing.Size(180, 45)
        Me.btnEli.TabIndex = 10
        Me.btnEli.Text = "Eliminar"
        '
        'GridDatosInv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridDatosInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridDatosInv.BackgroundColor = System.Drawing.Color.White
        Me.GridDatosInv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridDatosInv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridDatosInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDatosInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridDatosInv.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDatosInv.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridDatosInv.EnableHeadersVisualStyles = False
        Me.GridDatosInv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.Location = New System.Drawing.Point(42, 455)
        Me.GridDatosInv.Name = "GridDatosInv"
        Me.GridDatosInv.RowHeadersVisible = False
        Me.GridDatosInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDatosInv.Size = New System.Drawing.Size(784, 224)
        Me.GridDatosInv.TabIndex = 11
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GridDatosInv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GridDatosInv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridDatosInv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GridDatosInv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GridDatosInv.ThemeStyle.HeaderStyle.Height = 21
        Me.GridDatosInv.ThemeStyle.ReadOnly = False
        Me.GridDatosInv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GridDatosInv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridDatosInv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GridDatosInv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.RowsStyle.Height = 22
        Me.GridDatosInv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridDatosInv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtBus
        '
        Me.txtBus.AutoRoundedCorners = True
        Me.txtBus.BackColor = System.Drawing.Color.Transparent
        Me.txtBus.BorderRadius = 22
        Me.txtBus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBus.DefaultText = ""
        Me.txtBus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBus.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtBus.ForeColor = System.Drawing.Color.Black
        Me.txtBus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBus.Location = New System.Drawing.Point(511, 387)
        Me.txtBus.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBus.PlaceholderText = "Nombre del Producto a buscar"
        Me.txtBus.SelectedText = ""
        Me.txtBus.Size = New System.Drawing.Size(315, 47)
        Me.txtBus.TabIndex = 12
        '
        'btnSal
        '
        Me.btnSal.Animated = True
        Me.btnSal.AutoRoundedCorners = True
        Me.btnSal.BackColor = System.Drawing.Color.Transparent
        Me.btnSal.BorderRadius = 21
        Me.btnSal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSal.ForeColor = System.Drawing.Color.White
        Me.btnSal.Location = New System.Drawing.Point(646, 275)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(180, 45)
        Me.btnSal.TabIndex = 13
        Me.btnSal.Text = "Salir"
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(Empresax3.Form1)
        '
        'Form1BindingSource1
        '
        Me.Form1BindingSource1.DataSource = GetType(Empresax3.Form1)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(884, 691)
        Me.Controls.Add(Me.btnSal)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.GridDatosInv)
        Me.Controls.Add(Me.btnEli)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnGua)
        Me.Controls.Add(Me.btnNue)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtPre)
        Me.Controls.Add(Me.txtCos)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtCod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.GridDatosInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCos As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDes As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtObs As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNue As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGua As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEli As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GridDatosInv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtBus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents Form1BindingSource1 As BindingSource
End Class
