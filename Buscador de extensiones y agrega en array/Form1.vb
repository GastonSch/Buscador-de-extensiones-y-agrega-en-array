Imports System.Collections.ObjectModel
Public Class Form1
    Dim Fotos(,) As String  '<----------CREO UN ARRAY de dos dimenciones 
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim files As ReadOnlyCollection(Of String)
        files = My.Computer.FileSystem.GetFiles(TextBox2.Text, FileIO.SearchOption.SearchAllSubDirectories, "*." & TextBox1.Text) '<---------- RUTA DEL ARCHIVO DONDE ESTAN LAS FOTOS 

        ListBox1.Items.Clear()
        ReDim Fotos(files.Count - 1, 1) '<----------redimenciono ARRAy

        For I = 0 To files.Count - 1            '<-----se carga el array
            Fotos(I, 0) = files(I)

        Next

        For I = 0 To files.Count - 1                '<--- aca tiene otro for solo para mostrar lo que cargo en el array
            ListBox1.Items.Add(Fotos(I, 0))
        Next

        'End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim ARCHIVO As String = ListBox1.SelectedItem
        Fotos(ListBox1.SelectedIndex, 1) = "selecionado" '<----------Al selecionar se carga "selecinado" en la sedunda columna del array que son las fotos a imprimir

        selecionados.Items.Add(ListBox1.SelectedItem)


        If ARCHIVO.ToLower.Contains(".jpg") Then
            PictureBox1.Image = Bitmap.FromFile(ARCHIVO)
            '
        End If
    End Sub


End Class
