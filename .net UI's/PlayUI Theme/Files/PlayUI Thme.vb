#Region " Imports "

Imports System.Drawing.Drawing2D
Imports System.ComponentModel

#End Region

'|------DO-NOT-REMOVE------|
'
' Creator: HazelDev
' Site   : HazelDev.com
' Created: 16.Oct.2014
' Changed: 18.Oct.2014
' Version: 1.0.0
'
'|------DO-NOT-REMOVE------|

#Region " Theme Container "

Class PlayUI_ThemeContainer
    Inherits ContainerControl

#Region " Enums "

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
        Block = 3
    End Enum

#End Region
#Region " Variables "

    Private HeaderRect As Rectangle
    Protected State As MouseState
    Private MoveHeight As Integer
    Private MouseP As Point = New Point(0, 0)
    Private Cap As Boolean = False
    Private HasShown As Boolean

#End Region
#Region " Properties "

    Private _Sizable As Boolean = True
    Property Sizable() As Boolean
        Get
            Return _Sizable
        End Get
        Set(ByVal value As Boolean)
            _Sizable = value
        End Set
    End Property

    Private _SmartBounds As Boolean = True
    Property SmartBounds() As Boolean
        Get
            Return _SmartBounds
        End Get
        Set(ByVal value As Boolean)
            _SmartBounds = value
        End Set
    End Property

    Private _RoundCorners As Boolean = True
    Property RoundCorners() As Boolean
        Get
            Return _RoundCorners
        End Get
        Set(ByVal value As Boolean)
            _RoundCorners = value
            Invalidate()
        End Set
    End Property

    Private _IsParentForm As Boolean
    Protected ReadOnly Property IsParentForm As Boolean
        Get
            Return _IsParentForm
        End Get
    End Property

    Protected ReadOnly Property IsParentMdi As Boolean
        Get
            If Parent Is Nothing Then Return False
            Return Parent.Parent IsNot Nothing
        End Get
    End Property

    Private _ControlMode As Boolean
    Protected Property ControlMode() As Boolean
        Get
            Return _ControlMode
        End Get
        Set(ByVal v As Boolean)
            _ControlMode = v
            Invalidate()
        End Set
    End Property

    Private _StartPosition As FormStartPosition
    Property StartPosition As FormStartPosition
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.StartPosition Else Return _StartPosition
        End Get
        Set(ByVal value As FormStartPosition)
            _StartPosition = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.StartPosition = value
            End If
        End Set
    End Property

