<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Secondaire
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
        Me.Active_Final_CommunDataSet = New TestConnexion.Active_Final_CommunDataSet()
        Me.ActiveFinalCommunDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADRESSEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADRESSETableAdapter = New TestConnexion.Active_Final_CommunDataSetTableAdapters.ADRESSETableAdapter()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTTableAdapter = New TestConnexion.Active_Final_CommunDataSetTableAdapters.CLIENTTableAdapter()
        Me.CLIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_Client = New System.Windows.Forms.Button()
        Me.BTN_Collabo = New System.Windows.Forms.Button()
        Me.BTN_Projet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADRESSEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Active_Final_CommunDataSet
        '
        Me.Active_Final_CommunDataSet.DataSetName = "Active_Final_CommunDataSet"
        Me.Active_Final_CommunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActiveFinalCommunDataSetBindingSource
        '
        Me.ActiveFinalCommunDataSetBindingSource.DataSource = Me.Active_Final_CommunDataSet
        Me.ActiveFinalCommunDataSetBindingSource.Position = 0
        '
        'ADRESSEBindingSource
        '
        Me.ADRESSEBindingSource.DataMember = "ADRESSE"
        Me.ADRESSEBindingSource.DataSource = Me.ActiveFinalCommunDataSetBindingSource
        '
        'ADRESSETableAdapter
        '
        Me.ADRESSETableAdapter.ClearBeforeFill = True
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.ActiveFinalCommunDataSetBindingSource
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'CLIENTBindingSource1
        '
        Me.CLIENTBindingSource1.DataMember = "CLIENT"
        Me.CLIENTBindingSource1.DataSource = Me.ActiveFinalCommunDataSetBindingSource
        '
        'BTN_Client
        '
        Me.BTN_Client.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Client.Location = New System.Drawing.Point(52, 285)
        Me.BTN_Client.Name = "BTN_Client"
        Me.BTN_Client.Size = New System.Drawing.Size(173, 82)
        Me.BTN_Client.TabIndex = 0
        Me.BTN_Client.Text = "ACCES CLIENT"
        Me.BTN_Client.UseVisualStyleBackColor = True
        '
        'BTN_Collabo
        '
        Me.BTN_Collabo.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Collabo.Location = New System.Drawing.Point(331, 285)
        Me.BTN_Collabo.Name = "BTN_Collabo"
        Me.BTN_Collabo.Size = New System.Drawing.Size(161, 82)
        Me.BTN_Collabo.TabIndex = 1
        Me.BTN_Collabo.Text = "ACCES COLLABO"
        Me.BTN_Collabo.UseVisualStyleBackColor = True
        '
        'BTN_Projet
        '
        Me.BTN_Projet.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Projet.Location = New System.Drawing.Point(595, 285)
        Me.BTN_Projet.Name = "BTN_Projet"
        Me.BTN_Projet.Size = New System.Drawing.Size(152, 82)
        Me.BTN_Projet.TabIndex = 2
        Me.BTN_Projet.Text = "ACCES PROJET"
        Me.BTN_Projet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(294, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 82)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Administration"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRM_Secondaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 603)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Projet)
        Me.Controls.Add(Me.BTN_Collabo)
        Me.Controls.Add(Me.BTN_Client)
        Me.Name = "FRM_Secondaire"
        Me.Text = "FenetreSecondaire"
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADRESSEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActiveFinalCommunDataSetBindingSource As BindingSource
    Friend WithEvents Active_Final_CommunDataSet As Active_Final_CommunDataSet
    Friend WithEvents ADRESSEBindingSource As BindingSource
    Friend WithEvents ADRESSETableAdapter As Active_Final_CommunDataSetTableAdapters.ADRESSETableAdapter
    Friend WithEvents CLIENTBindingSource As BindingSource
    Friend WithEvents CLIENTTableAdapter As Active_Final_CommunDataSetTableAdapters.CLIENTTableAdapter
    Friend WithEvents CLIENTBindingSource1 As BindingSource
    Friend WithEvents BTN_Client As Button
    Friend WithEvents BTN_Collabo As Button
    Friend WithEvents BTN_Projet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
