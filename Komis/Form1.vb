Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private Sub Zatwierdz_Click(sender As Object, e As EventArgs) Handles Zatwierdz.Click
        If Lakier.Text <> "" And OpcjeTak.Checked = False Then
            Miniaturka.Visible = True
            Gwiazdki1.Visible = True
        ElseIf OpcjeTak.Checked = True And OpcjeBox.Text <> "" Then
            Miniaturka.Visible = True
            Gwiazdki1.Visible = True
        ElseIf OpcjeTak.Checked = True And OpcjeBox.Text = "" Then
            MessageBox.Show("Wybierając wyposarzenie dodatkowe musisz wybrać jakąś opcje!", "Uwaga", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Wypełnij wszystkie pola!", "Uwaga", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Wyczysc_Click(sender As Object, e As EventArgs) Handles Wyczysc.Click
        Marka.Text = ""
        Model.Text = ""
        Silnik.Text = ""
        Lakier.Text = ""
        ComboBoxKomis.Text = ""
        Klasyczny.Checked = False
        Metalic.Checked = False
        Miniaturka.Visible = False
        OpcjeBox.Text = ""
        OpcjeNie.Checked = False
        OpcjeTak.Checked = False
        Gwiazdki1.Visible = False
        DataGridViewOceny.Visible = False
    End Sub

    Private Sub Metalic_CheckedChanged(sender As Object, e As EventArgs) Handles Metalic.CheckedChanged
        Lakier.Items.Clear()
        If Silnik.Text <> "" Then
            DownloadKolor(ComboBoxKomis.Text, Metalic.Name)
        End If
    End Sub

    Private Sub Model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Model.SelectedIndexChanged
        Silnik.Items.Clear()
        Silnik.Text = ""
        Lakier.Items.Clear()
        Lakier.Text = ""
        DownloadSilnik(ComboBoxKomis.Text, "Silnik")

    End Sub

    Private Sub Klasyczny_CheckedChanged(sender As Object, e As EventArgs) Handles Klasyczny.CheckedChanged
        Lakier.Items.Clear()
        If Silnik.Text <> "" Then
            DownloadKolor(ComboBoxKomis.Text, Klasyczny.Name)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Klasyczny.Checked = False
        Me.Metalic.Checked = False
        DownloadOceny()
        'TODO: This line of code loads data into the 'Komis2DataSet.Komis2' table. You can move, or remove it, as needed.
        'Me.Komis2TableAdapter.Fill(Me.Komis2DataSet.Komis2)
        'TODO: This line of code loads data into the 'Komis1DataSet.Komis1' table. You can move, or remove it, as needed.
        'Me.Komis1TableAdapter.Fill(Me.Komis1DataSet.Komis1)
        'TODO: This line of code loads data into the 'Komis2DataSet1.Komis2' table. You can move, or remove it, as needed.
        ' Me.Komis2TableAdapter.Fill(Me.Komis2DataSet1.Komis2)
        'TODO: This line of code loads data into the 'Komis1DataSet.Komis1' table. You can move, or remove it, as needed.
        ' Me.Komis1TableAdapter.Fill(Me.Komis1DataSet.Komis1)

    End Sub

    Private Sub ComboBoxKomis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKomis.SelectedIndexChanged
        Marka.Text = ""
        Marka.Items.Clear()
        Model.Text = ""
        Model.Items.Clear()
        Silnik.Items.Clear()
        Silnik.Text = ""
        Lakier.Items.Clear()
        Lakier.Text = ""
        DownloadAuto(ComboBoxKomis.Text)
    End Sub



    Private Sub Marka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Marka.SelectedIndexChanged
        Model.Text = ""
        Model.Items.Clear()
        Silnik.Items.Clear()
        Silnik.Text = ""
        Lakier.Items.Clear()
        Lakier.Text = ""
        DownloadModel(ComboBoxKomis.Text, Marka.Text)
    End Sub



    Private Sub DownloadAuto(baza As String)
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\" + baza + ".accdb;Persist Security Info=False"
        Dim sqlQRY As String = "Select Distinct " + baza + ".Marka FROM " + baza
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet
            'wypełniamy danymi z bazy
            da.Fill(ds, baza)
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables(baza)
            'wyswietlenie danych
            Dim row As DataRow
            For Each row In dt.Rows
                Marka.Items.Add(row(0))
            Next row
        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub DownloadModel(baza As String, marka As String)
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\" + baza + ".accdb;Persist Security Info=False"
        Dim sqlQRY As String = "Select " + baza + ".Model FROM " + baza + " WHERE " + baza + ".Marka='" + marka + "'"
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet
            'wypełniamy danymi z bazy
            da.Fill(ds, baza)
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables(baza)
            'wyswietlenie danych
            Dim row As DataRow
            For Each row In dt.Rows
                Model.Items.Add(row(0))
            Next row
        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub DownloadSilnik(baza As String, tabela As String)
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\" + baza + ".accdb;Persist Security Info=False"
        Dim sqlQRY As String = "Select " + tabela + "." + tabela + " FROM " + tabela
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet
            'wypełniamy danymi z bazy
            da.Fill(ds, tabela)
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables(tabela)
            'wyswietlenie danych
            Dim row As DataRow
            For Each row In dt.Rows
                Silnik.Items.Add(row(0))
            Next row
        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub DownloadKolor(baza As String, tabela As String)
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\" + baza + ".accdb;Persist Security Info=False"
        Dim sqlQRY As String = "Select " + tabela + "." + tabela + " FROM " + tabela
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet
            'wypełniamy danymi z bazy
            da.Fill(ds, tabela)
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables(tabela)
            'wyswietlenie danych
            Dim row As DataRow
            For Each row In dt.Rows
                Lakier.Items.Add(row(0))
            Next row
        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Close()
    End Sub

    Private Sub OpcjeTak_CheckedChanged(sender As Object, e As EventArgs) Handles OpcjeTak.CheckedChanged
        OpcjeBox.Visible = True
        If Miniaturka.Visible = True Then
            Miniaturka.Visible = False
        End If

        If ComboBoxKomis.Text <> "" Then
            DownloadOpcje(ComboBoxKomis.Text, GroupBox2.Text)
        End If


    End Sub

    Private Sub OpcjeNie_CheckedChanged(sender As Object, e As EventArgs) Handles OpcjeNie.CheckedChanged
        OpcjeBox.Visible = False
        OpcjeBox.Items.Clear()
    End Sub

    Private Sub DownloadOpcje(baza As String, tabela As String)
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\" + baza + ".accdb;Persist Security Info=False"
        Dim sqlQRY As String = "Select " + tabela + "." + tabela + " FROM " + tabela
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet
            'wypełniamy danymi z bazy
            da.Fill(ds, tabela)
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables(tabela)
            'wyswietlenie danych
            Dim row As DataRow
            For Each row In dt.Rows
                OpcjeBox.Items.Add(row(0))
            Next row
        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub DownloadOceny()
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\Oceny.accdb;Persist Security Info=False"
        Dim sqlQRY As String = "SELECT Oceny.Marka, Oceny.Model, Oceny.Ocena" _
                                & " FROM Oceny " _
                                & " WHERE Oceny.ID=(SELECT MAX(Oceny.ID) from Oceny);"
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet("Oceny")
            'wypełniamy danymi z bazy
            da.Fill(ds, "Oceny")
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables("Oceny")
            'wyswietlenie danych
            'Dim row As DataRow
            'For Each row In dt.Rows
            ' OpcjeBox.Items.Add(row(0).item(0))
            'Next row
            lblLastRated.Text = "Ostatni oceniony samochód to " + dt.Rows(0).ItemArray(0) + " " + dt.Rows(0).ItemArray(1) + " z oceną " + dt.Rows(0).ItemArray(2).ToString()
        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub DownloadNajlepiejOceniane()
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\Oceny.accdb;Persist Security Info=False"
        Dim sqlQRY As String = "SELECT TOP 3 Oceny.Marka, Oceny.Model, Avg(Oceny.Ocena) AS Średnia_Ocen, Count(Oceny.Ocena) AS Liczba_Ocen" _
                                & " FROM Oceny " _
                                & " GROUP BY Oceny.Marka, Oceny.Model" _
                                & " ORDER BY Avg(Oceny.Ocena) DESC , Oceny.Model DESC , Oceny.Marka DESC;"
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet("Oceny")
            'wypełniamy danymi z bazy
            da.Fill(ds, "Oceny")
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables("Oceny")
            'wstawienie danych do kontrolki data view
            Dim objDaneWidok As DataView = dt.DefaultView
            DataGridViewOceny.DataSource = ds
            DataGridViewOceny.DataMember = "Oceny"

        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub Gwiazdki1_najlepszyClicked() Handles Gwiazdki1.najlepszyClicked
        DataGridViewOceny.Visible = True
        DownloadNajlepiejOceniane()
    End Sub

    Private Sub DownloadNajczesciejOceniane()
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\Oceny.accdb;Persist Security Info=False"
        Dim sqlQRY As String = "SELECT TOP 3 Oceny.Marka, Oceny.Model, Avg(Oceny.Ocena) AS Średnia_Ocen, Count(Oceny.Ocena) AS Liczba_Ocen" _
                                & " FROM Oceny " _
                                & " GROUP BY Oceny.Marka, Oceny.Model" _
                                & " ORDER BY Count(Oceny.Ocena) DESC , Oceny.Model DESC , Oceny.Marka DESC;"
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet("Oceny")
            'wypełniamy danymi z bazy
            da.Fill(ds, "Oceny")
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables("Oceny")
            'wstawienie danych do kontrolki data view
            Dim objDaneWidok As DataView = dt.DefaultView
            DataGridViewOceny.DataSource = ds
            DataGridViewOceny.DataMember = "Oceny"

        Catch ex As SqlException
            txtStatus.Text = "Error: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

    End Sub

    Private Sub Gwiazdki1_popularnyClicked() Handles Gwiazdki1.popularnyClicked
        DataGridViewOceny.Visible = True
        DownloadNajczesciejOceniane()
    End Sub

    Private Sub Glosuj_Click() Handles Gwiazdki1.glosujClicked
        Dim strWpis As String = "insert into Oceny(Marka,Model,Ocena)" &
        " values (" & "'" & Marka.Text & "'," & "'" & Model.Text &
        "'" & "," & "'" & Gwiazdki1.Value & "'" & ");"
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\mrowc\Desktop\IO\TK\Oceny.accdb;Persist Security Info=False"
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()
            txtStatus.Text = txtStatus.Text & "Polaczenie otwarte" & vbCrLf
            'tworzymy obiekt OleDbCommand
            Dim objZapytanie As New System.Data.OleDb.OleDbCommand(strWpis, conn)
            objZapytanie.ExecuteNonQuery()
        Catch ex As SqlException
            txtStatus.Text = "Bład podczas wpisywania danych: " & ex.ToString & vbCrLf
        Finally
            conn.Close()
            txtStatus.Text = txtStatus.Text & vbCrLf & "polaczenie zamkniete."
        End Try

        lblLastRated.Text = "Ostatni oceniony samochód to " + Marka.Text + " " + Model.Text + " z oceną " + Gwiazdki1.Value.ToString()

    End Sub
End Class
