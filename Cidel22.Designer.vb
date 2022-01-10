<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cidel22
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cidel22))
        Me.Cdb_Load_ics = New System.Windows.Forms.Button()
        Me.Txb_recap = New System.Windows.Forms.TextBox()
        Me.Tbc_cidel = New System.Windows.Forms.TabControl()
        Me.Tbp_cidel = New System.Windows.Forms.TabPage()
        Me.Txb_elo_csv = New System.Windows.Forms.TextBox()
        Me.Txb_loyer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txb_cidel_nb_Mois = New System.Windows.Forms.TextBox()
        Me.Ckb_decimales = New System.Windows.Forms.CheckBox()
        Me.Dtp_cidel = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Cidel_csv_fact = New System.Windows.Forms.Button()
        Me.Txb_cidel_csv = New System.Windows.Forms.TextBox()
        Me.Dgv_Facts = New System.Windows.Forms.DataGridView()
        Me.Txb_ess_date = New System.Windows.Forms.TextBox()
        Me.Txb_ess_duree = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tbc_cidel.SuspendLayout()
        Me.Tbp_cidel.SuspendLayout()
        CType(Me.Dgv_Facts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cdb_Load_ics
        '
        Me.Cdb_Load_ics.BackColor = System.Drawing.Color.PaleGreen
        Me.Cdb_Load_ics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cdb_Load_ics.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cdb_Load_ics.Location = New System.Drawing.Point(12, 2)
        Me.Cdb_Load_ics.Name = "Cdb_Load_ics"
        Me.Cdb_Load_ics.Size = New System.Drawing.Size(228, 33)
        Me.Cdb_Load_ics.TabIndex = 0
        Me.Cdb_Load_ics.Text = "Load cabinetidel.stglen ics"
        Me.Cdb_Load_ics.UseVisualStyleBackColor = False
        '
        'Txb_recap
        '
        Me.Txb_recap.Location = New System.Drawing.Point(12, 41)
        Me.Txb_recap.Multiline = True
        Me.Txb_recap.Name = "Txb_recap"
        Me.Txb_recap.ReadOnly = True
        Me.Txb_recap.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txb_recap.Size = New System.Drawing.Size(228, 100)
        Me.Txb_recap.TabIndex = 1
        '
        'Tbc_cidel
        '
        Me.Tbc_cidel.Controls.Add(Me.Tbp_cidel)
        Me.Tbc_cidel.Location = New System.Drawing.Point(12, 147)
        Me.Tbc_cidel.Name = "Tbc_cidel"
        Me.Tbc_cidel.SelectedIndex = 0
        Me.Tbc_cidel.Size = New System.Drawing.Size(240, 520)
        Me.Tbc_cidel.TabIndex = 4
        '
        'Tbp_cidel
        '
        Me.Tbp_cidel.Controls.Add(Me.Txb_elo_csv)
        Me.Tbp_cidel.Controls.Add(Me.Txb_loyer)
        Me.Tbp_cidel.Controls.Add(Me.Label1)
        Me.Tbp_cidel.Controls.Add(Me.Txb_cidel_nb_Mois)
        Me.Tbp_cidel.Controls.Add(Me.Ckb_decimales)
        Me.Tbp_cidel.Controls.Add(Me.Dtp_cidel)
        Me.Tbp_cidel.Controls.Add(Me.Btn_Cidel_csv_fact)
        Me.Tbp_cidel.Controls.Add(Me.Txb_cidel_csv)
        Me.Tbp_cidel.Location = New System.Drawing.Point(4, 22)
        Me.Tbp_cidel.Name = "Tbp_cidel"
        Me.Tbp_cidel.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Tbp_cidel.Size = New System.Drawing.Size(232, 494)
        Me.Tbp_cidel.TabIndex = 0
        Me.Tbp_cidel.Text = "Cidel"
        Me.Tbp_cidel.UseVisualStyleBackColor = True
        '
        'Txb_elo_csv
        '
        Me.Txb_elo_csv.Location = New System.Drawing.Point(17, 188)
        Me.Txb_elo_csv.Multiline = True
        Me.Txb_elo_csv.Name = "Txb_elo_csv"
        Me.Txb_elo_csv.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txb_elo_csv.Size = New System.Drawing.Size(161, 88)
        Me.Txb_elo_csv.TabIndex = 6
        Me.Txb_elo_csv.Visible = False
        '
        'Txb_loyer
        '
        Me.Txb_loyer.Location = New System.Drawing.Point(168, 10)
        Me.Txb_loyer.Name = "Txb_loyer"
        Me.Txb_loyer.Size = New System.Drawing.Size(52, 20)
        Me.Txb_loyer.TabIndex = 5
        Me.Txb_loyer.Text = "200"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nb Mois :"
        '
        'Txb_cidel_nb_Mois
        '
        Me.Txb_cidel_nb_Mois.Location = New System.Drawing.Point(168, 32)
        Me.Txb_cidel_nb_Mois.Name = "Txb_cidel_nb_Mois"
        Me.Txb_cidel_nb_Mois.Size = New System.Drawing.Size(20, 20)
        Me.Txb_cidel_nb_Mois.TabIndex = 3
        Me.Txb_cidel_nb_Mois.Text = "1"
        Me.Txb_cidel_nb_Mois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ckb_decimales
        '
        Me.Ckb_decimales.AutoSize = True
        Me.Ckb_decimales.Checked = True
        Me.Ckb_decimales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ckb_decimales.Location = New System.Drawing.Point(87, 12)
        Me.Ckb_decimales.Name = "Ckb_decimales"
        Me.Ckb_decimales.Size = New System.Drawing.Size(75, 17)
        Me.Ckb_decimales.TabIndex = 6
        Me.Ckb_decimales.Text = "Décimales"
        Me.Ckb_decimales.UseVisualStyleBackColor = True
        '
        'Dtp_cidel
        '
        Me.Dtp_cidel.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_cidel.Location = New System.Drawing.Point(6, 35)
        Me.Dtp_cidel.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.Dtp_cidel.Name = "Dtp_cidel"
        Me.Dtp_cidel.Size = New System.Drawing.Size(94, 20)
        Me.Dtp_cidel.TabIndex = 2
        '
        'Btn_Cidel_csv_fact
        '
        Me.Btn_Cidel_csv_fact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cidel_csv_fact.Location = New System.Drawing.Point(6, 6)
        Me.Btn_Cidel_csv_fact.Name = "Btn_Cidel_csv_fact"
        Me.Btn_Cidel_csv_fact.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cidel_csv_fact.TabIndex = 1
        Me.Btn_Cidel_csv_fact.Text = "csv + récap"
        Me.Btn_Cidel_csv_fact.UseVisualStyleBackColor = True
        '
        'Txb_cidel_csv
        '
        Me.Txb_cidel_csv.Location = New System.Drawing.Point(6, 94)
        Me.Txb_cidel_csv.Multiline = True
        Me.Txb_cidel_csv.Name = "Txb_cidel_csv"
        Me.Txb_cidel_csv.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txb_cidel_csv.Size = New System.Drawing.Size(176, 88)
        Me.Txb_cidel_csv.TabIndex = 0
        Me.Txb_cidel_csv.Visible = False
        '
        'Dgv_Facts
        '
        Me.Dgv_Facts.AllowUserToAddRows = False
        Me.Dgv_Facts.AllowUserToDeleteRows = False
        Me.Dgv_Facts.AllowUserToOrderColumns = True
        Me.Dgv_Facts.AllowUserToResizeRows = False
        Me.Dgv_Facts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.Dgv_Facts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Facts.Location = New System.Drawing.Point(254, 12)
        Me.Dgv_Facts.MultiSelect = False
        Me.Dgv_Facts.Name = "Dgv_Facts"
        Me.Dgv_Facts.ReadOnly = True
        Me.Dgv_Facts.RowHeadersVisible = False
        Me.Dgv_Facts.RowHeadersWidth = 102
        Me.Dgv_Facts.Size = New System.Drawing.Size(236, 826)
        Me.Dgv_Facts.TabIndex = 5
        '
        'Txb_ess_date
        '
        Me.Txb_ess_date.Location = New System.Drawing.Point(324, 95)
        Me.Txb_ess_date.Name = "Txb_ess_date"
        Me.Txb_ess_date.Size = New System.Drawing.Size(94, 20)
        Me.Txb_ess_date.TabIndex = 8
        Me.Txb_ess_date.Visible = False
        '
        'Txb_ess_duree
        '
        Me.Txb_ess_duree.Location = New System.Drawing.Point(324, 121)
        Me.Txb_ess_duree.Name = "Txb_ess_duree"
        Me.Txb_ess_duree.Size = New System.Drawing.Size(94, 20)
        Me.Txb_ess_duree.TabIndex = 9
        Me.Txb_ess_duree.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fd1_excel"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Duree2jour"
        Me.Label3.Visible = False
        '
        'Frm_Cidel22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 845)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txb_ess_duree)
        Me.Controls.Add(Me.Txb_ess_date)
        Me.Controls.Add(Me.Dgv_Facts)
        Me.Controls.Add(Me.Txb_recap)
        Me.Controls.Add(Me.Tbc_cidel)
        Me.Controls.Add(Me.Cdb_Load_ics)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Cidel22"
        Me.Text = "Cidel22"
        Me.Tbc_cidel.ResumeLayout(False)
        Me.Tbp_cidel.ResumeLayout(False)
        Me.Tbp_cidel.PerformLayout()
        CType(Me.Dgv_Facts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cdb_Load_ics As Button
    Friend WithEvents Txb_recap As TextBox
    Friend WithEvents Tbc_cidel As TabControl
    Friend WithEvents Tbp_cidel As TabPage
    Friend WithEvents Btn_Cidel_csv_fact As Button
    Friend WithEvents Txb_cidel_csv As TextBox
    Friend WithEvents Dtp_cidel As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Txb_cidel_nb_Mois As TextBox
    Friend WithEvents Txb_loyer As TextBox
    Friend WithEvents Dgv_Facts As DataGridView
    Friend WithEvents Ckb_decimales As CheckBox
    Friend WithEvents Txb_ess_date As TextBox
    Friend WithEvents Txb_ess_duree As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txb_elo_csv As TextBox
End Class
