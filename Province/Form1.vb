Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CreateTable()
        Call PrepareButtons()
        Call LoadNewProv()
    End Sub
    Private Sub DynamicClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        'MsgBox("You clicked " + btn.Text)
        Call CheckAnswer(btn.Text)
        Call LoadNewProv()
    End Sub
    Private Sub CreateButtons(BCapt As String, ix As Byte)
        Dim btn As New Button
        btn.Height = 90
        btn.Width = 200
        btn.Font = New Font(lbl_NewPr.Font.Name, 22, FontStyle.Regular)

        btn.Text = BCapt
        btn.Name = "btn_" & BCapt
        AddHandler btn.Click, AddressOf DynamicClick
        Me.Controls.Add(btn)

        btn.Left = 10 + (ix Mod 5) * btn.Width
        btn.Top = 120 + Math.Floor(ix / 5) * btn.Height
    End Sub
    Private Sub CreateTable()
        With tbl_Prov
            .Rows.Add("L'Aquila", "Abruzzo", False, False)
            .Rows.Add("Teramo", "Abruzzo", False, False)
            .Rows.Add("Pescara", "Abruzzo", False, False)
            .Rows.Add("Chieti", "Abruzzo", False, False)
            .Rows.Add("Potenza", "Basilicata", False, False)
            .Rows.Add("Matera", "Basilicata", False, False)
            .Rows.Add("Cosenza", "Calabria", False, False)
            .Rows.Add("Catanzaro", "Calabria", False, False)
            .Rows.Add("Reggio di Calabria", "Calabria", False, False)
            .Rows.Add("Crotone", "Calabria", False, False)
            .Rows.Add("Vibo Valentia", "Calabria", False, False)
            .Rows.Add("Caserta", "Campania", False, False)
            .Rows.Add("Benevento", "Campania", False, False)
            .Rows.Add("Napoli", "Campania", False, False)
            .Rows.Add("Avellino", "Campania", False, False)
            .Rows.Add("Salerno", "Campania", False, False)
            .Rows.Add("Piacenza", "Emilia-Romagna", False, False)
            .Rows.Add("Parma", "Emilia-Romagna", False, False)
            .Rows.Add("Reggio nell'Emilia", "Emilia-Romagna", False, False)
            .Rows.Add("Modena", "Emilia-Romagna", False, False)
            .Rows.Add("Bologna", "Emilia-Romagna", False, False)
            .Rows.Add("Ferrara", "Emilia-Romagna", False, False)
            .Rows.Add("Ravenna", "Emilia-Romagna", False, False)
            .Rows.Add("Forli'-Cesena", "Emilia-Romagna", False, False)
            .Rows.Add("Rimini", "Emilia-Romagna", False, False)
            .Rows.Add("Udine", "Friuli-Venezia Giulia", False, False)
            .Rows.Add("Gorizia", "Friuli-Venezia Giulia", False, False)
            .Rows.Add("Trieste", "Friuli-Venezia Giulia", False, False)
            .Rows.Add("Pordenone", "Friuli-Venezia Giulia", False, False)
            .Rows.Add("Viterbo", "Lazio", False, False)
            .Rows.Add("Rieti", "Lazio", False, False)
            .Rows.Add("Roma", "Lazio", False, False)
            .Rows.Add("Latina", "Lazio", False, False)
            .Rows.Add("Frosinone", "Lazio", False, False)
            .Rows.Add("Imperia", "Liguria", False, False)
            .Rows.Add("Savona", "Liguria", False, False)
            .Rows.Add("Genova", "Liguria", False, False)
            .Rows.Add("La Spezia", "Liguria", False, False)
            .Rows.Add("Varese", "Lombardia", False, False)
            .Rows.Add("Como", "Lombardia", False, False)
            .Rows.Add("Sondrio", "Lombardia", False, False)
            .Rows.Add("Milano", "Lombardia", False, False)
            .Rows.Add("Bergamo", "Lombardia", False, False)
            .Rows.Add("Brescia", "Lombardia", False, False)
            .Rows.Add("Pavia", "Lombardia", False, False)
            .Rows.Add("Cremona", "Lombardia", False, False)
            .Rows.Add("Mantova", "Lombardia", False, False)
            .Rows.Add("Lecco", "Lombardia", False, False)
            .Rows.Add("Lodi", "Lombardia", False, False)
            .Rows.Add("Pesaro e Urbino", "Marche", False, False)
            .Rows.Add("Ancona", "Marche", False, False)
            .Rows.Add("Macerata", "Marche", False, False)
            .Rows.Add("Ascoli Piceno", "Marche", False, False)
            .Rows.Add("Campobasso", "Molise", False, False)
            .Rows.Add("Isernia", "Molise", False, False)
            .Rows.Add("Torino", "Piemonte", False, False)
            .Rows.Add("Vercelli", "Piemonte", False, False)
            .Rows.Add("Novara", "Piemonte", False, False)
            .Rows.Add("Cuneo", "Piemonte", False, False)
            .Rows.Add("Asti", "Piemonte", False, False)
            .Rows.Add("Alessandria", "Piemonte", False, False)
            .Rows.Add("Biella", "Piemonte", False, False)
            .Rows.Add("Verbano-Cusio-Ossola", "Piemonte", False, False)
            .Rows.Add("Foggia", "Puglia", False, False)
            .Rows.Add("Bari", "Puglia", False, False)
            .Rows.Add("Taranto", "Puglia", False, False)
            .Rows.Add("Brindisi", "Puglia", False, False)
            .Rows.Add("Lecce", "Puglia", False, False)
            .Rows.Add("Sassari", "Sardegna", False, False)
            .Rows.Add("Nuoro", "Sardegna", False, False)
            .Rows.Add("Cagliari", "Sardegna", False, False)
            .Rows.Add("Oristano", "Sardegna", False, False)
            .Rows.Add("Trapani", "Sicilia", False, False)
            .Rows.Add("Palermo", "Sicilia", False, False)
            .Rows.Add("Messina", "Sicilia", False, False)
            .Rows.Add("Agrigento", "Sicilia", False, False)
            .Rows.Add("Caltanissetta", "Sicilia", False, False)
            .Rows.Add("Enna", "Sicilia", False, False)
            .Rows.Add("Catania", "Sicilia", False, False)
            .Rows.Add("Ragusa", "Sicilia", False, False)
            .Rows.Add("Siracusa", "Sicilia", False, False)
            .Rows.Add("Massa-Carrara", "Toscana", False, False)
            .Rows.Add("Lucca", "Toscana", False, False)
            .Rows.Add("Pistoia", "Toscana", False, False)
            .Rows.Add("Firenze", "Toscana", False, False)
            .Rows.Add("Livorno", "Toscana", False, False)
            .Rows.Add("Pisa", "Toscana", False, False)
            .Rows.Add("Arezzo", "Toscana", False, False)
            .Rows.Add("Siena", "Toscana", False, False)
            .Rows.Add("Grosseto", "Toscana", False, False)
            .Rows.Add("Prato", "Toscana", False, False)
            .Rows.Add("Bolzano", "Trentino-Alto Adige", False, False)
            .Rows.Add("Trento", "Trentino-Alto Adige", False, False)
            .Rows.Add("Perugia", "Umbria", False, False)
            .Rows.Add("Terni", "Umbria", False, False)
            .Rows.Add("Aosta", "Valle d'Aosta", False, False)
            .Rows.Add("Verona", "Veneto", False, False)
            .Rows.Add("Vicenza", "Veneto", False, False)
            .Rows.Add("Belluno", "Veneto", False, False)
            .Rows.Add("Treviso", "Veneto", False, False)
            .Rows.Add("Venezia", "Veneto", False, False)
            .Rows.Add("Padova", "Veneto", False, False)
            .Rows.Add("Rovigo", "Veneto", False, False)
        End With

        With tbl_Regions
            .Rows.Add("Abruzzo")
            .Rows.Add("Basilicata")
            .Rows.Add("Calabria")
            .Rows.Add("Campania")
            .Rows.Add("Emilia-Romagna")
            .Rows.Add("Friuli-Venezia Giulia")
            .Rows.Add("Lazio")
            .Rows.Add("Liguria")
            .Rows.Add("Lombardia")
            .Rows.Add("Marche")
            .Rows.Add("Molise")
            .Rows.Add("Piemonte")
            .Rows.Add("Puglia")
            .Rows.Add("Sardegna")
            .Rows.Add("Sicilia")
            .Rows.Add("Toscana")
            .Rows.Add("Trentino-Alto Adige")
            .Rows.Add("Umbria")
            .Rows.Add("Valle d'Aosta")
            .Rows.Add("Veneto")
        End With
    End Sub
    Private Sub PrepareButtons()
        Dim ix As Byte
        For ix = 0 To tbl_Regions.Rows.Count - 1
            CreateButtons(tbl_Regions.Rows(ix)("Region").ToString, ix)
        Next ix
    End Sub
    Private Sub LoadNewProv()
        Dim foundrow As DataRow()
        Dim rndNumb As Integer

        foundrow = tbl_Prov.Select("Load = False")
        If foundrow.Length = 0 Then Exit Sub
        rndNumb = GetRandom(1, foundrow.Length + 1)
        lbl_NewPr.Text = tbl_Prov.Rows(rndNumb)("Prov").ToString
        tbl_Prov.Rows(rndNumb)("load") = True
        lbl_Done.Text = CStr(CInt(lbl_Done.Text) + 1)
        'MsgBox(foundrow.Length) ' how many missing
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        'min inclusive max exclusive
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Sub CheckAnswer(ans As String)
        Dim strSelection As String
        Dim foundrows() As DataRow
        strSelection = "Prov = '" & lbl_NewPr.Text & "'"
        foundrows = tbl_Prov.Select(strSelection)

        If foundrows(0)("Reg") = ans Then
            foundrows(0)("Correct") = True
        Else
            MsgBox(foundrows(0)("Reg"))
        End If
        lbl_Correct.Text = CStr(tbl_Prov.Select("Correct = true").Length)
    End Sub
End Class

