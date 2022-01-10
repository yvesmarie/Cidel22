
Imports cu3 = Cfc3.Cu
Imports Objps3 = Cfc3.Object_Paras
Imports scg = System.Collections.Generic


Public Class C_Load
    'Private mRep_Appli As String
    'Private mRep_Datas As String
    'Private mRep_Export As String
    'Private mRep_Import As String
    'Private mImport_ics As String
    'Private _mIDE As Object_IDE
    Public MOIDE As Cfc3.Object_IDE
    Public MOIDES As Cfc3.Object_IDEs
    Public mPElodie As String
    Private _mKEY As String
    Private _mTxtIcs As String
    Private _mTxtCsv As String
    Private oCodes As Objps3
    Private _mYd1 As String
    Private _mYd2 As String
    Private _mdecimales As Boolean
    'Private xfacts As scg.SortedDictionary(Of String, String)
    Public Cdt As Y_Cdt
    '--
    'Const CEXCEPT = "RRULE,DTSTAMP,CREATED,LAST,LOCATION,SEQUENCE,STATUS,TRANSP,END:VEVENT"
    ' je recherche 
    Const CRECHERCHE = "UID,DTSTART,DTEND,SUMMARY,DESCRIPTION"
    'Const CRECHERCHE = "UID,DTSTART,DTEND,DESCRIPTION,SUMMARY:Garde"
    '--
    Public CFacts As Cfc3.Object_FACTs

    Public oCsvFacts As Objps3  ' = New Object_Paras("cle", "")


    Sub New()
        Dim cidel As String = "prenom=cidel,code=X" _
            & ",rep=../datas" _
            & ",https=https://calendar.google.com/calendar/ical/cabinetidel.stglen%40gmail.com/private-7abcb318264aa836ec637e91b68621b5/basic.ics" _
            & ",email=cabinetidel.stglen@gmail.com" _
            & ",csv_recap=d1Excel;code;jours" _
            & ",id=10"
        Dim elo As String = "email=elodievdbboulot@gmail.com" _
                    & ",https=https://calendar.google.com/calendar/ical/elodievdbboulot%40gmail.com/private-fb21909592be9f254b533c1e738aa7ef/basic.ics" _
                    & ",xcodes=Elodie.elodie.Élodie.élodie.élo.elo.elo soir" _
                    & ",prenom=Elodie" _
                    & ",id=13" _
                    & ""
        Dim mag As String = "email=magalie.iphone@iphone.com" _
                    & ",https=https://calendar.google.com/calendar/ical/cidel.magalie%40gmail.com/private-8a06d07af8aeba14f05eca3e4cff1515/basic.ics" _
                    & ",xcodes=mag.Mag.Magalie.magalie" _
                    & ",prenom=Magalie" _
                    & ",id=12" _
                    & ""

        Dim laur As String = "" _
                    & "xcodes=Lauriane.lauriane.laur" _
                    & ",prenom=Lauriane" _
                    & ""

        Dim chris As String = "" _
                    & "xcodes=Christelle.christelle.chris" _
                    & ",prenom=Christelle" _
                    & ""

        MOIDES = New Cfc3.Object_IDEs("cidel", cidel)
        MOIDES.OAdd("elo", elo)
        'MOIDES.OAdd("élo", elo)
        'MOIDES.OAdd("élodie", elo)
        'MOIDES.OAdd("Élodie", elo)
        'MOIDES.OAdd("elodie", elo)
        'MOIDES.OAdd("Elodie", elo)
        MOIDES.OAdd("mag", mag)
        MOIDES.OAdd("laur", laur)
        MOIDES.OAdd("chris", chris)
        IDE_Codes()
        Cdt_Init()
    End Sub
    '--
    Sub Cdt_Init()
        Cdt = New Y_Cdt
    End Sub

    'https://docs.microsoft.com/fr-fr/dotnet/visual-basic/developing-apps/programming/computer-resources/how-to-download-a-file
    Sub DownLoadFile_Http(xhttp As String, xfile As String)
        cu3.Fdelete(MOIDE.Import_ics)
        My.Computer.Network.DownloadFile(xhttp, xfile)
    End Sub

    Sub Fic_Import_ics(Optional ximport_ics_Ok As Boolean = False)
        'cu3.DownLoadFile(MOIDE.MHttps, MOIDE.Import_ics)
        'My.Computer.Network.DownloadFile(MIDE.Https, xfile);
        If (ximport_ics_Ok Or (Not cu3.Fexists(MOIDE.Import_ics))) Then
            DownLoadFile_Http(MOIDE.MHttps, MOIDE.Import_ics)
        End If
    End Sub

    Public Sub IDE_Codes()

        oCodes = New Objps3("codes", "")
        oCodes.OAdd("mag", MOIDES.CODES("mag"))
        oCodes.OAdd("elo", MOIDES.CODES("elo"))
        oCodes.OAdd("élo", MOIDES.CODES("elo"))
        oCodes.OAdd("laur", MOIDES.CODES("laur"))
        oCodes.OAdd("chris", MOIDES.CODES("chris"))
        ' oCodes.OAdd("laur", MOIDES.CODES("laur"))
        '? oCodes.V("mag")
    End Sub
    Public Property MKEY As String
        Get
            Return _mKEY
        End Get
        Set(value As String)
            _mKEY = value
        End Set
    End Property

    '--
    ' format string "2021/03/18"
    '--
    Public Property MYd1 As String
        Get
            Return _mYd1
        End Get
        Set(value As String)
            _mYd1 = value
        End Set
    End Property

    Public Function MYd1_excel() As Long
        Return cu3.Fd1_excel(_mYd1)
    End Function

    Public Function MYd2_excel() As Long
        Return cu3.Fd1_excel(_mYd2)
    End Function
    Public Function Mxd2() As String
        Return cu3.Fd1_Dt2xd1(_mYd2)
    End Function

    Public Function Duree2mn() As Double
        Duree2mn = cu3.Fd1_DureeMinute(_mYd1, _mYd2)
    End Function
    Public Function Duree2heure() As Double
        Duree2heure = cu3.Fd1_DureeHeure(_mYd1, _mYd2)
    End Function
    Public Function Duree2jour() As Double
        Duree2jour = cu3.Fd1_DureeJour(_mYd1, _mYd2)
    End Function
    ' en secondes
    Function Duree() As Double
        Return cu3.Fd1_Duree(_mYd1, _mYd2)
    End Function


    '--
    ' format string "2021/03/18"
    '--
    Public Property MYd2 As String
        Get
            Return _mYd2
        End Get
        Set(value As String)
            _mYd2 = value
        End Set
    End Property

    Public Property MDecimales As Boolean
        Get
            Return _mdecimales
        End Get
        Set(value As Boolean)
            _mdecimales = value
        End Set
    End Property


    Sub Set_OIDE(xkey As String)
        _mKEY = xkey
        MOIDE = MOIDES.Get_oIDE(xkey)
    End Sub
    '--
    ' FobjIde
    '--
    Function FIcsRead() As String
        Return cu3.FreadTxt(MOIDE.Import_ics)
    End Function

    '--
    ' DTSTART;VALUE=DATE:20141018
    ' DTSTART:20130916T110000Z
    ' -> 20130916
    'Function FIcs_DT2date(x As String) As String
    'Dim xs, xx, s1
    's1 = ":"
    'xs = Strings.Split(x, sep)
    'xx = xs(1)
    'Return Strings.Left(xx, 8)
    'Return cu3.FIcs_DT2date(x)
    'End Function

    ' MyPos = Instr(4, SearchString, SearchChar, 1)
    Public Function F_txt_IndexOf(searChars As String, SearchString As String, Optional exact As Boolean = False, Optional s1 As String = ",")
        Dim s, SearchChar
        Dim MyPos As Int32
        Dim xexact$

        '--
        'str = LCase(SearchString$)
        If (SearchString.Length < 1) Then
            GoTo Error_Sub
        End If
        xexact = ""
        If (exact) Then
            xexact = "*"
        End If
        '--
        s = Strings.Split(searChars, s1)
        '--
        MyPos = -1
        For Each SearchChar In s
            MyPos = InStr(1, xexact & SearchString & xexact, xexact & SearchChar & xexact, vbTextCompare)
            If (MyPos > 0) Then
                Exit For
            End If
        Next
