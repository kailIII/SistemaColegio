Module modPrincipal

  Public mOUsuario As Usuario
  Public mODocente As Docente

  Public Sub main()
    Dim f As New frmIdentificar

    f.ShowDialog()
    f = Nothing
    If mOUsuario IsNot Nothing Then
      Application.Run(New frmPrincipal)
    End If
  End Sub

End Module