#End Region
#Region " EventArgs "

    Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
        MyBase.OnParentChanged(e)

        If Parent Is Nothing Then Return
        _IsParentForm = TypeOf Parent Is Form

        If Not _ControlMode Then
            InitializeMessages()

            If _IsParentForm Then
                Me.ParentForm.FormBorderStyle = FormBorderStyle.None
                Me.ParentForm.TransparencyKey = Color.Fuchsia

                If Not DesignMode Then
                    AddHandler ParentForm.Shown, AddressOf FormShown
                End If
            End If
            Parent.BackColor = BackColor
            Parent.MinimumSize = New Size(261, 65)
        End If
    End Sub

    Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        If Not _ControlMode Then HeaderRect = New Rectangle(0, 0, Width - 14, MoveHeight - 7)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)
        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized OrElse _ControlMode) Then
            If HeaderRect.Contains(e.Location) Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(0))
            ElseIf _Sizable AndAlso Not Previous = 0 Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(Previous))
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        Cap = False
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized) Then
            If _Sizable AndAlso Not _ControlMode Then InvalidateMouse()
        End If
        If Cap Then
            Parent.Location = MousePosition - MouseP
        End If
    End Sub

    Protected Overrides Sub OnInvalidated(ByVal e As System.Windows.Forms.InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        ParentForm.Text = Text
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Private Sub FormShown(ByVal sender As Object, ByVal e As EventArgs)
        If _ControlMode OrElse HasShown Then Return

        If _StartPosition = FormStartPosition.CenterParent OrElse _StartPosition = FormStartPosition.CenterScreen Then
            Dim SB As Rectangle = Screen.PrimaryScreen.Bounds
            Dim CB As Rectangle = ParentForm.Bounds
            ParentForm.Location = New Point(SB.Width \ 2 - CB.Width \ 2, SB.Height \ 2 - CB.Width \ 2)
        End If
        HasShown = True
    End Sub

#End Region
#Region " Mouse & Size "

    Private Sub SetState(ByVal current As MouseState)
        State = current
        Invalidate()
    End Sub

    Private GetIndexPoint As Point
    Private B1x, B2x, B3, B4 As Boolean
    Private Function GetIndex() As Integer
        GetIndexPoint = PointToClient(MousePosition)
        B1x = GetIndexPoint.X < 7
        B2x = GetIndexPoint.X > Width - 7
        B3 = GetIndexPoint.Y < 7
        B4 = GetIndexPoint.Y > Height - 7

        If B1x AndAlso B3 Then Return 4
        If B1x AndAlso B4 Then Return 7
        If B2x AndAlso B3 Then Return 5
        If B2x AndAlso B4 Then Return 8
        If B1x Then Return 1
        If B2x Then Return 2
        If B3 Then Return 3
        If B4 Then Return 6
        Return 0
    End Function

    Private Current, Previous As Integer
    Private Sub InvalidateMouse()
        Current = GetIndex()
        If Current = Previous Then Return

        Previous = Current
        Select Case Previous
            Case 0
                Cursor = Cursors.Default
            Case 6
                Cursor = Cursors.SizeNS
            Case 8
                Cursor = Cursors.SizeNWSE
            Case 7
                Cursor = Cursors.SizeNESW
        End Select
    End Sub

    Private Messages(8) As Message
    Private Sub InitializeMessages()
        Messages(0) = Message.Create(Parent.Handle, 161, New IntPtr(2), IntPtr.Zero)
        For I As Integer = 1 To 8
            Messages(I) = Message.Create(Parent.Handle, 161, New IntPtr(I + 9), IntPtr.Zero)
        Next
    End Sub

    Private Sub CorrectBounds(ByVal bounds As Rectangle)
        If Parent.Width > bounds.Width Then Parent.Width = bounds.Width
        If Parent.Height > bounds.Height Then Parent.Height = bounds.Height

        Dim X As Integer = Parent.Location.X
        Dim Y As Integer = Parent.Location.Y

        If X < bounds.X Then X = bounds.X
        If Y < bounds.Y Then Y = bounds.Y

        Dim Width As Integer = bounds.X + bounds.Width
        Dim Height As Integer = bounds.Y + bounds.Height

        If X + Parent.Width > Width Then X = Width - Parent.Width
        If Y + Parent.Height > Height Then Y = Height - Parent.Height

        Parent.Location = New Point(X, Y)
    End Sub

    Private WM_LMBUTTONDOWN As Boolean
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If WM_LMBUTTONDOWN AndAlso m.Msg = 513 Then
            WM_LMBUTTONDOWN = False

            SetState(MouseState.Over)
            If Not _SmartBounds Then Return

            If IsParentMdi Then
                CorrectBounds(New Rectangle(Point.Empty, Parent.Parent.Size))
            Else
                CorrectBounds(Screen.FromControl(Parent).WorkingArea)
            End If
        End If
    End Sub

#End Region

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
    End Sub

    Sub New()
        SetStyle(DirectCast(139270, ControlStyles), True)
        BackColor = Color.FromArgb(43, 46, 50)
        Padding = New Padding(20, 56, 20, 16)
        DoubleBuffered = True
        Dock = DockStyle.Fill
        MoveHeight = 40
        Font = New Font("Segoe UI", 9)
        _RoundCorners = True
        _Sizable = False
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics
        G.Clear(Color.FromArgb(43, 46, 50))

        G.DrawRectangle(New Pen(Color.FromArgb(26, 26, 26)), New Rectangle(0, 0, Width - 1, Height - 1))
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, ClientRectangle.Height - 38), Color.FromArgb(43, 46, 51), Color.FromArgb(35, 37, 40)), New Rectangle(1, 1, Width - 2, ClientRectangle.Height - 38))
        G.DrawLine(New Pen(Color.FromArgb(65, 69, 75)), 1, 1, Width - 2, 1)
        G.DrawLine(New Pen(Color.FromArgb(161, 166, 171)), 1, Height - 37, Width - 2, Height - 37)
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(124, 127, 134), Color.FromArgb(114, 117, 124)), New Rectangle(1, Height - 36, Width - 2, 35))
        G.DrawLine(New Pen(Color.FromArgb(65, 69, 75)), 1, 4, 1, Me.Height - 38)
        G.DrawLine(New Pen(Color.FromArgb(65, 69, 75)), Width - 2, 4, Width - 2, Me.Height - 38)

        If _RoundCorners = True Then

            ' Draw Left upper corner
            G.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 1, 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 1, 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 2, 1, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 3, 1, 1, 1)

            ' Draw right upper corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 3, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 4, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 1, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 2, 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 2, 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 3, 1, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 4, 1, 1, 1)

            ' Draw Left bottom corner
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 4, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 2, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 3, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 2, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 1, Height - 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 1, Height - 4, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 3, Height - 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), 2, Height - 2, 1, 1)

            ' Draw right bottom corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 4, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 2, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 2, Height - 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 2, Height - 4, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 4, Height - 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(26, 26, 26)), Width - 3, Height - 2, 1, 1)
        End If

        ' G.DrawString(Text, New Font("Tahoma", 10.5, FontStyle.Bold), New SolidBrush(Color.FromArgb(129, 151, 172)), New Rectangle(0, 12, Width - 12, Height), New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Near})
    End Sub
