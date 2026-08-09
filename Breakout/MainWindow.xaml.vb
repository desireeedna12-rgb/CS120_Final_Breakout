Imports System.Windows.Threading
Imports System.Windows.Media.Imaging
Imports System.Drawing.Text
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

    Private BALL As New Ellipse
    Private BALL_BUFFER As Double = 5
    Private BALL_TRANSLATE As New TranslateTransform(0, 0)
    Private BALL_SPEED_Y As Double = 5
    Private BALL_SPEED_X As Double = 5

    Sub New()
        InitializeComponent()
        DrawPaddle()
        DrawBall()
        GameLoop.Interval = TimeSpan.FromMilliseconds(1)
        AddHandler GameLoop.Tick, AddressOf UpdateLoop

        GameLoop.Start()
    End Sub

    Private Sub UpdateLoop(Sender As Object, e As EventArgs)
        MovePaddle()
        MoveBall()
        Check_Collision()

    End Sub

    Private Sub Check_Collision()

        'Retrieve the coordinate of the ball's postion
        Dim pt As Point = New Point(BALL_TRANSLATE.X, BALL_TRANSLATE.Y)
        VisualTreeHelper.HitTest(MainCanvas, Nothing, New HitTestResultCallback(AddressOf MyHitTestResult), New PointHitTestParameters(pt))




    End Sub
    Public Function MyHitTestResult(ByVal result As HitTestResult) As HitTestResultBehavior

        If result.VisualHit.GetType() Is GetType(Rectangle) Then
            ' Hits the paddle here
            BALL_SPEED_Y *= -1
            'Code directional ball
            'check distance of ball from center of paddle
            Dim centerOfPaddleX As Double = PADDLE_TRANSLATE.X + CENTER_OF_PADDLE
            Dim ballDistFromPaddleCenterX As Double = BALL_TRANSLATE.X - centerOfPaddleX
            'will determine the angle the ball will move as it is hit by the paddle
            BALL_SPEED_X += ballDistFromPaddleCenterX * 0.05

        End If

        Return HitTestResultBehavior.Continue
    End Function

    Private Sub DrawBall()

        Dim imagePath As String =
        IO.Path.Combine(AppContext.BaseDirectory, "IslandBall.png")

        Dim ballImage As New BitmapImage(
        New Uri(imagePath, UriKind.Absolute))

        With BALL
            .Fill = New ImageBrush(ballImage)
            .StrokeThickness = 2
            .Stroke = Brushes.Pink
            .Width = 28
            .Height = 28
            .RenderTransform = BALL_TRANSLATE
        End With

        BALL_TRANSLATE.X = (MainCanvas.Width / 2)
        BALL_TRANSLATE.Y = MainCanvas.Height / 2
        MainCanvas.Children.Add(BALL)
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
    Private Sub MoveBall()
        BALL_TRANSLATE.X += BALL_SPEED_X
        BALL_TRANSLATE.Y += BALL_SPEED_Y
        BALL.RenderTransform = BALL_TRANSLATE
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
