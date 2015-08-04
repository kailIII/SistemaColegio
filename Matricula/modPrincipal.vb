Module modPrincipal

  Public mOInstitucion As Institucion
  Public moAnioActual As AnioLectivo
  Public mOUsuario As Usuario
  
  Public Sub main()
    Dim f As New frmIdentificar
    Dim fPer As frmPeriodoActual

    f.ShowDialog()

    If mOUsuario IsNot Nothing Then
      fPer = New frmPeriodoActual
      fPer.Configurar()

      If mOInstitucion IsNot Nothing Then
        Application.Run(New frmPrincipal)
      End If
    End If
  End Sub

End Module
