Public Class Commandline
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ("control") Then
            Process.Start("control")
            TextBox1.Clear()
        Else
            If TextBox1.Text = ("exit") Then
                End
            Else
                If TextBox1.Text = ("chrome") Then
                    Process.Start("chrome.exe")
                    TextBox1.Clear()
                Else
                    If TextBox1.Text = ("tasks") Then
                        Process.Start("taskmgr")
                        TextBox1.Clear()
                    Else
                        If TextBox1.Text = ("regedit") Then
                            Process.Start("regedit")
                            TextBox1.Clear()
                        Else
                            If TextBox1.Text = ("apps") Then
                                Process.Start("appwiz.cpl")
                                TextBox1.Clear()
                            Else
                                If TextBox1.Text = ("brett tech") Then
                                    Dim webaddress As String = "http://www.Brett-TechRepair.Com"
                                    Process.Start(webaddress)
                                    TextBox1.Clear()
                                Else
                                    If TextBox1.Text = ("advanced user") Then
                                        Process.Start("control", "userpasswords2")
                                        TextBox1.Clear()

                                    Else
                                        MsgBox("Invalid Command")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webaddress As String = "http://www.brett-techrepair.com/mycmdcommands.html"
        Process.Start(webaddress)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End

    End Sub
End Class
