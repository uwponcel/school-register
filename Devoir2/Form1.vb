'********************************************************************
'* Devoir 02 - William Poncelet
'********************************************************************
Public Class Form1

    '********************************************************************
    '* Variables globale
    '********************************************************************

    Public Structure Membres
        Dim NoMembre As String
        Dim TypeMembre As String
        Dim LangCode As String
        Dim MembreNom As String
        Dim MembrePrenom As String
        Dim MembreAdresse As String
        Dim MembreVille As String
        Dim ProvCode As String
        Dim MembreCodePostal As String
        Dim MembreNoTel As String
        Dim MembreEmail As String
    End Structure
    Public Structure Provinces
        Dim ProvCode As String
        Dim ProvDesc As String
    End Structure
    Public Structure Langues
        Dim LangCode As String
        Dim LangDesc As String
    End Structure
    Public Structure TypesMembres
        Dim TypeMembre As String
        Dim TypeMembreDesc As String
    End Structure

    Public FicheMembre As New SortedList(Of String, Membres)
    Public FicheProvince As New SortedList(Of String, Provinces)
    Public FicheLangue As New SortedList(Of String, Langues)
    Public FicheTypeMembre As New SortedList(Of String, TypesMembres)

    Public RecMembre As New Membres
    Public RecProvince As New Provinces
    Public RecTypeMembre As New TypesMembres
    Public RecLangue As New Langues

    Private index As Integer
    Private modified As Boolean = False
    Private saved As Boolean = False
    Private isLoaded As Boolean = False

    Private Sub MiseAJourMembre_Click(sender As Object, e As EventArgs) Handles MiseAJourMembre.Click
        ' Ajouter ici le code pour mettre à jour le membre dans la collection
        ' N'oublier pas de marquer la collection comme modifiée 
        '             afin de la sauvegarder lors de la fermeture de l'application.
        If Not isLoaded Then
            MsgBox("Veuillez charger la collection de membres en premier.")
        Else
            Dim Membre As Membres

            Membre.NoMembre = Me.mtbNumeroMembre.Text
            Membre.MembreNom = Me.mtbNom.Text
            Membre.MembrePrenom = Me.mtbPrenom.Text
            Membre.MembreAdresse = Me.tbAdresse.Text
            Membre.MembreVille = Me.tbVille.Text
            Membre.ProvCode = cboProvince.SelectedItem.ToString
            Membre.MembreCodePostal = mtbCodePostal.Text
            Membre.MembreNoTel = mtbTelephone.Text
            Membre.MembreEmail = tbCourriel.Text
            Membre.LangCode = cboLangue.SelectedItem.ToString
            Membre.TypeMembre = cboTypeMembre.SelectedItem.ToString



            Dim isSame As Boolean = Membre.Equals(FicheMembre.Item(Membre.NoMembre))

            If Not isSame Then
                FicheMembre.Item(Membre.NoMembre) = Membre
                MsgBox("Mise à jour de la fiche du membre réussie !")
                modified = True
            Else
                MsgBox("Veuillez effectuer une modification en premier !")
            End If
        End If
    End Sub

    Private Sub FirstMember_Click(sender As Object, e As EventArgs) Handles FirstMember.Click
        'Ajouter ici le code pour afficher le premier membre de la collection
        '(faites attention, vous êtes peut-être dèjà sur le premier membre)
        'N'oubliez pas de rafraîchir le nom de la province, la description de la langue et du type de membre
        If Not isLoaded Then
            MsgBox("Veuillez charger la collection de membres en premier.")
        Else
            If index = FicheMembre.IndexOfKey(FicheMembre.Keys.First) Then
                MsgBox("Vous visualiser déjà le premier membre.")
            End If
            index = FicheMembre.IndexOfKey(FicheMembre.Keys.First)
            AfficherMembre(FicheMembre.Keys.First)
            LoadCboDescriptions()
        End If
    End Sub

    Private Sub PreviousMember_Click(sender As Object, e As EventArgs) Handles PreviousMember.Click
        'Ajouter ici le code pour afficher le  membre précédent
        '(faites attention, vous êtes peut-être dèjà sur le premier membre)
        'N'oubliez pas de rafraîchir le nom de la province, la description de la langue et du type de membre
        If Not isLoaded Then
            MsgBox("Veuillez charger la collection de membres en premier.")
        Else
            If index = FicheMembre.IndexOfKey(FicheMembre.Keys.First) Then
                MsgBox("Il n'y a pas de membres supplémentaire.")
            Else
                Dim nextMember = FicheMembre.Values(index - 1).NoMembre
                AfficherMembre(nextMember)
                LoadCboDescriptions()
                index -= 1
            End If
        End If
    End Sub

    Private Sub NextMember_Click(sender As Object, e As EventArgs) Handles NextMember.Click
        'Ajouter ici le code pour afficher le  membre suivant
        '(faites attention, vous êtes peut-être sur le dernier membre)
        'N'oubliez pas de rafraîchir le nom de la province, la description de la langue et du type de membre
        If Not isLoaded Then
            MsgBox("Veuillez charger la collection de membres en premier.")
        Else
            If index = FicheMembre.IndexOfKey(FicheMembre.Keys.Last) Then
                MsgBox("Il n'y a pas de membres supplémentaire.")
            Else
                Dim nextMember = FicheMembre.Values(index + 1).NoMembre
                AfficherMembre(nextMember)
                LoadCboDescriptions()
                index += 1
            End If
        End If
    End Sub

    Private Sub LastMember_Click(sender As Object, e As EventArgs) Handles LastMember.Click
        'Ajouter ici le code pour afficher le dernier membre 
        '(faites attention, vous êtes peut-être sur le dernier membre)
        'N'oubliez pas de rafraîchir le nom de la province, la description de la langue et du type de membre
        If Not isLoaded Then
            MsgBox("Veuillez charger la collection de membres en premier.")
        Else
            If index = FicheMembre.IndexOfKey(FicheMembre.Keys.Last) Then
                MsgBox("Vous visualiser déjà le dernier membre.")
            End If
            index = FicheMembre.IndexOfKey(FicheMembre.Keys.Last)
            AfficherMembre(FicheMembre.Keys.Last)
            LoadCboDescriptions()
        End If
    End Sub

    Private Sub ChargerCollections_Click(sender As Object, e As EventArgs) Handles ChargerCollections.Click

        Dim cle As String
        Dim Membre As Membres
        Dim Province As Provinces
        Dim Langue As Langues
        Dim TypeMembre As TypesMembres


        If Not isLoaded Then
            'Ajouter ici le code nécessaire pour charger les donnéers des 4 fichiers de données diponibles dans les collections respectives.
            Using BBMembresReader As New FileIO.TextFieldParser("..\..\..\BB_Membres.txt")
                BBMembresReader.TextFieldType = FileIO.FieldType.Delimited
                BBMembresReader.SetDelimiters("|")
                Dim currentRow As String()
                While Not BBMembresReader.EndOfData
                    Try
                        currentRow = BBMembresReader.ReadFields()
                        Membre.NoMembre = currentRow(0)
                        Membre.TypeMembre = currentRow(1)
                        Membre.LangCode = currentRow(2)
                        Membre.MembreNom = currentRow(3)
                        Membre.MembrePrenom = currentRow(4)
                        Membre.MembreAdresse = currentRow(5)
                        Membre.MembreVille = currentRow(6)
                        Membre.ProvCode = currentRow(7)
                        Membre.MembreCodePostal = currentRow(8)
                        Membre.MembreNoTel = currentRow(9)
                        Membre.MembreEmail = currentRow(10)
                        cle = Membre.NoMembre
                        FicheMembre.Add(cle, Membre)
                    Catch ex As FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                    End Try
                End While
                BBMembresReader.Close()
            End Using
            Using BBTypesMembresReader As New FileIO.TextFieldParser("..\..\..\BB_TypesMembres.txt")
                BBTypesMembresReader.TextFieldType = FileIO.FieldType.Delimited
                BBTypesMembresReader.SetDelimiters("|")
                Dim currentRow As String()
                While Not BBTypesMembresReader.EndOfData
                    Try
                        currentRow = BBTypesMembresReader.ReadFields()
                        TypeMembre.TypeMembre = currentRow(0)
                        TypeMembre.TypeMembreDesc = currentRow(1)
                        cle = TypeMembre.TypeMembre
                        FicheTypeMembre.Add(cle, TypeMembre)
                    Catch ex As FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                    End Try
                End While
                BBTypesMembresReader.Close()
            End Using
            Using BBProvincesReader As New FileIO.TextFieldParser("..\..\..\BB_Provinces.txt")
                BBProvincesReader.TextFieldType = FileIO.FieldType.Delimited
                BBProvincesReader.SetDelimiters("|")
                Dim currentRow As String()
                While Not BBProvincesReader.EndOfData
                    Try
                        currentRow = BBProvincesReader.ReadFields()
                        Province.ProvCode = currentRow(0)
                        Province.ProvDesc = currentRow(1)
                        cle = Province.ProvCode
                        FicheProvince.Add(cle, Province)
                    Catch ex As FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                    End Try
                End While
                BBProvincesReader.Close()
            End Using
            Using BBLanguesReader As New FileIO.TextFieldParser("..\..\..\BB_Langues.txt")
                BBLanguesReader.TextFieldType = FileIO.FieldType.Delimited
                BBLanguesReader.SetDelimiters("|")
                Dim currentRow As String()
                While Not BBLanguesReader.EndOfData
                    Try
                        currentRow = BBLanguesReader.ReadFields()
                        Langue.LangCode = currentRow(0)
                        Langue.LangDesc = currentRow(1)
                        cle = Langue.LangCode
                        FicheLangue.Add(cle, Langue)
                    Catch ex As FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                    End Try
                End While
                BBLanguesReader.Close()
            End Using

            'Vous devrez également dans cette étape charger les collections ITEMS des 3 COMBOXBOX du formulaires 
            'à partir des données des collections qui viennet d'être chargées.

            Me.cboProvince.Items.Clear()
            Me.cboLangue.Items.Clear()
            Me.cboTypeMembre.Items.Clear()

            For Each element In FicheProvince.Keys
                Me.cboProvince.Items.Add(element)
            Next element
            For Each element In FicheLangue.Keys
                Me.cboLangue.Items.Add(element)
            Next element
            For Each element In FicheTypeMembre.Keys
                Me.cboTypeMembre.Items.Add(element)
            Next element

            Me.cboProvince.Sorted = True
            Me.cboLangue.Sorted = True
            Me.cboTypeMembre.Sorted = True

            'Et finalement vous devez afficher l'information du premier membre.
            'N'oubliez pas de rafraîchir le nom de la province, la description de la langue et du type de membre

            index = FicheMembre.IndexOfKey(FicheMembre.Keys.First)

            AfficherMembre(FicheMembre.Keys.First)
            LoadCboDescriptions()

            isLoaded = True

        Else
            MsgBox("La collection est déjà affiché.")
        End If


        '' Afficher débug
        'Dim sb As New System.Text.StringBuilder
        'For Each item As KeyValuePair(Of String, Membres) In FicheMembre
        '    sb.AppendLine(item.Key & " " & item.Value.MembreEmail)
        'Next
        'MessageBox.Show(sb.ToString())

        'Dim sb2 As New System.Text.StringBuilder
        'For Each item As KeyValuePair(Of String, TypesMembres) In FicheTypeMembre
        '    sb2.AppendLine(item.Key & " " & item.Value.TypeMembreDesc)
        'Next
        'MessageBox.Show(sb2.ToString())

        'Dim sb3 As New System.Text.StringBuilder
        'For Each item As KeyValuePair(Of String, Provinces) In FicheProvince
        '    sb3.AppendLine(item.Key & " " & item.Value.ProvDesc)
        'Next
        'MessageBox.Show(sb3.ToString())

        'Dim sb4 As New System.Text.StringBuilder
        'For Each item As KeyValuePair(Of String, Langues) In FicheLangue
        '    sb4.AppendLine(item.Key & " " & item.Value.LangDesc)
        'Next
        'MessageBox.Show(sb4.ToString())
        '
    End Sub
    Private Sub AfficherMembre(key As String)
        Dim Membre As Membres = FicheMembre.Item(key)

        Me.mtbNumeroMembre.Text = Membre.NoMembre
        Me.mtbNom.Text = Membre.MembreNom
        Me.mtbPrenom.Text = Membre.MembrePrenom
        Me.tbAdresse.Text = Membre.MembreAdresse
        Me.tbVille.Text = Membre.MembreVille
        Me.cboProvince.SelectedIndex = cboProvince.FindStringExact(Membre.ProvCode)
        Me.mtbNumeroMembre.Text = Membre.NoMembre
        Me.mtbNumeroMembre.Text = Membre.NoMembre
        Me.mtbNumeroMembre.Text = Membre.NoMembre
        Me.mtbCodePostal.Text = Membre.MembreCodePostal
        Me.mtbTelephone.Text = Membre.MembreNoTel
        Me.tbCourriel.Text = Membre.MembreEmail
        Me.cboLangue.SelectedIndex = cboLangue.FindStringExact(Membre.LangCode)
        Me.cboTypeMembre.SelectedIndex = cboTypeMembre.FindStringExact(Membre.TypeMembre)
    End Sub

    Private Sub LoadCboDescriptions()
        Dim Province As Provinces
        Dim Langues As Langues
        Dim TypeMembre As TypesMembres

        Province = FicheProvince.Item(cboProvince.SelectedItem.ToString)
        Langues = FicheLangue.Item(cboLangue.SelectedItem.ToString)
        TypeMembre = FicheTypeMembre.Item(cboTypeMembre.SelectedItem.ToString)

        Me.tbProvinceDesc.Text = Province.ProvDesc
        Me.tbLangueDesc.Text = Langues.LangDesc
        Me.tbTypeMembreDesc.Text = TypeMembre.TypeMembreDesc
    End Sub

    Private Sub Sauvegarder_Click(sender As Object, e As EventArgs) Handles Sauvegarder.Click
        'Ajouter ici le code nécessaire pour sauvegarder (Écrire par dessus le fichier existant)
        '               les donnéers de la collection des Membres, si celle-ci 
        '               a subi des changements (Mise-À-Jour).
        'Vous ne pouvez pas fermer l'application sans faire cette sauvegarde.

        If modified Then
            Dim FILE_NAME As String = "..\..\..\BB_Membres.txt"
            Dim writer As IO.StreamWriter
            Try
                writer = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, False)
                writer.Write(_WriteFile)
                writer.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Sauvegarde de la collection des membres effectué")
            saved = True
        Else
            MsgBox("Veuillez effectuer une modification en premier.")
        End If

    End Sub

    Private Function _WriteFile() As String
        Dim t As Type = GetType(Membres)
        Dim output As New Text.StringBuilder()

        For Each Membre In FicheMembre
            For Each p As Reflection.FieldInfo In t.GetFields()
                If Membre.Value.NoMembre IsNot "" And Membre.Value.NoMembre IsNot Nothing Then
                    output.Append(p.GetValue(Membre.Value) & "|")
                End If
            Next
            output.AppendLine()
        Next

        Return output.ToString()
    End Function

    Private Sub FermerApplication_Click(sender As Object, e As EventArgs) Handles FermerApplication.Click
        'Vous ne pouvez pas fermer l'application si la collection des membres a été modifiée
        '        et que la collection n'a pas été sauvegardée.

        If saved Then
            Me.Close()
        Else
            MsgBox("Veuillez effectuer une sauvegarde en premier.")
        End If
    End Sub
End Class
