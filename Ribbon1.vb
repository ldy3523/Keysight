Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click, Button2.Click
        MsgBox（"FSDFSDF"）
    End Sub

    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs)

    End Sub

    Private Sub Button2_Disposed(sender As Object, e As EventArgs) Handles Button2.Disposed

    End Sub
End Class