Suite_Sub:
        GoTo Fin_Sub
Error_Sub:
Fin_Sub:
        Return MyPos
    End Function


    '--
    ' lire l'agenda d'Elodie sur la clinique
    ' celui qui est nouveau donc 
    ' je vais chercher DESCIPTION
    '
    ' BEGIN:VEVENT
    ' DTSTART;VALUE=DATE20210314
    ' DTEND;VALUE=DATE:20210315
    ' DTSTAMP:20210311T002004Z
    ' UID:cidela44269a1
    ' CREATED:19000101T120000Z
    ' DESCRIPTION:uid=cidela44269a1.d=2021-03-14.c=6740479.q=j.t=JUD s4
    ' LAST-MODIFIED:20210306T172257Z
    ' LOCATION:Clinique
    ' SEQUENCE:0
    ' STATUS:CONFIRMED
    ' SUMMARY:Clinique JUD s4 
    ' TRANSP:OPAQUE
    ' End:VEVENT
    '--

    Function Fic_read_ics_et_csv(xkey As String) As String
        Set_OIDE(xkey)
        Return Fic_read_ics_et_csv()
    End Function

    '--
    ' MOIDE, _mYd1, _mYd2
    ' si xOk je re-charge
    '--
    Function Fic_read_ics_et_csv() As String
        Dim xd1 As String = _mYd1
        Dim xd2 As String = _mYd2
        _mTxtIcs = FIcsRead()
        Select Case MKEY
            Case "elo" : _mTxtCsv = Fic_read_Cidel_10(xd1, xd2, "DESCRIPTION:uid=cidel")
            Case "cidel" : _mTxtCsv = Fic_read_Cidel_10(xd1, xd2, "SUMMARY:Garde")
            Case Else
                _mTxtCsv = ""
        End Select
        cu3.FwriteTxt(MOIDE.Import_csv, _mTxtCsv)
        Return _mTxtCsv
    End Function

    Function Facture_Recap(xloyer As String)
        'Dim nb As Single = CFacts.Get_oFACT("mag").MJours
        CFacts.MDecimales = _mdecimales
        Return (CFacts.Recap(xloyer))
    End Function
    '--
    ' xkey ="cidel"
    ' pour trouver l'agenda du cabinet
    ' créer un fichier csv par jour pour vérifier
    '--
    Function Facture_Cidel(xkey As String) As Int32
        Dim xsep As String = ""
        '--
        Dim xtxts
        Dim xtxt As String
        Dim s1, s3 As String
        Dim dx1, dx2 As Long
        Dim xgarde, xg As String
        Dim xgardes
        Dim j As Int32
        Dim cpt, dcpt As Single
        '--
        s1 = ";"
        s3 = vbCrLf
        cpt = 0
        '--
        CFacts = New Cfc3.Object_FACTs("total", "")
        '--
        ' toujours xkey doît être = "cidel"
        If (Not (_mKEY = xkey)) Then
            Set_OIDE(xkey)
        End If
        'Dim xd2 As String = Mxd2()
        Dim Yd1_excel As Long = MYd1_excel()
        Dim Yd2_excel As Long = MYd2_excel()
        Dim Nb_Jours As Integer = (Yd2_excel - Yd1_excel)
        'xcodes = MOIDES.CODES(xkey)
        '--
        Dim xcsv As String = Trim(cu3.FreadTxt(MOIDE.Import_csv))
        If (String.IsNullOrEmpty(xcsv)) Then
            GoTo Error_Sub
        End If
        '--
        xtxts = Split(xcsv, s3)
        '--
        '2021/01/30;20210201;Garde lauriane
        '2021/01/28;20210129;Garde christelle / Mag 
        '--

        '--
        ' je démarre avec les valeurs vide
        ' pour créer l'object et les keys
        ' dx1 la date excel
        ' dx2 aussi
        Dim fkey As String
        Dim oEnrg As New Objps3("d1;d2;garde;dx1;dx2", "")
        Dim oRecapCsv As New Objps3(MOIDE.MRrecap, "")
        Dim xfac_csv_jour As String = "" ' = MOIDE.MRrecap
        Dim xtmp As String
        Dim iGarde As Int32
        Dim xj As String
        Dim inb As Int32
        Dim vd1 As Date, xvd1 As String, xddd As String
        '--
        oCsvFacts = New Objps3("")
        '--
        'xsep = s3
        '--
        'oCsvFacts.OAdd(xj + "." + iGarde.ToString, xtmp)
        'Dim i As Integer
        'Dim xyd1 As Long, xyd2 As Long
        'xyd1 = cu3.Fd1_excel(_mYd1)
        'xyd2 = cu3.Fd1_excel(_mYd2)
        iGarde = 1
        ' "30-03-2021;mardi;Garde Lauriane;1"
        For inb = 0 To (Nb_Jours - 1)
            xvd1 = Format(DateAdd("d", inb, _mYd1), "dd-MM-yyy")
            xddd = Format(DateAdd("d", inb, _mYd1), "dddd")
            xtmp = $"{xvd1}{s1}{xddd}{s1} {s1} "
            oCsvFacts.OAdd(CStr(Yd1_excel + inb) + "." + iGarde.ToString, xtmp)

        Next
        For Each xtxt In xtxts
            If (String.IsNullOrEmpty(xtxt)) Then
                GoTo Suite_Next_xtxt
            End If
            oEnrg.Set_Valeurs($"{xtxt}")
            If (Len(xtxt) < 10) Then
                GoTo Suite_Next_xtxt
            End If
            '-- ?oEnrg.OParas("garde")
            'dx1 = Convert.ToInt32(oEnrg.V("dx1"))
            dx1 = Convert.ToInt32(oEnrg.OParas("dx1"))
            dx2 = Convert.ToInt32(oEnrg.OParas("dx2"))
            '--
            ' la ou les personnes
            ' faire un compte par personne
            '--garde remplacé par s pour summary
            'xg = Trim(oEnrg.OParas("s"))
            xg = Trim(oEnrg.OParas("t"))
            'MsgBox(xg)
            If (F_txt_IndexOf("lo", xg) > 0) Then
                'Stop
            End If
            xgardes = Split(xg, "/")
                dcpt = (1 / (UBound(xgardes) + 1))
            iGarde = 0
            For Each xgarde In xgardes
                iGarde += 1
                xgarde = Trim(Replace(xgarde, "Garde ", ""))
                If (F_txt_IndexOf(xgarde, oCodes.OParas("mag")) > 0) Then
                    fkey = "Magalie"
                ElseIf (F_txt_IndexOf(xgarde, oCodes.OParas("elo")) > 0) Then
                    fkey = "Elodie"
                ElseIf (F_txt_IndexOf(xgarde, oCodes.OParas("laur")) > 0) Then
                    fkey = "Lauriane"
                ElseIf (F_txt_IndexOf(xgarde, oCodes.OParas("chris")) > 0) Then
                    fkey = "Christelle"
                Else
                    fkey = xgarde
                End If
                If (fkey = "1") Then
                    Stop
                End If
                '--
                CFacts.OAdd(fkey)
                ' on traite jour par jour
                ' la date de départ c'est la date xd1 du planning
                ' donc inb += 1 se trouve après Next_jdx
                inb = 0
                vd1 = cu3.Str2date(oEnrg.OParas("d"))
                For j = dx1 To (dx2 - 1)
                    If (j >= Yd2_excel) Then
                        GoTo Next_jdx
                    End If
                    If (j < Yd1_excel) Then
                        GoTo Next_jdx
                    End If
                    '--
                    ' trans
                    xvd1 = Format(DateAdd("d", inb, vd1), "dd-MM-yyy")
                    xddd = Format(DateAdd("d", inb, vd1), "dddd")
                    '--
                    xj = j.ToString
                    xtmp = xvd1 + s1 + xddd + s1 + fkey + s1 + dcpt.ToString
                    xfac_csv_jour += (xsep + xtmp)
                    xsep = s3

                    '--
                    cpt += dcpt
                    CFacts.Jours_Add(dcpt)
                    If (xtmp.Length < 10) Then
                        Stop
                    End If
                    oCsvFacts.OAdd(xj + "." + iGarde.ToString, xtmp)
                    '--
