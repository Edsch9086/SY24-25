Imports System.Windows.Media.Media3D

Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Picturebox1.Source = _103c.Source
        Label1.Content = "Main Armament: Bofors L74 105mm
Secondary Armament: 3x 7.62 mg's
Engine: 290 hp (Drive) / 489 hp (Aim/Suspension)
Power/Weight: 18.3 hp/tonne
wedge"

    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs) Handles Button2.Click
        Picturebox1.Source = _122a.Source
        Label1.Content = "Main Armament: Rheinmetall L44 120mm
Secondary Armament: 2x 7.62 mg's
Engine: 1500 hp
Power/Weight: 24.19 hp/tonne
slightly modified Leopard 2A6"
    End Sub

    Private Sub Button3_Click(sender As Object, e As RoutedEventArgs) Handles Button3.Click
        Picturebox1.Source = _123a.Source
        Label1.Content = "Main Armament: Rheinmetall L44 120mm
Secondary Armament:   2x 7.62 mg's
Engine: 1500 hp
Power/ Weight:   24.19 hp/tonne
Soon-to-be in service, currently in testing"
    End Sub
End Class