End Class

#End Region
#Region " ControlBox "

Public Class PlayUI_ControlBox
    Inherits Control

#Region " Enums "

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
    End Enum

#End Region
#Region " MouseStates "

    Dim State As MouseState = MouseState.None
    Dim X As Integer
    Dim MinBtn As New Rectangle(3, 2, 17, 17)
    Dim CloseBtn As New Rectangle(23, 2, 17, 17)

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        If X > 0 AndAlso X < 17 Then
            FindForm.WindowState = FormWindowState.Minimized
        ElseIf X > 20 AndAlso X < 40 Then
            FindForm.Close()
        End If

        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.Location.X
        Invalidate()
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.UserPaint Or _
          ControlStyles.SupportsTransparentBackColor Or _
          ControlStyles.ResizeRedraw Or _
          ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Font = New Font("Marlett", 7)
        Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Size = New Size(45, 23)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Location = New Point(Parent.Width - 50, 5)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        MyBase.OnPaint(e)
        G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim LGBClose As New LinearGradientBrush(CloseBtn, Color.FromArgb(29, 29, 29), Color.FromArgb(29, 29, 29), 90S)
        G.FillEllipse(LGBClose, CloseBtn)
        G.DrawString("r", New Font("Marlett", 7), New SolidBrush(Color.FromArgb(117, 117, 119)), New Rectangle(26, 8, 0, 0))

        Dim LGBMinimize As New LinearGradientBrush(MinBtn, Color.FromArgb(29, 29, 29), Color.FromArgb(29, 29, 29), 90S)
        G.FillEllipse(LGBMinimize, MinBtn)
        G.DrawString("0", New Font("Marlett", 7), New SolidBrush(Color.FromArgb(117, 117, 119)), New Rectangle(6.5, 8, 0, 0))

        Select Case State
            Case MouseState.None
                Dim xLGBClose As New LinearGradientBrush(CloseBtn, Color.FromArgb(29, 29, 29), Color.FromArgb(29, 29, 29), 90S)
                G.FillEllipse(xLGBClose, CloseBtn)
                G.DrawString("r", New Font("Marlett", 7), New SolidBrush(Color.FromArgb(117, 117, 119)), New Rectangle(26, 8, 0, 0))

                Dim xLGBMinimize As New LinearGradientBrush(MinBtn, Color.FromArgb(29, 29, 29), Color.FromArgb(29, 29, 29), 90S)
                G.FillEllipse(xLGBMinimize, MinBtn)
                G.DrawString("0", New Font("Marlett", 7), New SolidBrush(Color.FromArgb(117, 117, 119)), New Rectangle(6.5, 8, 0, 0))
            Case MouseState.Over
                If X > 23 AndAlso X < 40 Then
                    Dim xLGBClose As New LinearGradientBrush(CloseBtn, Color.FromArgb(37, 37, 37), Color.FromArgb(37, 37, 37), 90S)
                    G.FillEllipse(xLGBClose, CloseBtn)
                    G.DrawString("r", New Font("Marlett", 7), New SolidBrush(Color.FromArgb(117, 117, 119)), New Rectangle(26, 8, 0, 0))
                ElseIf X > 3 AndAlso X < 20 Then
                    Dim xLGBMinimize As New LinearGradientBrush(MinBtn, Color.FromArgb(37, 37, 37), Color.FromArgb(37, 37, 37), 90S)
                    G.FillEllipse(xLGBMinimize, MinBtn)
                    G.DrawString("0", New Font("Marlett", 7), New SolidBrush(Color.FromArgb(117, 117, 119)), New Rectangle(6.5, 8, 0, 0))
                End If
        End Select

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose()
        B.Dispose()
    End Sub
