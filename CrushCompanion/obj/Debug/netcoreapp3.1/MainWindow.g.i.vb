﻿#ExternalChecksum("..\..\..\MainWindow.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","712B75CEBDA244F2B006CB43A7C81BF84B69CBD3")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CrushCompanion
Imports Hardcodet.Wpf.TaskbarNotification
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Controls.Ribbon
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell
Imports WpfAnimatedGif


'''<summary>
'''MainWindow
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainWindow
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",13)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CurrencyHeader As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",14)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents USD_Button As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",15)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents AUD_Button As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",17)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents PriceColor_Header As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents White_Button As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",19)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Black_Button As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",44)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents image As System.Windows.Controls.Image
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",45)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents priceLabel As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",47)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CLICK_AREA As System.Windows.Shapes.Rectangle
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/CrushCompanion;V0.1.0.0;component/mainwindow.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\MainWindow.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",10)
            AddHandler CType(target,MainWindow).Loaded, New System.Windows.RoutedEventHandler(AddressOf Me.Window_Loaded)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",10)
            AddHandler CType(target,MainWindow).MouseLeftButtonUp, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.Window_MouseLeftButtonUp)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",10)
            AddHandler CType(target,MainWindow).MouseLeftButtonDown, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.Window_MouseLeftButtonDown)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",10)
            AddHandler CType(target,MainWindow).ContextMenuOpening, New System.Windows.Controls.ContextMenuEventHandler(AddressOf Me.Window_ContextMenuOpening)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",10)
            AddHandler CType(target,MainWindow).ContextMenuClosing, New System.Windows.Controls.ContextMenuEventHandler(AddressOf Me.Window_ContextMenuClosing)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.CurrencyHeader = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 3) Then
            Me.USD_Button = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 4) Then
            Me.AUD_Button = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 5) Then
            Me.PriceColor_Header = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 6) Then
            Me.White_Button = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 7) Then
            Me.Black_Button = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 8) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",22)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Checked, New System.Windows.RoutedEventHandler(AddressOf Me.MenuItem_Checked)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",22)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Unchecked, New System.Windows.RoutedEventHandler(AddressOf Me.MenuItem_Unchecked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 9) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",24)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Checked, New System.Windows.RoutedEventHandler(AddressOf Me.followMouseChecked)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",24)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Unchecked, New System.Windows.RoutedEventHandler(AddressOf Me.followMouseUnchecked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 10) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",26)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Checked, New System.Windows.RoutedEventHandler(AddressOf Me.gravityChecked)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",26)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Unchecked, New System.Windows.RoutedEventHandler(AddressOf Me.gravityUnchecked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 11) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",28)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Checked, New System.Windows.RoutedEventHandler(AddressOf Me.stayStillChecked)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\MainWindow.xaml",28)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Unchecked, New System.Windows.RoutedEventHandler(AddressOf Me.stayStillUnchecked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 12) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",31)
            AddHandler CType(target,System.Windows.Controls.MenuItem).Click, New System.Windows.RoutedEventHandler(AddressOf Me.kill)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 13) Then
            Me.image = CType(target,System.Windows.Controls.Image)
            Return
        End If
        If (connectionId = 14) Then
            Me.priceLabel = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 15) Then
            Me.CLICK_AREA = CType(target,System.Windows.Shapes.Rectangle)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

