Imports cu3 = Cfc3.Cu

Public Class Y_Cdt
    Private _mDtLibd As String
    Private _mDtLibf As String
    Private _mDtd As String
    Private _mDtf As String  ' DTSTART;TZID=Romance Standard Time:20201203T100000Z
    Private _mDateTimed As Date
    Private _mDateTimef As Date
    Private _mDated As Date
    Private _mDatef As Date
    Private _mTimed As Date
    Private _mTimef As Date
    Const KMn As Integer = 1440
    Const KHeure As Integer = 24
    '--

    Public Sub New()
    End Sub
    Sub Paras(xparas As String, Optional s1 As String = ",")
        Dim yParas, para
        Dim xvars
        yParas = Split(xparas, s1)
        For Each para In yParas
            xvars = Split(para, "=", 2)
            Select Case xvars(0)
                Case "dtd" : MDtLibd = CStr(xvars(1))
                Case "dtf" : MDtLibf = CStr(xvars(1))

            End Select
        Next
    End Sub

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

    Public Property MDated As Date
        Get
            Return _mDated
        End Get
        Set(value As Date)
            _mDated = value
        End Set
    End Property

    Public Property MDatef As Date
        Get
            Return _mDatef
        End Get
        Set(value As Date)
            _mDatef = value
        End Set
    End Property

    Public Property MDateTimed As Date
        Get
            Return _mDateTimed
        End Get
        Set(value As Date)
            _mDateTimed = value
        End Set
    End Property
    Public Property MDateTimef As Date
        Get
            Return _mDateTimef
        End Get
        Set(value As Date)
            _mDateTimef = value
        End Set
    End Property


    Public Function Duree2mn() As Double
        Duree2mn = (Duree() / 60)
    End Function
    Public Function Duree2heure() As Double
        Duree2heure = (Duree() / (60 * 60))
    End Function


    Function Duree() As Double
        Return cu3.Fd1_Duree(_mDateTimed, _mDateTimef)
    End Function


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

End Class
