Module DynamicFunctions


    Public Function To_mysql_Date(ByVal mixDate As Date) As String
        Return Convert.ToDateTime(mixDate).ToString("yyyy-MM-dd")
    End Function

    Public Function To_mysql_DateTime(ByVal mixDate As Date) As String
        Return Convert.ToDateTime(mixDate).ToString("yyyy-MM-dd h:mm:ss")
    End Function

    Public Function PC_Date(ByVal mixDate As Date) As String
        Return Convert.ToDateTime(mixDate).ToString("MM-dd-yyyy")
    End Function

    Public Function PC_DateTime(ByVal mixDate As Date) As String
        Return Convert.ToDateTime(mixDate).ToString("MM-dd-yyyy h:mm:ss")
    End Function

    Public Function NumberToWords(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String

        If Not IsNumeric(nAmount) Then Return "-"


        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then tempDecValue = nAmount.Substring(nAmount.IndexOf("."))


        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try

            Dim intAmount As Long = nAmount


            If intAmount > 0 Then

                nSet = IIf((intAmount.ToString.Trim.Length / 3) > (CLng(intAmount.ToString.Trim.Length / 3)), CLng(intAmount.ToString.Trim.Length / 3) + 1, CLng(intAmount.ToString.Trim.Length / 3))


                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))


                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))


                Dim Ones() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}


                intAmount = eAmount


                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1


                If nHundred > 0 Then wAmount = wAmount & Ones(nHundred) & " Hundred "
                If nTen > 0 Then
                    If nTen = 1 And nOne > 0 Then
                        wAmount = wAmount & Teens(nOne) & " "
                    Else
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If

                wAmount = wAmount & HMBT(nSet) & " "

                wAmount = NumberToWords(CStr(CLng(nAmount) - (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else

                If Val(nAmount) = 0 Then nAmount &= tempDecValue : tempDecValue = String.Empty

                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = wAmount.Trim.ToLower & " pesos and " & Trim(CStr(Math.Round(Val(nAmount), 2) * 100) & "/100.")
                'Trim(NumberToWords(CStr(Math.Round(Val(nAmount), 2) * 100), wAmount.Trim & " Pesos and ", 1)) & " cents."
            End If
        Catch ex As Exception

            MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = IIf(InStr(wAmount.Trim.ToLower, "pesos"), wAmount.Trim, wAmount.Trim.ToLower & " pesos only.")

        Return wAmount
    End Function

End Module
