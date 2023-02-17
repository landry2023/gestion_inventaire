<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxbNom = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TbxMotDePasse = New System.Windows.Forms.TextBox
        Me.BtnValider = New System.Windows.Forms.Button
        Me.BtnAnnuler = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TbxPrenom = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(25, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 48)
        Me.Label2.Text = "NomUtilisateur / Username :"
        '
        'TxbNom
        '
        Me.TxbNom.Location = New System.Drawing.Point(159, 33)
        Me.TxbNom.Name = "TxbNom"
        Me.TxbNom.Size = New System.Drawing.Size(100, 23)
        Me.TxbNom.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 36)
        Me.Label4.Text = "Mot De Passe / Password :"
        '
        'TbxMotDePasse
        '
        Me.TbxMotDePasse.Location = New System.Drawing.Point(159, 130)
        Me.TbxMotDePasse.Name = "TbxMotDePasse"
        Me.TbxMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxMotDePasse.Size = New System.Drawing.Size(100, 23)
        Me.TbxMotDePasse.TabIndex = 10
        '
        'BtnValider
        '
        Me.BtnValider.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnValider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnValider.Location = New System.Drawing.Point(24, 174)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(72, 20)
        Me.BtnValider.TabIndex = 11
        Me.BtnValider.Text = "VALIDER"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAnnuler.Location = New System.Drawing.Point(187, 174)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(72, 20)
        Me.BtnAnnuler.TabIndex = 12
        Me.BtnAnnuler.Text = "ANNULER"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 40)
        Me.Label1.Text = "Prénom / FirstName :"
        '
        'TbxPrenom
        '
        Me.TbxPrenom.Location = New System.Drawing.Point(159, 81)
        Me.TbxPrenom.Name = "TbxPrenom"
        Me.TbxPrenom.Size = New System.Drawing.Size(100, 23)
        Me.TbxPrenom.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(285, 219)
        Me.Controls.Add(Me.TbxPrenom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.TbxMotDePasse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxbNom)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "CONNEXION/CONNECTION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxbNom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbxMotDePasse As System.Windows.Forms.TextBox
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxPrenom As System.Windows.Forms.TextBox

End Class
