Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click

        TXTNAME.Text = ""
        TXTDEP.Text = ""
        TXTWH.Text = ""
        TXTREGRATE.Text = ""
        TXTOVERTIME.Text = ""
        TXTOVERRATE.Text = ""
        TXTNAME2.Text = ""
        TXTDEP2.Text = ""
        TXTWH2.Text = ""
        TXTREGRATE2.Text = ""
        TXTOVERTIME2.Text = ""
        TXTOVERRATE2.Text = ""
        TXTGROSS.Text = ""
        TXTSSS.Text = ""
        TXTPHIL.Text = ""
        TXTPAGIBIG.Text = ""
        TXTINTAX.Text = ""
        TXTTOTALDEC.Text = ""
        TXTNET.Text = ""

    End Sub
    Private Sub BTNCOM_Click(sender As Object, e As EventArgs) Handles BTNCOM.Click
        Dim NAME = TXTNAME.Text
        Dim DEP = TXTDEP.Text
        Dim WH = TXTWH.Text
        Dim REGRATE = TXTREGRATE.Text
        Dim TIME = TXTOVERTIME.Text
        Dim RATE = TXTOVERRATE.Text
        Dim SSS As Double = 0.05
        Dim PHIL As Double = 150
        Dim IBIG As Double = 0.03
        Dim INCOMERATE As Double = 0.08
        Dim REGPAY As Double = WH * REGRATE
        Dim PAY As Double = TIME * RATE
        Dim GPAY = REGPAY + PAY
        Dim SSSDED As Double = GPAY * SSS
        Dim PHILDED As Double = PHIL
        Dim IBIGDED As Double = GPAY * IBIG
        Dim TAX As Double = GPAY - (SSSDED + PHILDED + IBIGDED)
        Dim TAXDED = TAX * INCOMERATE
        Dim TOTALDED = SSSDED + PHIL + IBIGDED + TAXDED
        Dim NETPAY As Double = GPAY - TOTALDED
        TXTNAME2.Text = NAME
        TXTDEP2.Text = DEP
        TXTWH2.Text = WH
        TXTREGRATE2.Text = REGRATE
        TXTOVERTIME2.Text = TIME
        TXTOVERRATE2.Text = RATE
        TXTGROSS.Text = GPAY.ToString("0.00")
        TXTSSS.Text = SSSDED.ToString("0.00")
        TXTPHIL.Text = PHILDED.ToString("0.00")
        TXTPAGIBIG.Text = IBIGDED.ToString("0.00")
        TXTINTAX.Text = TAXDED.ToString("0.00")
        TXTTOTALDEC.Text = TOTALDED.ToString("0.00")
        TXTNET.Text = NETPAY.ToString("0.00")

    End Sub
End Class
