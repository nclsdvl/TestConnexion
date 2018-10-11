<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Principale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BTN_Valider = New System.Windows.Forms.Button()
        Me.Login = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_LOG = New System.Windows.Forms.TextBox()
        Me.txt_MDP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTN_Valider
        '
        Me.BTN_Valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Valider.Font = New System.Drawing.Font("French Script MT", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Valider.Location = New System.Drawing.Point(306, 393)
        Me.BTN_Valider.Name = "BTN_Valider"
        Me.BTN_Valider.Size = New System.Drawing.Size(329, 120)
        Me.BTN_Valider.TabIndex = 0
        Me.BTN_Valider.Text = "Valider"
        Me.BTN_Valider.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(319, 98)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(102, 33)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Login :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mot de passe :"
        '
        'txt_LOG
        '
        Me.txt_LOG.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LOG.Location = New System.Drawing.Point(451, 95)
        Me.txt_LOG.Name = "txt_LOG"
        Me.txt_LOG.Size = New System.Drawing.Size(233, 40)
        Me.txt_LOG.TabIndex = 3
        '
        'txt_MDP
        '
        Me.txt_MDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MDP.Location = New System.Drawing.Point(451, 180)
        Me.txt_MDP.Name = "txt_MDP"
        Me.txt_MDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MDP.Size = New System.Drawing.Size(233, 40)
        Me.txt_MDP.TabIndex = 4
        '
        'FRM_Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(942, 601)
        Me.Controls.Add(Me.txt_MDP)
        Me.Controls.Add(Me.txt_LOG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.BTN_Valider)
        Me.Name = "FRM_Principale"
        Me.Text = "Fenetre d'Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Valider As Button
    Friend WithEvents Login As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_LOG As TextBox
    Friend WithEvents txt_MDP As TextBox
End Class
