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

Imports System

Namespace GrapeCity.ActiveReports.Samples.CustomTileProviders.My.Resources

    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    Friend Class Resources

        Private Shared resourceMan As Global.System.Resources.ResourceManager

        Private Shared resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>
        Friend Sub New()
            MyBase.New
        End Sub

        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.CustomTileProviders.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = Value
            End Set
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Google Maps ©{0} Google, Please see http://www.google.com/intl/en_us/help/legalnotices_maps.html for more details..
        '''</summary>
        Friend Shared ReadOnly Property GoogleMapsTileProvider_TileProviderCopyright() As String
            Get
                Return ResourceManager.GetString("GoogleMapsTileProvider_TileProviderCopyright", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to The specified MapQuest Maps key is invalid..
        '''</summary>
        Friend Shared ReadOnly Property MapQuestMapsKeyIsInvalid() As String
            Get
                Return ResourceManager.GetString("MapQuestMapsKeyIsInvalid", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Copyright © {0} MapQuest, Inc. (“MapQuest”). Please see http://info.mapquest.com/terms-of-use/ for more details..
        '''</summary>
        Friend Shared ReadOnly Property MapQuestTileProvider_TileProviderCopyright() As String
            Get
                Return ResourceManager.GetString("MapQuestTileProvider_TileProviderCopyright", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to © {0} OpenStreetMap contributors. Please see http://www.openstreetmap.org/copyright for more details..
        '''</summary>
        Friend Shared ReadOnly Property OpenStreetMapTileProvider_TileProviderCopyright() As String
            Get
                Return ResourceManager.GetString("OpenStreetMapTileProvider_TileProviderCopyright", resourceCulture)
            End Get
        End Property
    End Class
End Namespace