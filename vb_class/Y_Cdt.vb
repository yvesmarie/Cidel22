Imports cu3 = Cfc3.Cu

Public Class Y_Cdt
    Private _mDescr As String
    Private _mUid As String
    Private _mSummary As String
    Private _mDtLibd As String
    Private _mDtLibf As String
    Private _mDtd As String
    Private _mDtf As String  ' DTSTART;TZID=Romance Standard Time:20201203T100000Z
    '--
    Private _mC As Long
    '--
    Private _mS As String  '-> Summary
    Private _mT As String
    Private _mTrouve As String
    '--
    Private _mDateTimed As Date
    Private _mDateTimef As Date
    Private _mYMDd As String
    Private _mYMDf As String
    Private _mDated As Date
    Private _mDatef As Date
    Private _mTimed As Date
    Private _mTimef As Date
    Const KMn As Integer = 1440
    Const KHeure As Integer = 24
    '--

    Public Sub New()
        _mTrouve = "Garde,Clinique"
    End Sub
    Sub Paras(xparas As String, Optional s1 As String = ",")
        Dim yParas, para
        Dim xvars
        yParas = Split(xparas, s1)
        For Each para In yParas
            xvars = Split(para, "=", 2)
            Select Case xvars(0)
                Case "dtd" : MDtLibd = CStr(xvars(1)) : MYMDd = CStr(xvars(1))
                Case "dtf" : MDtLibf = CStr(xvars(1)) : MYMDf = CStr(xvars(1))
                Case "uid" : _mUid = ExtractVar(xvars(1))
                Case "descr" : _mDescr = Replace(ExtractVar(xvars(1)), "uid=", "")
                'Case "s" : _mSummary = ExtractVar(xvars(1))
                Case "s" : MS = (xvars(1))
                Case "c" : _mC = CLng(xvars(1))

            End Select
        Next
    End Sub
    Function ExtractVar(xvar) As String
        ' séparateur ":"
        Dim xvars
        Dim xsep As String
        xsep = ":"
        xvars = Split(xvar, xsep)
        ExtractVar = CStr(xvars(1))
    End Function


    Public Property MDtLibd As String
        Get
            Return _mDtLibd
        End Get
        Set(value As String)
            _mDtLibd = value
            _mDateTimed = cu3.Fdt_2_DateTime(value)
            _mTimed = Format(_mDateTimed, "hh:mm:ss")
            _mDated = Format(_mDateTimed, "dd-MM-yyyy")

        End Set
    End Property

    Public Property MYMDd As String
        Get
            Return _mYMDd
        End Get
        Set(value As String)
            _mYMDd = cu3.Fdt_2_YMDhms(value)
        End Set
    End Property

    Public Property MYMDf As String
        Get
            Return _mYMDf
        End Get
        Set(value As String)
            _mYMDf = cu3.Fdt_2_YMDhms(value)
        End Set
    End Property

    Public Property MS As String
        Get
            Return _mS
        End Get
        Set(value As String)
            _mS = ExtractVar(value)
            _mT = cu3.Ftxt_trd(_mTrouve, "", _mS)
        End Set
    End Property

    Public Property MDtLibf As String
        Get
            Return _mDtLibf
        End Get
        Set(value As String)
            _mDtLibf = value
            _mDateTimef = cu3.Fdt_2_DateTime(value)
            _mTimef = Format(_mDateTimef, "hh:mm:ss")
            _mDatef = Format(_mDateTimef, "dd-MM-yyyy")
        End Set
    End Property

    Public ReadOnly Property MDated As Date
        Get
            Return _mDated
        End Get
    End Property

    Public ReadOnly Property MDatef As Date
        Get
            Return _mDatef
        End Get
    End Property

    Public ReadOnly Property MDateTimed As Date
        Get
            Return _mDateTimed
        End Get
    End Property
    Public ReadOnly Property MDateTimef As Date
        Get
            Return _mDateTimef
        End Get
    End Property


    Public ReadOnly Property Duree2mn As Double
        Get
            Return (Duree / 60)
        End Get
    End Property

    Public ReadOnly Property Duree2heure As Double
        Get
            Return (Duree / (60 * 60))
        End Get
    End Property


    Public ReadOnly Property Duree As Double
        Get
            Return cu3.Fd1_Duree(_mDateTimed, _mDateTimef)
        End Get
    End Property



    Public ReadOnly Property MT As String
        Get
            Return _mT
        End Get
    End Property
    Public ReadOnly Property V2d1 As String
        Get
            Return cu3.Fd1_Dt2Sql(_mDateTimed)
        End Get
    End Property
    Public ReadOnly Property V2d2 As String
        Get
            Return cu3.Fd1_Dt2Sql(_mDateTimef)
        End Get
    End Property
    Public ReadOnly Property Dx1 As Double
        Get
            Return cu3.Fd1_excel(_mDateTimed)
        End Get
    End Property
    Public ReadOnly Property Dx2 As Double
        Get
            Return cu3.Fd1_excel(_mDateTimef)
        End Get
    End Property

    Public ReadOnly Property MUid As String
        Get
            Return _mUid
        End Get
    End Property

    Public ReadOnly Property MDescr As String
        Get
            Return _mDescr
        End Get
    End Property

    Public ReadOnly Property MSummary As String
        Get
            Return _mSummary
        End Get
    End Property

    Public ReadOnly Property MC As String
        Get
            Paras(_mDescr, ".")
            Return _mC
        End Get
    End Property


    Function Csv_01(Optional s1 As String = ";")
        Return "" _
            & "uid=" & MUid _
            & s1 & "descr=" & MDescr _
            & s1 & "d=" & V2d1 _
            & s1 & "f=" & V2d2 _
            & s1 & "s=" & MSummary _
            & s1 & "dx1=" & Dx1 _
            & s1 & "dx2=" & Dx2 _
            & s1 & "c=" & MC _
            & s1 & "t=" & _mT _
            & ""
    End Function
End Class
