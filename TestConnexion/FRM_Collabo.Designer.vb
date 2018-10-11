<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Collabo
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.COLLABORATEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Active_Final_CommunDataSet = New TestConnexion.Active_Final_CommunDataSet()
        Me.COLLABORATEURTableAdapter = New TestConnexion.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.COLLABORATEURBindingSource
        Me.ComboBox1.DisplayMember = "NOM_COLLABORATEUR"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(352, 173)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "PRENOM_COLLABORATEUR"
        '
        'COLLABORATEURBindingSource
        '
        Me.COLLABORATEURBindingSource.DataMember = "COLLABORATEUR"
        Me.COLLABORATEURBindingSource.DataSource = Me.Active_Final_CommunDataSet
        '
        'Active_Final_CommunDataSet
        '
        Me.Active_Final_CommunDataSet.DataSetName = "Active_Final_CommunDataSet"
        Me.Active_Final_CommunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COLLABORATEURTableAdapter
        '
        Me.COLLABORATEURTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(168, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(600, 44)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Merci de choisir un collabo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRM_Collabo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1222, 780)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FRM_Collabo"
        Me.Text = "Collabo"
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Active_Final_CommunDataSet As Active_Final_CommunDataSet
    Friend WithEvents COLLABORATEURBindingSource As BindingSource
    Friend WithEvents COLLABORATEURTableAdapter As Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
