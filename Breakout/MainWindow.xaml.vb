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

    Private WALL_TOP As Double = 0
    Private WALL_LEFT As Double = 0
    Private WALL_RIGHT As Double = 0
    Private WALL_BOTTOM As Double = 0

    'Brick system
    Private BRICKS As New List(Of Rectangle)

    'Score system
    Private SCORE As Integer = 0

    'Lives system
    Private LIVES As Integer = 3

    Private collisionCooldown As Integer = 0


    Sub New()
        InitializeComponent()
        DrawPaddle()
        DrawBall()
        DrawBricks()
        SETWALLS()
        GameLoop.Interval = TimeSpan.FromMilliseconds(16)
        AddHandler GameLoop.Tick, AddressOf UpdateLoop

        GameLoop.Start()
    End Sub
    Private Sub DrawBricks()

        Dim brickWidth As Double = 70
        Dim brickHeight As Double = 25
        Dim spacing As Double = 10

        Dim rows As Integer = 6
        Dim columns As Integer = 5

        Dim startX As Double = 40
        Dim startY As Double = 60

        For row As Integer = 0 To rows - 1

            For column As Integer = 0 To columns - 1

                Dim brick As New Rectangle()

                brick.Width = brickWidth
                brick.Height = brickHeight

                Select Case row

                    Case 0
                        brick.Fill = Brushes.DeepPink

                    Case 1
                        brick.Fill = Brushes.Orange

                    Case 2
                        brick.Fill = Brushes.Gold

                    Case 3
                        brick.Fill = Brushes.Green

                    Case 4
                        brick.Fill = Brushes.Blue

                    Case 5
                        brick.Fill = Brushes.Purple

                End Select
                brick.Stroke = System.Windows.Media.Brushes.White
                brick.StrokeThickness = 2

                brick.Tag = 0
                brick.Opacity = 1.0

                Canvas.SetLeft(brick, startX + column * (brickWidth + spacing))
                Canvas.SetTop(brick, startY + row * (brickHeight + spacing))

                MainCanvas.Children.Add(brick)

                BRICKS.Add(brick)

            Next

        Next

    End Sub

    Private Sub HitBrick(brick As Rectangle)

        Dim hits As Integer = CInt(brick.Tag)

        hits += 1
        brick.Tag = hits

        Select Case hits

            Case 1
                ' First hit
                brick.Opacity = 0.7

            Case 2
                ' Second hit
                brick.Opacity = 0.4

            Case 3
                ' Third hit
                brick.Opacity = 0.2

            Case Else
                ' Fourth hit removes the brick
                MainCanvas.Children.Remove(brick)
                BRICKS.Remove(brick)

                SCORE += 10
                ScoreText.Text = "Score: " & SCORE

        End Select

    End Sub
    Private Sub UpdateLoop(Sender As Object, e As EventArgs)

        If collisionCooldown > 0 Then
            collisionCooldown -= 1
        End If

        MovePaddle()
        MoveBall()
        Check_Collision()

    End Sub

    Private Sub Check_Collision()
        ' Create the ball collision rectangle
        Dim ballRect As New Rect(
    BALL_TRANSLATE.X,
    BALL_TRANSLATE.Y,
    BALL.Width,
    BALL.Height)

        ' Check paddle collision
        Dim paddleRect As New Rect(
    PADDLE_TRANSLATE.X,
    PADDLE_TRANSLATE.Y,
    PADDLE.Width,
    PADDLE.Height)

        If collisionCooldown = 0 AndAlso
   BALL_SPEED_Y > 0 AndAlso
   ballRect.IntersectsWith(paddleRect) Then

            ' Bounce upward
            BALL_SPEED_Y = -Math.Abs(BALL_SPEED_Y)

            ' Move ball slightly above paddle so it does not collide repeatedly
            BALL_TRANSLATE.Y = PADDLE_TRANSLATE.Y - BALL.Height - 1

            ' Directional paddle bounce
            Dim centerOfPaddleX As Double =
        PADDLE_TRANSLATE.X + CENTER_OF_PADDLE

            Dim ballCenterX As Double =
        BALL_TRANSLATE.X + (BALL.Width / 2)

            Dim ballDistFromPaddleCenterX As Double =
        ballCenterX - centerOfPaddleX

            BALL_SPEED_X +=
        ballDistFromPaddleCenterX / PADDLE_BUFFER

        End If

        ' Check brick collisions
        For i As Integer = BRICKS.Count - 1 To 0 Step -1

            Dim brick As Rectangle = BRICKS(i)

            Dim brickRect As New Rect(
                Canvas.GetLeft(brick),
                Canvas.GetTop(brick),
                brick.Width,
                brick.Height)

            If collisionCooldown = 0 AndAlso ballRect.IntersectsWith(brickRect) Then

                ' Bounce the ball
                BALL_SPEED_Y *= -1

                ' Fade/damage the brick
                HitBrick(brick)

                ' Prevent repeated collision with same brick
                collisionCooldown = 5

                Exit For

            End If

        Next
        If BALL_TRANSLATE.Y < WALL_TOP And BALL_SPEED_Y < 0 Then
            BALL_SPEED_Y *= -1

        End If

        If BALL_TRANSLATE.X <= WALL_LEFT And BALL_SPEED_X < 0 Then
            BALL_SPEED_X *= -1
        End If

        If BALL_TRANSLATE.X >= WALL_RIGHT And BALL_SPEED_X > 0 Then
            BALL_SPEED_X *= -1
        End If

        If BALL_TRANSLATE.Y > WALL_BOTTOM Then


            ' Lose one life
            LIVES -= 1
            LivesText.Text = "Lives: " & New String("♥"c, LIVES)

            If LIVES > 0 Then

                ' Reset ball safely above the bottom
                BALL_TRANSLATE.X = 250
                BALL_TRANSLATE.Y = 150

                ' Send ball upward
                BALL_SPEED_X = 5
                BALL_SPEED_Y = -5

            Else

                ' Stop the game when lives reach zero
                GameLoop.Stop()
                MessageBox.Show("Game Over! Final Score: " & SCORE)

            End If


        End If


    End Sub
    Public Function MyHitTestResult(ByVal result As HitTestResult) As HitTestResultBehavior

        If result.VisualHit.GetType() Is GetType(Rectangle) Then

            Dim hitRectangle As Rectangle = DirectCast(result.VisualHit, Rectangle)

            If hitRectangle Is PADDLE Then

                ' Hits the paddle
                BALL_SPEED_Y *= -1

                ' Code directional ball
                ' Check distance of ball from center of paddle
                Dim centerOfPaddleX As Double = PADDLE_TRANSLATE.X + CENTER_OF_PADDLE
                Dim ballDistFromPaddleCenterX As Double = BALL_TRANSLATE.X - centerOfPaddleX

                ' Will determine the angle the ball takes after hitting paddle
                BALL_SPEED_X += ballDistFromPaddleCenterX / PADDLE_BUFFER

            ElseIf BRICKS.Contains(hitRectangle) Then

                ' Bounce the ball
                BALL_SPEED_Y *= -1

                ' Fade the brick instead of removing it immediately
                HitBrick(hitRectangle)

                Return HitTestResultBehavior.Stop

            End If

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
            .Width = 26
            .Height = 26
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
            .Height = 55
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
    Private Sub SETWALLS()
        WALL_RIGHT = MainCanvas.Width - (BALL.Width + BALL_BUFFER)
        WALL_TOP += BALL.Height
        WALL_BOTTOM = MainCanvas.Height

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
