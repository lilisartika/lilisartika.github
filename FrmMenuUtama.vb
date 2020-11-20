Public Class FrmMenuUtama

    Private Sub FrmMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Jam, Tanggal As String
        Jam = Format(Now, "hh:mm:ss")
        Tanggal = Format(Now, "dddd dd-MM-yyyy")
        LblInfoWaktu.Text = " " & Jam & ", " & Tanggal & ""
    End Sub

    Private Sub BtnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuku.Click
        FrmBuku.ShowDialog()
    End Sub

    Private Sub BtnKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKategori.Click
        FrmKategori.ShowDialog()
    End Sub

    Private Sub BtnRak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRak.Click
        FrmRak.ShowDialog()
    End Sub

    Private Sub BtnPeminjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjam.Click
        FrmPeminjam.ShowDialog()
    End Sub

    Private Sub BtnPeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjaman.Click
        FrmDataPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnPengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPengembalian.Click
        FrmPengembalianBuku.ShowDialog()
    End Sub
End Class