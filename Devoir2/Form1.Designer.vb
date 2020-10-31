<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ChargerCollections = New System.Windows.Forms.Button()
        Me.Sauvegarder = New System.Windows.Forms.Button()
        Me.FermerApplication = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbTypeMembreDesc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbLangueDesc = New System.Windows.Forms.TextBox()
        Me.cboTypeMembre = New System.Windows.Forms.ComboBox()
        Me.cboLangue = New System.Windows.Forms.ComboBox()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.LastMember = New System.Windows.Forms.Button()
        Me.NextMember = New System.Windows.Forms.Button()
        Me.PreviousMember = New System.Windows.Forms.Button()
        Me.FirstMember = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbProvinceDesc = New System.Windows.Forms.TextBox()
        Me.MiseAJourMembre = New System.Windows.Forms.Button()
        Me.tbCourriel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtbTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCodePostal = New System.Windows.Forms.MaskedTextBox()
        Me.mtbPrenom = New System.Windows.Forms.MaskedTextBox()
        Me.mtbNom = New System.Windows.Forms.MaskedTextBox()
        Me.mtbNumeroMembre = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbVille = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAdresse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChargerCollections
        '
        Me.ChargerCollections.Location = New System.Drawing.Point(6, 379)
        Me.ChargerCollections.Name = "ChargerCollections"
        Me.ChargerCollections.Size = New System.Drawing.Size(188, 38)
        Me.ChargerCollections.TabIndex = 551
        Me.ChargerCollections.Text = "Charger les collections de données à partir des fichiers"
        Me.ChargerCollections.UseVisualStyleBackColor = True
        '
        'Sauvegarder
        '
        Me.Sauvegarder.Location = New System.Drawing.Point(211, 379)
        Me.Sauvegarder.Name = "Sauvegarder"
        Me.Sauvegarder.Size = New System.Drawing.Size(188, 38)
        Me.Sauvegarder.TabIndex = 552
        Me.Sauvegarder.Text = "Sauvegarder les collections de données dans des fichiers"
        Me.Sauvegarder.UseVisualStyleBackColor = True
        '
        'FermerApplication
        '
        Me.FermerApplication.Location = New System.Drawing.Point(419, 379)
        Me.FermerApplication.Name = "FermerApplication"
        Me.FermerApplication.Size = New System.Drawing.Size(188, 38)
        Me.FermerApplication.TabIndex = 553
        Me.FermerApplication.Text = "Fermer l'application"
        Me.FermerApplication.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.tbTypeMembreDesc)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.tbLangueDesc)
        Me.TabPage1.Controls.Add(Me.cboTypeMembre)
        Me.TabPage1.Controls.Add(Me.cboLangue)
        Me.TabPage1.Controls.Add(Me.cboProvince)
        Me.TabPage1.Controls.Add(Me.LastMember)
        Me.TabPage1.Controls.Add(Me.NextMember)
        Me.TabPage1.Controls.Add(Me.PreviousMember)
        Me.TabPage1.Controls.Add(Me.FirstMember)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.tbProvinceDesc)
        Me.TabPage1.Controls.Add(Me.MiseAJourMembre)
        Me.TabPage1.Controls.Add(Me.tbCourriel)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.mtbTelephone)
        Me.TabPage1.Controls.Add(Me.mtbCodePostal)
        Me.TabPage1.Controls.Add(Me.mtbPrenom)
        Me.TabPage1.Controls.Add(Me.mtbNom)
        Me.TabPage1.Controls.Add(Me.mtbNumeroMembre)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.tbVille)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.tbAdresse)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(708, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Membre"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(355, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(209, 13)
        Me.Label13.TabIndex = 589
        Me.Label13.Text = "<-----Description du type de membre"
        '
        'tbTypeMembreDesc
        '
        Me.tbTypeMembreDesc.Enabled = False
        Me.tbTypeMembreDesc.Location = New System.Drawing.Point(223, 255)
        Me.tbTypeMembreDesc.MaxLength = 50
        Me.tbTypeMembreDesc.Name = "tbTypeMembreDesc"
        Me.tbTypeMembreDesc.Size = New System.Drawing.Size(131, 20)
        Me.tbTypeMembreDesc.TabIndex = 588
        Me.tbTypeMembreDesc.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(355, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 13)
        Me.Label10.TabIndex = 587
        Me.Label10.Text = "<-----Description de la langue"
        '
        'tbLangueDesc
        '
        Me.tbLangueDesc.Enabled = False
        Me.tbLangueDesc.Location = New System.Drawing.Point(223, 229)
        Me.tbLangueDesc.MaxLength = 50
        Me.tbLangueDesc.Name = "tbLangueDesc"
        Me.tbLangueDesc.Size = New System.Drawing.Size(131, 20)
        Me.tbLangueDesc.TabIndex = 586
        Me.tbLangueDesc.TabStop = False
        '
        'cboTypeMembre
        '
        Me.cboTypeMembre.FormattingEnabled = True
        Me.cboTypeMembre.Location = New System.Drawing.Point(131, 255)
        Me.cboTypeMembre.Name = "cboTypeMembre"
        Me.cboTypeMembre.Size = New System.Drawing.Size(86, 21)
        Me.cboTypeMembre.TabIndex = 585
        Me.cboTypeMembre.Text = "MADU"
        '
        'cboLangue
        '
        Me.cboLangue.FormattingEnabled = True
        Me.cboLangue.Location = New System.Drawing.Point(131, 230)
        Me.cboLangue.Name = "cboLangue"
        Me.cboLangue.Size = New System.Drawing.Size(86, 21)
        Me.cboLangue.TabIndex = 584
        Me.cboLangue.Text = "FR"
        '
        'cboProvince
        '
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(131, 133)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(84, 21)
        Me.cboProvince.TabIndex = 583
        Me.cboProvince.Text = "QC"
        '
        'LastMember
        '
        Me.LastMember.Location = New System.Drawing.Point(304, 297)
        Me.LastMember.Name = "LastMember"
        Me.LastMember.Size = New System.Drawing.Size(75, 23)
        Me.LastMember.TabIndex = 581
        Me.LastMember.Text = ">>"
        Me.LastMember.UseVisualStyleBackColor = True
        '
        'NextMember
        '
        Me.NextMember.Location = New System.Drawing.Point(223, 297)
        Me.NextMember.Name = "NextMember"
        Me.NextMember.Size = New System.Drawing.Size(75, 23)
        Me.NextMember.TabIndex = 580
        Me.NextMember.Text = ">"
        Me.NextMember.UseVisualStyleBackColor = True
        '
        'PreviousMember
        '
        Me.PreviousMember.Location = New System.Drawing.Point(142, 297)
        Me.PreviousMember.Name = "PreviousMember"
        Me.PreviousMember.Size = New System.Drawing.Size(75, 23)
        Me.PreviousMember.TabIndex = 579
        Me.PreviousMember.Text = "<"
        Me.PreviousMember.UseVisualStyleBackColor = True
        '
        'FirstMember
        '
        Me.FirstMember.Location = New System.Drawing.Point(63, 297)
        Me.FirstMember.Name = "FirstMember"
        Me.FirstMember.Size = New System.Drawing.Size(75, 23)
        Me.FirstMember.TabIndex = 578
        Me.FirstMember.Text = "<<"
        Me.FirstMember.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(353, 137)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(144, 13)
        Me.Label31.TabIndex = 577
        Me.Label31.Text = "<-----Nom de la province"
        '
        'tbProvinceDesc
        '
        Me.tbProvinceDesc.Enabled = False
        Me.tbProvinceDesc.Location = New System.Drawing.Point(221, 134)
        Me.tbProvinceDesc.MaxLength = 50
        Me.tbProvinceDesc.Name = "tbProvinceDesc"
        Me.tbProvinceDesc.Size = New System.Drawing.Size(131, 20)
        Me.tbProvinceDesc.TabIndex = 576
        Me.tbProvinceDesc.TabStop = False
        '
        'MiseAJourMembre
        '
        Me.MiseAJourMembre.Location = New System.Drawing.Point(466, 297)
        Me.MiseAJourMembre.Name = "MiseAJourMembre"
        Me.MiseAJourMembre.Size = New System.Drawing.Size(174, 23)
        Me.MiseAJourMembre.TabIndex = 575
        Me.MiseAJourMembre.Text = "Mise à jour les données - membre"
        Me.MiseAJourMembre.UseVisualStyleBackColor = True
        '
        'tbCourriel
        '
        Me.tbCourriel.Location = New System.Drawing.Point(131, 206)
        Me.tbCourriel.MaxLength = 80
        Me.tbCourriel.Name = "tbCourriel"
        Me.tbCourriel.Size = New System.Drawing.Size(312, 20)
        Me.tbCourriel.TabIndex = 574
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 573
        Me.Label9.Text = "Courriel"
        '
        'mtbTelephone
        '
        Me.mtbTelephone.Location = New System.Drawing.Point(131, 182)
        Me.mtbTelephone.Mask = "\(000\)000\-0000"
        Me.mtbTelephone.Name = "mtbTelephone"
        Me.mtbTelephone.Size = New System.Drawing.Size(100, 20)
        Me.mtbTelephone.TabIndex = 572
        '
        'mtbCodePostal
        '
        Me.mtbCodePostal.Location = New System.Drawing.Point(131, 158)
        Me.mtbCodePostal.Mask = ">L0L\-0L0"
        Me.mtbCodePostal.Name = "mtbCodePostal"
        Me.mtbCodePostal.Size = New System.Drawing.Size(54, 20)
        Me.mtbCodePostal.TabIndex = 571
        '
        'mtbPrenom
        '
        Me.mtbPrenom.Location = New System.Drawing.Point(131, 61)
        Me.mtbPrenom.Mask = ">L<CCCCCCCCCCCCCCCCCCCCCCCCCCCCC"
        Me.mtbPrenom.Name = "mtbPrenom"
        Me.mtbPrenom.Size = New System.Drawing.Size(199, 20)
        Me.mtbPrenom.TabIndex = 570
        '
        'mtbNom
        '
        Me.mtbNom.Location = New System.Drawing.Point(131, 37)
        Me.mtbNom.Mask = ">L<CCCCCCCCCCCCCCCCCCCCCCCCCCCCC"
        Me.mtbNom.Name = "mtbNom"
        Me.mtbNom.Size = New System.Drawing.Size(199, 20)
        Me.mtbNom.TabIndex = 569
        '
        'mtbNumeroMembre
        '
        Me.mtbNumeroMembre.Enabled = False
        Me.mtbNumeroMembre.Location = New System.Drawing.Point(131, 13)
        Me.mtbNumeroMembre.Mask = "\M000000"
        Me.mtbNumeroMembre.Name = "mtbNumeroMembre"
        Me.mtbNumeroMembre.Size = New System.Drawing.Size(84, 20)
        Me.mtbNumeroMembre.TabIndex = 568
        Me.mtbNumeroMembre.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 567
        Me.Label11.Text = "Type de membre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 566
        Me.Label12.Text = "Langue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 565
        Me.Label5.Text = "No de téléphone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 564
        Me.Label6.Text = "Code postal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 563
        Me.Label7.Text = "Province"
        '
        'tbVille
        '
        Me.tbVille.Location = New System.Drawing.Point(131, 109)
        Me.tbVille.MaxLength = 50
        Me.tbVille.Name = "tbVille"
        Me.tbVille.Size = New System.Drawing.Size(199, 20)
        Me.tbVille.TabIndex = 562
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 561
        Me.Label8.Text = "Ville"
        '
        'tbAdresse
        '
        Me.tbAdresse.Location = New System.Drawing.Point(131, 85)
        Me.tbAdresse.MaxLength = 80
        Me.tbAdresse.Name = "tbAdresse"
        Me.tbAdresse.Size = New System.Drawing.Size(289, 20)
        Me.tbAdresse.TabIndex = 560
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 559
        Me.Label3.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 558
        Me.Label4.Text = "Prenom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 557
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 556
        Me.Label1.Text = "# membre"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(716, 361)
        Me.TabControl1.TabIndex = 556
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 426)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.FermerApplication)
        Me.Controls.Add(Me.Sauvegarder)
        Me.Controls.Add(Me.ChargerCollections)
        Me.MinimumSize = New System.Drawing.Size(711, 465)
        Me.Name = "Form1"
        Me.Text = "Devoir2"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChargerCollections As System.Windows.Forms.Button
    Friend WithEvents Sauvegarder As System.Windows.Forms.Button
    Friend WithEvents FermerApplication As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbTypeMembreDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbLangueDesc As System.Windows.Forms.TextBox
    Friend WithEvents cboTypeMembre As System.Windows.Forms.ComboBox
    Friend WithEvents cboLangue As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents LastMember As System.Windows.Forms.Button
    Friend WithEvents NextMember As System.Windows.Forms.Button
    Friend WithEvents PreviousMember As System.Windows.Forms.Button
    Friend WithEvents FirstMember As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tbProvinceDesc As System.Windows.Forms.TextBox
    Friend WithEvents MiseAJourMembre As System.Windows.Forms.Button
    Friend WithEvents tbCourriel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mtbTelephone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCodePostal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbPrenom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbNom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbNumeroMembre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbVille As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

End Class
