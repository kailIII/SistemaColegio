Public Class RNResponsableCajaChica

	Public Sub Registrar(Byval wResponsableCajaChica AS ResponsableCajaChica)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_iResponsableCajaChica", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@vigencia", wResponsableCajaChica.vigencia)
			.AddWithValue("@codigoPersonal", wResponsableCajaChica.codigoPersonal)
		End With

		Try
			cn.Open()
			cmd.ExecuteNonQuery()
		Catch ex AS Exception
			Throw ex
		Finally
			cmd.Dispose()
			cmd = Nothing
			If cn.State = ConnectionState.Open Then
				cn.Close()
			End If
			cn.Dispose()
			cn = Nothing
		End Try
	End Sub
	Public Sub Modificar(Byval wResponsableCajaChica AS ResponsableCajaChica)
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_aResponsableCajaChica", cn)
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoRespCajaChica", wResponsableCajaChica.codigoRespCajaChica)
			.AddWithValue("@vigencia", wResponsableCajaChica.vigencia)
			.AddWithValue("@codigoPersonal", wResponsableCajaChica.codigoPersonal)
		End With

		Try
			cn.Open()
			cmd.ExecuteNonQuery()
		Catch ex AS Exception
			Throw ex
		Finally
			cmd.Dispose()
			cmd = Nothing
			If cn.State = ConnectionState.Open Then
				cn.Close()
			End If
			cn.Dispose()
			cn = Nothing
		End Try
	End Sub
	Public Function Leer(Byval wResponsableCajaChica AS ResponsableCajaChica) AS ResponsableCajaChica
		Dim cn As New SqlConnection(My.Settings.Conexion)
		Dim cmd As New SqlCommand("pr_lResponsableCajaChica", cn)
		Dim dr As SQLDataReader = Nothing
		Dim dato As ResponsableCajaChica = Nothing
		cmd.CommandType = CommandType.StoredProcedure
		With cmd.Parameters
			.AddWithValue("@codigoRespCajaChica", wResponsableCajaChica.codigoRespCajaChica)
		End With

		Try
			cn.Open()
			dr = cmd.ExecuteReader()
			If dr.Read = True Then
				dato = New ResponsableCajaChica( wResponsableCajaChica.codigoRespCajaChica,CBool( dr.Item("vigencia") ),CInt( dr.Item("codigoPersonal") ) )
			End If
		Catch ex AS Exception
			Throw ex
		Finally
			cmd.Dispose()
			cmd = Nothing
			If cn.State = ConnectionState.Open Then
				cn.Close()
			End If
			cn.Dispose()
			cn = Nothing
		End Try
		Return dato
	End Function

End Class