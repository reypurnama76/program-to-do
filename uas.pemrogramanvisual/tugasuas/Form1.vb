Public Class Form1
    Private Sub btnTambahData_Click(sender As Object, e As EventArgs) Handles btnTambahData.Click
        Dim data As String = txtinput.Text

        ' Cek apakah input kosong
        If data <> "" Then
            lstOutput.Items.Add("Data ke-" & (lstOutput.Items.Count + 1).ToString() & ": " & data)
            txtinput.Clear() ' Menghapus input setelah ditambahkan
        Else
            MessageBox.Show("Masukkan data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBacaFile_Click(sender As Object, e As EventArgs) Handles btnBacaFile.Click
        OpenFileDialog1.Filter = "Text Files|*.txt"

        ' Jika user memilih file
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenFileDialog1.FileName
            Dim fileData As String() = IO.File.ReadAllLines(filePath) ' Membaca isi file

            lstOutput.Items.Clear() ' Kosongkan ListBox sebelum menampilkan data baru

            ' Loop untuk menampilkan isi file ke dalam ListBox
            Dim i As Integer = 1
            For Each line As String In fileData
                lstOutput.Items.Add("Data ke-" & i.ToString() & ": " & line)
                i += 1
            Next
        End If
    End Sub

    Private Sub btnHapusData_Click(sender As Object, e As EventArgs) Handles btnHapusData.Click
        If lstOutput.Items.Count > 0 Then
            lstOutput.Items.Clear() ' Menghapus semua data dari ListBox
            MessageBox.Show("Semua data telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Tidak ada data yang bisa dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnPercabangan_Click(sender As Object, e As EventArgs) Handles btnPercabangan.Click
        Dim nilai As Integer = CInt(InputBox("Masukkan angka:"))
        If nilai Mod 2 = 0 Then
            MessageBox.Show("Angka " & nilai.ToString() & " adalah bilangan genap.")
        Else
            MessageBox.Show("Angka " & nilai.ToString() & " adalah bilangan ganjil.")
        End If
    End Sub

    Private Sub btnPerulangan_Click(sender As Object, e As EventArgs) Handles btnPerulangan.Click
        Dim hasil As String = ""
        lstOutput.Items.Clear()
        For i As Integer = 1 To 10
            hasil = "Angka: " & i.ToString()
            lstOutput.Items.Add(hasil) ' Menampilkan angka di ListBox
        Next
    End Sub


    ' Event untuk memanggil procedure
    Private Sub btnProcedure_Click(sender As Object, e As EventArgs) Handles btnProcedure.Click
            TampilkanPesan()
        End Sub

        ' Procedure yang menampilkan pesan
        Private Sub TampilkanPesan()
            MessageBox.Show("Ini adalah contoh procedure di dalam program.")
        End Sub


    End Class
