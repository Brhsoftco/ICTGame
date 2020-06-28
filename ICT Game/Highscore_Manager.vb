Option Strict Off
Option Explicit On
Class Highscore_Manager

    Public Scores() As Integer
    Public Names() As String
    Public NumberEntries As Integer

    Public Function CheckScore(ByVal Score As Integer, Optional ByVal SortDirection As Boolean = True) As Boolean
        Dim i, j As Integer

        For i = 0 To NumberEntries
            If SortDirection Then 'Higher the better
                If Score > Scores(i) Then
                    CheckScore = True
                    Exit Function
                End If
            Else
                If Score < Scores(i) Then
                    CheckScore = True
                    Exit Function
                End If
            End If
        Next i
    End Function

    Public Function SaveScore(ByVal ApplicationName As String, ByVal PlayerName As String, ByVal Score As Integer, Optional ByVal SortDirection As Boolean = True) As Boolean
        Dim i, j As Integer
        Dim lT1, lT2 As Integer
        Dim sT1, sT2 As String
        Dim lFound As Integer

        lFound = -1

        For i = 0 To NumberEntries
            If SortDirection Then 'Higher the better
                If Score > Scores(i) Then
                    SaveScore = True
                    lFound = i
                    Exit For
                End If
            Else
                If Score < Scores(i) Then
                    SaveScore = True
                    lFound = i
                    Exit For
                End If
            End If
        Next i

        If lFound = -1 Then Exit Function

        'Shift around scores and names
        lT2 = Score
        sT2 = PlayerName
        For i = lFound To NumberEntries
            lT1 = Scores(i)
            sT1 = Names(i)
            Scores(i) = lT2
            Names(i) = sT2
            lT2 = lT1
            sT2 = sT1
        Next i

        'Save all scores
        For i = 0 To NumberEntries
            Call SaveSetting(ApplicationName, "Highscore", i & "S", CStr(Scores(i)))
            Call SaveSetting(ApplicationName, "Highscore", i & "N", Names(i))
        Next i
    End Function

    Public Function LoadScores(ByVal NumberScores As Integer, ByVal DefaultScore As Integer, ByVal DefaultName As String, ByVal ApplicationName As String, Optional ByVal SortDirection As Boolean = True) As Object
        Dim j, i, t As Integer
        Dim ts As String

        'Make room for scores
        NumberEntries = NumberScores
        ReDim Scores(NumberScores)
        ReDim Names(NumberScores)

        'Load them
        For i = 0 To NumberScores
            Scores(i) = CInt(GetSetting(ApplicationName, "Highscore", i & "S", CStr(DefaultScore)))
            Names(i) = GetSetting(ApplicationName, "Highscore", i & "N", DefaultName)
        Next i

        'Sort them
        For i = 0 To NumberScores
            For j = 0 To NumberScores
                If SortDirection Then 'Higher the better
                    If Scores(i) > Scores(j) Then
                        t = Scores(i)
                        ts = Names(i)
                        Scores(i) = Scores(j)
                        Names(i) = Names(j)
                        Scores(j) = t
                        Names(j) = ts
                    End If
                Else
                    If Scores(i) < Scores(j) Then
                        t = Scores(i)
                        ts = Names(i)
                        Scores(i) = Scores(j)
                        Names(i) = Names(j)
                        Scores(j) = t
                        Names(j) = ts
                    End If
                End If
            Next j
        Next i
    End Function

    Public Function GetPlayerScore(ByVal Index As Integer) As Integer
        On Error Resume Next
        GetPlayerScore = Scores(Index)
    End Function

    Public Function GetPlayerName(ByVal Index As Integer) As String
        On Error Resume Next
        GetPlayerName = Names(Index)
    End Function
End Class