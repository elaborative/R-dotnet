Imports System.Diagnostics

Partial Class admin_Rtest
    Inherits System.Web.UI.Page

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Dim strName As String = ""
        Dim strMax As String = ""
        strName = left(TxtName.Text,20) 
        strMax = cint(TxtValue.Text)

        Dim strReturned = RunRScript("C:\Program Files\R\R-4.0.0\bin\Rscript.exe", "D:\RScripts\randohist.R \""" & strName & "\"" " & strMax & "", "D:\RScripts\")

        LblPlots.Text = "Running R - " & DateTime.Now() & "<br>"
        LblPlots.Text &= "<img src='/RPlots/randhist.png'><br>"
        LblPlots.Text &= "Returned:" & strReturned

    End Sub


    Function RunRScript(rpath, scriptpath, workdir)

        Try
            'rpath = C:\Program Files\R\R-3.4.3\bin\Rscript.exe

            Dim startinfo = New ProcessStartInfo()
            startinfo.FileName = rpath
            startinfo.Arguments = scriptpath
            startinfo.WorkingDirectory = workdir
            startinfo.RedirectStandardOutput = True
            startinfo.CreateNoWindow = True
            startinfo.UseShellExecute = False

            Using proc As Process = New Process()
                proc.StartInfo = startinfo
                proc.Start()
                Return proc.StandardOutput.ReadToEnd()
            End Using

        Catch ex As Exception
            Return "PROCESS ERROR:" & ex.ToString()
        End Try

        Return String.Empty
    End Function
End Class