End Class

#End Region
#Region " Header Label "

Class PlayUI_HeaderLabel
    Inherits Label

    Sub New()
        Font = New Font("Arial", 9, FontStyle.Bold)
        ForeColor = Color.FromArgb(253, 254, 255)
        BackColor = Color.Transparent
    End Sub
End Class

#End Region
#Region " Label "

Class PlayUI_Label
    Inherits Label

    Sub New()
        Font = New Font("Arial", 8, FontStyle.Regular)
        ForeColor = Color.FromArgb(116, 119, 124)
        BackColor = Color.Transparent
    End Sub
End Class

#End Region
#Region " Link Label "
Class PlayUI_LinkLabel
    Inherits LinkLabel

    Sub New()
        Font = New Font("Arial", 8, FontStyle.Regular)
        BackColor = Color.Transparent
        LinkColor = Color.FromArgb(115, 118, 125)
        ActiveLinkColor = Color.FromArgb(103, 105, 112)
        VisitedLinkColor = Color.FromArgb(115, 118, 125)
        LinkBehavior = Windows.Forms.LinkBehavior.NeverUnderline
    End Sub
End Class

#End Region
#Region " Separator "

Public Class PlayUI_Separator
    Inherits Control

#Region " Variables "

    Dim myBrush As New SolidBrush(Color.FromArgb(56, 60, 65))
    Dim myPen As New Pen(myBrush)

#End Region

    Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.Size = New Point(120, 10)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.DrawLine(myPen, 0, 5, Width, 5)
    End Sub
End Class

#End Region
#Region " Panel "

Class PlayUI_Panel
    Inherits ContainerControl

    Private Shape As GraphicsPath

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)

        BackColor = Color.Transparent
        Me.Size = New Size(187, 117)
        Padding = New Padding(5, 5, 5, 5)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)

        Shape = New GraphicsPath
        With Shape
            .AddArc(0, 0, 10, 10, 180, 90)
            .AddArc(Width - 11, 0, 10, 10, -90, 90)
            .AddArc(Width - 11, Height - 11, 10, 10, 0, 90)
            .AddArc(0, Height - 11, 10, 10, 90, 90)
            .CloseAllFigures()
        End With
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)

        G.SmoothingMode = SmoothingMode.HighQuality

        G.Clear(Color.Transparent) ' Set control background to transparent
        G.FillPath(New SolidBrush(Color.FromArgb(47, 49, 53)), Shape) ' Draw RTB background
        G.DrawPath(New Pen(Color.FromArgb(37, 38, 41)), Shape) ' Draw border

        G.Dispose()
        e.Graphics.DrawImage(B.Clone(), 0, 0)
        B.Dispose()
    End Sub
End Class

#End Region
#Region " Button Base "

Class PlayUI_ButtonBase
    Inherits ContainerControl

    Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(110, 50)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim LGB1 As New LinearGradientBrush(New Rectangle(0, 0, Width, Height), _
                                            Color.FromArgb(36, 38, 41), _
                                            Color.FromArgb(36, 38, 41), 90.0F)

        G.FillEllipse(LGB1, New Rectangle(0, 9, 30, 30))
        G.FillEllipse(LGB1, New Rectangle(29, 0, 48, 48))
        G.FillEllipse(LGB1, New Rectangle(76, 9, 30, 30))

        LGB1.Dispose()
    End Sub
End Class

#End Region
#Region " Normal Button "

Class PlayUI_Button_N
    Inherits Control

