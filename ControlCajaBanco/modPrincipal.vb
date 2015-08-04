Module modPrincipal

  Public mOInstitucion As Institucion
  Public moNivel As Nivel
  Public moAnioActual As AnioLectivo
  Public mOPeriodoActual As PeriodoAcademico
  Public mOUsuario As Usuario
  Public mODocente As Docente
  Public mODirectorNivel As Persona
  Public mOCajaChica As CajaChica

  Public Sub main()
    Dim f As New frmIdentificar
    Dim fPer As frmPeriodoActual

    f.ShowDialog()
    Application.EnableVisualStyles()
    If mOUsuario IsNot Nothing Then
      fPer = New frmPeriodoActual
      fPer.Configurar()
      'Application.Run(fPer)
      If mOInstitucion IsNot Nothing Then
        ' mOCajaChica IsNot Nothing Then
        Application.Run(New frmPrincipal)
        'End If

      End If
    End If
  End Sub

End Module
