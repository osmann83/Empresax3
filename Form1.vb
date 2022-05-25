Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration


Public Class Form1

    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion

    Dim cmd As MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub limpiar()

        txtCod.Text = ""
        txtNom.Text = ""
        txtDes.Text = ""
        txtCos.Text = ""
        txtPre.Text = ""
        txtNum.Text = ""
        txtObs.Text = ""

    End Sub

    Private Sub mostrar()
        conn = objetoconexion.AbrirCon

        Dim query As String = "select * from inventario"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        GridDatosInv.DataSource = ds.Tables(0)

        conn.Close()
        conn.Dispose()

    End Sub



    Private Sub btnGua_Click(sender As Object, e As EventArgs) Handles btnGua.Click

        If txtCod.Text = "" Then
            MessageBox.Show("Agregar el codigo del artículo", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf txtNom.Text = "" Then
            MessageBox.Show("Agregar el nombre del artículo", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf txtDes.Text = "" Then
            MessageBox.Show("Agregar el descripción del artículo", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf txtCos.Text = "" Then
            MessageBox.Show("Agregar el costo del artículo", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf txtPre.Text = "" Then
            MessageBox.Show("Agregar el precio del artículo", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf txtNum.Text = "" Then
            MessageBox.Show("Agregar las existencias del artículo", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Else
            conn = objetoconexion.AbrirCon
            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into inventario(codigo,articulo,descripcion,costo,venta,existencias,observacion)values(@cod,@art,@des,@cos,@ven,@exi,@obs);"
                cmd.Parameters.AddWithValue("@cod", txtCod.Text)
                cmd.Parameters.AddWithValue("@art", txtNom.Text)
                cmd.Parameters.AddWithValue("@des", txtDes.Text)
                cmd.Parameters.AddWithValue("@cos", txtCos.Text)
                cmd.Parameters.AddWithValue("@ven", txtPre.Text)
                cmd.Parameters.AddWithValue("@exi", txtNum.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)


                cmd.ExecuteNonQuery()

                conn.Close()
                conn.Dispose()

                MessageBox.Show("Registro Creado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

                mostrar()
                limpiar()

                btnNue.Enabled = True
                btnGua.Enabled = False
                btnEli.Enabled = True
                btnMod.Enabled = True
                GridDatosInv.Enabled = True
                txtBus.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Registro Creado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If

    End Sub

    Private Sub GridDatosInv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridDatosInv.CellContentClick

        Dim row As DataGridViewRow = GridDatosInv.CurrentRow
        Try
            txtCod.Text = row.Cells(0).Value.ToString()
            txtNom.Text = row.Cells(1).Value.ToString()
            txtDes.Text = row.Cells(2).Value.ToString()
            txtCos.Text = row.Cells(3).Value.ToString()
            txtPre.Text = row.Cells(4).Value.ToString()
            txtNum.Text = row.Cells(5).Value.ToString()
            txtObs.Text = row.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click

        If txtCod.Text = "" Then
            MessageBox.Show("Elija el artículo que desea modificar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            conn = objetoconexion.AbrirCon

            Try

                cmd = conn.CreateCommand
                cmd.CommandText = "update inventario set articulo=@art,descripcion=@des,costo=@cos,venta=@ven,existencias=@exi,observacion=@obs where codigo=@cod;"
                cmd.Parameters.AddWithValue("@cod", txtCod.Text)
                cmd.Parameters.AddWithValue("@art", txtNom.Text)
                cmd.Parameters.AddWithValue("@des", txtDes.Text)
                cmd.Parameters.AddWithValue("@cos", txtCos.Text)
                cmd.Parameters.AddWithValue("@ven", txtPre.Text)
                cmd.Parameters.AddWithValue("@exi", txtNum.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)

                cmd.ExecuteNonQuery()

                mostrar()

                conn.Close()
                conn.Dispose()

                MessageBox.Show("Registro Actualizado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiar()

            Catch ex As Exception
                MessageBox.Show("Error actualizando registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If



    End Sub

    Private Sub btnEli_Click(sender As Object, e As EventArgs) Handles btnEli.Click

        If txtCod.Text = "" Then
            MessageBox.Show("Elija el artículo que desea Eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            conn = objetoconexion.AbrirCon

            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "delete from inventario where codigo=@cod"
                cmd.Parameters.AddWithValue("@cod", txtCod.Text)

                cmd.ExecuteNonQuery()

                mostrar()

                conn.Close()
                conn.Dispose()

                MessageBox.Show("Registro Eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)


                limpiar()

            Catch ex As Exception

                MessageBox.Show("Registro no se ha podido Eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


        End If



    End Sub

    Private Sub btnNue_Click(sender As Object, e As EventArgs) Handles btnNue.Click

        limpiar()

        btnNue.Enabled = False
        btnGua.Enabled = True
        btnEli.Enabled = False
        btnMod.Enabled = False
        GridDatosInv.Enabled = False
        txtBus.Enabled = False



    End Sub

    Private Sub txtBus_TextChanged(sender As Object, e As EventArgs) Handles txtBus.TextChanged
        conn = objetoconexion.AbrirCon

        Try
            Dim query As String = "select * from inventario where articulo like '%" & txtBus.Text & "%'"
            Dim adpt As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            GridDatosInv.DataSource = ds.Tables(0)


            conn.Close()
            conn.Dispose()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtCos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCos.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puedes ingresar valores númericos")
        End If

    End Sub


    Private Sub txtPre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPre.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puedes ingresar valores númericos")
        End If

    End Sub


    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puedes ingresar valores númericos")
        End If

    End Sub

    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click


        Dim message As String = "Estás seguro que deseas salir de la aplicación?"
        Dim caption As String = "Cerrar el aplicativo"
        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then End

    End Sub
End Class
