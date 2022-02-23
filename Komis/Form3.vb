Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Komis2DataSet1.Opcje_Dodatkowe' table. You can move, or remove it, as needed.
        Me.Opcje_DodatkoweTableAdapter1.Fill(Me.Komis2DataSet1.Opcje_Dodatkowe)
        'TODO: This line of code loads data into the 'Komis2DataSet1.Metalic' table. You can move, or remove it, as needed.
        Me.MetalicTableAdapter1.Fill(Me.Komis2DataSet1.Metalic)
        'TODO: This line of code loads data into the 'Komis2DataSet1.Klasyczny' table. You can move, or remove it, as needed.
        Me.KlasycznyTableAdapter1.Fill(Me.Komis2DataSet1.Klasyczny)
        'TODO: This line of code loads data into the 'Komis2DataSet1.Silnik' table. You can move, or remove it, as needed.
        Me.SilnikTableAdapter1.Fill(Me.Komis2DataSet1.Silnik)
        'TODO: This line of code loads data into the 'Komis2DataSet1.Komis2' table. You can move, or remove it, as needed.
        Me.Komis2TableAdapter1.Fill(Me.Komis2DataSet1.Komis2)
        'TODO: This line of code loads data into the 'Komis1DataSet.Opcje_Dodatkowe' table. You can move, or remove it, as needed.
        Me.Opcje_DodatkoweTableAdapter.Fill(Me.Komis1DataSet.Opcje_Dodatkowe)
        'TODO: This line of code loads data into the 'Komis1DataSet.Klasyczny' table. You can move, or remove it, as needed.
        Me.KlasycznyTableAdapter.Fill(Me.Komis1DataSet.Klasyczny)
        'TODO: This line of code loads data into the 'Komis1DataSet.Metalic' table. You can move, or remove it, as needed.
        Me.MetalicTableAdapter.Fill(Me.Komis1DataSet.Metalic)
        'TODO: This line of code loads data into the 'Komis1DataSet.Silnik' table. You can move, or remove it, as needed.
        Me.SilnikTableAdapter.Fill(Me.Komis1DataSet.Silnik)
        'TODO: This line of code loads data into the 'Komis1DataSet.Komis1' table. You can move, or remove it, as needed.
        Me.Komis1TableAdapter.Fill(Me.Komis1DataSet.Komis1)
        'TODO: This line of code loads data into the 'Komis1DataSet.Opcje_Dodatkowe' table. You can move, or remove it, as needed.
        Me.Opcje_DodatkoweTableAdapter.Fill(Me.Komis1DataSet.Opcje_Dodatkowe)
        'TODO: This line of code loads data into the 'Komis1DataSet.Klasyczny' table. You can move, or remove it, as needed.
        Me.KlasycznyTableAdapter.Fill(Me.Komis1DataSet.Klasyczny)
        'TODO: This line of code loads data into the 'Komis1DataSet.Metalic' table. You can move, or remove it, as needed.
        Me.MetalicTableAdapter.Fill(Me.Komis1DataSet.Metalic)
        'TODO: This line of code loads data into the 'Komis1DataSet.Silnik' table. You can move, or remove it, as needed.
        Me.SilnikTableAdapter.Fill(Me.Komis1DataSet.Silnik)
        'TODO: This line of code loads data into the 'Komis1DataSet.Komis1' table. You can move, or remove it, as needed.
        Me.Komis1TableAdapter.Fill(Me.Komis1DataSet.Komis1)

    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Close()
    End Sub
    Private Sub ComboBoxKomis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKomis.SelectedIndexChanged
        If ComboBoxKomis.Text = "Komis1" Then
            Marka.DataBindings.Clear()
            Model.DataBindings.Clear()
            Silnik.DataBindings.Clear()
            Metalic.DataBindings.Clear()
            Klasyczny.DataBindings.Clear()
            Opcje_Dodatkowe.DataBindings.Clear()
            Marka.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceKomis1, "Marka", True))
            Model.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceKomis1, "Model", True))
            Silnik.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SilnikBindingSource, "Silnik", True))
            Metalic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MetalicBindingSource, "Metalic", True))
            Klasyczny.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlasycznyBindingSource, "Klasyczny", True))
            Opcje_Dodatkowe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpcjeDodatkoweBindingSource, "Opcje_Dodatkowe", True))
            MarkaModelCurrRow.Text = BindingSourceKomis1.Position + 1
            MarkaModelLastRow.Text = BindingSourceKomis1.Count
            SilnikCurrRow.Text = SilnikBindingSource.Position + 1
            SilnikLastRow.Text = SilnikBindingSource.Count
            MetalicCurrRow.Text = MetalicBindingSource.Position + 1
            MetalicLastRow.Text = MetalicBindingSource.Count
            KlasycznyCurrRow.Text = KlasycznyBindingSource.Position + 1
            KlasycznyLastRow.Text = KlasycznyBindingSource.Count
            OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource.Position + 1
            OpcjeDodatkoweLastRow.Text = OpcjeDodatkoweBindingSource.Count

        ElseIf ComboBoxKomis.Text = "Komis2" Then
            Marka.DataBindings.Clear()
            Model.DataBindings.Clear()
            Silnik.DataBindings.Clear()
            Metalic.DataBindings.Clear()
            Klasyczny.DataBindings.Clear()
            Opcje_Dodatkowe.DataBindings.Clear()
            Marka.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceKomis2, "Marka", True))
            Model.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceKomis2, "Model", True))
            Silnik.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Silnik2BindingSource, "Silnik", True))
            Metalic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MetalicBindingSource2, "Metalic", True))
            Klasyczny.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlasycznyBindingSource2, "Klasyczny", True))
            Opcje_Dodatkowe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpcjeDodatkoweBindingSource2, "Opcje_Dodatkowe", True))
            MarkaModelCurrRow.Text = BindingSourceKomis2.Position + 1
            MarkaModelLastRow.Text = BindingSourceKomis2.Count
            SilnikCurrRow.Text = SilnikBindingSource.Position + 1
            SilnikLastRow.Text = Silnik2BindingSource.Count
            MetalicCurrRow.Text = MetalicBindingSource2.Position + 1
            MetalicLastRow.Text = MetalicBindingSource2.Count
            KlasycznyCurrRow.Text = KlasycznyBindingSource2.Position + 1
            KlasycznyLastRow.Text = KlasycznyBindingSource2.Count
            OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource2.Position + 1
            OpcjeDodatkoweLastRow.Text = OpcjeDodatkoweBindingSource2.Count

        End If
    End Sub

    Private Sub MarkaModelNext_Click(sender As Object, e As EventArgs) Handles MarkaModelNext.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If BindingSourceKomis1.Position <> BindingSourceKomis1.Count Then
                BindingSourceKomis1.Position += 1
                MarkaModelCurrRow.Text = BindingSourceKomis1.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If BindingSourceKomis2.Position <> BindingSourceKomis2.Count Then
                BindingSourceKomis2.Position += 1
                MarkaModelCurrRow.Text = BindingSourceKomis2.Position + 1
            End If

        End If

    End Sub

    Private Sub MarkaModelPrev_Click(sender As Object, e As EventArgs) Handles MarkaModelPrev.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If BindingSourceKomis1.Position <> 0 Then
                BindingSourceKomis1.Position -= 1
                MarkaModelCurrRow.Text = BindingSourceKomis1.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If BindingSourceKomis2.Position <> 0 Then
                BindingSourceKomis2.Position -= 1
                MarkaModelCurrRow.Text = BindingSourceKomis2.Position + 1
            End If

        End If
    End Sub

    Private Sub MarkaModelFirst_Click(sender As Object, e As EventArgs) Handles MarkaModelFirst.Click
        If ComboBoxKomis.Text = "Komis1" Then
            BindingSourceKomis1.Position = 0
            MarkaModelCurrRow.Text = BindingSourceKomis1.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            BindingSourceKomis2.Position = 0
            MarkaModelCurrRow.Text = BindingSourceKomis2.Position + 1
        End If
    End Sub

    Private Sub MarkaModelLast_Click(sender As Object, e As EventArgs) Handles MarkaModelLast.Click
        If ComboBoxKomis.Text = "Komis1" Then
            BindingSourceKomis1.Position = BindingSourceKomis1.Count - 1
            MarkaModelCurrRow.Text = BindingSourceKomis1.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            BindingSourceKomis2.Position = BindingSourceKomis2.Count - 1
            MarkaModelCurrRow.Text = BindingSourceKomis2.Position + 1
        End If
    End Sub

    Private Sub SilnikNext_Click(sender As Object, e As EventArgs) Handles SilnikNext.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If SilnikBindingSource.Position <> SilnikBindingSource.Count Then
                SilnikBindingSource.Position += 1
                SilnikCurrRow.Text = SilnikBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If Silnik2BindingSource.Position <> Silnik2BindingSource.Count Then
                Silnik2BindingSource.Position += 1
                SilnikCurrRow.Text = Silnik2BindingSource.Position + 1
            End If

        End If
    End Sub

    Private Sub SilnikPrev_Click(sender As Object, e As EventArgs) Handles SilnikPrev.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If SilnikBindingSource.Position <> SilnikBindingSource.Count Then
                SilnikBindingSource.Position -= 1
                SilnikCurrRow.Text = SilnikBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If Silnik2BindingSource.Position <> Silnik2BindingSource.Count Then
                Silnik2BindingSource.Position -= 1
                SilnikCurrRow.Text = Silnik2BindingSource.Position + 1
            End If

        End If
    End Sub

    Private Sub SilnikLast_Click(sender As Object, e As EventArgs) Handles SilnikLast.Click
        If ComboBoxKomis.Text = "Komis1" Then
            SilnikBindingSource.Position = SilnikBindingSource.Count - 1
            SilnikCurrRow.Text = SilnikBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            Silnik2BindingSource.Position = Silnik2BindingSource.Count - 1
            SilnikCurrRow.Text = Silnik2BindingSource.Position + 1
        End If
    End Sub

    Private Sub SilnikFirst_Click(sender As Object, e As EventArgs) Handles SilnikFirst.Click
        If ComboBoxKomis.Text = "Komis1" Then
            SilnikBindingSource.Position = 0
            SilnikCurrRow.Text = SilnikBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            Silnik2BindingSource.Position = 0
            SilnikCurrRow.Text = Silnik2BindingSource.Position + 1
        End If
    End Sub

    Private Sub MetalicNext_Click(sender As Object, e As EventArgs) Handles MetalicNext.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If MetalicBindingSource.Position <> MetalicBindingSource.Count Then
                MetalicBindingSource.Position += 1
                MetalicCurrRow.Text = MetalicBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If MetalicBindingSource2.Position <> MetalicBindingSource2.Count Then
                MetalicBindingSource2.Position += 1
                MetalicCurrRow.Text = MetalicBindingSource2.Position + 1
            End If

        End If
    End Sub

    Private Sub MetalicPrev_Click(sender As Object, e As EventArgs) Handles MetalicPrev.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If MetalicBindingSource.Position <> MetalicBindingSource.Count Then
                MetalicBindingSource.Position -= 1
                MetalicCurrRow.Text = MetalicBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If MetalicBindingSource2.Position <> MetalicBindingSource2.Count Then
                MetalicBindingSource2.Position -= 1
                MetalicCurrRow.Text = MetalicBindingSource2.Position + 1
            End If

        End If
    End Sub

    Private Sub MetalicLast_Click(sender As Object, e As EventArgs) Handles MetalicLast.Click
        If ComboBoxKomis.Text = "Komis1" Then
            MetalicBindingSource.Position = MetalicBindingSource.Count - 1
            MetalicCurrRow.Text = MetalicBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            MetalicBindingSource2.Position = MetalicBindingSource2.Count - 1
            MetalicCurrRow.Text = MetalicBindingSource2.Position + 1
        End If
    End Sub

    Private Sub MetalicFirst_Click(sender As Object, e As EventArgs) Handles MetalicFirst.Click
        If ComboBoxKomis.Text = "Komis1" Then
            MetalicBindingSource.Position = 0
            MetalicCurrRow.Text = MetalicBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            MetalicBindingSource2.Position = 0
            MetalicCurrRow.Text = MetalicBindingSource2.Position + 1
        End If
    End Sub

    Private Sub KlasycznyNext_Click(sender As Object, e As EventArgs) Handles KlasycznyNext.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If KlasycznyBindingSource.Position <> KlasycznyBindingSource.Count Then
                KlasycznyBindingSource.Position += 1
                KlasycznyCurrRow.Text = KlasycznyBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If KlasycznyBindingSource2.Position <> KlasycznyBindingSource2.Count Then
                KlasycznyBindingSource2.Position += 1
                KlasycznyCurrRow.Text = KlasycznyBindingSource2.Position + 1
            End If
        End If
    End Sub

    Private Sub KlasycznyPrev_Click(sender As Object, e As EventArgs) Handles KlasycznyPrev.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If KlasycznyBindingSource.Position <> KlasycznyBindingSource.Count Then
                KlasycznyBindingSource.Position -= 1
                KlasycznyCurrRow.Text = KlasycznyBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If KlasycznyBindingSource2.Position <> KlasycznyBindingSource2.Count Then
                KlasycznyBindingSource2.Position -= 1
                KlasycznyCurrRow.Text = KlasycznyBindingSource2.Position + 1
            End If

        End If
    End Sub

    Private Sub KlasycznyLast_Click(sender As Object, e As EventArgs) Handles KlasycznyLast.Click
        If ComboBoxKomis.Text = "Komis1" Then
            KlasycznyBindingSource.Position = KlasycznyBindingSource.Count - 1
            KlasycznyCurrRow.Text = KlasycznyBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            KlasycznyBindingSource2.Position = KlasycznyBindingSource2.Count - 1
            KlasycznyCurrRow.Text = KlasycznyBindingSource2.Position + 1
        End If
    End Sub

    Private Sub KlasycznyFirst_Click(sender As Object, e As EventArgs) Handles KlasycznyFirst.Click
        If ComboBoxKomis.Text = "Komis1" Then
            KlasycznyBindingSource.Position = 0
            KlasycznyCurrRow.Text = KlasycznyBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            KlasycznyBindingSource2.Position = 0
            KlasycznyCurrRow.Text = KlasycznyBindingSource2.Position + 1
        End If
    End Sub

    Private Sub OpcjeNext_Click(sender As Object, e As EventArgs) Handles OpcjeNext.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If OpcjeDodatkoweBindingSource.Position <> OpcjeDodatkoweBindingSource.Count Then
                OpcjeDodatkoweBindingSource.Position += 1
                OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If OpcjeDodatkoweBindingSource2.Position <> OpcjeDodatkoweBindingSource2.Count Then
                OpcjeDodatkoweBindingSource2.Position += 1
                OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource2.Position + 1
            End If
        End If
    End Sub

    Private Sub OpcjePrev_Click(sender As Object, e As EventArgs) Handles OpcjePrev.Click
        If ComboBoxKomis.Text = "Komis1" Then
            If OpcjeDodatkoweBindingSource.Position <> OpcjeDodatkoweBindingSource.Count Then
                OpcjeDodatkoweBindingSource.Position -= 1
                OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource.Position + 1
            End If
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            If OpcjeDodatkoweBindingSource2.Position <> OpcjeDodatkoweBindingSource2.Count Then
                OpcjeDodatkoweBindingSource2.Position -= 1
                OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource2.Position + 1
            End If
        End If
    End Sub

    Private Sub OpcjeLast_Click(sender As Object, e As EventArgs) Handles OpcjeLast.Click
        If ComboBoxKomis.Text = "Komis1" Then
            OpcjeDodatkoweBindingSource.Position = OpcjeDodatkoweBindingSource.Count - 1
            OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            OpcjeDodatkoweBindingSource2.Position = OpcjeDodatkoweBindingSource2.Count - 1
            OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource2.Position + 1
        End If
    End Sub

    Private Sub OpcjeFirst_Click(sender As Object, e As EventArgs) Handles OpcjeFirst.Click
        If ComboBoxKomis.Text = "Komis1" Then
            OpcjeDodatkoweBindingSource.Position = 0
            OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource.Position + 1
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            OpcjeDodatkoweBindingSource2.Position = 0
            OpcjeDodatkoweCurrRow.Text = OpcjeDodatkoweBindingSource2.Position + 1
        End If
    End Sub

    Private Sub MarkaModelEdit_Click(sender As Object, e As EventArgs) Handles MarkaModelEdit.Click
        MarkaModelNext.Enabled = False
        MarkaModelPrev.Enabled = False
        MarkaModelFirst.Enabled = False
        MarkaModelLast.Enabled = False
        MarkaModelEdit.Enabled = False
        Marka.ReadOnly = False
        Model.ReadOnly = False
        Marka.Focus()
    End Sub

    Private Sub MarkaModelSave_Click(sender As Object, e As EventArgs) Handles MarkaModelSave.Click

        Dim iCurrentRecord As Integer
        If ComboBoxKomis.Text = "Komis1" Then
            BindingSourceKomis1.EndEdit()
            iCurrentRecord = BindingSourceKomis1.Position
            If Komis1DataSet.HasChanges() = True Then
                Komis1TableAdapter.Update(Komis1DataSet.Komis1)
                Komis1TableAdapter.Fill(Komis1DataSet.Komis1)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            End If
            BindingSourceKomis1.Position = iCurrentRecord
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            BindingSourceKomis2.EndEdit()
            iCurrentRecord = BindingSourceKomis2.Position
            If Komis2DataSet1.HasChanges() = True Then
                Komis2TableAdapter1.Update(Komis2DataSet1.Komis2)
                Komis2TableAdapter1.Fill(Komis2DataSet1.Komis2)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            BindingSourceKomis2.Position = iCurrentRecord
        End If
        MarkaModelLast.PerformClick()
        MarkaModelNext.Enabled = True
        MarkaModelPrev.Enabled = True
        MarkaModelFirst.Enabled = True
        MarkaModelLast.Enabled = True
        MarkaModelEdit.Enabled = True
        Marka.ReadOnly = True
        Model.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True

    End Sub

    Private Sub MarkaModelCancel_Click(sender As Object, e As EventArgs) Handles MarkaModelCancel.Click
        If ComboBoxKomis.Text = "Komis1" Then
            BindingSourceKomis1.CancelEdit()
            BindingSourceKomis1_PositionChanged(Nothing, Nothing)
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            BindingSourceKomis2.CancelEdit()
            BindingSourceKomis2_PositionChanged(Nothing, Nothing)
        End If
        Marka.ReadOnly = True
        Model.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
        MarkaModelEdit.Enabled = True
        MarkaModelNext.Enabled = True
        MarkaModelPrev.Enabled = True
        MarkaModelFirst.Enabled = True
        MarkaModelLast.Enabled = True

    End Sub

    Private Sub BindingSourceKomis1_PositionChanged(sender As Object, e As EventArgs)
        MarkaModelLastRow.Text = BindingSourceKomis1.Count()
        SilnikLastRow.Text = SilnikBindingSource.Count()
        KlasycznyLastRow.Text = KlasycznyBindingSource.Count()
        MetalicLastRow.Text = MetalicBindingSource.Count()
        OpcjeDodatkoweLastRow.Text = OpcjeDodatkoweBindingSource.Count()
    End Sub

    Private Sub BindingSourceKomis2_PositionChanged(sender As Object, e As EventArgs)
        MarkaModelLastRow.Text = BindingSourceKomis2.Count()
        SilnikLastRow.Text = Silnik2BindingSource.Count()
        KlasycznyLastRow.Text = KlasycznyBindingSource2.Count()
        MetalicLastRow.Text = MetalicBindingSource2.Count()
        OpcjeDodatkoweLastRow.Text = OpcjeDodatkoweBindingSource2.Count()
    End Sub

    Private Sub MarkaModelAdd_Click(sender As Object, e As EventArgs) Handles MarkaModelAdd.Click
        Dim iStartRec As Integer
        Marka.ReadOnly = False
        Model.ReadOnly = False
        Marka.Focus()
        iStartRec = BindingSourceKomis1.Position
        If ComboBoxKomis.Text = "Komis1" Then
            BindingSourceKomis1.AddNew()
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            BindingSourceKomis2.AddNew()
        End If

    End Sub

    Private Sub MarkaModelDelete_Click(sender As Object, e As EventArgs) Handles MarkaModelDelete.Click
        Dim iResponse As DialogResult
        iResponse = MessageBox.Show("Czy chcesz na pewno usunąc wiersz ?", "potwierdz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iResponse = Windows.Forms.DialogResult.Yes Then
            If ComboBoxKomis.Text = "Komis1" Then
                BindingSourceKomis1.RemoveAt(BindingSourceKomis1.Position)
                Komis1TableAdapter.Update(Komis1DataSet.Komis1)
                Komis1TableAdapter.Fill(Komis1DataSet.Komis1)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            ElseIf ComboBoxKomis.Text = "Komis2" Then
                BindingSourceKomis2.RemoveAt(BindingSourceKomis2.Position)
                Komis2TableAdapter1.Update(Komis2DataSet1.Komis2)
                Komis2TableAdapter1.Fill(Komis2DataSet1.Komis2)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            MarkaModelFirst.PerformClick()
        End If
    End Sub

    Private Sub SilnikAdd_Click(sender As Object, e As EventArgs) Handles SilnikAdd.Click
        Dim iStartRec As Integer
        Silnik.ReadOnly = False
        Silnik.Focus()
        iStartRec = SilnikBindingSource.Position
        If ComboBoxKomis.Text = "Komis1" Then
            SilnikBindingSource.AddNew()
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            Silnik2BindingSource.AddNew()
        End If
    End Sub

    Private Sub SilnikEdit_Click(sender As Object, e As EventArgs) Handles SilnikEdit.Click
        SilnikNext.Enabled = False
        SilnikPrev.Enabled = False
        SilnikFirst.Enabled = False
        SilnikLast.Enabled = False
        SilnikEdit.Enabled = False
        Silnik.ReadOnly = False
        Silnik.Focus()
    End Sub

    Private Sub SilnikSave_Click(sender As Object, e As EventArgs) Handles SilnikSave.Click
        Dim iCurrentRecord As Integer
        If ComboBoxKomis.Text = "Komis1" Then
            SilnikBindingSource.EndEdit()
            iCurrentRecord = SilnikBindingSource.Position
            If Komis1DataSet.HasChanges() = True Then
                SilnikTableAdapter.Update(Komis1DataSet.Silnik)
                SilnikTableAdapter.Fill(Komis1DataSet.Silnik)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            End If
            SilnikBindingSource.Position = iCurrentRecord
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            Silnik2BindingSource.EndEdit()
            iCurrentRecord = Silnik2BindingSource.Position
            If Komis2DataSet1.HasChanges() = True Then
                SilnikTableAdapter1.Update(Komis2DataSet1.Silnik)
                SilnikTableAdapter1.Fill(Komis2DataSet1.Silnik)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            Silnik2BindingSource.Position = iCurrentRecord
        End If
        SilnikLast.PerformClick()
        SilnikNext.Enabled = True
        SilnikPrev.Enabled = True
        SilnikFirst.Enabled = True
        SilnikLast.Enabled = True
        SilnikEdit.Enabled = True
        Silnik.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
    End Sub

    Private Sub SilnikCancel_Click(sender As Object, e As EventArgs) Handles SilnikCancel.Click
        If ComboBoxKomis.Text = "Komis1" Then
            SilnikBindingSource.CancelEdit()
            BindingSourceKomis1_PositionChanged(Nothing, Nothing)
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            Silnik2BindingSource.CancelEdit()
            BindingSourceKomis2_PositionChanged(Nothing, Nothing)
        End If
        Silnik.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
        SilnikEdit.Enabled = True
        SilnikNext.Enabled = True
        SilnikPrev.Enabled = True
        SilnikFirst.Enabled = True
        SilnikLast.Enabled = True
    End Sub

    Private Sub SilnikDelete_Click(sender As Object, e As EventArgs) Handles SilnikDelete.Click
        Dim iResponse As DialogResult
        iResponse = MessageBox.Show("Czy chcesz na pewno usunąc wiersz ?", "potwierdz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iResponse = Windows.Forms.DialogResult.Yes Then
            If ComboBoxKomis.Text = "Komis1" Then
                SilnikBindingSource.RemoveAt(SilnikBindingSource.Position)
                SilnikTableAdapter.Update(Komis1DataSet.Silnik)
                SilnikTableAdapter.Fill(Komis1DataSet.Silnik)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            ElseIf ComboBoxKomis.Text = "Komis2" Then
                Silnik2BindingSource.RemoveAt(Silnik2BindingSource.Position)
                SilnikTableAdapter1.Update(Komis2DataSet.Silnik)
                SilnikTableAdapter1.Fill(Komis2DataSet.Silnik)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            SilnikFirst.PerformClick()
        End If
    End Sub

    Private Sub MetalicAdd_Click(sender As Object, e As EventArgs) Handles MetalicAdd.Click
        Dim iStartRec As Integer
        Metalic.ReadOnly = False
        Metalic.Focus()
        iStartRec = SilnikBindingSource.Position
        If ComboBoxKomis.Text = "Komis1" Then
            MetalicBindingSource.AddNew()
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            MetalicBindingSource2.AddNew()
        End If
    End Sub

    Private Sub MetalicEdit_Click(sender As Object, e As EventArgs) Handles MetalicEdit.Click
        MetalicNext.Enabled = False
        MetalicPrev.Enabled = False
        MetalicFirst.Enabled = False
        MetalicLast.Enabled = False
        MetalicEdit.Enabled = False
        Metalic.ReadOnly = False
        Metalic.Focus()
    End Sub

    Private Sub MetalicSave_Click(sender As Object, e As EventArgs) Handles MetalicSave.Click
        Dim iCurrentRecord As Integer
        If ComboBoxKomis.Text = "Komis1" Then
            MetalicBindingSource.EndEdit()
            iCurrentRecord = MetalicBindingSource.Position
            If Komis1DataSet.HasChanges() = True Then
                MetalicTableAdapter.Update(Komis1DataSet.Metalic)
                MetalicTableAdapter.Fill(Komis1DataSet.Metalic)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            End If
            MetalicBindingSource.Position = iCurrentRecord
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            MetalicBindingSource2.EndEdit()
            iCurrentRecord = MetalicBindingSource2.Position
            If Komis2DataSet1.HasChanges() = True Then
                MetalicTableAdapter1.Update(Komis2DataSet1.Metalic)
                MetalicTableAdapter1.Fill(Komis2DataSet1.Metalic)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            MetalicBindingSource2.Position = iCurrentRecord
        End If
        MetalicLast.PerformClick()
        MetalicNext.Enabled = True
        MetalicPrev.Enabled = True
        MetalicFirst.Enabled = True
        MetalicLast.Enabled = True
        MetalicEdit.Enabled = True
        Metalic.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
    End Sub

    Private Sub MetalicCancel_Click(sender As Object, e As EventArgs) Handles MetalicCancel.Click
        If ComboBoxKomis.Text = "Komis1" Then
            MetalicBindingSource.CancelEdit()
            BindingSourceKomis1_PositionChanged(Nothing, Nothing)
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            MetalicBindingSource2.CancelEdit()
            BindingSourceKomis2_PositionChanged(Nothing, Nothing)
        End If
        Metalic.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
        MetalicEdit.Enabled = True
        MetalicNext.Enabled = True
        MetalicPrev.Enabled = True
        MetalicFirst.Enabled = True
        MetalicLast.Enabled = True
    End Sub

    Private Sub MetalicDelete_Click(sender As Object, e As EventArgs) Handles MetalicDelete.Click
        Dim iResponse As DialogResult
        iResponse = MessageBox.Show("Czy chcesz na pewno usunąc wiersz ?", "potwierdz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iResponse = Windows.Forms.DialogResult.Yes Then
            If ComboBoxKomis.Text = "Komis1" Then
                MetalicBindingSource.RemoveAt(MetalicBindingSource.Position)
                MetalicTableAdapter.Update(Komis1DataSet.Metalic)
                MetalicTableAdapter.Fill(Komis1DataSet.Metalic)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            ElseIf ComboBoxKomis.Text = "Komis2" Then
                MetalicBindingSource2.RemoveAt(MetalicBindingSource2.Position)
                MetalicTableAdapter1.Update(Komis2DataSet.Metalic)
                MetalicTableAdapter1.Fill(Komis2DataSet.Metalic)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            MetalicFirst.PerformClick()
        End If
    End Sub

    Private Sub KlasycznyCancel_Click(sender As Object, e As EventArgs) Handles KlasycznyCancel.Click
        If ComboBoxKomis.Text = "Komis1" Then
            KlasycznyBindingSource.CancelEdit()
            BindingSourceKomis1_PositionChanged(Nothing, Nothing)
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            KlasycznyBindingSource2.CancelEdit()
            BindingSourceKomis2_PositionChanged(Nothing, Nothing)
        End If
        Klasyczny.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
        KlasycznyEdit.Enabled = True
        KlasycznyNext.Enabled = True
        KlasycznyPrev.Enabled = True
        KlasycznyFirst.Enabled = True
        KlasycznyLast.Enabled = True
    End Sub

    Private Sub KlasycznySave_Click(sender As Object, e As EventArgs) Handles KlasycznySave.Click
        Dim iCurrentRecord As Integer
        If ComboBoxKomis.Text = "Komis1" Then
            KlasycznyBindingSource.EndEdit()
            iCurrentRecord = KlasycznyBindingSource.Position
            If Komis1DataSet.HasChanges() = True Then
                KlasycznyTableAdapter.Update(Komis1DataSet.Klasyczny)
                KlasycznyTableAdapter.Fill(Komis1DataSet.Klasyczny)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            End If
            KlasycznyBindingSource.Position = iCurrentRecord
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            KlasycznyBindingSource2.EndEdit()
            iCurrentRecord = KlasycznyBindingSource2.Position
            If Komis2DataSet1.HasChanges() = True Then
                KlasycznyTableAdapter1.Update(Komis2DataSet1.Klasyczny)
                KlasycznyTableAdapter1.Fill(Komis2DataSet1.Klasyczny)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            KlasycznyBindingSource2.Position = iCurrentRecord
        End If
        KlasycznyLast.PerformClick()
        KlasycznyNext.Enabled = True
        KlasycznyPrev.Enabled = True
        KlasycznyFirst.Enabled = True
        KlasycznyLast.Enabled = True
        KlasycznyEdit.Enabled = True
        Klasyczny.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
    End Sub

    Private Sub KlasycznyEdit_Click(sender As Object, e As EventArgs) Handles KlasycznyEdit.Click
        KlasycznyNext.Enabled = False
        KlasycznyPrev.Enabled = False
        KlasycznyFirst.Enabled = False
        KlasycznyLast.Enabled = False
        KlasycznyEdit.Enabled = False
        Klasyczny.ReadOnly = False
        Klasyczny.Focus()
    End Sub

    Private Sub KlasycznyAdd_Click(sender As Object, e As EventArgs) Handles KlasycznyAdd.Click
        Dim iStartRec As Integer
        Klasyczny.ReadOnly = False
        Klasyczny.Focus()
        iStartRec = KlasycznyBindingSource.Position
        If ComboBoxKomis.Text = "Komis1" Then
            KlasycznyBindingSource.AddNew()
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            KlasycznyBindingSource2.AddNew()
        End If
    End Sub

    Private Sub OpcjeAdd_Click(sender As Object, e As EventArgs) Handles OpcjeAdd.Click
        Dim iStartRec As Integer
        Opcje_Dodatkowe.ReadOnly = False
        Opcje_Dodatkowe.Focus()
        iStartRec = OpcjeDodatkoweBindingSource.Position
        If ComboBoxKomis.Text = "Komis1" Then
            OpcjeDodatkoweBindingSource.AddNew()
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            OpcjeDodatkoweBindingSource2.AddNew()
        End If
    End Sub

    Private Sub OpcjeEdit_Click(sender As Object, e As EventArgs) Handles OpcjeEdit.Click
        OpcjeNext.Enabled = False
        OpcjePrev.Enabled = False
        OpcjeFirst.Enabled = False
        OpcjeLast.Enabled = False
        OpcjeEdit.Enabled = False
        Opcje_Dodatkowe.ReadOnly = False
        Opcje_Dodatkowe.Focus()
    End Sub

    Private Sub OpcjeSave_Click(sender As Object, e As EventArgs) Handles OpcjeSave.Click
        Dim iCurrentRecord As Integer
        If ComboBoxKomis.Text = "Komis1" Then
            OpcjeDodatkoweBindingSource.EndEdit()
            iCurrentRecord = OpcjeDodatkoweBindingSource.Position
            If Komis1DataSet.HasChanges() = True Then
                Opcje_DodatkoweTableAdapter.Update(Komis1DataSet.Opcje_Dodatkowe)
                Opcje_DodatkoweTableAdapter.Fill(Komis1DataSet.Opcje_Dodatkowe)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            End If
            OpcjeDodatkoweBindingSource.Position = iCurrentRecord
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            OpcjeDodatkoweBindingSource2.EndEdit()
            iCurrentRecord = OpcjeDodatkoweBindingSource2.Position
            If Komis2DataSet1.HasChanges() = True Then
                Opcje_DodatkoweTableAdapter1.Update(Komis2DataSet1.Opcje_Dodatkowe)
                Opcje_DodatkoweTableAdapter1.Fill(Komis2DataSet1.Opcje_Dodatkowe)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            OpcjeDodatkoweBindingSource2.Position = iCurrentRecord
        End If
        OpcjeLast.PerformClick()
        OpcjeNext.Enabled = True
        OpcjePrev.Enabled = True
        OpcjeFirst.Enabled = True
        OpcjeLast.Enabled = True
        OpcjeEdit.Enabled = True
        Opcje_Dodatkowe.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
    End Sub

    Private Sub OpcjeCancel_Click(sender As Object, e As EventArgs) Handles OpcjeCancel.Click
        If ComboBoxKomis.Text = "Komis1" Then
            OpcjeDodatkoweBindingSource.CancelEdit()
            BindingSourceKomis1_PositionChanged(Nothing, Nothing)
        ElseIf ComboBoxKomis.Text = "Komis2" Then
            OpcjeDodatkoweBindingSource2.CancelEdit()
            BindingSourceKomis2_PositionChanged(Nothing, Nothing)
        End If
        Opcje_Dodatkowe.ReadOnly = True
        SilnikGroupBox.Visible = True
        LakierGroupBox.Visible = True
        OpcjeDodatkoweGroupBox.Visible = True
        OpcjeEdit.Enabled = True
        OpcjeNext.Enabled = True
        OpcjePrev.Enabled = True
        OpcjeFirst.Enabled = True
        OpcjeLast.Enabled = True
    End Sub

    Private Sub KlasycznyDelete_Click(sender As Object, e As EventArgs) Handles KlasycznyDelete.Click
        Dim iResponse As DialogResult
        iResponse = MessageBox.Show("Czy chcesz na pewno usunąc wiersz ?", "potwierdz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iResponse = Windows.Forms.DialogResult.Yes Then
            If ComboBoxKomis.Text = "Komis1" Then
                KlasycznyBindingSource.RemoveAt(KlasycznyBindingSource.Position)
                KlasycznyTableAdapter.Update(Komis1DataSet.Klasyczny)
                KlasycznyTableAdapter.Fill(Komis1DataSet.Klasyczny)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            ElseIf ComboBoxKomis.Text = "Komis2" Then
                KlasycznyBindingSource2.RemoveAt(MetalicBindingSource2.Position)
                KlasycznyTableAdapter1.Update(Komis2DataSet.Klasyczny)
                KlasycznyTableAdapter1.Fill(Komis2DataSet.Klasyczny)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            KlasycznyFirst.PerformClick()
        End If
    End Sub

    Private Sub OpcjeDelete_Click(sender As Object, e As EventArgs) Handles OpcjeDelete.Click
        Dim iResponse As DialogResult
        iResponse = MessageBox.Show("Czy chcesz na pewno usunąc wiersz ?", "potwierdz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iResponse = Windows.Forms.DialogResult.Yes Then
            If ComboBoxKomis.Text = "Komis1" Then
                OpcjeDodatkoweBindingSource.RemoveAt(OpcjeDodatkoweBindingSource.Position)
                Opcje_DodatkoweTableAdapter.Update(Komis1DataSet.Opcje_Dodatkowe)
                Opcje_DodatkoweTableAdapter.Fill(Komis1DataSet.Opcje_Dodatkowe)
                BindingSourceKomis1_PositionChanged(Nothing, Nothing)
            ElseIf ComboBoxKomis.Text = "Komis2" Then
                OpcjeDodatkoweBindingSource2.RemoveAt(OpcjeDodatkoweBindingSource.Position)
                Opcje_DodatkoweTableAdapter1.Update(Komis2DataSet.Opcje_Dodatkowe)
                Opcje_DodatkoweTableAdapter1.Fill(Komis2DataSet.Opcje_Dodatkowe)
                BindingSourceKomis2_PositionChanged(Nothing, Nothing)
            End If
            OpcjeFirst.PerformClick()
        End If
    End Sub
End Class