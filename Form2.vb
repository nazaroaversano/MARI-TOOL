'Ingresso Minimo Valido: 7:30
' Formato: HH.MM
' Buono pasto se Presenza >= 6:30

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Visible = CanSave
        Label1.Text = Me.Text
        ComboBox1.SelectedIndex = DateAndTime.Month(Now) - 1
        ComboBox2.Items.Add(DateAndTime.Year(Now) - 1)
        ComboBox2.Items.Add(DateAndTime.Year(Now))
        ComboBox2.SelectedIndex = 1


        'DataGridView1.DataMember.
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()
        'DataGridView1.ColumnCount = 7
        DataGridView1.Columns().Add("Data", "Data")
        'DataGridView1.Columns(0).Name = "Data"
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).ReadOnly = True
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).DefaultCellStyle.Font = New Font(DataGridView1.DefaultCellStyle.Font, FontStyle.Bold)
        'DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.Gray

        DataGridView1.Columns().Add("E1", "Ent. 1")

        DataGridView1.Columns().Add("U1", "Usc. 1")

        DataGridView1.Columns().Add("E2", "Ent. 2")

        DataGridView1.Columns().Add("U2", "Usc. 2")


        Dim AppCol As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
        AppCol.Name = "Attività"
        AppCol.MinimumWidth = 170
        AppCol.SortMode = DataGridViewColumnSortMode.NotSortable
        AppCol.Items().Add("")
        AppCol.Items().Add("Licenza")
        AppCol.Items().Add("Missione")
        AppCol.Items().Add("Ricovero")
        AppCol.Items().Add("Permesso")
        AppCol.Items().Add("Recupero")
        AppCol.Items().Add("Malattia")
        AppCol.Items().Add("Servizio")
        AppCol.Items().Add("Reperibilità")

        AppCol.Items().Add("Ass. Particolari")
        AppCol.Items().Add("Straordinario")
        AppCol.Items().Add("B.Pasto-C.Mensa")
        AppCol.Items().Add("Smart Working")
        AppCol.Items().Add("FESTIVO")



        'DataGridView1.Columns(5).Name = "Attività"
        'DataGridView1.Columns(5).MinimumWidth = 170
        'DataGridView1.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns().Add(AppCol)


        DataGridView1.Columns().Add("Giustificativo", "A")
        'DataGridView1.Columns(0).Name = "Data"
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).ReadOnly = True

        DataGridView1.Columns().Add("DurataMinuti", "Presenza")
        ' DataGridView1.Columns(DataGridView1.ColumnCount - 1).Visible = False
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).ReadOnly = True

        DataGridView1.Columns().Add("BP", "B.P.")
        ' DataGridView1.Columns(DataGridView1.ColumnCount - 1).Visible = False
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns(DataGridView1.ColumnCount - 1).ReadOnly = True
        '*****
        ' Dim el As DataGridViewRow
        'el = New DataGridViewRow
        'Dim ima As DataGridViewImageCell = New DataGridViewImageCell()
        'ima.Value = ImageList1.Images(0)
        ' ima.ImageLayout = DataGridViewImageCellLayout.Zoom
        'el.Cells.Add(ima)
        'DataGridView1.Rows.Add(el)
        '***
        AggiornaTabella(DateAndTime.Month(Now), DateAndTime.Year(Now))

        '  Dim row As String() = New String() {"1", "Product 1", "1000"}
        '  DataGridView1.Rows.Add(row)
        ' row = New String() {"2", "Product 2", "2000"}
        ' DataGridView1.Rows.Add(row)
        '  row = New String() {"3", "Product 3", "3000"}
        ' DataGridView1.Rows.Add(row)
        '  row = New String() {"4", "Product 4", "4000"}
        ' DataGridView1.Rows.Add(row)




    End Sub

    Sub AggiornaTabella(mese As Integer, anno As Integer)
        Dim Presenze As Integer = 0
        Dim AccumuloMinuti As Integer = 0
        Dim BuoniPasto As Integer = 0
        DataGridView1.Rows.Clear()
        Dim AppoggioData As Date
        Dim N_Giorni_Mese_Selezionato As Integer = System.DateTime.DaysInMonth(anno, mese)
        For i = 1 To N_Giorni_Mese_Selezionato
            AppoggioData = Convert.ToDateTime(i & "/" & mese & "/" & anno)

            Dim row = New String() {AppoggioData.ToString("dd/MM/yyyy"), "", ""}
            ' Dim a As DataGridViewRow = New DataGridView1


            Dim appi As Integer = DataGridView1.Rows.Add(row)
            If AppoggioData.DayOfWeek() = DayOfWeek.Saturday Or AppoggioData.DayOfWeek() = DayOfWeek.Sunday Then

                DataGridView1.Rows(appi).Cells("Attività").Value = "FESTIVO"
            End If

        Next i
        LeggiStatino(Me.Tag)
        AccumuloMinuti = 0
        For Each i As DataGridViewRow In DataGridView1.Rows
            AccumuloMinuti = AccumuloMinuti + i.Cells("DurataMinuti").Value
            If i.Cells("DurataMinuti").Value > (6 * 60 + 30) Or i.Cells("Attività").Value = "Smart Working" Or i.Cells("Attività").Value = "Servizio" Then
                Presenze = Presenze + 1
            End If
            If i.Cells("DurataMinuti").Value > (6 * 60 + 32) Or i.Cells("Attività").Value = "Servizio" Then
                BuoniPasto = BuoniPasto + 1
                i.Cells("BP").Value = "X"
            End If
        Next i
        Label2.Text = "Presenze: " & Presenze
        Label3.Text = "Buoni Pasto: " & BuoniPasto
        Label4.Text = "Tempo Totale di Presenza nel Mese: " & AccumuloMinuti \ 60 & " Ora/e e " & AccumuloMinuti Mod 60 & " Minuto/i"
        DataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
    End Sub


    Sub LeggiStatino(identificativo As String)
        Dim AttFileName As String = Application.StartupPath & DB_Folder & identificativo & TemplateTAttachDBName
        AttData = New DataSet
        AttData.Clear()
        AttData.ReadXmlSchema(New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(XMLSchema)))
        If IO.File.Exists(AttFileName) Then


            AttData.ReadXml(AttFileName)
            For Each j In AttData.Tables("Giorno").Rows
                For Each i As DataGridViewRow In DataGridView1.Rows

                    Dim jstring As String = j.item("data").ToString
                    If i.Cells("Data").Value = jstring Then
                        Dim appcella As DataGridViewComboBoxCell = i.Cells("Attività")
                        If appcella.Items.IndexOf(j.item("attivita").ToString) > -1 Then
                            appcella.Value = j.item("attivita").ToString
                        End If
                        i.Cells("E1").Value = j.Item("Ent1").ToString.Replace(":", ".")
                        i.Cells("E2").Value = j.Item("Ent2").ToString.Replace(":", ".")
                        i.Cells("U1").Value = j.Item("Usc1").ToString.Replace(":", ".")
                        i.Cells("U2").Value = j.Item("Usc2").ToString.Replace(":", ".")

                        Dim Alleg As DataRow() = AttData.Tables("Allegato").Select("Giorno_Id =" & j.Item("Giorno_Id").ToString)
                        If Alleg.Count > 0 Then

                            Dim ima As DataGridViewImageCell = New DataGridViewImageCell()
                            ima.Value = ImageList1.Images(0)
                            ima.ImageLayout = DataGridViewImageCellLayout.Zoom
                            i.Cells("Giustificativo") = ima 'el.Cells.Add(ima)
                            'DataGridView1.Rows.Add(el)
                        End If
                        ' For Each i In AttData.Tables("Allegato").Select("Giorno_Id =" & j.Item("Giorno_Id").ToString) 'j.Item("A").Table.Rows
                        'ListBox1.Items.Add(i.Item("Nome").ToString)
                        'Next i
                    End If
                Next i
            Next j
            For Each i As DataGridViewRow In DataGridView1.Rows
                '                DataGridView1.Columns().Add("Ent. 1", "Ent. 1")
                '               DataGridView1.Columns().Add("Usc. 1", "Usc. 1")
                Dim duration As Integer = 0
                If ValidTime(i.Cells("E1").Value.ToString.Replace(".", ":")) And ValidTime(i.Cells("U1").Value.ToString.Replace(".", ":")) Then
                    Dim E1 As DateTime = Convert.ToDateTime(i.Cells("E1").Value.ToString().Replace(".", ":"))
                    Dim U1 As DateTime = Convert.ToDateTime(i.Cells("U1").Value.ToString().Replace(".", ":"))


                    If (E1 - Convert.ToDateTime("07:30")).TotalSeconds < 0 Then
                        E1 = Convert.ToDateTime("07:30")
                    End If

                    duration = (U1 - E1).TotalMinutes  '+ (U2 - E2).Minutes
                    If ValidTime(i.Cells("E2").Value.ToString.Replace(".", ":")) And ValidTime(i.Cells("U2").Value.ToString.Replace(".", ":")) Then
                        Dim E2 As DateTime = Convert.ToDateTime(i.Cells("E2").Value.ToString().Replace(".", ":"))
                        Dim U2 As DateTime = Convert.ToDateTime(i.Cells("U2").Value.ToString().Replace(".", ":"))
                        duration = duration + (U2 - E2).TotalMinutes
                    End If

                    If duration < 0 Then
                        duration = 0
                    End If
                    If duration >= (6 * 60 + 30) Then
                        i.DefaultCellStyle.BackColor = Color.LightGreen
                    Else
                        If i.Cells("Attività").Value IsNot Nothing Then


                            If i.Cells("Attività").Value.ToString.Length > 0 Then
                                If i.Cells("Attività").Value.ToString = "FESTIVO" Then
                                    i.DefaultCellStyle.BackColor = Color.Purple
                                Else
                                    i.DefaultCellStyle.BackColor = Color.White

                                End If

                            Else
                                i.DefaultCellStyle.BackColor = Color.LightSalmon
                            End If
                        Else
                            i.DefaultCellStyle.BackColor = Color.LightSalmon
                        End If
                    End If
                Else
                    If i.Cells("Attività").Value IsNot Nothing Then


                        If i.Cells("Attività").Value.ToString.Length > 0 Then
                            If i.Cells("Attività").Value.ToString = "FESTIVO" Then
                                i.DefaultCellStyle.BackColor = Color.Purple
                            Else
                                i.DefaultCellStyle.BackColor = Color.White

                            End If
                        Else
                            i.DefaultCellStyle.BackColor = Color.Red
                        End If
                    Else
                        i.DefaultCellStyle.BackColor = Color.Red
                    End If
                End If

                i.Cells("DurataMinuti").Value = duration
            Next i
        End If
    End Sub

    Function ValidTime(input As String) As Boolean
        Dim appValid As Boolean = True

        appValid = appValid And input.Length = 5
        If appValid Then


            appValid = appValid And IsNumeric(input(0)) And IsNumeric(input(1))
            appValid = appValid And IsNumeric(input(3)) And IsNumeric(input(4))
            appValid = appValid And input(2) = ":"
        End If
        ValidTime = appValid
    End Function

    Sub ScriviStatino(identificativo As String)
        Dim AttFileName As String = Application.StartupPath & DB_Folder & identificativo & TemplateTAttachDBName
        AttData = New DataSet
        AttData.Clear()




        AttData.ReadXmlSchema(New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(XMLSchema)))
        If IO.File.Exists(AttFileName) Then
            AttData.ReadXml(AttFileName)
        End If



        For Each i As DataGridViewRow In DataGridView1.Rows


            For Each j In AttData.Tables("Giorno").Select("data = '" & i.Cells("Data").Value & "'")

                j.Item("attivita") = i.Cells("Attività").Value
                j.Item("Ent1") = i.Cells("E1").Value
                j.Item("Ent2") = i.Cells("E2").Value
                j.Item("Usc1") = i.Cells("U1").Value
                j.Item("Usc2") = i.Cells("U2").Value

            Next j
            If AttData.Tables("Giorno").Select("data = '" & i.Cells("Data").Value & "'").Count = 0 Then
                Dim AppRow = AttData.Tables("Giorno").NewRow
                AppRow.Item("data") = i.Cells("Data").Value
                AppRow.Item("attivita") = i.Cells("Attività").Value
                AppRow.Item("Ent1") = i.Cells("E1").Value
                AppRow.Item("Ent2") = i.Cells("E2").Value
                AppRow.Item("Usc1") = i.Cells("U1").Value
                AppRow.Item("Usc2") = i.Cells("U2").Value
                'AppRow.Item("Giorno_Id") = ComboBox2.Items(ComboBox2.SelectedIndex) * 365 + (ComboBox1.SelectedIndex + 1) * 31 + i.Index + 1  'System.Guid.NewGuid.ToString()
                AttData.Tables("Giorno").Rows.Add(AppRow)
            End If

        Next i
        AttData.WriteXml(AttFileName)

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        AggiornaTabella(ComboBox1.SelectedIndex + 1, ComboBox2.Items(ComboBox2.SelectedIndex))
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted

        AggiornaTabella(ComboBox1.SelectedIndex + 1, ComboBox2.Items(ComboBox2.SelectedIndex))
    End Sub



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        'LeggiStatino(Me.Tag)
    End Sub



    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.CurrentCell.ColumnIndex = 6 And DataGridView1.CurrentRow.Index > -1 Then

            Form3.Dispose()
            Form3identificativo = Me.Tag
            Form3.Text = "Allegati Giorno: " & DataGridView1.CurrentRow.Cells("Data").Value
            Form3data = DataGridView1.CurrentRow.Cells("Data").Value
            Form3.ShowDialog()
        End If
    End Sub


    Private Sub Form2_Click(sender As Object, e As EventArgs)
        'Routine di test non eseguita, tenuta qui solo come promemoria
        AttData = New DataSet
        AttData.Clear()
        Dim AttFileName As String = Application.StartupPath & DB_Folder & Me.Tag & "bis" & TemplateTAttachDBName
        Dim schema As String = Application.StartupPath & DB_Folder & "schema.xml"
        'If IO.File.Exists(AttFileName) Then
        Dim Prova As System.IO.FileStream = New System.IO.FileStream(schema, IO.FileMode.Open)
        'AttData.ReadXml(AttFileName)
        AttData.ReadXmlSchema(Prova)
        AttData.WriteXml(AttFileName)
        Prova.Close()
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScriviStatino(Me.Tag)
        MsgBox("Salvataggio Eseguito!", vbInformation)
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' AggiornaTabella(DateAndTime.Month(Now), DateAndTime.Year(Now))
        AggiornaTabella(ComboBox1.SelectedIndex + 1, ComboBox2.Items(ComboBox2.SelectedIndex))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Result As DialogResult = FolderBrowserDialog1.ShowDialog()

        If Result <> DialogResult.Cancel Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(FolderBrowserDialog1.SelectedPath & "\dati.csv", False)
            file.WriteLine(Label1.Text)
            file.WriteLine(Label2.Text)
            file.WriteLine(Label4.Text)
            file.WriteLine("Data;" & "Entrata 1;" & "Uscita 1;" & "Entrata 2;" & "Uscita 2;" & "Attività;" & "Presenza;")
            Dim appstringa As String = ""
            For Each i As DataGridViewRow In DataGridView1.Rows


                file.WriteLine(i.Cells(0).Value & ";" & i.Cells(1).Value & ";" & i.Cells(2).Value & ";" & i.Cells(3).Value & ";" & i.Cells(4).Value & ";" & i.Cells(5).Value & ";" & i.Cells(7).Value & ";")


            Next i
            file.Close()

            MsgBox("Salvataggio Effettuato!", vbInformation)
        End If
    End Sub

End Class