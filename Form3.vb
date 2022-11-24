Public Class Form3
    Dim GiornoId As String
    Dim AttDataForm3 As DataSet
    Dim AttFileName As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = CanSave
        Button3.Visible = CanSave
        AggiornaLista(Form3identificativo, Form3data)
    End Sub

    Sub AggiornaLista(identificativo As String, data As String)
        AttFileName = Application.StartupPath & DB_Folder & identificativo & TemplateTAttachDBName
        AttDataForm3 = New DataSet
        AttDataForm3.Clear()
        ListBox1.Items.Clear()
        If IO.File.Exists(AttFileName) Then
            AttDataForm3.ReadXmlSchema(New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(XMLSchema)))
            AttDataForm3.ReadXml(AttFileName)
            For Each j In AttData.Tables("Giorno").Rows
                If j.item("data").ToString = data Then
                    GiornoId = j.Item("Giorno_Id").ToString
                    For Each i In AttDataForm3.Tables("Allegato").Select("Giorno_Id =" & GiornoId) 'j.Item("A").Table.Rows
                        ListBox1.Items.Add(i.Item("Nome").ToString)

                    Next i
                End If
            Next j

        End If
    End Sub


    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        ' Dim a As DataRowView = BindingSource1.Current
        If ListBox1.SelectedIndex > -1 Then
            ' AttDataForm3.Tables("Allegato").Select()
            For Each i In AttDataForm3.Tables("Allegato").Select("Giorno_Id =" & GiornoId)
                If i.Item("Nome").ToString = ListBox1.SelectedItem.ToString Then 'j.Item("A").Table.Rows



                    Dim TempFile As String = System.IO.Path.GetTempPath & i.Item("Nome").ToString
                    IO.File.WriteAllBytes(TempFile, Convert.FromBase64String(i.Item("Allegato_Text")))
                    Process.Start(TempFile)
                End If
            Next i
            'Process.Start(Application.StartupPath & "\temp.jpg")
            'MsgBox(ListBox1.SelectedItem.ToString())
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.Multiselect = False
        Dim Risposta As DialogResult = OpenFileDialog1.ShowDialog()

        If Risposta = DialogResult.OK And System.IO.File.Exists(OpenFileDialog1.FileName) Then



            Dim NuovaRiga As DataRow = AttDataForm3.Tables("Allegato").NewRow
            NuovaRiga.Item("Giorno_Id") = GiornoId
            NuovaRiga.Item("nome") = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
                NuovaRiga.Item("Allegato_Text") = Convert.ToBase64String(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
            AttDataForm3.Tables("Allegato").Rows.Add(NuovaRiga)



            AttDataForm3.WriteXml(AttFileName)


            AggiornaLista(Form3identificativo, Form3data)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex > -1 Then
            AttDataForm3.Tables("Allegato").Rows(ListBox1.SelectedIndex).Delete()
            AttDataForm3.WriteXml(AttFileName)
            AggiornaLista(Form3identificativo, Form3data)
        End If
    End Sub
End Class