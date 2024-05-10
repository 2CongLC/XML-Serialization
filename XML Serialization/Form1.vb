Imports System.Data.SqlTypes
Imports System.IO
Imports System.Xml

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim xmlstring As String = File.ReadAllText(OpenFileDialog1.FileName)
                SerializationManager(Of String).WriteToXmlFile(SaveFileDialog1.FileName, xmlstring)

                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim xmlstring As String = SerializationManager(Of String).ReadFromXmlFile(OpenFileDialog1.FileName)
                File.WriteAllText(SaveFileDialog1.FileName, xmlstring)

                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim dt As Employee = New Employee()
            dt.EmpID = "0001"
            dt.EmpName = "name"
            dt.EmpList = New String() {"aaa", "bbb"}


            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                SerializationManager(Of Employee).WriteToXmlFile(SaveFileDialog1.FileName, dt)
            End If

            MessageBox.Show("ok")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim dt As Employee = SerializationManager(Of Employee).ReadFromXmlFile(OpenFileDialog1.FileName)
                TextBox1.Text = dt.EmpID
                TextBox2.Text = dt.EmpName

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click



        Try

            Dim myElement As XmlElement = New XmlDocument().CreateElement("MyElement", "ns")
            myElement.InnerText = "Hello World"


            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                SerializationManager(Of XmlElement).WriteToXmlFile(SaveFileDialog1.FileName, myElement)
            End If

            MessageBox.Show("ok")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try






    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try

            Dim myNode As XmlNode = New XmlDocument().CreateNode(XmlNodeType.Element, "MyNode", "ns")
            myNode.InnerText = "Hello Node"


            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                SerializationManager(Of XmlNode).WriteToXmlFile(SaveFileDialog1.FileName, myNode)
            End If

            MessageBox.Show("ok")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try

            Dim ds As DataSet = New DataSet("myDataSet")
            Dim t As DataTable = New DataTable("table1")
            Dim c As DataColumn = New DataColumn("thing")
            t.Columns.Add(c)
            ds.Tables.Add(t)
            Dim r As DataRow

            For i As Integer = 0 To 9
                r = t.NewRow()
                r(0) = "Thing " & i
                t.Rows.Add(r)
            Next

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                SerializationManager(Of DataSet).WriteToXmlFile(SaveFileDialog1.FileName, ds)
            End If

            MessageBox.Show("ok")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


End Class
