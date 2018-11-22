Imports VBScript_RegExp_55
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net.Mail

Public Class Class1

    Public Function CheckNull(ByVal valore As String) As String
        If String.IsNullOrEmpty(valore) Or String.IsNullOrWhiteSpace(valore) Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckCF(ByVal CodiceFiscale As String) As String
        If CheckCodiceFiscale(CodiceFiscale) = "Errato" Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckPartitaIVA(ByVal PartitaIVA As String) As String
        If PI1(PartitaIVA) = False Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckCognome(ByVal CodiceFiscale As String, ByVal Cognome As String) As String
        If ExtractLetters(Cognome, True) <> Mid(CodiceFiscale, 1, 3) Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckNome(ByVal CodiceFiscale As String, ByVal Nome As String) As String
        If ExtractLetters(Nome, False) <> Mid(CodiceFiscale, 4, 3) Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckIndirizzo(ByVal Indirizzo As String) As String
        If Len(Indirizzo) < 7 Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckCitta(ByVal Citta As String) As String
        Citta = Trim(UCase(Citta))
        Dim ListaCitta As String = My.Computer.FileSystem.ReadAllText("ListaCitta.txt")
        Dim listacitta1() As String = ListaCitta.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listacitta1.Length - 1
            If Trim(UCase(listacitta1(i))) = Citta Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function CheckCAP(ByVal CAP As String) As String
        Dim ListaCAP As String = My.Computer.FileSystem.ReadAllText("ListaCAP.txt")
        Dim listacap1() As String = ListaCAP.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listacap1.Length - 1
            If listacap1(i) = CAP Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function CheckProvincia(ByVal Provincia As String) As String
        Provincia = Trim(UCase(Provincia))
        Dim ListaProvince As String = My.Computer.FileSystem.ReadAllText("ListaProvince.txt")
        Dim listaprovince1() As String = ListaProvince.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listaprovince1.Length - 1
            If Trim(UCase(listaprovince1(i))) = Provincia Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function CheckNazione(ByVal Nazione As String) As String
        Nazione = Trim(UCase(Nazione))
        Dim ListaNazioni As String = My.Computer.FileSystem.ReadAllText("ListaNazioni.txt")
        Dim listanazioni1() As String = ListaNazioni.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listanazioni1.Length - 1
            If Trim(UCase(listanazioni1(i))) = Nazione Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function CheckTelefono(ByVal Telefono As String) As String
        If Len(Telefono) > 11 Then
            Return "KO"
        Else
            If iter_1(Telefono) = "OK" Then
                Return "OK"
            Else
                If iter_2(Telefono) = "OK" Then
                    Return "OK"
                Else
                    If iter_3(Telefono) = "OK" Then
                        Return "OK"
                    Else
                        If iter_4(Telefono) = "OK" Then
                            Return "OK"
                        Else
                            If iter_5(Telefono) = "OK" Then
                                Return "OK"
                            Else
                                If iter_6(Telefono) = "OK" Then
                                    Return "OK"
                                Else
                                    Return "KO"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return "Hello World"
    End Function

    Public Function CheckEmail(ByVal Email As String) As String
        If ValidateEmailAddress(Email) = False Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckIBAN(ByVal IBAN As String) As String
        If ValidateIban(IBAN) = False Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Function CheckImporto(ByVal Importo As Double) As String
        Try
            Importo = CDbl(Importo)
            Return "OK"
        Catch ex As Exception
            Return "KO"
        End Try

        Return "Hello World"
    End Function

    Public Function CheckAnnualita(ByVal Annualita As Double) As String
        Try
            Annualita = CDbl(Annualita)
            If Annualita < 1900 Or Annualita > 9999 Then
                Return "KO"
            Else
                Return "OK"
            End If
        Catch ex As Exception
            Return "KO"
        End Try
        Return "Hello World"
    End Function

    Public Function CheckScadenza(ByVal Scadenza As Date) As String
        Try
            Scadenza = CDate(Scadenza)
            If Scadenza < Now Then
                Return "KO"
            Else
                Return "OK"
            End If
        Catch ex As Exception
            Return "KO"
        End Try
        Return "Hello World"
    End Function

    Public Function CheckMulti(ByVal tabella As String, ByVal campo As String, ByVal where As String, ByVal dsn As String) As String

        Dim queryString As String = "SELECT " & tabella & "." & campo & "  FROM " & tabella & " WHERE " & where & ";"

        Using connection As New OdbcConnection("Dsn=" & dsn)
            Dim command As New OdbcCommand(queryString, connection)

            connection.Open()

            Dim reader As OdbcDataReader = command.ExecuteReader()

            While reader.Read()
            End While

            If reader.HasRows = False Then
                Return "OK"
            Else
                Return "KO"
            End If

            connection.Close()
            reader.Close()
        End Using

        Return "Hello World"
    End Function

    Public Function DirectWrite(ByVal query As String, ByVal dsn As String) As String

        Dim queryString As String = query

        Using connection As New OdbcConnection("Dsn=" & dsn)
            Dim command As New OdbcCommand(queryString, connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            Return "OK"
        End Using

        Return "Hello World"
    End Function

    Private Const IbanCountryLengths As String = "AL28AD24AT20AZ28BH22BE16BA20BR29BG22CR21HR21CY28CZ24DK18DO28EE20FO18" & _
                                                 "FI18FR27GE22DE22GI23GR27GL18GT28HU28IS26IE22IL23IT27KZ20KW30LV21LB28" & _
                                                 "LI21LT20LU20MK19MT31MR27MU30MC27MD24ME22NL18NO15PK24PS29PL28PT25RO24" & _
                                                 "SM27SA24RS22SK24SI19ES24SE24CH21TN24TR26AE23GB22VG24QA29"

    Structure RankInfo
        Dim Offset As Integer
        Dim Percentage As Single
    End Structure

    Public Function CheckCodiceFiscale(ByVal codicefiscale As String) As String
        CheckCodiceFiscale = "Errato"
        Const caratteri As Integer = 16
        If codicefiscale & "" = "" Then Exit Function
        If Not Len(codicefiscale) = caratteri Then Exit Function
        Const omocodici As String = "LMNPQRSTUV"
        Const listaControllo As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim listaPari() As Object
        listaPari = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25}
        Dim listaDispari() As Object
        listaDispari = {1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23}
        codicefiscale = UCase(codicefiscale)
        Dim k As Integer
        Dim x As Integer
        Dim cCodice(15) As String
        For k = 0 To 14
            cCodice(k) = Mid(codicefiscale, k + 1, 1)
        Next
        Dim somma As Long
        somma = 0
        Dim i As Integer
        i = 0
        While i < 15
            Dim s As String
            s = cCodice(i)
            x = InStr(1, "0123456789", s)
            If Not (x <= 0) Then
                s = Mid(listaControllo, x, 1)
            End If
            x = InStr(1, listaControllo, s, vbTextCompare)
            If (i Mod 2) = 0 Then
                x = listaDispari(x - 1)
            Else
                x = listaPari(x - 1)
            End If
            somma = somma + x
            i = i + 1
        End While
        x = somma Mod 26 + 1
        If Mid(listaControllo, x, 1) = Right(codicefiscale, 1) Then
            CheckCodiceFiscale = "Corretto"
        End If
    End Function

    Public Function PI1(ByVal codice) As Boolean

        'Controllo dell'esattezza formale della Partita IVA
        Dim n As Integer  ' contatore
        Dim cd As Integer ' contributo cifre dispari
        Dim cp As Integer ' contributo cifre pari
        Dim ct As Integer ' contributo totale

        'controlla la lunghezza del codice
        If Len(codice) <> 11 Then
            PI1 = False
            Exit Function
        End If

        'controlla l'esattezza del carattere di controllo
        ct = 0
        For n = 1 To 9 Step 2
            cd = CInt(Mid(codice, n, 1))
            cp = CInt(Mid(codice, n + 1, 1)) * 2
            If cp > 9 Then cp = cp - 9
            ct = ct + cd + cp
        Next n

        If (10 - ct Mod 10) Mod 10 = CInt(Right(codice, 1)) Then
            PI1 = True
        Else
            PI1 = False
        End If

    End Function

    Public Function ExtractLetters(ByVal strValue As String, ByVal bCognome As Boolean) As String
        Dim i, iVoc, iCon As Integer, strTemp, strVoc, strCon As String

        i = 1
        iVoc = 0
        iCon = 0
        strTemp = ""
        strVoc = ""
        strCon = ""

        strValue = UCase(strValue)

        While i <= Len(strValue)
            strTemp = Mid(strValue, i, 1)
            If Asc(strTemp) >= 65 And Asc(strTemp) <= 90 Then
                If InStr(1, "AEIOU", strTemp) Then
                    iVoc = iVoc + 1
                    strVoc = Trim(strVoc) + strTemp
                Else
                    iCon = iCon + 1
                    strCon = Trim(strCon) + strTemp
                End If
            End If
            i = i + 1
        End While

        strTemp = ""
        If bCognome Then
            If iCon >= 3 Then
                strTemp = Left(strCon, 3)
            ElseIf iCon = 2 Then
                strTemp = strCon
                If iVoc > 1 Then
                    strTemp = strTemp + Left(strVoc, 1)
                Else
                    strTemp = strTemp + "X"
                End If
            ElseIf iCon = 1 Then
                strTemp = strCon
                If iVoc >= 2 Then
                    strTemp = strTemp + strVoc
                ElseIf iVoc = 1 Then
                    strTemp = strTemp + strVoc + "X"
                Else
                    strTemp = strTemp + "XX"
                End If
            Else
                If iVoc >= 3 Then
                    strTemp = strVoc
                ElseIf iVoc = 2 Then
                    strTemp = strVoc + "X"
                ElseIf iVoc = 1 Then
                    strTemp = strVoc + "XX"
                Else
                    strTemp = "XXX"
                End If
            End If
        Else
            If iCon >= 4 Then
                strTemp = Left(strCon, 1)
                strTemp = strTemp + Mid(strCon, 3, 2)
            ElseIf iCon = 3 Then
                strTemp = strCon
            ElseIf iCon = 2 Then
                strTemp = strCon
                If iVoc > 1 Then
                    strTemp = strTemp + Left(strVoc, 1)
                Else
                    strTemp = strTemp + "X"
                End If
            ElseIf iCon = 1 Then
                strTemp = strCon
                If iVoc >= 2 Then
                    strTemp = strTemp + strVoc
                ElseIf iVoc = 1 Then
                    strTemp = strTemp + strVoc + "X"
                Else
                    strTemp = strTemp + "XX"
                End If
            Else
                If iVoc >= 3 Then
                    strTemp = strVoc
                ElseIf iVoc = 2 Then
                    strTemp = strVoc + "X"
                ElseIf iVoc = 1 Then
                    strTemp = strVoc + "XX"
                Else
                    strTemp = "XXX"
                End If
            End If
        End If

        ExtractLetters = strTemp

    End Function

    Public Function ValidateEmailAddress(ByVal strEmailAddress As String) As Boolean
        On Error GoTo Errore

        Dim objRegExp As New RegExp
        Dim blnIsValidEmail As Boolean

        objRegExp.IgnoreCase = True
        objRegExp.Global = True
        objRegExp.Pattern = "^([a-zA-Z0-9_\-\.]+)@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$"

        blnIsValidEmail = objRegExp.Test(strEmailAddress)
        ValidateEmailAddress = blnIsValidEmail

        Exit Function

