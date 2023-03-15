Imports System.IO
Imports System.Security
Imports Microsoft.Win32

Module mod_webcontroll_ie
    Public Enum BrowserEmulationVersion
        standard = 0
        Version7 = 7000
        Version8 = 8000
        Version8Standards = 8888
        Version9 = 9000
        Version9Standards = 9999
        Version10 = 10000
        Version10Standards = 10001
        Version11 = 11000
        Version11Edge = 11001
    End Enum


    Dim InternetExplorerRootKey As String = "Software\Microsoft\Internet Explorer"
    Dim BrowserEmulationKey As String = InternetExplorerRootKey & "\Main\FeatureControl\FEATURE_BROWSER_EMULATION"

    Public Function GetInternetExplorerMajorVersion() As Integer
        Dim result As Integer = 0

        Try
            Dim key As RegistryKey
            key = Registry.CurrentUser.OpenSubKey(InternetExplorerRootKey)
            Dim value As Object

            'If Not key = Nothing Then

            If Not key.GetValue("svcVersion") = "" Then
                value = key.GetValue("svcVersion")
            Else
                value = key.GetValue("Version")
            End If

            If Not value = "" Then
                Dim strVersion As String = ""
                Dim separator As Integer = 0
                strVersion = value.ToString()
                separator = strVersion.IndexOf(".")
                If Not separator = -1 Then
                    result = strVersion.Substring(0, separator)

                End If
            End If

            'End If

            Return result

        Catch ex As SecurityException
            Call debug_message(ex, "SetBrowserEmulationVersion - SecurityException")
        Catch ex As UnauthorizedAccessException
            Call debug_message(ex, "SetBrowserEmulationVersion - UnauthorizedAccessException ")
        Catch ex As Exception
            Call debug_message(ex, "SetBrowserEmulationVersion")
        End Try
    End Function

    Public Function GetBrowserEmulationVersion() As BrowserEmulationVersion

        Dim result As BrowserEmulationVersion
        result = BrowserEmulationVersion.standard
        Try
            Dim key As RegistryKey

            '# BAUM prüfen und anlegen
            If RegKeyNameExists(RegistryHive.CurrentUser, "Software\Microsoft\Internet Explorer\Main\FeatureControl\", "") = False Then
                Registry.CurrentUser.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl")
                'key = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\")
                'key.CreateSubKey("FeatureControl")

                Registry.CurrentUser.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION")

                'key = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\")
                'key.CreateSubKey("FEATURE_BROWSER_EMULATION")
            Else
                If RegKeyNameExists(RegistryHive.CurrentUser, "Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", "") = False Then
                    Registry.CurrentUser.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION")
                    'key = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\")
                    'key.CreateSubKey("FEATURE_BROWSER_EMULATION")
                End If
            End If

            key = Registry.CurrentUser.OpenSubKey(BrowserEmulationKey, True)

            If Not key Is Nothing Then
                Dim programName As String = ""
                Dim value As Object

                programName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
                value = key.GetValue(programName)


                result = DirectCast(Convert.ToInt32(value), BrowserEmulationVersion)
            Else

            End If

            Return result

        Catch ex As SecurityException
            Call debug_message(ex, "GetBrowserEmulationVersion - SecurityException")
        Catch ex As UnauthorizedAccessException
            Call debug_message(ex, "GetBrowserEmulationVersion - UnauthorizedAccessException ")
        Catch ex As Exception
            Call debug_message(ex, "GetBrowserEmulationVersion")
        End Try


    End Function
    Public Function SetBrowserEmulationVersion(BrowserEmulationVersion As BrowserEmulationVersion) As Boolean
        Dim result As Boolean
        Dim programName As String = ""

        result = False

        Try

            Dim key As RegistryKey
            key = Registry.CurrentUser.OpenSubKey(BrowserEmulationKey, True)

            If Not key Is Nothing Then

                programName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)


                If Not BrowserEmulationVersion = BrowserEmulationVersion.standard Then
                    key.SetValue(programName, BrowserEmulationVersion, RegistryValueKind.DWord)
                Else
                    key.DeleteValue(programName, False)
                End If

            End If

            result = True

        Catch ex As SecurityException
            Call debug_message(ex, "SetBrowserEmulationVersion")
        Catch ex As UnauthorizedAccessException
            Call debug_message(ex, "SetBrowserEmulationVersion")
        End Try

        Return result
    End Function

    Public Function SetBrowserEmulationVersion() As Boolean
        Dim ieVersion As Integer
        Dim emulationCode As BrowserEmulationVersion
        ieVersion = GetInternetExplorerMajorVersion()
        If ieVersion >= 11 Then
            emulationCode = BrowserEmulationVersion.Version11
        Else
            Select Case ieVersion
                Case 11
                    emulationCode = BrowserEmulationVersion.Version11
                Case 10
                    emulationCode = BrowserEmulationVersion.Version10
                Case 9
                    emulationCode = BrowserEmulationVersion.Version9
                Case 8
                    emulationCode = BrowserEmulationVersion.Version7
                Case Else

                    emulationCode = BrowserEmulationVersion.Version7
            End Select
        End If
        Return SetBrowserEmulationVersion(emulationCode)
    End Function
    Public Function IsBrowserEmulationSet() As Boolean

        Select Case GetBrowserEmulationVersion()
            Case BrowserEmulationVersion.standard
                Return False
            Case Else
                Return True
        End Select

    End Function

    Private Function RegKeyNameExists(ByVal hive As RegistryHive,
                                  ByVal path As String,
                                  ByVal keyName As String) As Boolean
        Dim regKey As RegistryKey
        Select Case hive
            Case RegistryHive.CurrentUser
                regKey = Registry.CurrentUser.OpenSubKey(path)  ' CurrentUser
            Case RegistryHive.LocalMachine
                regKey = Registry.LocalMachine.OpenSubKey(path) ' LocalMachine
            Case Else
                ' Throw New ArgumentException("Nur HKLM und HKCU sind erlaubt")
                Return False
        End Select

        If regKey Is Nothing Then
            Return False
        Else
            Return True
        End If

        If regKey Is Nothing Then Return False ' Schlüssel nicht vorhanden
        For Each regKeyName As String In regKey.GetValueNames()
            If regKeyName.Trim.ToUpper = keyName.Trim.ToUpper Then Return True ' Gefunden
        Next
        Return False ' Nicht gefunden
    End Function

End Module
