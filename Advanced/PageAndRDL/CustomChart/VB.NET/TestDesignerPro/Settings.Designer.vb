﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0"),
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
Partial Friend NotInheritable Class Settings
    Inherits Global.System.Configuration.ApplicationSettingsBase

    Private Shared defaultInstance As Settings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region

    Public Shared ReadOnly Property [Default]() As Settings
        Get

#If _MyType = "WindowsForms" Then
            If Not addedHandler Then
                SyncLock addedHandlerLockObject
                    If Not addedHandler Then
                        AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                        addedHandler = True
                    End If
                End SyncLock
            End If
#End If
            Return defaultInstance
        End Get
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property RecentFiles() As Global.System.Collections.Specialized.StringCollection
        Get
            Return CType(Me("RecentFiles"), Global.System.Collections.Specialized.StringCollection)
        End Get
        Set
            Me("RecentFiles") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("1024, 768")>
    Public Property WindowSize() As Global.System.Drawing.Size
        Get
            Return CType(Me("WindowSize"), Global.System.Drawing.Size)
        End Get
        Set
            Me("WindowSize") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("30, 30")>
    Public Property WindowPosition() As Global.System.Drawing.Point
        Get
            Return CType(Me("WindowPosition"), Global.System.Drawing.Point)
        End Get
        Set
            Me("WindowPosition") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("268")>
    Public Property RightPanelWidth() As Integer
        Get
            Return CType(Me("RightPanelWidth"), Integer)
        End Get
        Set
            Me("RightPanelWidth") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("1")>
    Public Property ActiveRightTab() As Integer
        Get
            Return CType(Me("ActiveRightTab"), Integer)
        End Get
        Set
            Me("ActiveRightTab") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("295")>
    Public Property LeftPanelWidth() As Integer
        Get
            Return CType(Me("LeftPanelWidth"), Integer)
        End Get
        Set
            Me("LeftPanelWidth") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
    Public Property IsGroupEditorActive() As Boolean
        Get
            Return CType(Me("IsGroupEditorActive"), Boolean)
        End Get
        Set
            Me("IsGroupEditorActive") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
    Public Property IsReportExplorerActive() As Boolean
        Get
            Return CType(Me("IsReportExplorerActive"), Boolean)
        End Get
        Set
            Me("IsReportExplorerActive") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
    Public Property IsLayersListActive() As Boolean
        Get
            Return CType(Me("IsLayersListActive"), Boolean)
        End Get
        Set
            Me("IsLayersListActive") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
    Public Property IsWindowMaximized() As Boolean
        Get
            Return CType(Me("IsWindowMaximized"), Boolean)
        End Get
        Set
            Me("IsWindowMaximized") = Value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty

        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>
        Friend ReadOnly Property Settings() As GrapeCity.ActiveReports.Samples.Radar.Settings
            Get
                Return GrapeCity.ActiveReports.Samples.Radar.Settings.Default
            End Get
        End Property
    End Module
End Namespace
