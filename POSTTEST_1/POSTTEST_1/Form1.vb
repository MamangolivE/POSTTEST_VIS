Public Class Form1
    Dim totalIPK As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ips As Double
        If Not Double.TryParse(txtIP.Text, ips) Then
            MessageBox.Show("Input Harus Angka")
            Exit Sub
        End If

        If ips < 0 Or ips > 4 Then
            MessageBox.Show("IP Tidak Valid")
            Exit Sub
        End If

        totalIPK += ips
        jumlahSemester += 1

        Dim ipk As Double = totalIPK / jumlahSemester
        nilaiIPK.Text = ipk.ToString("0.00")

        If ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
        ElseIf ipk > 2.75 And ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk > 3.0 Then
            lblPredikat.Text = "Sangat Memuaskan"
        Else
            lblPredikat.Text = "-"
        End If


    End Sub
End Class