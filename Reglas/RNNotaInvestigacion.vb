
Public Class RNNotaInvestigacion
  Inherits CADO

    Public Function ListarNotas(ByVal anio As Integer, ByVal codigoG As Integer, ByVal letra As String, ByVal codigoPeriodo As Integer) As List(Of NotaInvestigacion)
        Dim pars As New List(Of CParametro)
        Dim notas As New List(Of NotaInvestigacion)
        Dim dr As SqlDataReader
        pars.AddRange(New CParametro() {New CParametro("@anio", anio), _
                        New CParametro("@codigoG", codigoG), _
                        New CParametro("@letra", letra), _
                        New CParametro("@codigoPeriodo", codigoPeriodo)})

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("pr_liNotaInvestigacion", pars)
            While dr.Read
                notas.Add(New NotaInvestigacion(CInt(dr.Item("codigoNotaInv")), CStr(dr.Item("Nota")), _
                                             New Alumno(CInt(dr.Item("codigoPersona")), CStr(dr.Item("nombre")), CStr(dr.Item("ApellidoPat")), CStr(dr.Item("ApellidoMat"))), _
                                             New ResponsableInvestigacion(CInt(dr.Item("codigoRespInv")), CStr(dr.Item("Docente"))), _
                                             New AreaInvestigacion() With {.Codigo = CInt(dr.Item("codigoAreaInv")), _
                                                                         .Nombre = CStr(dr.Item("nombreArea")), .Periodo = New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")))}, New Matricula(CInt(dr.Item("nroMatricula"))), _
                                             CStr(dr.Item("Nivel"))))
            End While

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw
        Finally
            pars = Nothing
        End Try

        Return notas
    End Function

    Public Sub RegistrarNotas(ByVal nota As Double, ByVal matricula As Matricula, ByVal comentario As String,
                                   ByVal respInv As ResponsableInvestigacion, ByVal personal As Personal, ByVal codigo As Integer)
        Dim pars As New List(Of CParametro)

        pars.AddRange(New CParametro() {New CParametro("@Nota", nota), _
                      New CParametro("@nroMatricula", matricula.Numero), _
                      New CParametro("@comentario", comentario), _
                      New CParametro("@CodigoRespInv", respInv.Codigo), _
                      New CParametro("@CodigoNota", codigo), _
                      New CParametro("@CodPersonal", personal.Codigo)})

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("pr_iNotaInvestigacion", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw
        Finally
            pars = Nothing
        End Try

    End Sub

    Public Sub RegistrarNotasLetra(ByVal letra As String, ByVal matricula As Matricula, ByVal comentario As String,
                                   ByVal respInv As ResponsableInvestigacion, ByVal personal As Personal, ByVal codigo As Integer)
        Dim pars As New List(Of CParametro)

        pars.AddRange(New CParametro() {
                      New CParametro("@nroMatricula", matricula.Numero), _
                      New CParametro("@comentario", comentario), _
                      New CParametro("@CodigoRespInv", respInv.Codigo), _
                      New CParametro("@CodigoNota", codigo), _
                      New CParametro("@CodPersonal", personal.Codigo), _
                      New CParametro("@Nota", letra)})

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("pr_iNotaInvestigacionLetra", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw
        Finally
            pars = Nothing
        End Try

    End Sub

  Public Sub RegistrarNotas(ByVal wNotas As List(Of NotaInvestigacion))
    Dim pars As New List(Of CParametro)

        pars.AddRange(New CParametro() {New CParametro("@NroMatricula", 0), _
                                        New CParametro("@Nota", ""), _
                                        New CParametro("@Comentario", ""), _
                                        New CParametro("@CodigoRespInv", 0), _
                                        New CParametro("@CodigoNota", 0), _
                                        New CParametro("@CodPersonal", 0)})
    Try
      Me.Conectar(True)
      pars.Item(2).Valor = ""
      For Each nl As NotaInvestigacion In wNotas
        pars.Item(0).Valor = nl.Matricula.Numero
        pars.Item(1).Valor = nl.Nota
        pars.Item(3).Valor = nl.RespInvestigacion.Codigo
                pars.Item(5).Valor = nl.Personal.Codigo
        Me.EjecutarOrden("pr_iNotaInvestigacion", pars)
      Next
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try
  End Sub

  Public Sub RegistrarNotasLetras(ByVal wNotas As List(Of NotaInvestigacion))
    Dim pars As New List(Of CParametro)

        pars.AddRange(New CParametro() {New CParametro("@NroMatricula", 0), _
                                        New CParametro("@Nota", ""), _
                                        New CParametro("@Comentario", ""), _
                                        New CParametro("@CodigoRespInv", 0), _
                                        New CParametro("@CodigoNota", 0), _
                                        New CParametro("@CodPersonal", 0)})
    Try
      Me.Conectar(True)
      pars.Item(2).Valor = ""
      For Each nl As NotaInvestigacion In wNotas
        pars.Item(0).Valor = nl.Matricula.Numero
        pars.Item(1).Valor = nl.Nota
        pars.Item(3).Valor = nl.RespInvestigacion.Codigo
                pars.Item(5).Valor = nl.Personal.Codigo
        Me.EjecutarOrden("pr_iNotaInvestigacionLetra", pars)
      Next

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try
  End Sub

  Public Function ListarNotasNroMatricula(ByVal nroMatricula As Integer) As List(Of NotaInvestigacion)
    Dim pars As New List(Of CParametro)
    Dim notas As New List(Of NotaInvestigacion)
    Dim dr As SqlDataReader
    pars.AddRange(New CParametro() {New CParametro("@nroMatricula", nroMatricula)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liNotaAreaInvestigacionXNroMatricula", pars)
      While dr.Read
        notas.Add(New NotaInvestigacion(0, CStr(dr.Item("Nota")), _
                                     New Alumno(), _
                                     New ResponsableInvestigacion(), _
                                     New AreaInvestigacion(0, CStr(dr.Item("nombreArea"))), New Matricula(), ""))
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try

    Return notas
  End Function
End Class
