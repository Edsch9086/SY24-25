﻿Class MainWindow
    Private Sub fill1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles fill1.MouseDown, fill2.MouseDown, fill3.MouseDown, fill4.MouseDown, fill5.MouseDown, fill6.MouseDown, fill7.MouseDown, fill8.MouseDown

        brush1.Fill = sender.fill
    End Sub

    Private Sub p000_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles p000.MouseDown, p001.MouseDown, p002.MouseDown, p003.MouseDown, p004.MouseDown, p005.MouseDown, p006.MouseDown, p007.MouseDown, p008.MouseDown, p009.MouseDown, p010.MouseDown, p011.MouseDown, p012.MouseDown, p013.MouseDown, p014.MouseDown, p015.MouseDown, p016.MouseDown, p017.MouseDown, p018.MouseDown, p019.MouseDown, p020.MouseDown, p021.MouseDown, p022.MouseDown, p023.MouseDown, p024.MouseDown, p025.MouseDown, p026.MouseDown, p027.MouseDown, p028.MouseDown, p029.MouseDown, p030.MouseDown, p031.MouseDown, p032.MouseDown, p033.MouseDown, p034.MouseDown, p035.MouseDown, p036.MouseDown, p037.MouseDown, p038.MouseDown, p039.MouseDown, p040.MouseDown, p041.MouseDown, p042.MouseDown, p043.MouseDown, p044.MouseDown, p045.MouseDown, p046.MouseDown, p047.MouseDown, p048.MouseDown, p049.MouseDown, p050.MouseDown, p051.MouseDown, p052.MouseDown, p053.MouseDown, p054.MouseDown, p055.MouseDown, p056.MouseDown, p057.MouseDown, p058.MouseDown, p059.MouseDown, p060.MouseDown, p061.MouseDown, p062.MouseDown, p063.MouseDown, p064.MouseDown, p065.MouseDown, p066.MouseDown, p067.MouseDown, p068.MouseDown, p069.MouseDown, p070.MouseDown, p071.MouseDown, p072.MouseDown, p073.MouseDown, p074.MouseDown, p075.MouseDown, p076.MouseDown, p077.MouseDown, p078.MouseDown, p079.MouseDown, p080.MouseDown, p081.MouseDown, p082.MouseDown, p083.MouseDown, p084.MouseDown, p085.MouseDown, p086.MouseDown, p087.MouseDown, p088.MouseDown, p089.MouseDown, p090.MouseDown, p091.MouseDown, p092.MouseDown, p093.MouseDown, p094.MouseDown, p095.MouseDown, p096.MouseDown, p097.MouseDown, p098.MouseDown, p099.MouseDown, p100.MouseDown, p101.MouseDown, p102.MouseDown, p103.MouseDown, p104.MouseDown, p105.MouseDown, p106.MouseDown, p107.MouseDown, p108.MouseDown, p109.MouseDown, p110.MouseDown, p111.MouseDown, p112.MouseDown, p113.MouseDown, p114.MouseDown, p115.MouseDown, p116.MouseDown, p117.MouseDown, p118.MouseDown, p119.MouseDown, p120.MouseDown, p121.MouseDown, p122.MouseDown, p123.MouseDown, p124.MouseDown, p125.MouseDown, p126.MouseDown, p127.MouseDown, p128.MouseDown, p129.MouseDown, p130.MouseDown, p131.MouseDown, p132.MouseDown, p133.MouseDown, p134.MouseDown, p135.MouseDown, p136.MouseDown, p137.MouseDown, p138.MouseDown, p139.MouseDown, p140.MouseDown, p141.MouseDown, p142.MouseDown, p143.MouseDown, p144.MouseDown, p145.MouseDown, p146.MouseDown, p147.MouseDown, p148.MouseDown, p149.MouseDown, p150.MouseDown, p151.MouseDown, p152.MouseDown, p153.MouseDown, p154.MouseDown, p155.MouseDown, p156.MouseDown, p157.MouseDown, p158.MouseDown, p159.MouseDown, p160.MouseDown, p161.MouseDown, p162.MouseDown, p163.MouseDown, p164.MouseDown, p165.MouseDown, p166.MouseDown, p167.MouseDown, p168.MouseDown, p169.MouseDown, p170.MouseDown, p171.MouseDown, p172.MouseDown, p173.MouseDown, p174.MouseDown, p175.MouseDown, p176.MouseDown, p177.MouseDown, p178.MouseDown, p179.MouseDown, p180.MouseDown, p181.MouseDown, p182.MouseDown, p183.MouseDown, p184.MouseDown, p185.MouseDown, p186.MouseDown, p187.MouseDown, p188.MouseDown, p189.MouseDown, p190.MouseDown, p191.MouseDown, p192.MouseDown, p193.MouseDown, p194.MouseDown, p195.MouseDown, p196.MouseDown, p197.MouseDown, p198.MouseDown, p199.MouseDown, p200.MouseDown, p201.MouseDown, p202.MouseDown, p203.MouseDown, p204.MouseDown, p205.MouseDown, p206.MouseDown, p207.MouseDown, p208.MouseDown, p209.MouseDown, p210.MouseDown, p211.MouseDown, p212.MouseDown, p213.MouseDown, p214.MouseDown, p215.MouseDown, p216.MouseDown, p217.MouseDown, p218.MouseDown, p219.MouseDown, p220.MouseDown, p221.MouseDown, p222.MouseDown, p223.MouseDown, p224.MouseDown, p225.MouseDown, p226.MouseDown, p227.MouseDown, p228.MouseDown, p229.MouseDown, p230.MouseDown, p231.MouseDown, p232.MouseDown, p233.MouseDown, p234.MouseDown, p235.MouseDown, p236.MouseDown, p237.MouseDown, p238.MouseDown, p239.MouseDown, p240.MouseDown, p241.MouseDown, p242.MouseDown, p243.MouseDown, p244.MouseDown, p245.MouseDown, p246.MouseDown, p247.MouseDown, p248.MouseDown, p249.MouseDown, p250.MouseDown, p251.MouseDown, p252.MouseDown, p253.MouseDown, p254.MouseDown, p255.MouseDown

        sender.fill = brush1.Fill
    End Sub

    Private Function getRect(i As Integer) As Rectangle
        Dim s As String
        If i < 10 Then
            s = "p00" & i
        ElseIf i < 100 Then

            s = "p0" & i
        Else
            s = "p" & i
        End If
        For Each u In grid1.Children

            If u.name.Startswith(s) Then
                Return u
            End If
        Next
        Return Nothing
    End Function

    Private Sub topbutton_Click(sender As Object, e As RoutedEventArgs) Handles topbutton.Click
        For index = 0 To 127
            getRect(index).Fill = brush1.Fill
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        For index = 128 To 255
            getRect(index).Fill = brush1.Fill
        Next
    End Sub
End Class