Errore:
        ValidateEmailAddress = False
        MsgBox("Module:  - ValidateEmailAddress function" & vbCrLf & vbCrLf _
            & "Error#:  " & Err.Number & vbCrLf & vbCrLf & Err.Description)
    End Function

    Private Function ValidateIbanCountryLength(ByVal CountryCode As String, ByVal IbanLength As Integer) As Boolean
        Dim i As Integer
        For i = 0 To Len(IbanCountryLengths) / 4 - 1
            If Mid(IbanCountryLengths, i * 4 + 1, 2) = CountryCode And _
                        CInt(Mid(IbanCountryLengths, i * 4 + 3, 2)) = IbanLength Then
                ValidateIbanCountryLength = True
                Exit Function
            End If
        Next i
        ValidateIbanCountryLength = False
    End Function

    Private Function Mod97(ByVal Num As String) As Integer
        Dim lngTemp As Long
        Dim strTemp As String

        Do While Val(Num) >= 97
            If Len(Num) > 5 Then
                strTemp = Left(Num, 5)
                Num = Right(Num, Len(Num) - 5)
            Else
                strTemp = Num
                Num = ""
            End If
            lngTemp = CLng(strTemp)
            lngTemp = lngTemp Mod 97
            strTemp = CStr(lngTemp)
            Num = strTemp & Num
        Loop
        Mod97 = CInt(Num)
    End Function

    Public Function ValidateIban(ByVal IBAN As String) As Boolean
        Dim strIban As String
        Dim i As Integer

        strIban = UCase(IBAN)
        ' Remove spaces
        strIban = Replace(strIban, " ", "")

        ' Check if IBAN contains only uppercase characters and numbers
        For i = 1 To Len(strIban)
            If Not ((Asc(Mid(strIban, i, 1)) <= Asc("9") And Asc(Mid(strIban, i, 1)) >= Asc("0")) Or _
                    (Asc(Mid(strIban, i, 1)) <= Asc("Z") And Asc(Mid(strIban, i, 1)) >= Asc("A"))) Then
                ValidateIban = False
                Exit Function
            End If
        Next i

        ' Check if length of IBAN equals expected length for country
        If Not ValidateIbanCountryLength(Left(strIban, 2), Len(strIban)) Then
            ValidateIban = False
            Exit Function
        End If

        ' Rearrange
        strIban = Right(strIban, Len(strIban) - 4) & Left(strIban, 4)

        ' Replace characters
        For i = 0 To 25
            strIban = Replace(strIban, Chr(i + Asc("A")), i + 10)
        Next i

        ' Check remainder
        ValidateIban = Mod97(strIban) = 1
    End Function


    Function removeBadChars1(ByVal sInput As String) As String
        Dim i As Integer
        Dim sResult As String
        Dim sChr As String

        For i = 1 To Len(sInput)
            sChr = Mid(sInput, i, 1)
            If IsNumeric(sChr) Or sChr = "," Then
                sResult = sResult & sChr
            End If
        Next

        removeBadChars1 = sResult
    End Function

    Function removeBadChars(ByVal sInput As String) As String
        Dim i As Integer
        Dim sResult As String
        Dim sChr As String

        For i = 1 To Len(sInput)
            sChr = Mid(sInput, i, 1)
            If IsNumeric(sChr) Or sChr = "A" Or sChr = "B" Or sChr = "C" Or sChr = "D" Or sChr = "E" Or sChr = "F" Or sChr = "G" Or sChr = "H" Or sChr = "I" Or sChr = "J" Or sChr = "K" Or sChr = "L" Or sChr = "M" Or sChr = "N" Or sChr = "O" Or sChr = "P" Or sChr = "Q" Or sChr = "R" Or sChr = "S" Or sChr = "T" Or sChr = "U" Or sChr = "V" Or sChr = "W" Or sChr = "X" Or sChr = "Y" Or sChr = "Z" Then
                sResult = sResult & sChr
            End If
        Next

        removeBadChars = sResult
    End Function

    Public Function iter_1(ByVal Telefono As String) As String
        Dim iter1 As String = Mid(Telefono, 1, 1)
        Dim ListaPrefissi As String = My.Computer.FileSystem.ReadAllText("ListaPrefissi.txt")
        Dim listaprefissi1() As String = ListaPrefissi.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listaprefissi1.Length - 1
            If listaprefissi1(i) = iter1 Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function iter_2(ByVal Telefono As String) As String
        Dim iter1 As String = Mid(Telefono, 1, 2)
        Dim ListaPrefissi As String = My.Computer.FileSystem.ReadAllText("ListaPrefissi.txt")
        Dim listaprefissi1() As String = ListaPrefissi.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listaprefissi1.Length - 1
            If listaprefissi1(i) = iter1 Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function iter_3(ByVal Telefono As String) As String
        Dim iter1 As String = Mid(Telefono, 1, 3)
        Dim ListaPrefissi As String = My.Computer.FileSystem.ReadAllText("ListaPrefissi.txt")
        Dim listaprefissi1() As String = ListaPrefissi.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listaprefissi1.Length - 1
            If listaprefissi1(i) = iter1 Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function iter_4(ByVal Telefono As String) As String
        Dim iter1 As String = Mid(Telefono, 1, 4)
        Dim ListaPrefissi As String = My.Computer.FileSystem.ReadAllText("ListaPrefissi.txt")
        Dim listaprefissi1() As String = ListaPrefissi.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listaprefissi1.Length - 1
            If listaprefissi1(i) = iter1 Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function iter_5(ByVal Telefono As String) As String
        Dim iter1 As String = Mid(Telefono, 1, 5)
        Dim ListaPrefissi As String = My.Computer.FileSystem.ReadAllText("ListaPrefissi.txt")
        Dim listaprefissi1() As String = ListaPrefissi.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listaprefissi1.Length - 1
            If listaprefissi1(i) = iter1 Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function iter_6(ByVal Telefono As String) As String
        Dim iter1 As String = Mid(Telefono, 1, 6)
        Dim ListaPrefissi As String = My.Computer.FileSystem.ReadAllText("ListaPrefissi.txt")
        Dim listaprefissi1() As String = ListaPrefissi.Split(";")
        Dim i As Integer
        Dim trigger As Integer = 0
        For i = 0 To listaprefissi1.Length - 1
            If listaprefissi1(i) = iter1 Then
                trigger = 1
            End If
        Next
        If trigger = 1 Then
            Return "OK"
        Else
            Return "KO"
        End If
        Return "Hello World"
    End Function

    Public Function CheckPassword(ByVal Password As String) As String
        If Len(Password) < 7 Then
            Return "KO"
        Else
            Return "OK"
        End If
        Return "Hello World"
    End Function

    Public Shared Function GenerateSHA256String(ByVal inputString) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

    Public Shared Function GenerateSHA512String(ByVal inputString) As String
        Dim sha512 As SHA512 = SHA512Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

    Public Function GenerateRandom() As Integer
        Using provider As New RNGCryptoServiceProvider()
            Dim data As Byte() = New Byte(4 - 1) {}
            provider.GetBytes(data)
            Return BitConverter.ToInt32(data, 0)
        End Using
    End Function

    Public Function SendMail(ByVal username As String, ByVal password As String, ByVal port As Integer, ByVal server As String, ByVal sender As String, ByVal recipient As String, ByVal subject As String, ByVal bodystring As String, ByVal ssl As Boolean) As String
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New  _
            Net.NetworkCredential(sender, password)
            SmtpServer.Port = port
            SmtpServer.Host = server
            mail = New MailMessage()
            mail.From = New MailAddress(sender)
            mail.To.Add(recipient)
            mail.Subject = subject
            mail.Body = bodystring
            SmtpServer.EnableSsl = ssl
            SmtpServer.Send(mail)
            Return "OK"
        Catch ex As Exception
            Return "KO"
        End Try
    End Function

End Class
