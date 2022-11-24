
Imports System.ComponentModel
Imports System.Text

Public Class Form1

    Dim ArrayMesi() As String = {"A", "B", "C", "D", "E", "H", "L", "M", "P", "R", "S", "T"} 'Lettere che corrispondono al mese
    Dim ArrayDescrizioneMesi() As String = {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
    Dim ArrayCharPosizioneDispari() As Integer = {1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23}
    Dim ArrayChar() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim ArrayPari As New ArrayList
    Dim ArrayDispari As New ArrayList
    Dim ArrayVocali() As String = {"A", "E", "I", "O", "U"}
    Dim txtCodiceFiscale As String = ""




    Dim AttData As DataSet
    Dim DataSetComuni As DataSet
    Dim AttFileName As String

    'Dim sGUID As String
    ''  sGUID = System.Guid.NewGuid.ToString()
    'MessageBox.Show(sGUID
    Private Sub ReadXmlButton_Click(sender As Object, e As EventArgs)




        'BindingNavigator1.Items. .DataBindings. = 0
        'DataGridView1.DataSource = BindingSource1
        'DataGridView1.DataMember = "authors"

    End Sub





    Private Sub AggiornaCampiLettura(sender As Object, e As EventArgs)

        GroupBox1.Enabled = TypeOf (BindingSource1.Current) Is DataRowView
        If TypeOf (BindingSource1.Current) Is DataRowView Then
            Dim a As DataRowView = BindingSource1.Current

            TextBoxNome.Text = a.Row.Item("pp_Nome").ToString
            TextBoxCognome.Text = a.Row.Item("pp_Cognome").ToString
            TextBoxIncarico.Text = a.Row.Item("pp_Incarico").ToString
            TextBoxTabellare.Text = a.Row.Item("pp_Tabellare").ToString
            DateTimePicker1.Value = ValidDate(a.Row.Item("pp_AssunzioneCivile").ToString)
            DateTimePicker2.Value = ValidDate(a.Row.Item("pp_AssunzioneMilitare").ToString)
            ComboBoxLuogoNascita.Text = a.Row.Item("pp_LuogoNascita").ToString
            TextBoxCodiceFiscale.Text = a.Row.Item("pp_CodiceFiscale").ToString
            DateTimePicker3.Value = ValidDate(a.Row.Item("pp_Nascita").ToString)
            TextBoxResidenza.Text = a.Row.Item("pp_Residenza").ToString
            TextBoxTelefono.Text = a.Row.Item("pp_Telefono").ToString
            TextBoxEmail.Text = a.Row.Item("pp_Email").ToString
            TextBoxArea.Text = a.Row.Item("pp_Area").ToString
            TextBoxQualifica.Text = a.Row.Item("pp_Qualifica").ToString
            TextBoxNote.Text = a.Row.Item("pp_Note").ToString
            DateTimePicker5.Value = ValidDate(a.Row.Item("pp_AssunzioneGiuridica").ToString)
            DateTimePicker4.Value = ValidDate(a.Row.Item("pp_AssunzioneAmministrativa").ToString)

            AttFileName = Application.StartupPath & DB_Folder & a.Row.Item("id").ToString & TemplateAttachDBName
            AttData = New DataSet
            AttData.Clear()
            ListBox1.Items.Clear()
            If IO.File.Exists(AttFileName) Then
                AttData.ReadXml(AttFileName)
                If AttData.Tables.Contains("Allegati") Then
                    For Each i In AttData.Tables("Allegati").Rows
                        ListBox1.Items.Add(i.Item("nome").ToString)
                    Next i
                End If

            End If


            ' If a.Row.Item("pp_Allegati").ToString() <> "" Then
            'Dim MyStream As IO.Stream = New IO.MemoryStream(myByteArray)
            '  WebBrowser1.Navigate(a.Row.Item("pp_Allegati"))
            ' WebBrowser1.DocumentStream = New IO.MemoryStream(Convert.FromBase64String(a.Row.Item("pp_Allegati")))
            'PictureBox1.Image = Image.FromStream(New IO.MemoryStream(Convert.FromBase64String(a.Row.Item("pp_Allegati2"))))
            'End If

        End If

    End Sub


    Function ValidDate(PotentialDate As String) As Date
        If (PotentialDate) = "" Then
            ValidDate = Now
        Else
            ValidDate = PotentialDate
        End If

    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form4.ShowDialog()
        Dim ToolTip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()
        ToolTip1.SetToolTip(Button4, "Calcolo Automatico del Codice Fiscale")
        BindingNavigatorAddNewItem.Visible = CanSave
        BindingNavigatorDeleteItem.Visible = CanSave
        ToolStripButton1.Visible = CanSave
        Button2.Visible = CanSave
        Button3.Visible = CanSave
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True
        DataSetComuni = New DataSet
        DataSetComuni.ReadXml(New IO.MemoryStream(Encoding.Unicode.GetBytes(ElencoComuni)))
        ComboBoxLuogoNascita.DataSource = DataSetComuni.Tables(0)
        ComboBoxLuogoNascita.ValueMember = "nome"
        ComboBoxLuogoNascita.AutoCompleteSource = AutoCompleteSource.ListItems

        ComboBoxLuogoNascita.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        If Not IO.Directory.Exists(Application.StartupPath & DB_Folder) Then
            IO.Directory.CreateDirectory(Application.StartupPath & DB_Folder)
        End If
        ' If IO.File.Exists(Application.StartupPath & schemaindex) Then
        AuthorsDataSet.ReadXmlSchema(New IO.MemoryStream(Encoding.Unicode.GetBytes(XMLSchemaIndex)))
        If IO.File.Exists(Application.StartupPath & DB_Index) Then
            AuthorsDataSet.ReadXml(Application.StartupPath & DB_Index)
            'AuthorsDataSet.WriteXmlSchema(Application.StartupPath & schemaindex)
        End If
        ' End If

        BindingNavigator1.BindingSource = BindingSource1
        BindingSource1.DataSource = AuthorsDataSet
        BindingSource1.DataMember = "Persona"

        BindingSource1_CurrentChanged(sender, e)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.PositionChanged
        AggiornaCampiLettura(sender, e)
        If TypeOf (sender) Is BindingSource Then
            If TypeOf (sender.current) Is DataRowView Then


                If Not sender.current.isnew And Not sender.current.isedit Then


                    BindingNavigatorAddNewItem.Enabled = True
                    BindingNavigatorDeleteItem.Enabled = True
                    ToolStripButton1.Enabled = False
                End If
            End If
        End If
    End Sub



    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        ' Dim a As DataRowView = BindingSource1.Current
        If ListBox1.SelectedIndex > -1 Then


            Dim TempFile As String = System.IO.Path.GetTempPath & AttData.Tables("Allegati").Rows(ListBox1.SelectedIndex).Item("nome")
            IO.File.WriteAllBytes(TempFile, Convert.FromBase64String(AttData.Tables("Allegati").Rows(ListBox1.SelectedIndex).Item("Allegato_Text")))
            Process.Start(TempFile)

            'Process.Start(Application.StartupPath & "\temp.jpg")
            'MsgBox(ListBox1.SelectedItem.ToString())
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Dispose()
        Form2.Tag = BindingSource1.Current.Row.Item("id").ToString
        Form2.Text = TextBoxNome.Text & " " & TextBoxCognome.Text & " - " & TextBoxIncarico.Text

        Form2.ShowDialog()
    End Sub



    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        BindingSource1.Filter = "pp_Cognome LIKE '*" & ToolStripTextBox1.Text & "*'"
        BindingSource1_CurrentChanged(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If ListBox1.SelectedIndex > -1 Then
            Dim Risposta = MsgBox("E' la tua risposta definitiva?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conferma Cancellazione")
            If Risposta = MsgBoxResult.Yes Then


                AttData.Tables("Allegati").Rows(ListBox1.SelectedIndex).Delete()
                AttData.WriteXml(AttFileName)
                BindingSource1_CurrentChanged(sender, e)
            End If
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True

        If TypeOf (BindingSource1.Current) Is DataRowView Then
            Dim a As DataRowView = BindingSource1.Current
            a.Row.Item("pp_Nome") = TextBoxNome.Text
            a.Row.Item("pp_Cognome") = TextBoxCognome.Text
            a.Row.Item("pp_Incarico") = TextBoxIncarico.Text
            a.Row.Item("pp_Tabellare") = TextBoxTabellare.Text
            a.Row.Item("pp_AssunzioneCivile") = DateTimePicker1.Value
            a.Row.Item("pp_AssunzioneMilitare") = DateTimePicker2.Value
            a.Row.Item("pp_LuogoNascita") = ComboBoxLuogoNascita.Text
            a.Row.Item("pp_CodiceFiscale") = TextBoxCodiceFiscale.Text
            a.Row.Item("pp_Nascita") = DateTimePicker3.Value
            a.Row.Item("pp_Residenza") = TextBoxResidenza.Text
            a.Row.Item("pp_Telefono") = TextBoxTelefono.Text
            a.Row.Item("pp_Email") = TextBoxEmail.Text
            a.Row.Item("pp_Area") = TextBoxArea.Text
            a.Row.Item("pp_Qualifica") = TextBoxQualifica.Text
            a.Row.Item("pp_Note") = TextBoxNote.Text
            a.Row.Item("pp_AssunzioneGiuridica") = DateTimePicker5.Value
            a.Row.Item("pp_AssunzioneAmministrativa") = DateTimePicker4.Value




            If a.IsNew Then
                Dim sGUID As String
                sGUID = System.Guid.NewGuid.ToString()
                Debug.Write(sGUID)
                a.Row.Item("id") = sGUID
                AuthorsDataSet.Tables("Persona").Rows.Add(a.Row)

                Dim ds As New DataSet
                Dim dt = New DataTable()

                dt.Columns.Add(New DataColumn("Allegato", Type.GetType("System.String")))
                dt.Columns.Add(New DataColumn("Nome", Type.GetType("System.String")))

                ds.Tables.Add(dt)
                ds.Tables(0).TableName = "Allegati"

                'AppDataSet.Tables("Allegati").ReadXmlSchema(Application.StartupPath & DB_Folder & ModelloAllegati)
                dt.WriteXml(Application.StartupPath & DB_Folder & sGUID & TemplateAttachDBName)
            End If
            AuthorsDataSet.WriteXml(Application.StartupPath & DB_Index)
            BindingSource1_CurrentChanged(sender, e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.Multiselect = False
        Dim Risposta As DialogResult = OpenFileDialog1.ShowDialog()

        If Risposta = DialogResult.OK And System.IO.File.Exists(OpenFileDialog1.FileName) Then

            If Not AttData.Tables.Contains("Allegati") Then
                AttData.Tables.Add("Allegati")
                AttData.Tables("Allegati").Columns.Add(New DataColumn("Allegato_Text", Type.GetType("System.String")))
                AttData.Tables("Allegati").Columns.Add(New DataColumn("Nome", Type.GetType("System.String")))
            End If
            Dim NuovaRiga As DataRow = AttData.Tables("Allegati").NewRow
            NuovaRiga.Item("nome") = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            NuovaRiga.Item("Allegato_Text") = Convert.ToBase64String(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
            AttData.Tables("Allegati").Rows.Add(NuovaRiga)

            ' Debug.Write(System.IO.Path.GetFileName(OpenFileDialog1.FileName))
            'Debug.Write(Convert.ToBase64String(IO.File.ReadAllBytes(OpenFileDialog1.FileName)))

            AttData.WriteXml(AttFileName)
            BindingSource1_CurrentChanged(sender, e)
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim Risposta = MsgBox("La modifica non sarà effettiva fino al salvataggio.", MsgBoxStyle.Information, "Notifica")

        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False

    End Sub

    Private Sub Value_Changed(sender As Object, e As EventArgs) ' Handles TextBoxNome.TextChanged, TextBoxTelefono.TextChanged, TextBoxTabellare.TextChanged, TextBoxResidenza.TextChanged, TextBoxLuogoNascita.TextChanged, TextBoxIncarico.TextChanged, TextBoxEmail.TextChanged, TextBoxCognome.TextChanged, TextBoxCodiceFiscale.TextChanged, DateTimePicker3.ValueChanged, DateTimePicker2.ValueChanged, DateTimePicker1.ValueChanged
        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False

    End Sub
    Private Function PulisciStringa(ByVal Array1 As String, ByVal array2 As String) As String
        Dim temp1 As Array
        temp1 = array2.ToCharArray

        Array1 = UCase(Array1)
        For j As Integer = 0 To temp1.Length - 1 Step 1
            Array1 = Array1.ToString.Replace(temp1(j).ToString, "")
        Next
        Return Array1.ToString
    End Function
    Private Function CalcoloCodiceFiscale() As String

        Dim Parte1CodiceFiscale As String
        Dim Parte2CodiceFiscale As String
        Dim Parte3CodiceFiscale As String

        'Prima Cosa 
        Dim Cognome As String
        Dim Nome As String
        Dim SessoMaschio As Boolean
        Dim resp As MsgBoxResult
        resp = MsgBox("Si tratta di un Maschio?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Indicare il Genere")

        SessoMaschio = resp = MsgBoxResult.Yes
        Cognome = UCase(TextBoxCognome.Text.Replace(" ", "").ToString)
        Nome = UCase(TextBoxNome.Text.Replace(" ", "").ToString)

        Dim Data As Date
        Dim Aumenta As Integer = 0

        If (Not SessoMaschio) Then
            Aumenta = 40
        End If

        If IsDate(DateTimePicker3.Value) Then
            Data = DateTimePicker3.Value
            Dim giorno As Integer = Data.Day
            giorno = giorno + Aumenta
            Dim mese As Integer = Data.Month
            Parte2CodiceFiscale = Data.ToString("yy") & ArrayMesi(mese - 1) & giorno.ToString()
        End If

        Dim ArrayConsonanti As Array

        If Cognome.Length > 0 Then

            For i As Integer = 0 To Cognome.Length - 1
                For j As Integer = 0 To ArrayVocali.Length - 1
                    Cognome = Cognome.ToString.Replace(ArrayVocali(j).ToString, "")
                Next
            Next
        End If

        Select Case Cognome.Length

            Case Is = 3, Is > 3

                Parte1CodiceFiscale = Cognome.Substring(0, 3).ToString

            Case Is = 2

                Parte1CodiceFiscale = PulisciStringa(TextBoxCognome.Text, Cognome)
                Parte1CodiceFiscale = Cognome.Substring(0, 2).ToString & Parte1CodiceFiscale(0).ToString

            Case Is = 1

                Parte1CodiceFiscale = PulisciStringa(TextBoxCognome.Text, Cognome)
                Parte1CodiceFiscale = Cognome.Substring(0, 1).ToString & Parte1CodiceFiscale(0).ToString

            Case Is = 0

                Parte1CodiceFiscale = TextBoxCognome.Text

                Select Case Parte1CodiceFiscale.Length
                    Case Is = 3, Is > 4
                        Parte1CodiceFiscale = Parte1CodiceFiscale.Substring(0, 3).ToString
                    Case Is = 2
                        Parte1CodiceFiscale = Parte1CodiceFiscale.Substring(0, 2).ToString & "X"
                    Case Is = 1
                        Parte1CodiceFiscale = Parte1CodiceFiscale.Substring(0, 1).ToString & "XX"
                    Case Is = 0
                        Parte1CodiceFiscale = "XXX"
                End Select


        End Select


        If Nome.Length > 2 Then

            For i As Integer = 0 To Nome.Length - 1
                For j As Integer = 0 To ArrayVocali.Length - 1
                    Nome = Nome.ToString.Replace(ArrayVocali(j).ToString, "")
                Next
            Next
        End If

        Dim TEMP As String
        Select Case Nome.Length

            Case Is = 4, Is > 4
                'Mariangela = MNG
                'Aldo Maria = LMR
                ArrayConsonanti = Nome.ToArray
                Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(2).ToString & ArrayConsonanti(3).ToString

            Case Is = 3
                'Bruno = BRN
                ArrayConsonanti = Nome.ToArray
                Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & ArrayConsonanti(2).ToString

            Case Is = 2
                'Luca = LCU
                ArrayConsonanti = Nome.ToArray
                TEMP = PulisciStringa(UCase(TextBoxNome.Text), Nome)
                If TEMP.Length > 0 Then
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & TEMP(0).ToString
                Else
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & "X"
                End If
            Case Is = 1
                'Lia = LIA
                ArrayConsonanti = Nome.ToArray
                TEMP = PulisciStringa(UCase(TextBoxNome.Text), Nome)
                If TEMP.Length > 0 Then
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & TEMP(0).ToString & TEMP(1).ToString
                Else
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & "X"
                End If
            Case Is = 0
                Select Case TextBoxNome.TextLength
                    Case Is = 3, Is > 4
                        Parte1CodiceFiscale = Parte1CodiceFiscale & TextBoxNome.Text.Substring(0, 3).ToString
                    Case Is = 2
                        Parte1CodiceFiscale = Parte1CodiceFiscale & TextBoxNome.Text.Substring(0, 2).ToString & "X"
                    Case Is = 1
                        Parte1CodiceFiscale = Parte1CodiceFiscale & TextBoxNome.Text.Substring(0, 1).ToString & "XX"
                    Case Is = 0
                        Parte1CodiceFiscale = Parte1CodiceFiscale & "XXX"
                End Select

        End Select

        Dim strcodicecatasto As String
        strcodicecatasto = DataSetComuni.Tables(0).Select("nome = '" & ComboBoxLuogoNascita.Text & "'")(0).Item("codice").ToString()



        Parte2CodiceFiscale = Parte2CodiceFiscale & strcodicecatasto
        Parte2CodiceFiscale = Parte1CodiceFiscale & Parte2CodiceFiscale
        Parte3CodiceFiscale = StringCarattereControllo(Parte2CodiceFiscale)


        CalcoloCodiceFiscale = Parte2CodiceFiscale & Parte3CodiceFiscale
        'Parte3CodiceFiscale = Parte1CodiceFiscale & Parte2CodiceFiscale & Parte3CodiceFiscale



    End Function
    Private Function StringCarattereControllo(ByVal CodiceFiscale As String) As String
        Dim risultato As Integer = 0
        Dim sommapari As Integer = 0
        Dim sommadispari As Integer = 0
        Try
            If CodiceFiscale.ToString <> "" Then
                For i As Integer = 0 To CodiceFiscale.Length - 1 Step 1
                    'Vi ricordo che l'array parte da zero ma noi dobbiamo calcolare come se fosse 1 
                    'e quindi Dispari si trovano nella posizione Pari e i Pari si trovano nella posizione Dispari
                    If i Mod (2) = 1 Then
                        'Indice Dispari - Posizione Dispari)
                        ArrayPari.Add(CodiceFiscale.Substring(i, 1).ToString)
                    Else
                        'Indice Pari - Posizione Pari
                        ArrayDispari.Add(CodiceFiscale.Substring(i, 1).ToString)
                    End If
                Next
                For i As Integer = 0 To ArrayPari.Count - 1 Step 1
                    If IsNumeric(ArrayPari(i).ToString) Then
                        sommapari = sommapari + ArrayPari(i).ToString
                        'Console.WriteLine(ArrayPari(i).ToString & " ArrayPari(" & i & ").ToString = " & ArrayPari(i).ToString)
                    Else
                        For j As Integer = 0 To ArrayChar.Length - 1 Step 1
                            If (UCase(ArrayPari(i).ToString) = ArrayChar(j).ToString) Then
                                sommapari = sommapari + j
                                'Console.WriteLine(ArrayPari(i).ToString & " ArrayPari(" & i & ").ToString = " & j)
                                Exit For
                            End If
                        Next
                    End If
                Next
                For i As Integer = 0 To ArrayDispari.Count - 1 Step 1
                    If IsNumeric(ArrayDispari(i).ToString) Then
                        sommadispari = sommadispari + ArrayCharPosizioneDispari(ArrayDispari(i).ToString).ToString
                        'Console.WriteLine(ArrayDispari(i).ToString & " ArrayDispari(" & i & ").ToString = " & ArrayCharPosizioneDispari(ArrayDispari(i).ToString).ToString)
                    Else
                        For j As Integer = 0 To ArrayChar.Length - 1 Step 1
                            If (UCase(ArrayDispari(i).ToString) = ArrayChar(j).ToString) Then
                                sommadispari = sommadispari + ArrayCharPosizioneDispari(j).ToString
                                'Console.WriteLine(ArrayDispari(i).ToString & " ArrayCharPosizioneDispari(" & j & ").ToString = " & ArrayCharPosizioneDispari(j).ToString)
                                Exit For
                            End If
                        Next
                    End If
                Next
                risultato = 0

            End If

            ArrayPari.Clear()
            ArrayDispari.Clear()
            risultato = (sommapari + sommadispari) Mod 26
            'Console.WriteLine(ArrayChar(risultato).ToString & " = " & CodiceFiscale.Substring(CodiceFiscale.Length - 1, 1).ToString)
            Return ArrayChar(risultato).ToString
        Catch ex As Exception
            'Errore generato da qualche numero e carattere strano
            Return "Errore"
        End Try
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataSetComuni.Tables(0).Select("nome = '" & ComboBoxLuogoNascita.Text & "'").Count > 0 Then
            TextBoxCodiceFiscale.Text = CalcoloCodiceFiscale()
        Else
            MsgBox("Comune di Nascita Errato", MsgBoxStyle.Critical, "Errore nei Dati")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged

    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
End Class