#Region " Variables "

    Private MouseState As Integer
    Private Shape As GraphicsPath
    Private InactiveGB, PressedGB, PressedContourGB As LinearGradientBrush
    Private R1 As Rectangle
    Private P1, P3 As Pen
    Private _TextAlignment As StringAlignment = StringAlignment.Center
    Private _TextColor As Color = Color.FromArgb(150, 150, 150)

#End Region
#Region " Properties "

    Public Property TextAlignment As StringAlignment
        Get
            Return Me._TextAlignment
        End Get
        Set(ByVal value As StringAlignment)
            Me._TextAlignment = value
            Me.Invalidate()
        End Set
    End Property

    Public Overrides Property ForeColor As Color
        Get
            Return Me._TextColor
        End Get
        Set(ByVal value As Color)
            Me._TextColor = value
            Me.Invalidate()
        End Set
    End Property

#End Region
#Region " EventArgs "

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MouseState = 0
        Invalidate()
        MyBase.OnMouseUp(e)
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MouseState = 1
        Invalidate()
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MouseState = 0
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        Invalidate()
        MyBase.OnTextChanged(e)
    End Sub

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or _
                 ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.ResizeRedraw Or _
                 ControlStyles.SupportsTransparentBackColor Or _
                 ControlStyles.UserPaint, True)

        BackColor = Color.Transparent
        DoubleBuffered = True
        Font = New Font("Segoe UI", 8)
        ForeColor = Color.FromArgb(255, 255, 255)
        Size = New Size(42, 24)
        _TextAlignment = StringAlignment.Center
        P1 = New Pen(Color.FromArgb(25, 26, 28)) ' P1 = Border color
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        If Width > 0 AndAlso Height > 0 Then

            Shape = New GraphicsPath
            R1 = New Rectangle(0, 0, Width, Height)

            InactiveGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(31, 31, 31), Color.FromArgb(30, 30, 30), 90.0F)
            PressedGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(26, 26, 26), Color.FromArgb(26, 26, 26), 90.0F)
            PressedContourGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(23, 23, 23), Color.FromArgb(23, 23, 23), 90.0F)

            P3 = New Pen(PressedContourGB)
        End If

        With Shape
            .AddArc(0, 0, 10, 10, 180, 90)
            .AddArc(Width - 11, 0, 10, 10, -90, 90)
            .AddArc(Width - 11, Height - 11, 10, 10, 0, 90)
            .AddArc(0, Height - 11, 10, 10, 90, 90)
            .CloseAllFigures()
        End With

        Invalidate()
        MyBase.OnResize(e)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        With e.Graphics
            .SmoothingMode = SmoothingMode.HighQuality

            Select Case MouseState
                Case 0 'Inactive
                    .FillPath(InactiveGB, Shape) ' Fill button body with InactiveGB color gradient
                    .DrawLine(New Pen(Color.FromArgb(39, 39, 39)), 2, 1, Width - 3, 1)
                    .DrawPath(P1, Shape) ' Draw button border [InactiveGB]              
                    .DrawString(Text, Font, New SolidBrush(ForeColor), R1, New StringFormat() With {.Alignment = _TextAlignment, .LineAlignment = StringAlignment.Center})
                Case 1 'Pressed
                    .FillPath(PressedGB, Shape) ' Fill button body with PressedGB color gradient
                    .DrawPath(P3, Shape) ' Draw button border [PressedGB]
                    .DrawString(Text, Font, New SolidBrush(ForeColor), R1, New StringFormat() With {.Alignment = _TextAlignment, .LineAlignment = StringAlignment.Center})
            End Select
        End With
        MyBase.OnPaint(e)
    End Sub
End Class

#End Region
#Region " Round Button "

Class PlayUI_Button_R
    Inherits Control

#Region " Enums "

    Enum MyRadius
        R12
        R21
    End Enum

#End Region
#Region " Variables "

    Private MouseState As Integer
    Private InactiveGB, PressedGB, PressedContourGB As LinearGradientBrush
    Private P1, P3 As Pen
    Private _Image As Image
    Private _ImageSize As Size
    Private _Radius As MyRadius