Next_jdx:
                    inb += 1
                Next j
            Next
Suite_Next_xtxt:
        Next
        '--
Suite_Sub:
        CFacts.MNb = cpt
        cu3.FwriteTxt(MOIDE.Fac_recap_csv, xfac_csv_jour)
        GoTo Fin_Sub
Error_Sub:
        'MsgBox(CFacts.Get_oFACT("mag").MJours)
        cpt = 0
Fin_Sub:
        Return cpt
    End Function

    '--
    ' dans excel csv ->
    ' uid=cidela44362a1.d=2021-06-15.c=6750054.q=.t=X.f=2021-06-16.s=StGlen X
    ' N:\a_vs_2021\Apps\Cidel22\datas\import\cabinetidel.stglen.csv
    'avec visual
    ' d1=2021-04-09;d2=2021-04-10;desc=cidela44295a1.d=2021-04-09.c=39168.q=.t=Garde Lauriane;t=Garde Lauriane / Mag;garde=Garde Lauriane / Mag;dx1=44295;dx2=44296;uid=cidela44295a1
    '
    '--

    Function FReplace_mots(x As String)
        '--
        Dim i%
        Dim xmots_replace, xmots
        xmots = Split("laurinae,elodie,Élodie,elo,élo,Élo,matin,( M),(M),soir,(S),( S),bosse à PLESSALA,mag", ",")
        xmots_replace = Split("Lauriane,Elodie,Elodie,Elodie,Elodie,Elodie,/,/,/,,,,,Mag", ",")
        For i = 0 To UBound(xmots)
            x = Replace(x, xmots(i), xmots_replace(i))
        Next
        FReplace_mots = x
    End Function

    Function Fic_read_Cidel_10(d1 As Date, d2 As Date, Optional critere As String = "SUMMARY:Garde") As String
        Dim xOk As Boolean
        Dim Txt As String
        Dim i, lenCrit As Int32
        Dim rs
        Dim r, cle_critere As String
        Dim xsep, s3, sepa, sepPoint As String
        '--
        Dim xics As String
        Dim tmps
        Dim tmp2 As String, xtmp2 As String
        Dim critere_dtend As String
        '--
        Dim xKeyElo As Boolean = (_mKEY = "elo")
        Dim xd1 = Format(d1, "yyyyMMdd")
        Dim xd2 = Format(d2, "yyyyMMdd")
        Dim v2garde As String = ""
        '--
        lenCrit = Len(critere)
        tmps = Split(critere, ":")
        cle_critere = tmps(0)
        '--
        Txt = FReplace_mots(FIcsRead())

        ' tous les VEVENT
        rs = Split(Txt, "BEGIN:VEVENT")
        '--
        s3 = vbCrLf
        sepa = ";"
        xsep = ""
        xics = ""
        sepPoint = "."
        For i = 1 To UBound(rs)
            r = Strings.Trim(rs(i))
            '--
            ' je ne prends que les blocs avec critere =  "SUMMARY:Garde" pour cidel
            '--
            If (F_txt_IndexOf(critere, r) < 1) Then
                GoTo Suite_Next_r
            End If
            '--
            tmps = Split(Replace(r, vbCrLf & " ", ""), s3)
            '--
            ' ligne par ligne
            '--
            xOk = False
            For Each tmp2 In tmps
                xtmp2 = Trim(tmp2)
                '--
                If (xtmp2.Length < 5) Then
                    GoTo Suite_Next_r2
                End If
                '
                ' je recherche "UID,DTSTART,DTEND,DESCRIPTION,SUMMARY"
                ' il faut prendre l'uid en cas de modif
                If (Not F_txt_IndexOf(CRECHERCHE, xtmp2) > 0) Then
                    GoTo Suite_Next_r2
                End If
                '--
                critere_dtend = "UID"
                If (Left(xtmp2, Len(critere_dtend)) = critere_dtend) Then
                    Cdt.Paras("uid=" & xtmp2)
                    GoTo Suite_Next_r2
                End If
                '--
                critere_dtend = "DTSTART"
                If (Left(xtmp2, critere_dtend.Length) = critere_dtend) Then
                    Cdt.Paras("dtd=" + xtmp2)
                    xOk = (Cdt.MDated < d2)
                    If (Not xOk) Then
                        Exit For
                    End If
                    GoTo Suite_Next_r2
                End If
                '--
                critere_dtend = "DTEND"
                If (Left(xtmp2, critere_dtend.Length) = critere_dtend) Then
                    Cdt.Paras("dtf=" + xtmp2)
                    xOk = (Cdt.MDatef > d1)
                    If (Not xOk) Then
                        Exit For
                    End If
                    GoTo Suite_Next_r2
                End If
                '--
                If (xKeyElo) Then
                    critere_dtend = "SUMMARY"
                    If (Left(xtmp2, critere_dtend.Length) = critere_dtend) Then
                        Cdt.Paras("s=" + Trim(Mid(xtmp2, Len(critere_dtend) + 2)))
                    End If
                    GoTo Suite_Next_r2
                End If
                '--
                critere_dtend = "SUMMARY"
                If (Left(xtmp2, Len(critere_dtend)) = critere_dtend) Then
                    '9xtmp2 = FReplace_mots(xtmp2)
                    Cdt.Paras("s=" & xtmp2)
                    GoTo Suite_Next_r2
                End If
                '--
Suite_Next_r2:
            Next
            '--
            If (Not xOk) Then
                GoTo Suite_Next_r
            End If
            Select Case _mKEY
                Case "xelo"
                    'xics = xics & xsep & xdescription & ".f=" & cdt.v2d2 & ".s=" & v2summary
                    xics &= $"{xsep}{Cdt.MDescr}{sepPoint}f={Cdt.V2d2}{sepPoint}s={Cdt.MSummary}{sepPoint}{Cdt.Dx1}{sepPoint}{Cdt.Dx2}"
                Case "xcidel"
                    xics &= $"{xsep}d1={Cdt.V2d1}{sepa}d2={Cdt.V2d2}{sepa}desc={Cdt.MDescr}{sepa}{Cdt.MSummary}{v2garde}{Cdt.Dx1}{sepa}{Cdt.Dx2}{sepa}{Cdt.MUid}"
                Case Else
                    xics = xics & xsep & Cdt.Csv_01()
                    '--

            End Select
            xsep = s3
            '--
Suite_Next_r:
        Next i
        '--
Suite_Sub:
        GoTo Fin_Sub
Error_Sub:
        'MsgBox "Une erreur s'est produite..."
        xics = ""
Fin_Sub:
        Return xics
    End Function


End Class
