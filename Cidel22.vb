
Imports cu3 = Cfc3.Cu
'Imports Objp3 = Cfc3.Object_Para


' cabinetidel.stglen.ics
Public Class Frm_Cidel22
    Public CLoad As C_Load
    Private _mKey As String = "cidel"

    Public Property MKey As String
        Get
            Return _mKey
        End Get
        Set(value As String)
            _mKey = value
        End Set
    End Property
    '--
    Private Sub Frm_Cidel22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CLoad = New C_Load()
        '_mKey = "cidel"
        Ouvrir_cidel_ics()
        'Txb_ess_date.Text = (cu3.Fd1_excel("2021-04-06 23:59:59"))
        'Facture_Cidel22()
        'Txb_ess_duree.Text = CLoad.Duree2jour()
    End Sub
    '--
    ' if xOk je recharge .ics
    Sub Ouvrir_cidel_ics()
        Ouvrir_cidel_ics(ximport_ics_Ok:=False)
    End Sub
    Sub Ouvrir_cidel_ics(ximport_ics_Ok As Boolean)
        CLoad.Set_OIDE(_mKey)
        ' va l'importer s'il n'existe pas (False)
        CLoad.MDecimales = Ckb_decimales.Checked
        CLoad.Fic_Import_ics(ximport_ics_Ok)
        '--
        ' peut toujours changer
        '--
        Set_Cload_yd1_yd2()
        Txb_recap.Text = CLoad.Fic_read_ics_et_csv()
        Facture_Cidel22()

    End Sub

    Private Sub Btn_Cidel_csv_fact_Click(sender As Object, e As EventArgs) Handles Btn_Cidel_csv_fact.Click
        Ouvrir_cidel_ics()
    End Sub

    Private Sub Cdb_Load_ics_Click(sender As Object, e As EventArgs) Handles Cdb_Load_ics.Click
        'Dim xd1 As String = "20210101"
        'Dim xd2 As String = "20310101"
        '--
        Ouvrir_cidel_ics(ximport_ics_Ok:=True)

        'Txb_recap.Text = CLoad.Fic_read_ics(xd1, xd2)
        'CLoad.Load_ics()
        'Txb_ics.Text = CLoad.Import_ics
        'CLoad.FobjIDE()
        'Txb_ics.Text = CLoad.FIcsRead()
        'Txb_ics.Text = CLoad.Fic_read_ics_Cidel("20210101")
        'Txb_ics.Text = CLoad.Fic_read_ics_Cidel("20210101")
        '--
        ' essais
        '--
        'Ess_Fd1_Excel2Txb()
        'Txb_ics.Text = cu3.Fd1_Dt2Txt("2021-03-18")
    End Sub
    Private Sub Ess_Fd1_Excel2Txb()
        Txb_recap.Text = cu3.Fd1_excel(New DateTime(2021, 3, 7)).ToString
        Txb_recap.Text &= vbCrLf & cu3.Fd1_excel(#2021/3/8#).ToString
        Txb_recap.Text &= vbCrLf & cu3.Fd1_excel("2021/3/9 12:00:00").ToString
        Txb_recap.Text &= vbCrLf & cu3.Fd1_excel("2021-3-10").ToString
        Txb_recap.Text &= vbCrLf & cu3.Fd1_excel("2021-3-10").ToString
        Txb_recap.Text &= vbCrLf & cu3.Fd1_Dt2Sql("19700101").ToString
        Txb_recap.Text &= vbCrLf & (cu3.Fd1_Dt2Sql("20210312").ToString)
        Txb_recap.Text &= vbCrLf & (cu3.FIcs_DT2Sql("dsqdsqd:2021-3-12").ToString)
        Txb_recap.Text &= vbCrLf & cu3.Fd1_excel(cu3.Fd1_Dt2Sql("2021-3-12")).ToString
    End Sub

    Sub Set_Cload_yd1_yd2()
        CLoad.MYd1 = Format(Dtp_cidel.Value, "yyyy-MM-01")
        CLoad.MYd2 = Format(Dtp_cidel.Value.AddMonths(Txb_cidel_nb_Mois.Text), "yyyy-MM-01")
    End Sub

    '--
    ' avec la clé cidel
    ' dans la classe CLoad
    '   j'actualise la valeur d1 et d2
    '       Set_Cload_yd1_yd2()
    '--
    Sub Facture_Cidel22(Optional xkey As String = "cidel")
        '--
        ' Dim xd1 As String = Dtp_cidel.Value.Year & "/" & Dtp_cidel.Value.Month & "/" & "01"
        ' Dim yd1 As String = Format(Dtp_cidel.Value, "yyyy/MM/01")
        ' Dim yd2 As String = Format(Dtp_cidel.Value.AddMonths(Txb_cidel_nb_Mois.Text), "yyyy/MM/01")
        ' Txb_cidel_csv.Text = CLoad.Fic_read_ics(xkey, yd1, yd2)
        '--
        'Set_Cload_yd1_yd2()
        'CLoad.MDecimales = Ckb_decimales.Checked
        '9Txb_cidel_csv.Text = CLoad.Fic_read_ics(xkey)
        '9Txb_elo_csv.Text = CLoad.Fic_read_ics("elo")
        '--
        Dim nb_jours As Single = CLoad.Facture_Cidel(xkey)
        Txb_recap.Text = ($"nb = {nb_jours}") + vbCrLf + Replace(CLoad.Facture_Recap(Txb_loyer.Text), ";", vbCrLf)
        '--
        'GoTo Suite_dgv
        '--
        'Suite_dgv:
        '--
        ' , xx = Mid(xd.Key, 1, 1)
        ' xd.key = 44286.1
        ' xd.Value = 31-03-2021;mercredi;Laurianne;1
        ' xjoursemaine = Mid(xd.Value, 12, InStr(13, xd.Value, ";") - 12)
        ' Return Mid(xd, 12, InStr(13, xd, ";") - 12)
        ' Return Mid(xd, InStr(13, xd, ";") + 1, InStr(InStr(13, xd, ";") + 1, xd, ";") - InStr(13, xd, ";") + 3)
        '--
        Dgv_Facts.DataSource = (
            From xd In CLoad.oCsvFacts.OParas
            Let xdate = Xd_i(xd.Value, 0) _
                , xinfirmiere = Xd_infirmiere(xd.Value, 2) _
                , xjoursemaine = Xd_i(xd.Value, 1)
            Where ((cu3.Fd1_fr2sql(xdate) >= CLoad.MYd1) And (cu3.Fd1_fr2sql(xdate) < CLoad.MYd2))
            Select x = New With {xjoursemaine, xdate, xinfirmiere}
            ).ToList
        GoTo Fin_Sub
Fin_Sub:
    End Sub
    Function Xd_i(xd As String, i As Integer) As String
        Dim xds = Split(xd, ";")
        Return xds(i)
    End Function
    Function Xd_infirmiere(xd As String, i As Integer) As String
        Dim xds = Split(xd, ";")
        Dim r As String = xds(i)
        If (xds(3) = "0,5") Then
            r &= " " & xds(3)
        End If
        Return r
    End Function

    Private Sub Ckb_decimales_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_decimales.CheckedChanged

        If (Not (CLoad Is Nothing)) Then
            Ouvrir_cidel_ics()
        End If
    End Sub
End Class
