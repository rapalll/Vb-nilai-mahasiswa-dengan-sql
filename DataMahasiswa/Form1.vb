Imports System.Data.SqlClient

Public Class Form1
    Public sqll As String
    Public cari As Integer

    Private Sub txtekt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtekt1.TextChanged
    End Sub

    Private Sub txtuts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuts.TextChanged
    End Sub

    Private Sub txtekt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtekt2.TextChanged

    End Sub

    Private Sub txtuas_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuas.TextChanged

    End Sub

    Private Sub hapus()
        txtnim.Text = ""
        txtnama.Text = ""
        txtfakultas.Text = ""
        txtprodi.Text = ""
        txtsemester.Text = ""
        txtekt1.Text = ""
        txtuts.Text = ""
        txtekt2.Text = ""
        txtuas.Text = ""
        txtekt1.Text = ""
        txtuts.Text = ""
        txtekt2.Text = ""
        txtuas.Text = ""
        txtrata.Text = ""
        txtgrade.Text = ""
    End Sub


    Private Sub aktifTombol(ByRef status As Boolean)
        btnhapus.Enabled = status
        btnsave.Enabled = status
        btnubah.Enabled = status
    End Sub

    Private Sub aktifText(ByRef status As Boolean)
        txtnim.Enabled = status
        txtnama.Enabled = status
        txtfakultas.Enabled = status
        txtprodi.Enabled = status
        txtsemester.Enabled = status
        txtekt1.Enabled = status
        txtuts.Enabled = status
        txtekt2.Enabled = status
        txtuas.Enabled = status
        txtrata.Enabled = status
        txtgrade.Enabled = status
    End Sub


    Private Sub TampilData()
        BukaKoneksi()

        If cari = 1 Then
            sql = sqll
        Else
            sql = "SELECT*FROM tbl_mhs"
        End If

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet

        da.Fill(ds)

        For Each dt In ds.Tables
            DataGridView1.DataSource = dt
        Next

        TutupKoneksi()
    End Sub

    Private Sub HapusData()
        BukaKoneksi()

        sql = "DELETE FROM tbl_mhs WHERE Nim = '" & txtnim.Text & "'"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus")

        Catch ex As Exception
            MsgBox("Data Gagal Diubah")
        End Try

        TutupKoneksi()
    End Sub

    Private Sub SimpanData()
        BukaKoneksi()
        sql = "INSERT INTO tbl_mhs (Nim, Nama, Fakultas, prodi, Semester, Ekt1, Uts, Ekt2, Uas, Rata,  Grade) VALUES (" &
            "'" & txtnim.Text & "'," &
            "'" & txtnama.Text & "'," &
            "'" & txtfakultas.Text & "'," &
            "'" & txtprodi.Text & "'," &
            "'" & txtsemester.Text & "'," &
            "'" & txtekt1.Text & "'," &
            "'" & txtuts.Text & "'," &
            "'" & txtekt2.Text & "'," &
            "'" & txtuas.Text & "'," &
            "'" & txtrata.Text & "'," &
            "'" & txtgrade.Text & "')"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")

        Catch ex As Exception
            MsgBox("Simpan Gagal")
        End Try

        TutupKoneksi()
    End Sub

    Private Sub UbahData()
        BukaKoneksi()
        sql = "Update tbl_mhs SET  " &
              "Nim = '" & txtnim.Text & "'," &
              "Nama = '" & txtnama.Text & "'," &
              "Fakultas = '" & txtfakultas.Text & "'," &
              "Prodi = '" & txtprodi.Text & "'," &
              "Semester = '" & txtsemester.Text & "'," &
              "Ekt1 = '" & txtekt1.Text & "'," &
              "Uts = '" & txtuts.Text & "'," &
              "Ekt2 = '" & txtekt2.Text & "'," &
              "Uas = '" & txtuas.Text & "'," &
              "Rata = '" & txtrata.Text & "'," &
              "Grade = '" & txtgrade.Text & "'WHERE Nim = '" & txtnim.Text & "'"


        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Data Berhasil Anda ubah")
        Catch ex As Exception
            MsgBox("Data Gagal Diubah")
        End Try

        TutupKoneksi()

    End Sub

    Private Sub CariData()

        Dim kategori = ""

        If cmbkategori.Text = "Nim" Then
            kategori = "Nim"

        ElseIf cmbkategori.Text = "Nama" Then
            kategori = "Nama"

        ElseIf cmbkategori.Text = "Fakultas" Then
            kategori = "Fakultas"

        ElseIf cmbkategori.Text = "Prodi" Then
            kategori = "Prodi"

        ElseIf cmbkategori.Text = "Semester" Then
            kategori = "Semester"

        ElseIf cmbkategori.Text = "Ekt1" Then
            kategori = "Ekt1"

        ElseIf cmbkategori.Text = "Uts" Then
            kategori = "Uts"

        ElseIf cmbkategori.Text = "Ekt2" Then
            kategori = "Ekt2"

        ElseIf cmbkategori.Text = "Uas" Then
            kategori = "Uas"

        ElseIf cmbkategori.Text = "Rata" Then
            kategori = "Rata"

        ElseIf cmbkategori.Text = "Grade" Then
            kategori = "Grade"
        End If

        sqll = "SELECT * FROM tbl_mhs WHERE" & kategori & "LIKE '%" & txtcari.Text & "'%"

        cari = 1


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BukaKoneksi()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim Pesan As String
        Pesan = MsgBox(" Apakah Kamu Yakin Akan Menghapus? ", vbYesNo, "Konfirmasi")
        If Pesan = 6 Then
            HapusData()
            TampilData()
            hapus()
            aktifText(False)
            aktifTombol(False)

            cmbkategori.Text = "Tambah"
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        cmbkategori.Items.Add("NIM")
        cmbkategori.Items.Add("Nama")
        cmbkategori.Items.Add("Fakultas")
        cmbkategori.Items.Add("Prodi")
        cmbkategori.Items.Add("Semester")
        cmbkategori.Items.Add("Ekt-1")
        cmbkategori.Items.Add("UTS")
        cmbkategori.Items.Add("Ekt-2")
        cmbkategori.Items.Add("UAS")
        cmbkategori.Items.Add("Rata-Rata")
        cmbkategori.Items.Add("Grade")

        TampilData()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        SimpanData()
        TampilData()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        txtnim.Text = DataGridView1.Item(0, i).Value
        txtnama.Text = DataGridView1.Item(1, i).Value
        txtfakultas.Text = DataGridView1.Item(2, i).Value
        txtprodi.Text = DataGridView1.Item(3, i).Value
        txtsemester.Text = DataGridView1.Item(4, i).Value
        txtekt1.Text = DataGridView1.Item(5, i).Value
        txtuts.Text = DataGridView1.Item(6, i).Value
        txtekt2.Text = DataGridView1.Item(7, i).Value
        txtuas.Text = DataGridView1.Item(8, i).Value
        txtrata.Text = DataGridView1.Item(9, i).Value
        txtgrade.Text = DataGridView1.Item(10, i).Value

        aktifText(True)
        aktifTombol(True)
        txtnim.Enabled = False
        btnsave.Enabled = False
        btntambah.Text = "BATAL"
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click

    End Sub

    Private Sub txtuas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        txtrata.Text = 0.125 * Val(txtekt1.Text) + 0.25 * Val(txtuts.Text) + 0.125 * Val(txtekt2.Text) + 0.5 * Val(txtuas.Text)

        Select Case txtrata.Text
            Case Is >= 80
                txtgrade.Text = "A"
            Case Is >= 70
                txtgrade.Text = "B"
            Case Is >= 60
                txtgrade.Text = "C"
            Case Is >= 50
                txtgrade.Text = "D"
            Case Else
                txtgrade.Text = "E"
        End Select
    End Sub

    Private Sub txt1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dispose()
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        UbahData()
        TampilData()
        hapus()
        aktifText(False)
        aktifTombol(False)
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        TampilData()
        hapus()
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        TampilData()
        CariData()
    End Sub
End Class