#End Region
#Region " Properties "

    Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            If value Is Nothing Then
                _ImageSize = Size.Empty
            Else
                _ImageSize = value.Size
            End If

            _Image = value
            Invalidate()
        End Set
    End Property

    Protected ReadOnly Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
    End Property

    Public Property Radius As MyRadius
        Get
            Return _Radius
        End Get
        Set(value As MyRadius)
            _Radius = value
            Select Case _Radius
                Case MyRadius.R12
                    Size = New Size(25, 25)
                Case MyRadius.R21
                    Size = New Size(44, 44)
            End Select
            Invalidate()
        End Set
    End Property

#End Region
#Region " EventArgs "

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MouseState = 0
        Invalidate()
        MyBase.OnMouseUp(e)
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MouseState = 1
        Invalidate()
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MouseState = 0
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or _
                 ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.ResizeRedraw Or _
                 ControlStyles.SupportsTransparentBackColor Or _
                 ControlStyles.UserPaint, True)

        BackColor = Color.Transparent
        DoubleBuffered = True
        Size = New Size(25, 25)
        P1 = New Pen(Color.FromArgb(116, 119, 126)) ' P1 = Border color
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Select Case _Radius
            Case MyRadius.R12
                Me.Size = New Size(25, 25)
            Case MyRadius.R21
                Me.Size = New Size(44, 44)
        End Select

        InactiveGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(116, 119, 126), Color.FromArgb(116, 119, 126), 90.0F)
        PressedGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(95, 97, 103), Color.FromArgb(95, 97, 103), 90.0F)
        PressedContourGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(95, 97, 103), Color.FromArgb(95, 97, 103), 90.0F)
        P3 = New Pen(PressedContourGB) ' P3 = Border color when button is pressed

        Invalidate()
        MyBase.OnResize(e)
    End Sub
    Private Sub FinishDrawing(ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)
        Dim MyCircle As New Rectangle(center.X / 2, center.Y / 2, radius * 2, radius * 2)

        Select Case MouseState
            Case 0 'Inactive
                g.FillEllipse(InactiveGB, MyCircle)
                g.DrawEllipse(P1, MyCircle)

                If IsNothing(Image) Then
                Else
                    g.DrawImage(_Image, 5, 5, ImageSize.Width, ImageSize.Height)
                End If

            Case 1 'Pressed
                g.FillEllipse(PressedGB, MyCircle)
                g.DrawEllipse(P3, MyCircle)

                If IsNothing(Image) Then
                Else
                    g.DrawImage(_Image, 5, 5, ImageSize.Width, ImageSize.Height)
                End If
        End Select
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        With e.Graphics
            .SmoothingMode = SmoothingMode.HighQuality
            Select Case _Radius
                Case MyRadius.R12
                    FinishDrawing(e.Graphics, New Point(0, 0), 12)
                Case MyRadius.R21
                    FinishDrawing(e.Graphics, New Point(0, 0), 21)
            End Select
        End With
    End Sub
End Class

#End Region
#Region " Star Rating "

Class PlayUI_StarRating
    Inherits UserControl

#Region " Variables "

    Private _ImageSize As Size
    Private _ImageRated As Image
    Private _ImageUnrated As Image
    Private _Stars As Integer = 0
    Private _MaximumStars As Integer = 5
    Private TempStar As Integer = -1

#End Region
#Region " Properties "

    Protected ReadOnly Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
    End Property

    Public Property Stars() As Integer
        Get
            Return Me._Stars
        End Get
        Set(value As Integer)
            If value > _MaximumStars Then
                MsgBox("Value can't be higher than the maximum number of stars!")
            End If
            Me._Stars = value
            Me.Invalidate()
        End Set
    End Property

    Public Property MaximumStars() As Integer
        Get
            Return Me._MaximumStars
        End Get
        Set(value As Integer)
            Me._MaximumStars = value
        End Set
    End Property

    Public Property ImageRated() As Image
        Get
            Return _ImageRated
        End Get
        Set(value As Image)
            If value Is Nothing Then
                _ImageSize = Size.Empty
            Else
                _ImageSize = value.Size
            End If
            _ImageRated = value
            Invalidate()
        End Set
    End Property

    Public Property ImageUnrated() As Image
        Get
            Return _ImageUnrated
        End Get
        Set(value As Image)
            If value Is Nothing Then
                _ImageSize = Size.Empty
            Else
                _ImageSize = value.Size
            End If
            _ImageUnrated = value
            Invalidate()
        End Set
    End Property

