Imports com.paypal.soap.api
Imports com.paypal.sdk.services
Imports com.paypal.sdk.profiles

Public Class clsPaypal

    Public API_Username As String
    Public API_Passwort As String
    Public API_Signature As String

    Dim API As IAPIProfile = ProfileFactory.createSignatureAPIProfile()

    '########################################################################
    '# >> Transaktionen abrufen 
    '########################################################################
    Public Function getTransaktions(ByRef lvw As ListView, ByVal dtPicker As DateTimePicker) As Boolean

        Dim caller As New CallerServices()

        API.APIUsername = API_Username
        API.APIPassword = API_Passwort
        API.APISignature = API_Signature
        API.Environment = "live"
        caller.APIProfile = API

        Dim concreteRequest As New TransactionSearchRequestType()
        Dim endDate As Date
        Dim startDate As Date

        startDate = dtPicker.Value

        concreteRequest.StartDate = startDate
        concreteRequest.EndDate = endDate.AddHours(23).AddMinutes(59).AddSeconds(59)
        concreteRequest.EndDateSpecified = True

        Dim concreteResponse As New TransactionSearchResponseType
        Dim bError As Boolean = False
        concreteResponse = caller.Call("TransactionSearch", concreteRequest)

        Dim iCount As Integer = 0
        Try            
            iCount = concreteResponse.PaymentTransactions.Length
            bError = False
        Catch ex As Exception
            bError = True
        End Try


        If bError = False Then


            For iCount = 0 To concreteResponse.PaymentTransactions.Length - 1

                Dim lvwItem As New ListViewItem
                lvwItem.Text = concreteResponse.PaymentTransactions(iCount).PayerDisplayName
                lvwItem.SubItems.Add(concreteResponse.PaymentTransactions(iCount).Status)
                lvwItem.SubItems.Add(concreteResponse.PaymentTransactions(iCount).Payer)
                lvwItem.SubItems.Add(concreteResponse.PaymentTransactions(iCount).Timestamp)
                lvwItem.SubItems.Add(concreteResponse.PaymentTransactions(iCount).Type)
                lvwItem.SubItems.Add(concreteResponse.PaymentTransactions(iCount).FeeAmount.Value)
                lvwItem.SubItems.Add(concreteResponse.PaymentTransactions(iCount).NetAmount.Value)
                lvwItem.SubItems.Add(concreteResponse.PaymentTransactions(iCount).GrossAmount.Value)
                lvw.Items.Add(lvwItem)
            Next

        End If

        Return True
    End Function
End Class
