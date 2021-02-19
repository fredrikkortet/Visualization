Private Function getConnection_Int() As String
Try
Dim id_str As String
Dim parameters As String
Dim cm As New EIBA.Interop.Falcon.ConnectionManager
Dim con As EIBA.Interop.Falcon.FalconConnection
'Skapar Connection Manager
con = cm.GetConnection("", True)
If con.guidEdi = Nothing Or con.Parameters = Nothing Then
id_str = "-"
parameters = "-"
Else
'Hämtar guID för uppkoppling
Dim gu_id As System.Guid
gu_id = con.guidEdi
'Hämtar och skapar parametersträngen för uppkoppling
parameters = ""
Dim i As Integer
For i = 0 To (con.Parameters.Length - 1)
parameters = parameters & Convert.ToChar(con.Parameters(i))
Next i
id_str = "{" & gu_id.ToString() & "}"
End If
Return id_str & "|" & parameters
Catch ex As Exception
Throw New Exception("|x| GetConnection: Error opening connection
manager. (e1102)" & vbCrLf & "- " & ex.Message)
End Try
End Function