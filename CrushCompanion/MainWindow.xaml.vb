
Imports System.Runtime.InteropServices
Imports System.Windows.Threading
Imports System.Windows
Imports System.Windows.Forms
Imports DotNetBrowser.WPF
Imports System.Windows.Input
Imports Microsoft.Windows.forms

Imports System.Net
Imports System.IO
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Class MainWindow


    '''''''''''''''' NEW 2022 '''''''''''''''''''''''''''''''''''''''''''
    Dim firstItem
    Dim previousAmount = 999
    Dim selectedCurrency = "usd"
    Dim selectedPriceColor = "white"

    Function json()
        'MyCredentials As System.Net.NetworkCredential           ' define default app credentials
        'MyCredentials = New System.Net.NetworkCredential(userName:="...", password:="...")

        Dim updatedURL = "https://api.coingecko.com/api/v3/simple/price?ids=bitcrush&vs_currencies=selectedCurrency"
        Dim finalURL = updatedURL.Replace("selectedCurrency", selectedCurrency)

        Dim request As WebRequest = WebRequest.Create(finalURL)

        request.Method = "GET"
        ' request.Credentials = MyCredentials                        ' set default credentials
        Dim response As WebResponse = request.GetResponse()         ' fire this puppy off
        Dim inputstream1 As Stream = response.GetResponseStream()   ' define the stream(must be stream
        Dim reader As New StreamReader(inputstream1)                ' get the data stream set
        Dim workspace = reader.ReadToEnd                                ' get all the chucks
        inputstream1.Dispose()                                      ' get rid of the stream, we no longer need it
        reader.Close()                                              ' house keeping
        response.Close()
        Dim objects = JObject.Parse(workspace)
        firstItem = objects.Item("bitcrush").Item(selectedCurrency)
        Debug.WriteLine(firstItem)

        priceLabel.Content = "$" & firstItem

        If firstItem > previousAmount And previousAmount <> 999 Then
            priceLabel.Foreground = Brushes.Green
        ElseIf firstItem < previousAmount And previousAmount <> 999 Then
            priceLabel.Foreground = Brushes.Red
        ElseIf firstItem = previousAmount Then

            If selectedPriceColor = "white" Then
                priceLabel.Foreground = Brushes.White
            ElseIf selectedPriceColor = "black" Then
                priceLabel.Foreground = Brushes.Black
            End If

        End If

            previousAmount = firstItem

    End Function



    'create a Timer on your form and set Interval = 1000 (1 second) - is called at page load! T3
    Public Sub dispatcherTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        CommandManager.InvalidateRequerySuggested()
        Debug.WriteLine("Timer elapsed!")
        json()
    End Sub


    '''''''''''''''' END NEW 2022 '''''''''''''''''''''''''''''''''''''''''''



    Dim followMouse = False
    Dim stayStill = False
    Dim gravity = True
    Dim directionAmount = 0
    Dim mouseLocation As Point


    Dim display1Width As Integer = System.Windows.SystemParameters.WorkArea.Width
    Dim display1Height As Integer = System.Windows.SystemParameters.WorkArea.Height

    Function moveDown()
        Dim currentTopPosition = Me.Top
        If currentTopPosition <= display1Height - 200 And gravity = True Then
            ' Debug.WriteLine(currentTopPosition)
            Me.Top = currentTopPosition + 0.5
            'Threading.Thread.Sleep(100)
            'Debug.WriteLine(currentTopPosition)
            moveDown()
        ElseIf currentTopPosition > display1Height - 250 Then
            moveUp()
        End If
    End Function
    Function moveUp()
        Dim currentTopPosition = Me.Top
        If currentTopPosition > display1Height - 200 Then
            Me.Top = currentTopPosition - 1
            moveUp()
        End If
        If currentTopPosition < display1Height - 250 Then
            moveDown()
        End If
    End Function


    ' tstzzzzz

    Function gravityChecked()
        Debug.WriteLine("Gravity Enabled!")
        gravity = True
        moveDown()
    End Function
    Function gravityUnchecked()
        Debug.WriteLine("Gravity Disabled!")
        gravity = False
    End Function

    Function stayStillChecked()
        Debug.WriteLine("Stay still Enabled!")
        stayStill = True

    End Function
    Function stayStillUnchecked()
        Debug.WriteLine("Stay still Disabled!")
        stayStill = False
    End Function

    ' tstzzzzz

    Dim loadFinished = False
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Me.WindowStyle = 0

        moveDown()

        ' Debug.WriteLine(display1Width.ToString)
        '  Debug.WriteLine(display1Height.ToString)

        json()
        Dim dt As DispatcherTimer = New DispatcherTimer()

        AddHandler dt.Tick, AddressOf dispatcherTimer_Tick

        dt.Interval = New TimeSpan(0, 0, 60) ' 0,0,60 is 60sec

        dt.Start()

        Dim generator As New Random()
        Dim randomvalue As Integer
        randomvalue = generator.Next(1, display1Width)
        ' Debug.WriteLine(" " + randomvalue.ToString())

        Me.Left = randomvalue.ToString()

        NewTimerPls()

        loadFinished = True

    End Sub

    Private Sub Window_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs)
        moveDown()
    End Sub

    Private Sub Window_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)

        Me.DragMove()


    End Sub


    '   Dim currentCreature = 0
    '
    '    Function changeimage()
    '
    ' getRunningProgs()
    '
    '       Dim imageRef = New BitmapImage
    '
    '
    '       If currentCreature = 0 Then
    '       imageRef.BeginInit()
    '       imageRef.UriSource = New Uri("pack://application:,,,/PLACEHOLDER.gif")
    '       imageRef.EndInit()
    '       currentCreature = 1
    '       ElseIf currentCreature = 1 Then
    '       imageRef.BeginInit()
    '       imageRef.UriSource = New Uri("pack://application:,,,/PLACEHOLDER.gif")
    '       imageRef.EndInit()
    '       currentCreature = 2
    '       End If
    '
    '        WpfAnimatedGif.ImageBehavior.SetAnimatedSource(image, imageRef)
    '
    '    End Function

    Dim testid = 0

    Function getRunningProgs()

        For Each proc As Process In Process.GetProcesses
            If proc.MainWindowTitle <> "" Then
                'proc.
                'Debug.WriteLine(proc.ProcessName)
                testid = proc.Id
            End If
        Next


    End Function





    ''''' TIMER

    Private dpTimer As DispatcherTimer

    Public Sub NewTimerPls()
        dpTimer = New DispatcherTimer
        dpTimer.Interval = TimeSpan.FromMilliseconds(1) '5000
        AddHandler dpTimer.Tick, AddressOf TickMe
        dpTimer.Start()
        NewDirTimer()
        NewTimerPls3()
    End Sub

    Private Sub TickMe()
        'Do whatever here 
        'Debug.WriteLine(directionAmount)
        ' dpTimer.Stop()

        Dim mouseIsDown As Boolean = System.Windows.Input.Mouse.LeftButton = MouseButtonState.Pressed
        If mouseIsDown = False And contextOpenBoi = False Then
            Dim currentLeftPosition = Me.Left
            ' Debug.WriteLine(currentLeftPosition)                                           '<<<<<<---- DEBUG LEFT POS
            Me.Left = currentLeftPosition + directionAmount
        End If


        Dim currentTopPosition = Me.Top
        If currentTopPosition < display1Height - 50 Then

            '  Debug.WriteLine("awalys running")     <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< new 2022

            ' Debug.WriteLine(currentTopPosition)
            Dim generator As New Random()
            Dim randomvalue As Decimal
            randomvalue = generator.Next(-0.5, 0.5)
            Me.Top = currentTopPosition + randomvalue
        End If


    End Sub


    ''''' TIMER2222222222222

    Private dpTimer2 As DispatcherTimer
    Public Sub NewDirTimer()
        dpTimer2 = New DispatcherTimer
        dpTimer2.Interval = TimeSpan.FromMilliseconds(200) '5000
        AddHandler dpTimer2.Tick, AddressOf TickMe2
        dpTimer2.Start()
    End Sub

    Private Sub TickMe2()

        Dim generatorz As New Random()
        Dim randomvaluez As Decimal
        randomvaluez = generatorz.Next(200, 1500)
        dpTimer2.Interval = TimeSpan.FromMilliseconds(randomvaluez) '5000

        Dim currentLeftPosition = Me.Left

        If followMouse = False Then
            'Debug.WriteLine(followMouse)
            If currentLeftPosition > 0 And currentLeftPosition < display1Width - 250 And stayStill = False Then     '''' specified image size here
                Dim generator As New Random()
                Dim randomvalue As Decimal
                randomvalue = generator.Next(-2, 3)
                directionAmount = randomvalue
            ElseIf currentLeftPosition <= 0 And stayStill = False Then
                Dim generator As New Random()
                Dim randomvalue As Decimal
                randomvalue = generator.Next(3, 5)
                directionAmount = randomvalue
            ElseIf currentLeftPosition > display1Width - 250 And stayStill = False Then '''' specified image size here
                directionAmount = -5
            End If
        ElseIf followMouse = True Then  '''' folooow moouseee hereeee ''''''''''''''''''''''''''''

            '  Dim generatorx As New Random()
            '  Dim randomvaluex As Decimal
            ' randomvaluex = generatorx.Next(50, 100)
            ' dpTimer2.Interval = TimeSpan.FromMilliseconds(randomvaluex)

            '   Debug.WriteLine(mouseLocation.X)
            If mouseLocation.X >= 125 And stayStill = False Then     '''' specified image size here (125 - half image)
                directionAmount = mouseLocation.X * 0.02 ' was 5
            End If
            If mouseLocation.X < 0 And stayStill = False Then     '''' specified image size here (125 - half image)
                Dim tempAmount = mouseLocation.X * 0.02
                directionAmount = tempAmount
            End If
        End If

        If stayStill = True Then
            directionAmount = 0
        End If



    End Sub


    ''''' TIMER 333 for cursorFollow

    Private dpTimer3 As DispatcherTimer

    Public Sub NewTimerPls3()
        dpTimer3 = New DispatcherTimer
        dpTimer3.Interval = TimeSpan.FromMilliseconds(100)
        AddHandler dpTimer3.Tick, AddressOf TickMe3
        dpTimer3.Start()
    End Sub

    Dim contextOpenBoi = False
    Private Sub TickMe3()
        'Do whatever here 
        ' dpTimer.Stop()

        Dim mouseIsDown As Boolean = System.Windows.Input.Mouse.LeftButton = MouseButtonState.Pressed

        If contextOpenBoi = False And mouseIsDown = False Then
            Mouse.Capture(Me)
            mouseLocation = Mouse.GetPosition(Me)
            ReleaseMouseCapture()

            'Debug.WriteLine(mouseLocation)  ''' BEDUGE MOSUE LCAOTOIUN
        End If

    End Sub

    Function kill()
        System.Windows.Application.Current.Shutdown()
    End Function

    Private Sub Window_ContextMenuOpening(sender As Object, e As ContextMenuEventArgs)
        contextOpenBoi = True
    End Sub

    Private Sub Window_ContextMenuClosing(sender As Object, e As ContextMenuEventArgs)
        contextOpenBoi = False
    End Sub


    Private Sub followMouseChecked(sender As Object, e As RoutedEventArgs)
        followMouse = True
        '  Debug.WriteLine("follow!")
    End Sub
    Private Sub followMouseUnchecked(sender As Object, e As RoutedEventArgs)
        followMouse = False
    End Sub

    Private Sub CLICK_AREA_MouseEnter(sender As Object, e As MouseEventArgs) Handles CLICK_AREA.MouseEnter
        priceLabel.Opacity = 1
    End Sub

    Private Sub CLICK_AREA_MouseLeave(sender As Object, e As MouseEventArgs) Handles CLICK_AREA.MouseLeave
        priceLabel.Opacity = 0.6
    End Sub

    Private Sub USD_Button_Click(sender As Object, e As RoutedEventArgs) Handles USD_Button.Click
        CurrencyHeader.Header = "Currency [USD]"
        selectedCurrency = "usd"
        json()
    End Sub

    Private Sub AUD_Button_Click(sender As Object, e As RoutedEventArgs) Handles AUD_Button.Click
        CurrencyHeader.Header = "Currency [AUD]"
        selectedCurrency = "aud"
        json()
    End Sub

    Private Sub Black_Button_Click(sender As Object, e As RoutedEventArgs) Handles Black_Button.Click
        PriceColor_Header.Header = "Price color [B]"
        priceLabel.Foreground = Brushes.Black
        selectedPriceColor = "black"
    End Sub

    Private Sub White_Button_Click(sender As Object, e As RoutedEventArgs) Handles White_Button.Click
        PriceColor_Header.Header = "Price color [W]"
        priceLabel.Foreground = Brushes.White
        selectedPriceColor = "white"
    End Sub


    Private Sub MenuItem_Checked(sender As Object, e As RoutedEventArgs)
        If loadFinished = True Then
            priceLabel.Visibility = Visibility.Visible
        End If
    End Sub

    Private Sub MenuItem_Unchecked(sender As Object, e As RoutedEventArgs)
        priceLabel.Visibility = Visibility.Hidden
    End Sub
End Class