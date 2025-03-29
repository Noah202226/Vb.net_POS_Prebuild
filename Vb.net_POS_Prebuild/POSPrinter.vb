Imports System.Drawing.Printing
Imports System.IO
Imports QRCoder ' Make sure you installed this via NuGet

Public Class POSPrinter
    Private _receiptText As String
    Private _imagePath As String
    Private _qrText As String

    ' Constructor accepts dynamic image path
    Public Sub New(receiptText As String, imagePath As String, qrText As String)
        _receiptText = receiptText
        _imagePath = imagePath
        _qrText = qrText
    End Sub

    ' Print function
    Public Sub PrintReceipt()
        Dim pd As New PrintDocument()
        'pd.PrinterSettings.PrinterName = "Your_Thermal_Printer_Name"

        'If Not pd.PrinterSettings.IsValid Then
        '    MsgBox("Error: Printer not found!")
        '    Exit Sub
        'End If

        AddHandler pd.PrintPage, AddressOf Me.PrintPageHandler
        pd.Print()
    End Sub

    ' Print page event handler
    Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim font As New Font("Courier New", 10, FontStyle.Bold)
        Dim yPos As Integer = 10 ' Vertical position

        ' 1️⃣ Print Logo (user-selected)
        If Not String.IsNullOrEmpty(_imagePath) AndAlso File.Exists(_imagePath) Then
            Try
                Dim logo As Image = Image.FromFile(_imagePath)
                e.Graphics.DrawImage(logo, 10, yPos, 100, 100) ' Adjust size
                yPos += 110 ' Move text below image
            Catch ex As Exception
                MsgBox("Error loading image: " & ex.Message)
            End Try
        End If

        ' 2️⃣ Print Receipt Text
        e.Graphics.DrawString(_receiptText, font, Brushes.Black, 10, yPos)
        yPos += 100

        ' 3️⃣ Generate and Print QR Code
        If Not String.IsNullOrEmpty(_qrText) Then
            Try
                Dim qrGenerator As New QRCodeGenerator()
                Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(_qrText, QRCodeGenerator.ECCLevel.Q)
                Dim qrCode As New QRCode(qrCodeData)
                Dim qrImage As Bitmap = qrCode.GetGraphic(6)

                e.Graphics.DrawImage(qrImage, 10, yPos, 100, 100)
            Catch ex As Exception
                MsgBox("Error generating QR Code: " & ex.Message)
            End Try
        End If
    End Sub
End Class
