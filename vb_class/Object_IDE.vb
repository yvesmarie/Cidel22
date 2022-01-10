Class Object_IDE
    Public id As Integer
    Private mCode As String
    Private mPrenom As String
    Private mEmail As String
    Private mEbase As String
    'Private mESuff As String
    Private mHttps As String
    'Private mPath As String
    Private mRep As String
    Private Const DS As String = ChrW(47)
    '--
    ' vue du côté appli
    ' le fichier qui vient de gmail (import)
    ' je remplace source par import
    'Public import_ics As String
    'Public import_csv As String
    '--
    Sub New(Optional params As String = "")
        Init_Params(params)
    End Sub
    Function Init_Params(Optional params As String = "")
        Dim xOk As Boolean
        Dim xtps As String()
        Dim xtp As String
        Dim xvars As String()
        Dim xvar As String
        Dim xval As String
        Dim paras As String
        '
        paras = "prenom=Elodie,code=E" _
            & ",rep=N://Production/60_Cidel" _
            & ",https=https://calendar.google.com/calendar/ical/elodievdbboulot%40gmail.com/private-fb21909592be9f254b533c1e738aa7ef/basic.ics" _
            & ",email=elodievdbboulot@gmail.com"
        paras = "prenom=cidel,code=X" _
            & ",rep=N://Production/60_Cidel" _
            & ",https=https://calendar.google.com/calendar/ical/cabinetidel.stglen%40gmail.com/private-7abcb318264aa836ec637e91b68621b5/basic.ics" _
            & ",email=cabinetidel.stglen@gmail.com"

        xtps = Split(paras & "," & params, ",")
        For Each xtp In xtps
            If (xtp.Length < 3) Then
                GoTo Suite_Next_xtp
            End If
            xvars = Split(xtp, "=")
            xvar = xvars(0)
            xval = xvars(1)
            Select Case xvars(0)
                Case "rep"
                    Rep = xval
                Case "https"
                    Https = xval
                Case "email"
                    Email = xval
                Case "code"
                    Code = xval
                Case "prenom"
                    Prenom = xval
            End Select
Suite_Next_xtp:
        Next
Suite_Sub:
        xOk = True
        GoTo Fin_Sub
Error_sub:
        xOk = False
Fin_Sub:
        Return xOk
    End Function
    Property Rep() As String
        Set(value As String)
            mRep = value
        End Set
        Get
            Return mRep
        End Get
    End Property
    ReadOnly Property Path() As String
        Get
            Return mRep & DS & "datas"
        End Get
    End Property
    Property Https() As String
        Set(value As String)
            mHttps = value
        End Set
        Get
            Return mHttps
        End Get
    End Property
    Property Prenom() As String
        Set(value As String)
            mPrenom = value
        End Set
        Get
            Return mPrenom
        End Get
    End Property
    Property Code() As String
        Set(value As String)
            mCode = value
        End Set
        Get
            Return mCode
        End Get
    End Property
    Property Email() As String
        Set(value As String)
            mEmail = value
            Dim xtps As String()
            xtps = Split(mEmail, "@")
            mEbase = xtps(0)
            'mESuff = xtps(1)
        End Set
        Get
            Return mEmail
        End Get
    End Property
    ReadOnly Property Export_ics() As String
        Get
            Return Path & DS & "export" & DS & mEbase & ".ics"
        End Get
    End Property
    ReadOnly Property Export_csv() As String
        Get
            Return Path & DS & "export" & DS & mEbase & ".csv"
        End Get
    End Property
    ReadOnly Property Import_ics() As String
        Get
            Return Path & DS & "import" & DS & mEbase & ".ics"
        End Get
    End Property
    ReadOnly Property Import_csv() As String
        Get
            Return Path & DS & "import" & DS & mEbase & ".csv"
        End Get
    End Property

End Class
