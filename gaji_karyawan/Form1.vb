Public Class Form1
    Dim dataArray(4) As String
    Dim TotalGaji As Int32

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim columns(4) As String
        columns(0) = "No"
        columns(1) = "Nama"
        columns(2) = "Jam Kerja"
        columns(3) = "Tarif Kerja Per Jam"
        columns(4) = "Gaji"

        ListView1.View = View.Details

        ListView1.Columns.Clear()
        For column = 0 To 4
            ListView1.Columns.Add(columns(column), 120)
        Next

        txtNo.Text = 1
        txtNama.Focus()
    End Sub

    Private Function FormatRupiah(ByVal value As Integer) As String
        Dim formattedString As String = value.ToString("#,##0")
        Return formattedString
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Gaji As Int32

        dataArray(0) = txtNo.Text
        dataArray(1) = txtNama.Text
        dataArray(2) = txtJJK.Text
        dataArray(3) = txtTPJ.Text

        If (Integer.Parse(txtJJK.Text) <= 40) Then
            Gaji = (Integer.Parse(txtJJK.Text) * Integer.Parse(txtTPJ.Text))
            dataArray(4) = (Gaji * 4).ToString()
        Else
            Dim overtime As Int32 = Integer.Parse(txtJJK.Text) - 40
            Gaji = (40 * Integer.Parse(txtTPJ.Text) + (Integer.Parse(txtTPJ.Text) * 1.5 * overtime))
            dataArray(4) = (Gaji * 4).ToString()
        End If

        TotalGaji += Gaji * 4

        textTotalGaji.Text = FormatRupiah(TotalGaji).ToString()

        Dim listItems As ListViewItem
        listItems = New ListViewItem
        listItems = ListView1.Items.Add(dataArray(0))
        listItems.SubItems.Add(dataArray(1))
        listItems.SubItems.Add(dataArray(2))
        listItems.SubItems.Add(dataArray(3))
        listItems.SubItems.Add(FormatRupiah(dataArray(4)))

        txtNo.Text = (Integer.Parse(txtNo.Text) + 1).ToString()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If ListView1.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                ListView1.Items.Remove(item)
                Dim gajiItem As String = item.SubItems(4).Text.Replace(".", "")
                TotalGaji -= Integer.Parse(gajiItem * 4)
            Next
            textTotalGaji.Text = FormatRupiah(TotalGaji)
        Else
            MessageBox.Show("Pilih item yang ingin dihapus.")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Gaji As Int32

        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedData As ListViewItem = ListView1.SelectedItems(0)
            If (Integer.Parse(selectedData.SubItems(2).Text) <= 40) Then
                Gaji = (Integer.Parse(selectedData.SubItems(2).Text) * Integer.Parse(selectedData.SubItems(3).Text))
                textGaji.Text = FormatRupiah((Gaji * 4)).ToString()
                textTunjangan.Text = "-,0"
            Else
                Dim overtime As Int32 = Integer.Parse(selectedData.SubItems(2).Text) - 40
                Gaji = (40 * Integer.Parse(selectedData.SubItems(3).Text))
                textGaji.Text = FormatRupiah((Gaji * 4)).ToString()
                textTunjangan.Text = FormatRupiah(((Integer.Parse(selectedData.SubItems(3).Text) * 1.5 * overtime) * 4)).ToString()
            End If
        End If
    End Sub
End Class
