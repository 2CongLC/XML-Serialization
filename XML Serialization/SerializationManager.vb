Imports System
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization


Public Class SerializationManager(Of t As Class)

    Public Shared Sub WriteToXmlFile(ByVal filePath As String, ByVal objectToWrite As t)
        Try
            'Dim writer As TextWriter = New StreamWriter(filePath)
            Dim fs As Stream = New FileStream(filePath, FileMode.Create)
            Dim xmls As XmlSerializer = New XmlSerializer(GetType(t))
            xmls.Serialize(fs, objectToWrite)
            fs.Flush()
            fs.Dispose()
            fs.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Public Shared Function ReadFromXmlFile(ByVal filePath As String) As t
        Dim obj As t = Nothing
        Try

            Dim fs As Stream = New FileStream(filePath, FileMode.Open)
            Dim xmls As XmlSerializer = New XmlSerializer(GetType(t))
            obj = DirectCast(xmls.Deserialize(fs), t)
            fs.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return obj
    End Function

End Class
