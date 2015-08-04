Module modPrincipal

  Public mOInstitucion As Institucion
  Public moAnioActual As AnioLectivo
  Public mOPeriodoActual As PeriodoAcademico

  Public Sub main()
    Dim f As frmInformacionAlumno
    Dim fPer As frmPeriodoActual

    fPer = New frmPeriodoActual
    fPer.Configurar()

    If moAnioActual IsNot Nothing Then
      f = New frmInformacionAlumno
      f.Presentar()
    End If

  End Sub

End Module
