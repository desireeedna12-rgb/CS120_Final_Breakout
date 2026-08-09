Imports System.Windows.Threading
Class MyWindow



    Dim GameLoop As New DispatcherTimer

    Sub New()
        InitializeComponent()
        GameLoop.Interval = TimeSpan.FromMilliseconds(1)
        AddHandler GameLoop.Tick, AddressOf UpdateLoop




        GameLoop.Start()
    End Sub

    Private Sub UpdateLoop(Sender As Object, e As EventArgs)



    End Sub





End Class
