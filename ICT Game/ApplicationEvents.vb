Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Sub onLoad() Handles MyBase.Startup
            highscore.TopMost = True
            highscore.StartPosition = FormStartPosition.CenterScreen
            highscore.ControlBox = False
        End Sub
        Private Sub unhandledExceptionHandler(ByVal sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs)
            MsgBox("An unhandled exception occurred in your application, details:" & vbCrLf & e.Exception.ToString, vbCritical, "Unhandled Exception - NUMBERS_APPMAIN")
            Dim p As New Process()
            p.StartInfo.FileName = System.Reflection.Assembly.GetCallingAssembly().Location
            p.Kill()
        End Sub
    End Class
End Namespace
