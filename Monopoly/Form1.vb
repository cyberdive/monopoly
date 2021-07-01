Public Class Form1
    Dim tableau(40) As terrain
    Dim joueurs(2) As joueur

    Dim aquiletour As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Dim des As Integer = CInt(Int((6 * Rnd()) + 1))
        joueurs(aquiletour).position = joueurs(aquiletour).position + des
        If joueurs(aquiletour).position > 40 Then
            joueurs(aquiletour).position = joueurs(aquiletour).position - 40
        End If

        Dim achat As Boolean
        If tableau(joueurs(aquiletour).position).proprietaire = 0 Then
            '  achat = MsgBox("Voulez vous acheter?", vbYesNo)
            achat = True
            If achat Then
                tableau(joueurs(aquiletour).position).proprietaire = aquiletour
                joueurs(aquiletour).cashDisponible = joueurs(aquiletour).cashDisponible - tableau(joueurs(aquiletour).position).prix

                '     Dim curBitmap As New Bitmap("C:\Users\patrick\Documents\Visual Studio 2017\Projects\Monopoly\red.jpg")
                Dim pb As New PictureBox
                If aquiletour = 1 Then
                    pb.ImageLocation = "C:\Users\patrick\Documents\Visual Studio 2017\Projects\Monopoly\green.jpg"
                Else
                    pb.ImageLocation = "C:\Users\patrick\Documents\Visual Studio 2017\Projects\Monopoly\red.jpg"
                End If

                PictureBox1.SendToBack()


                    pb.Location = New System.Drawing.Point(tableau(joueurs(aquiletour).position).gpsX, tableau(joueurs(aquiletour).position).gpsY)
                    pb.Name = "pctbleu"
                    pb.Size = New System.Drawing.Size(20, 20)
                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                    pb.TabIndex = 11
                    pb.TabStop = False

                    Me.Controls.Add(pb)



                End If
            Else
            joueurs(aquiletour).cashDisponible = joueurs(aquiletour).cashDisponible - 1
            joueurs(tableau(joueurs(aquiletour).position).proprietaire).cashDisponible = joueurs(tableau(joueurs(aquiletour).position).proprietaire).cashDisponible + 1
        End If

        joueurs(aquiletour).gpsX = tableau(joueurs(aquiletour).position).gpsX
        joueurs(aquiletour).gpsY = tableau(joueurs(aquiletour).position).gpsY

        pctjoueur1.Left = joueurs(1).gpsX
        pctjoueur1.Top = joueurs(1).gpsY
        pctjoueur2.Left = joueurs(2).gpsX
        pctjoueur2.Top = joueurs(2).gpsY








        lblDes.Text = des
        If aquiletour = 1 Then
            aquiletour = 2
        Else
            aquiletour = 1

        End If
        lbljoueur1.Text = joueurs(1).cashDisponible
        lbljoueur2.text = joueurs(2).cashDisponible
        lblaquiletour.Text = aquiletour
    End Sub
    Private Sub init()


        Dim Lignebasse = 439
        Dim Lignehaute = 15
        Dim Lignegauche = 295
        Dim Lignedroite = 849
        For q As Integer = 1 To 40
            tableau(q) = New terrain()
        Next q
        For q2 As Integer = 1 To 2
            joueurs(q2) = New joueur()
            joueurs(q2).nom = " joueur" + q2.ToString
            joueurs(q2).gpsX = Lignebasse
            joueurs(q2).gpsY = Lignedroite
        Next q2
        tableau(1).prix = 1
        tableau(1).proprietaire = 0
        tableau(1).gpsX = 780
        tableau(1).gpsY = Lignebasse

        tableau(2).prix = 1
        tableau(2).proprietaire = 0
        tableau(2).gpsX = 730
        tableau(2).gpsY = Lignebasse

        tableau(3).prix = 2
        tableau(3).proprietaire = 0
        tableau(3).gpsX = 678
        tableau(3).gpsY = Lignebasse

        tableau(4).prix = 2
        tableau(4).proprietaire = 0
        tableau(4).gpsX = 626
        tableau(4).gpsY = Lignebasse

        tableau(5).prix = 3
        tableau(5).proprietaire = 0
        tableau(5).gpsX = 574
        tableau(5).gpsY = Lignebasse

        tableau(6).prix = 3
        tableau(6).proprietaire = 0
        tableau(6).gpsX = 522
        tableau(6).gpsY = Lignebasse

        tableau(7).prix = 4
        tableau(7).proprietaire = 0
        tableau(7).gpsX = 468
        tableau(7).gpsY = Lignebasse

        tableau(8).prix = 4
        tableau(8).proprietaire = 0
        tableau(8).gpsX = 416
        tableau(8).gpsY = Lignebasse

        tableau(9).prix = 5
        tableau(9).proprietaire = 0
        tableau(9).gpsX = 358
        tableau(9).gpsY = Lignebasse

        tableau(10).prix = 5
        tableau(10).proprietaire = 0
        tableau(10).gpsX = 295
        tableau(10).gpsY = Lignebasse

        tableau(11).prix = 1
        tableau(11).proprietaire = 0
        tableau(11).gpsX = Lignegauche
        tableau(11).gpsY = 390

        tableau(12).prix = 1
        tableau(12).proprietaire = 0
        tableau(12).gpsX = Lignegauche
        tableau(12).gpsY = 350

        tableau(13).prix = 2
        tableau(13).proprietaire = 0
        tableau(13).gpsX = Lignegauche
        tableau(13).gpsY = 310

        tableau(14).prix = 2
        tableau(14).proprietaire = 0
        tableau(14).gpsX = Lignegauche
        tableau(14).gpsY = 270

        tableau(15).prix = 3
        tableau(15).proprietaire = 0
        tableau(15).gpsX = Lignegauche
        tableau(15).gpsY = 230

        tableau(16).prix = 3
        tableau(16).proprietaire = 0
        tableau(16).gpsX = Lignegauche
        tableau(16).gpsY = 190

        tableau(17).prix = 4
        tableau(17).proprietaire = 0
        tableau(17).gpsX = Lignegauche
        tableau(17).gpsY = 150

        tableau(18).prix = 4
        tableau(18).proprietaire = 0
        tableau(18).gpsX = Lignegauche
        tableau(18).gpsY = 110

        tableau(19).prix = 5
        tableau(19).proprietaire = 0
        tableau(19).gpsX = Lignegauche
        tableau(19).gpsY = 70

        tableau(20).prix = 5
        tableau(20).proprietaire = 0
        tableau(20).gpsX = Lignegauche
        tableau(20).gpsY = Lignehaute

        tableau(21).prix = 1
        tableau(21).proprietaire = 0
        tableau(21).gpsX = 358
        tableau(21).gpsY = Lignehaute

        tableau(22).prix = 1
        tableau(22).proprietaire = 0
        tableau(22).gpsX = 416
        tableau(22).gpsY = Lignehaute

        tableau(23).prix = 2
        tableau(23).proprietaire = 0
        tableau(23).gpsX = 468
        tableau(23).gpsY = Lignehaute

        tableau(24).prix = 2
        tableau(24).proprietaire = 0
        tableau(24).gpsX = 522
        tableau(24).gpsY = Lignehaute

        tableau(25).prix = 3
        tableau(25).proprietaire = 0
        tableau(25).gpsX = 574
        tableau(25).gpsY = Lignehaute

        tableau(26).prix = 3
        tableau(26).proprietaire = 0
        tableau(26).gpsX = 626
        tableau(26).gpsY = Lignehaute

        tableau(27).prix = 4
        tableau(27).proprietaire = 0
        tableau(27).gpsX = 678
        tableau(27).gpsY = Lignehaute

        tableau(28).prix = 4
        tableau(28).proprietaire = 0
        tableau(28).gpsX = 730
        tableau(28).gpsY = Lignehaute

        tableau(29).prix = 5
        tableau(29).proprietaire = 0
        tableau(29).gpsX = 780
        tableau(29).gpsY = Lignehaute

        tableau(30).prix = 5
        tableau(30).proprietaire = 0
        tableau(30).gpsX = Lignedroite
        tableau(30).gpsY = Lignehaute

        tableau(31).prix = 1
        tableau(31).proprietaire = 0
        tableau(31).gpsX = Lignedroite
        tableau(31).gpsY = 70

        tableau(32).prix = 1
        tableau(32).proprietaire = 0
        tableau(32).gpsX = Lignedroite
        tableau(32).gpsY = 110

        tableau(33).prix = 2
        tableau(33).proprietaire = 0
        tableau(33).gpsX = Lignedroite
        tableau(33).gpsY = 150

        tableau(34).prix = 2
        tableau(34).proprietaire = 0
        tableau(34).gpsX = Lignedroite
        tableau(34).gpsY = 190

        tableau(35).prix = 3
        tableau(35).proprietaire = 0
        tableau(35).gpsX = Lignedroite
        tableau(35).gpsY = 230

        tableau(36).prix = 3
        tableau(36).proprietaire = 0
        tableau(36).gpsX = Lignedroite
        tableau(36).gpsY = 270

        tableau(37).prix = 4
        tableau(37).proprietaire = 0
        tableau(37).gpsX = Lignedroite
        tableau(37).gpsY = 310

        tableau(38).prix = 4
        tableau(38).proprietaire = 0
        tableau(38).gpsX = Lignedroite
        tableau(38).gpsY = 350

        tableau(39).prix = 5
        tableau(39).proprietaire = 0
        tableau(39).gpsX = Lignedroite
        tableau(39).gpsY = 390

        tableau(40).prix = 5
        tableau(40).proprietaire = 0
        tableau(40).gpsX = Lignedroite
        tableau(40).gpsY = Lignebasse





    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button1_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Dim bmp As New Bitmap(1, 1)
        'Store the current image in a the bitmap object (assuming you have a picturebox on your form named picturebox1)
        bmp = PictureBox1.Image
        'Change portion of image colour (70 X 100 pixels just as a demo)
        For i = 0 To 30
            For j = 0 To 30

                'change Alpha, Red, Green and blue values
                bmp.SetPixel(i, j, Color.FromArgb(100, 100, 20, 20))

            Next

        Next
        PictureBox1.Image = bmp


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("vou")
        MsgBox("vou")

    End Sub
End Class