#End Region
#Region " EventArgs "

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Dim StarLoc As Double = (e.X + _ImageRated.Width - 5) / _ImageRated.Width
        Dim HoverStar As Integer = Convert.ToInt32(Math.Floor(StarLoc))

        If Not HoverStar.Equals(TempStar) Then
            TempStar = HoverStar
            Me.Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        TempStar = -1
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim StarLoc As Double = (e.X + _ImageRated.Width - 5) / _ImageRated.Width
        Dim StarToAdd As Integer = Convert.ToInt32(Math.Floor(StarLoc))

        If Not StarToAdd.Equals(_Stars) Then
            _Stars = StarToAdd
            If _Stars > _MaximumStars Then
                _Stars = _MaximumStars
            End If
            Me.Invalidate()
        End If
    End Sub

#End Region

    Sub New()
        Size = New Size(82, 17)
        BackColor = Color.Transparent
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics

        If _ImageRated Is Nothing OrElse _ImageUnrated Is Nothing Then
            Return
        End If

        For i As Integer = 0 To _MaximumStars - 1
            If i < (If(TempStar = -1, _Stars, TempStar)) Then
                G.DrawImage(_ImageRated, _ImageRated.Width * i, 0, ImageSize.Width, ImageSize.Height)
            Else
                G.DrawImage(_ImageUnrated, _ImageRated.Width * i, 0, ImageSize.Width, ImageSize.Height)
            End If
        Next
    End Sub
End Class

#End Region
#Region " ProgressBar "

Class PlayUI_ProgressBar
    Inherits Control

#Region " RoundRect "

    Private CreateRoundPath As GraphicsPath

    Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
        CreateRoundPath = New GraphicsPath(FillMode.Winding)
        CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
        CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function

#End Region
#Region " Custom Properties "

    Private _Maximum As Integer = 100
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal V As Integer)
            If V < 1 Then V = 1
            If V < _Value Then _Value = V
            _Maximum = V
            Invalidate()
        End Set
    End Property

    Private _Minimum As Integer
    Public Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            _Minimum = value

            If value > _Maximum Then _Maximum = value
            If value > _Value Then _Value = value

            Invalidate()
        End Set
    End Property

    Private _Value As Integer
    Public Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal V As Integer)
            If V > _Maximum Then V = Maximum
            _Value = V
            Invalidate()
        End Set
    End Property

    Private _ValueColour As Color = Color.FromArgb(42, 119, 220)
    <Category("Colours")>
    Public Property ValueColour As Color
        Get
            Return _ValueColour
        End Get
        Set(value As Color)
            _ValueColour = value
            Invalidate()
        End Set
    End Property

#End Region

    Private Percent As Double

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        Size = New Size(100, 10)
    End Sub

    Public Sub Increment(Value As Integer)
        Me._Value += Value
        Invalidate()
    End Sub

    Public Sub Decrement(Value As Integer)
        Me._Value -= Value
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.graphics
        G.SmoothingMode = SmoothingMode.HighQuality

        Percent = (_Value / _Maximum) * 100

        Dim Slope As Integer = 8
        Dim MyRect As New Rectangle(0, 0, Width - 1, Height - 1)

        Dim BorderPath As GraphicsPath = CreateRound(MyRect, Slope)
        G.FillPath(New SolidBrush(Color.FromArgb(51, 52, 55)), BorderPath)

        Dim ProgressBlend As New ColorBlend(3)
        ProgressBlend.Colors(0) = _ValueColour
        ProgressBlend.Colors(1) = _ValueColour
        ProgressBlend.Colors(2) = _ValueColour
        ProgressBlend.Positions = New Single() {0, 0.5, 1}
        Dim LGB As New LinearGradientBrush(MyRect, Color.Black, Color.Black, 90.0F)
        LGB.InterpolationColors = ProgressBlend

        Dim ProgressRect As New Rectangle(1, 1, CInt(((Width / _Maximum) * _Value) - 3), Height - 3)
        Dim ProgressPath As GraphicsPath = CreateRound(ProgressRect, Slope)

        If Percent >= 1 Then
            G.FillPath(LGB, ProgressPath)
        End If

        Try
            G.DrawPath(New Pen(Color.FromArgb(51, 52, 55)), BorderPath)
        Catch ex As Exception
        End Try
    End Sub
End Class

#End Region