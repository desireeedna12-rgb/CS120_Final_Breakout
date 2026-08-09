Imports System.Windows.Threading
Imports System.Windows.Media.Imaging
Class MyWindow



    Dim GameLoop As New DispatcherTimer

    Dim PADDLE_BUFFER As Integer = 15
    Dim PADDLE As New Rectangle()
    Const PADDLE_DISTANCE_FROM_BOTTOM As Double = 50
    Dim CENTER_OF_PADDLE As Double
    Private PADDLE_SPEED As Double = 5
    Dim PADDLE_TRANSLATE As New TranslateTransform(0, 0)
    Private Move_Left As Boolean = False
    Private Move_Right As Boolean



    Sub New()
        InitializeComponent()
        DrawPaddle()
        GameLoop.Interval = TimeSpan.FromMilliseconds(1)
        AddHandler GameLoop.Tick, AddressOf UpdateLoop




        GameLoop.Start()
    End Sub

    Private Sub UpdateLoop(Sender As Object, e As EventArgs)
        MovePaddle()


    End Sub

    Private Sub DrawPaddle()

        Dim imagePath As String =
        IO.Path.Combine(AppContext.BaseDirectory, "IslandPaddle.png")

        Dim paddleImage As New BitmapImage(
       New Uri(imagePath, UriKind.Absolute)
      )


        With PADDLE
            .Fill = New ImageBrush(paddleImage)
            .Stroke = Brushes.Pink
            .StrokeThickness = 2
            .Width = 140
            .Height = 100
            .RenderTransform = PADDLE_TRANSLATE
            CENTER_OF_PADDLE = .Width / 2
        End With

        'Must be set after everything is created
        PADDLE_TRANSLATE.X = (MainCanvas.Width - PADDLE.Width - PADDLE_BUFFER)
        PADDLE_TRANSLATE.Y = MainCanvas.Height - PADDLE.Height - PADDLE_DISTANCE_FROM_BOTTOM
        MainCanvas.Children.Add(PADDLE)
    End Sub
    Private Sub MovePaddle()

        If Move_Left Then
            PADDLE_TRANSLATE.X -= PADDLE_SPEED
        End If

        If Move_Right Then
            PADDLE_TRANSLATE.X += PADDLE_SPEED
        End If

        PADDLE.RenderTransform = PADDLE_TRANSLATE
    End Sub

    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.Key

            Case Key.A
                'Console.WriteLine("<--A was pressed")
                Move_Left = True

            Case Key.W
                'Console.WriteLine("W was pressed")

            Case Key.S
                'Console.WriteLine("S was pressed")

            Case Key.D
                'Console.WriteLine("D was pressed -->")
                Move_Right = True
            Case Key.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub Window_KeyUp(sender As Object, e As KeyEventArgs)
        Select Case e.Key

            Case Key.A
                Move_Left = False

            Case Key.W

            Case Key.S

            Case Key.D
                Move_Right = False

            Case Key.Escape
                Me.Close()

        End Select
    End Sub
End Class
