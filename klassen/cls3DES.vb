Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Friend Class cTripleDES

    ' define the triple des provider
    Private m_des As New TripleDESCryptoServiceProvider

    ' define the string handler
    Private m_utf8 As New UTF8Encoding

    ' define the local property arrays
    'Private m_key() As Byte
    'Private m_iv() As Byte
    Private m_key As String = ""
    Private m_iv As String = ""
    Public Sub New(ByVal key As String, iv As String)
        Me.m_key = key
        Me.m_iv = iv
        m_des.Mode = CipherMode.CBC
    End Sub

    'Public Function Encrypt(ByVal input() As Byte) As Byte()
    '    Return Transform(input, m_des.CreateEncryptor(m_key, m_iv))
    'End Function

    'Public Function Decrypt(ByVal input() As Byte) As Byte()
    '    Return Transform(input, m_des.CreateDecryptor(m_key, m_iv))
    'End Function

    'Public Function Encrypt(ByVal text As String) As String
    '    Dim input() As Byte = m_utf8.GetBytes(text)
    '    Dim output() As Byte = Transform(input,
    '                    m_des.CreateEncryptor(m_key, m_iv))
    '    Return Convert.ToBase64String(output)
    'End Function

    'Public Function Decrypt(ByVal text As String) As String
    '    Dim input() As Byte = Convert.FromBase64String(text)
    '    Dim output() As Byte = Transform(input,
    '                     m_des.CreateDecryptor(m_key, m_iv))
    '    Return m_utf8.GetString(output)
    'End Function

    'Private Function Transform(ByVal input() As Byte,
    '    ByVal CryptoTransform As ICryptoTransform) As Byte()
    '    ' create the necessary streams
    '    Dim memStream As MemoryStream = New MemoryStream
    '    Dim cryptStream As CryptoStream = New _
    '        CryptoStream(memStream, CryptoTransform,
    '        CryptoStreamMode.Write)

    '    ' transform the bytes as requested
    '    cryptStream.Write(input, 0, input.Length)
    '    cryptStream.FlushFinalBlock()
    '    ' Read the memory stream and convert it back into byte array
    '    memStream.Position = 0
    '    Dim result(CType(memStream.Length - 1, System.Int32)) As Byte
    '    memStream.Read(result, 0, CType(result.Length, System.Int32))
    '    ' close and release the streams
    '    memStream.Close()
    '    cryptStream.Close()
    '    ' hand back the encrypted buffer
    '    Return result
    'End Function

    Public Function Encrypt2(encrypt As String) As String
        Dim sa As SymmetricAlgorithm = SymmetricAlgorithm.Create("TripleDES")

        sa.Key = Convert.FromBase64String(Me.m_key)
        sa.IV = Convert.FromBase64String(Me.m_iv)

        Dim inputByteArray() As Byte = Encoding.ASCII.GetBytes(encrypt)
        Dim MS As MemoryStream = New MemoryStream()
        Dim trans As ICryptoTransform = sa.CreateEncryptor()
        Dim buf(2049) As Byte
        Dim cs As CryptoStream = New CryptoStream(MS, trans, CryptoStreamMode.Write)
        cs.Write(inputByteArray, 0, inputByteArray.Length)
        cs.FlushFinalBlock()
        Return Convert.ToBase64String(MS.ToArray())
    End Function

    Public Function Decrypt2(encryptedValue As String) As String
        Dim tripleDESKey As SymmetricAlgorithm = SymmetricAlgorithm.Create("TripleDES")
        tripleDESKey.Key = Convert.FromBase64String(Me.m_key)
        tripleDESKey.IV = Convert.FromBase64String(Me.m_iv)

        Dim encryptedStream As MemoryStream = New MemoryStream()

        encryptedStream.Write(Convert.FromBase64String(encryptedValue), 0,
    Convert.FromBase64String(encryptedValue).Length)
        encryptedStream.Position = 0
        Dim cs As CryptoStream = New CryptoStream(encryptedStream,
    tripleDESKey.CreateDecryptor(), CryptoStreamMode.Read)

        Dim decryptedStream As MemoryStream = New MemoryStream()

        Dim buf(2049) As Byte
        Dim bytesRead As Integer = 0
        bytesRead = cs.Read(buf, 0, buf.Length)
        While ((bytesRead > 0))
            decryptedStream.Write(buf, 0, bytesRead)
            bytesRead = cs.Read(buf, 0, buf.Length)
        End While

        Return Encoding.ASCII.GetString(decryptedStream.ToArray())
    End Function

End Class