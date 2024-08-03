<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_reference = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        Me.reference = New System.Windows.Forms.TextBox()
        Me.mr = New System.Windows.Forms.TextBox()
        Me.dad = New System.Windows.Forms.TextBox()
        Me.hopital = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.nameNom = New System.Windows.Forms.TextBox()
        Me.commune = New System.Windows.Forms.TextBox()
        Me.Titre = New System.Windows.Forms.Label()
        Me.dateNais = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lbl_reference
        '
        Me.lbl_reference.AutoSize = True
        Me.lbl_reference.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_reference.Location = New System.Drawing.Point(35, 74)
        Me.lbl_reference.Name = "lbl_reference"
        Me.lbl_reference.Size = New System.Drawing.Size(117, 32)
        Me.lbl_reference.TabIndex = 0
        Me.lbl_reference.Text = "reference"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(416, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pere"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(35, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "commune"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(361, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "date de naissance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(416, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hopital"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(35, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "prenom"
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nom.Location = New System.Drawing.Point(35, 144)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(67, 32)
        Me.nom.TabIndex = 6
        Me.nom.Text = "Nom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(416, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 32)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Mere"
        '
        'save
        '
        Me.save.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.save.Location = New System.Drawing.Point(50, 378)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(147, 33)
        Me.save.TabIndex = 8
        Me.save.Text = "Enregistrer"
        Me.save.UseVisualStyleBackColor = False
        '
        'quitter
        '
        Me.quitter.BackColor = System.Drawing.Color.Silver
        Me.quitter.Location = New System.Drawing.Point(673, 378)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(115, 33)
        Me.quitter.TabIndex = 9
        Me.quitter.Text = "Quitter"
        Me.quitter.UseVisualStyleBackColor = False
        '
        'supprimer
        '
        Me.supprimer.BackColor = System.Drawing.Color.Red
        Me.supprimer.Location = New System.Drawing.Point(476, 378)
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(126, 33)
        Me.supprimer.TabIndex = 10
        Me.supprimer.Text = "Supprimer"
        Me.supprimer.UseVisualStyleBackColor = False
        '
        'modifier
        '
        Me.modifier.BackColor = System.Drawing.Color.Yellow
        Me.modifier.Location = New System.Drawing.Point(286, 378)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(133, 33)
        Me.modifier.TabIndex = 11
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = False
        '
        'reference
        '
        Me.reference.Location = New System.Drawing.Point(172, 85)
        Me.reference.Name = "reference"
        Me.reference.Size = New System.Drawing.Size(100, 23)
        Me.reference.TabIndex = 12
        '
        'mr
        '
        Me.mr.Location = New System.Drawing.Point(535, 326)
        Me.mr.Name = "mr"
        Me.mr.Size = New System.Drawing.Size(235, 23)
        Me.mr.TabIndex = 13
        '
        'dad
        '
        Me.dad.Location = New System.Drawing.Point(515, 237)
        Me.dad.Name = "dad"
        Me.dad.Size = New System.Drawing.Size(226, 23)
        Me.dad.TabIndex = 14
        '
        'hopital
        '
        Me.hopital.Location = New System.Drawing.Point(565, 85)
        Me.hopital.Name = "hopital"
        Me.hopital.Size = New System.Drawing.Size(176, 23)
        Me.hopital.TabIndex = 15
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(162, 237)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(129, 23)
        Me.prenom.TabIndex = 16
        '
        'nameNom
        '
        Me.nameNom.Location = New System.Drawing.Point(172, 153)
        Me.nameNom.Name = "nameNom"
        Me.nameNom.Size = New System.Drawing.Size(100, 23)
        Me.nameNom.TabIndex = 17
        '
        'commune
        '
        Me.commune.Location = New System.Drawing.Point(172, 326)
        Me.commune.Name = "commune"
        Me.commune.Size = New System.Drawing.Size(177, 23)
        Me.commune.TabIndex = 18
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.Lime
        Me.Titre.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Titre.Location = New System.Drawing.Point(213, 9)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(317, 40)
        Me.Titre.TabIndex = 19
        Me.Titre.Text = "Gestion des Naissances"
        '
        'dateNais
        '
        Me.dateNais.Location = New System.Drawing.Point(575, 171)
        Me.dateNais.Name = "dateNais"
        Me.dateNais.Size = New System.Drawing.Size(200, 23)
        Me.dateNais.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dateNais)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.commune)
        Me.Controls.Add(Me.nameNom)
        Me.Controls.Add(Me.prenom)
        Me.Controls.Add(Me.hopital)
        Me.Controls.Add(Me.dad)
        Me.Controls.Add(Me.mr)
        Me.Controls.Add(Me.reference)
        Me.Controls.Add(Me.modifier)
        Me.Controls.Add(Me.supprimer)
        Me.Controls.Add(Me.quitter)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_reference)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_reference As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nom As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents save As Button
    Friend WithEvents quitter As Button
    Friend WithEvents supprimer As Button
    Friend WithEvents modifier As Button
    Friend WithEvents reference As TextBox
    Friend WithEvents mr As TextBox
    Friend WithEvents dad As TextBox
    Friend WithEvents hopital As TextBox
    Friend WithEvents prenom As TextBox
    Friend WithEvents nameNom As TextBox
    Friend WithEvents commune As TextBox
    Friend WithEvents Titre As Label
    Friend WithEvents dateNais As DateTimePicker
End Class
