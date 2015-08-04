Module modLetras

  Private Unidades() As String = {"", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE"}
  Private Decenas() As String = {"VEINTI", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA"}
  Private Cientos() As String = {"CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS"}

  Public Function ConvertirLetras(ByVal wNumero As Double) As String
    Dim num As String = ""
    Dim dec As Integer

    dec = CInt(wNumero * 100) Mod 100
    num = Traducir(CInt(wNumero - (dec / 100))) & " y " & dec.ToString("00") & "/100 nuevos soles"

    Return num
  End Function

  Private Function Traducir(ByVal wNumero As Integer) As String

    If wNumero >= 1000 Then
      If wNumero < 2000 Then
        If wNumero > 1000 Then
          Return "MIL" & Traducir(wNumero - 1000)
        Else
          Return "MIL"
        End If
      Else
        Return Traducir(wNumero \ 1000) & "MIL" & Traducir(wNumero Mod 1000)
      End If
    ElseIf wNumero >= 100 Then
      If wNumero > 100 Then
        Return Cientos((wNumero \ 100) - 1) & " " & Traducir(wNumero Mod 100)
      Else
        Return "CIEN"
      End If
    ElseIf wNumero >= 20 Then
      If wNumero >= 30 Then
        If wNumero Mod 10 > 0 Then
          Return Decenas((wNumero \ 10) - 2) & " Y " & Traducir(wNumero Mod 10)
        Else
          Return Decenas((wNumero \ 10) - 2)
        End If
      ElseIf wNumero > 20 Then
        If wNumero Mod 10 > 0 Then
          Return Decenas((wNumero \ 10) - 2) & Traducir(wNumero Mod 10)
        Else
          Return Decenas((wNumero \ 10) - 2)
        End If
      Else
        Return "VEINTE"
      End If
    Else
      Return Unidades(wNumero)
    End If
  End Function

End Module
