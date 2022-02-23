Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginSystemDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LoginSystemDataSet.Login)

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim log = Me.LoginTableAdapter.Userdetails(Me.Username.Text, Me.Password.Text)

        If log Is Nothing Then
            Username.Clear()
            Password.Clear()
            Username.Select()
            MessageBox.Show("Login lub hasło nie są prawidłowe", "Login Error", MessageBoxButtons.OK)
        Else
            Dim user = Me.LoginTableAdapter.Loginvalid(Me.Username.Text, True)
            If user Is Nothing Then
                Form1.Show()
                Me.Hide()
            Else
                Form3.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Username.Clear()
        Password.Clear()
        Username.Select()
        DownloadLogin("LoginSystem", Username.Text)
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub DownloadLogin(baza As String, username As String)
        Dim cnString As String
        cnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + baza + ".accdb;Persist Security Info=False"
        Dim sqlQRY As String = "SELECT Login.Admin FROM Login WHERE Login.Username='" + username + "'"
        Dim conn As OleDbConnection = New OleDbConnection(cnString)
        Try
            conn.Open()

            'tworzymy adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)
            'tworzymy dataset
            Dim ds As DataSet = New DataSet
            'wypełniamy danymi z bazy
            da.Fill(ds, "Login")
            'pobieramy konkretną tabelę
            Dim dt As DataTable = ds.Tables("Login")
            'wyswietlenie danych
            Dim row As DataRow
            For Each row In dt.Rows
                MessageBox.Show(row(0))
            Next row
        Catch ex As SqlException

        Finally
            conn.Close()

        End Try
    End Sub
End Class