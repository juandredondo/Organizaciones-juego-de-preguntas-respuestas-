Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Tools.Word

Public Class Form1
    'para contar los puntos delos diferentes grupos

    Dim contar As Integer = 0
    'Dim 'NumeroGrupo As Integer = 1
    Dim PuntoGrupo1 As Integer = 0
    Dim PuntoGrupo2 As Integer = 0
    Dim PuntoGrupo3 As Integer = 0
    Dim PuntoGrupo4 As Integer = 0
    Dim PuntoGrupo5 As Integer = 0
    Public mensajeFinal As String



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Text = "Que es la informatica"
    End Sub

    Private Sub MostrarBarraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarBarraToolStripMenuItem.Click
        If ImgFondo.Width = 203 = True Then

            ImgFondo.Width = 10
            MostrarBarraToolStripMenuItem.Text = "Mostrar Barra"
        Else
            ImgFondo.Width = 203
            MostrarBarraToolStripMenuItem.Text = "Ocultar Barra"
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MostrarBarraToolStripMenuItem.Text = "Ocultar Barra"

        LblTurno.Text = i.ToString
     

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button2.Click, Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button10.Click, Button20.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click

        SumaPunto = PuntoGrupo1 + PuntoGrupo2 + PuntoGrupo3 + PuntoGrupo4 + PuntoGrupo5

        Dim opcion As Integer
        opcion = DirectCast(sender, Button).Text
        Select Case opcion
            Case 1
                contar = contar + 1
                habilitar(Button1)
                validar("Pregunta 1", " CONJUNTO DE VARIACIONES DE ORDEN ESTRUCTURAL QUE SUFREN LAS ORGANIZACIONES Y QUE SE TRADUCEN EN UN NUEVO COMPORTAMIENTO ORGANIZACIONAL.")

            Case 2
                contar = contar + 1
                habilitar(Button2)
                validar("Pregunta2", " 1.ADAPTATIVO 2.ORGANIZACIONAL 3.INNOVADOR ")

            Case 3
                contar = contar + 1
                habilitar(Button3)
                validar("Pregunta3", " LOS CAMBIOS SE ORIGINAN POR LA INTERACCIÓN DE FUERZAS INTERNAS Y EXTERNAS  ")




            Case 4
                contar = contar + 1
                habilitar(Button4)
                validar("Pregunta4", " TRES TIPOS DE CAMBIO ")

            Case 5
                contar = contar + 1
                habilitar(Button5)
                validar("Pregunta5", " APRENDIZAJE ")

            Case 6
                contar = contar + 1
                habilitar(Button6)
                validar("Pregunta6", " NO EXISTE RELACIÓN ENTRE EL APRENDIZAJE Y EL CAMBIO ORGANIZACIONAL.  ")
            Case 7
                contar = contar + 1
                habilitar(Button7)
                validar("Pregunta7", "FUERZAS QUE INTERACTUAN EN EL CAMBIO ORGANIZACIONAL ")
            Case 8
                contar = contar + 1
                habilitar(Button8)
                validar("Pregunta8", " BARRERAS DEL CAMBIO ")
            Case 9
                contar = contar + 1
                habilitar(Button9)
                validar("Pregunta9", " ETAPAS DEL CAMBIO  ")
            Case 10
                contar = contar + 1
                habilitar(Button10)
                validar("Pregunta10", "CAMBIO INNOVADOR ")


            Case 11
                contar = contar + 1
                habilitar(Button11)
                validar("Pregunta11", " 1.PÉRDIDA 2.RESISTENCIA ")

            Case 12
                contar = contar + 1
                habilitar(Button12)
                validar("Pregunta12", "FUERZAS EXTERNAS Y FUERZAS INTERNAS")
            Case 13
                contar = contar + 1
                habilitar(Button13)
                validar("Pregunta13", " SON AQUELLAS QUE NACEN DENTRO DE LA ORGANIZACIÓN, SURGEN DEL ANÁLISIS DEL COMPORTAMIENTO ORGANIZACIONAL Y SE PRESENTAN COMO ALTERNATIVAS DE SOLUCIÓN")

            Case 14
                contar = contar + 1
                habilitar(Button14)
                validar("Pregunta14", " 1.EDUCACIÓN Y COMUNICACIÓN 2. PARTICIPACIÓN: 3. FACILITACIÓN Y APOYO:4 NEGOCIACIÓN:5. MANIPULACIÓN Y COOPTACIÓN  ")

            Case 15
                contar = contar + 1
                habilitar(Button15)
                validar("Pregunta15", " FALSO ")
            Case 16
                contar = contar + 1
                habilitar(Button16)
                validar("Pregunta16", "CAMBIO ORGANIZACIONAL")
            Case 17
                contar = contar + 1
                habilitar(Button17)
                validar("Pregunta17", " IMPLICAN CIERTO GRADO DE COMPLEJIDAD, COSTO E INCERTIDUMBRE POR SU CARACTERÍSTICA DE INNOVACIÓN ")
            Case 18
                contar = contar + 1
                habilitar(Button18)
                validar("Pregunta18", " VERDADERO ")
            Case 19
                contar = contar + 1
                habilitar(Button19)
                validar("Pregunta19", " FUERZAS INTERNAS: ")
            Case 20
                contar = contar + 1
                habilitar(Button20)
                validar("Pregunta20", " CUALQUIER CAMBIO RELATIVAMENTE PERMANENTE EN LA CONDUCTA QUE OCURRE COMO RESULTADO DE LA EXPERIENCIA ")
        End Select

    End Sub

   

    Private Sub RichTextBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.DoubleClick, RichTextBox1.DoubleClick
        RichTextBox2.Clear()
        RichTextBox1.Clear()
    End Sub

   
    Public respuesta1 As String
    Public respuesta2 As String

    Function habilitar(ByRef NombControl As Control) As Integer

        If contar = 1 Then
            NombControl.Enabled = False
            respuesta1 = NombControl.Text
            NombControl.BackColor = Color.CadetBlue
        Else
            If contar = 2 Then
                respuesta2 = NombControl.Text
                NombControl.BackColor = Color.CadetBlue
                BtnCalificar.Enabled = True
                HabilitaBotones(False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False)
                contar = 0
            End If
        End If
    End Function

    Public Sub VerBotones(ByVal HabiltaBtn1 As Boolean, ByVal HabiltaBtn2 As Boolean, ByVal HabiltaBtn3 As Boolean, ByVal HabiltaBtn4 As Boolean, ByVal HabiltaBtn5 As Boolean, ByVal HabiltaBtn6 As Boolean, ByVal HabiltaBtn7 As Boolean, ByVal HabiltaBtn8 As Boolean, ByVal HabiltaBtn9 As Boolean, ByVal HabiltaBtn10 As Boolean, ByVal HabiltaBtn11 As Boolean, ByVal HabiltaBtn12 As Boolean, ByVal HabiltaBtn13 As Boolean, ByVal HabiltaBtn14 As Boolean, ByVal HabiltaBtn15 As Boolean, ByVal HabiltaBtn16 As Boolean, ByVal HabiltaBtn17 As Boolean, ByVal HabiltaBtn18 As Boolean, ByVal HabiltaBtn19 As Boolean, ByVal HabiltaBtn20 As Boolean)
        Button1.Visible = HabiltaBtn1
        Button2.Visible = HabiltaBtn2
        Button3.Visible = HabiltaBtn3
        Button4.Visible = HabiltaBtn4
        Button5.Visible = HabiltaBtn5
        Button6.Visible = HabiltaBtn6
        Button7.Visible = HabiltaBtn7
        Button8.Visible = HabiltaBtn8
        Button9.Visible = HabiltaBtn9
        Button10.Visible = HabiltaBtn10
        Button11.Visible = HabiltaBtn11
        Button12.Visible = HabiltaBtn12
        Button13.Visible = HabiltaBtn13
        Button14.Visible = HabiltaBtn14
        Button15.Visible = HabiltaBtn15
        Button16.Visible = HabiltaBtn16
        Button17.Visible = HabiltaBtn17
        Button18.Visible = HabiltaBtn18
        Button19.Visible = HabiltaBtn19
        Button20.Visible = HabiltaBtn20






    End Sub

    Public Sub habilitar(ByVal es As Button, ByVal h1 As Boolean)
        es.Enabled = h1


    End Sub


    Public Sub HabilitaBotones(ByVal HabiltaBtn1 As Boolean, ByVal HabiltaBtn2 As Boolean, ByVal HabiltaBtn3 As Boolean, ByVal HabiltaBtn4 As Boolean, ByVal HabiltaBtn5 As Boolean, ByVal HabiltaBtn6 As Boolean, ByVal HabiltaBtn7 As Boolean, ByVal HabiltaBtn8 As Boolean, ByVal HabiltaBtn9 As Boolean, ByVal HabiltaBtn10 As Boolean, ByVal HabiltaBtn11 As Boolean, ByVal HabiltaBtn12 As Boolean, ByVal HabiltaBtn13 As Boolean, ByVal HabiltaBtn14 As Boolean, ByVal HabiltaBtn15 As Boolean, ByVal HabiltaBtn16 As Boolean, ByVal HabiltaBtn17 As Boolean, ByVal HabiltaBtn18 As Boolean, ByVal HabiltaBtn19 As Boolean, ByVal HabiltaBtn20 As Boolean)
        Button1.Enabled = HabiltaBtn1
        Button2.Enabled = HabiltaBtn2
        Button3.Enabled = HabiltaBtn3
        Button4.Enabled = HabiltaBtn4
        Button5.Enabled = HabiltaBtn5
        Button6.Enabled = HabiltaBtn6
        Button7.Enabled = HabiltaBtn7
        Button8.Enabled = HabiltaBtn8
        Button9.Enabled = HabiltaBtn9
        Button10.Enabled = HabiltaBtn10
        Button11.Enabled = HabiltaBtn11
        Button12.Enabled = HabiltaBtn12
        Button13.Enabled = HabiltaBtn13
        Button14.Enabled = HabiltaBtn14
        Button15.Enabled = HabiltaBtn15
        Button16.Enabled = HabiltaBtn16
        Button17.Enabled = HabiltaBtn17
        Button18.Enabled = HabiltaBtn18
        Button19.Enabled = HabiltaBtn19
        Button20.Enabled = HabiltaBtn20

    End Sub
    Public Sub validar(ByVal TituloPregunta As String, ByVal Pregunta As String)
        If RichTextBox1.Text = Nothing Then
            LblTitulo1.Text = TituloPregunta
            RichTextBox1.Text = Pregunta

        Else
            LblTitulo2.Text = TituloPregunta
            RichTextBox2.Text = Pregunta
            SumaPunto = PuntoGrupo1 + PuntoGrupo2 + PuntoGrupo3 + PuntoGrupo4 + PuntoGrupo5
            ' MsgBox(SumaPunto)

        End If
    End Sub


    Sub GrupoGanados(ByVal puntoGrupo1, ByVal puntoGrupo2, ByVal puntoGrupo3, ByVal puntoGrupo4, ByVal puntoGrupo5)


        If puntoGrupo1 > puntoGrupo2 And puntoGrupo1 > puntoGrupo3 And puntoGrupo1 > puntoGrupo4 And puntoGrupo1 > puntoGrupo5 Then

            MsgBox("Felicidades el Equipo ganador es el 1")

        ElseIf puntoGrupo2 > puntoGrupo1 And puntoGrupo2 > puntoGrupo3 And puntoGrupo2 > puntoGrupo4 And puntoGrupo2 > puntoGrupo5 Then

            MsgBox("Felicidades el Equipo ganador es el 2")

        ElseIf puntoGrupo3 > puntoGrupo1 And puntoGrupo3 > puntoGrupo2 And puntoGrupo3 > puntoGrupo4 And puntoGrupo3 > puntoGrupo5 Then

            MsgBox("Felicidades el Equipo ganador es el 3")

        ElseIf puntoGrupo4 > puntoGrupo1 And puntoGrupo4 > puntoGrupo2 And puntoGrupo4 > puntoGrupo3 And puntoGrupo4 > puntoGrupo5 Then

            MsgBox("Felicidades el Equipo ganador es el 4")

        ElseIf puntoGrupo5 > puntoGrupo1 And puntoGrupo5 > puntoGrupo2 And puntoGrupo5 > puntoGrupo3 And puntoGrupo5 > puntoGrupo4 Then

            MsgBox("Felicidades el Equipo ganador es el 4")

        Else
            MsgBox(" Los Equipos en empate deben responder una pregunta para elejir el ganador", MsgBoxStyle.Exclamation, "Apliquemos lo Aprendido")

        End If
    End Sub

    Dim SumaPunto As Integer
    Private Sub Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalificar.Click


        If SumaPunto = 9 Then
            Funcalificar(respuesta1, respuesta2)
            MsgBox("El juego termino", MsgBoxStyle.Information)
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
            LblTitulo1.Text = ""
            LblTitulo2.Text = ""
            'Label1.Text = ""
            BtnCalificar.Enabled = False

            GrupoGanados(PuntoGrupo1, PuntoGrupo2, PuntoGrupo3, PuntoGrupo4, PuntoGrupo5)


        Else


            'NumeroGrupo = NumeroGrupo + 1
            contar = 0
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
            HabilitaBotones(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
            LblTitulo1.Text = ""
            LblTitulo2.Text = ""

            Button1.BackColor = Color.Transparent
            Button2.BackColor = Color.Transparent
            Button3.BackColor = Color.Transparent
            Button4.BackColor = Color.Transparent
            Button5.BackColor = Color.Transparent
            Button6.BackColor = Color.Transparent
            Button7.BackColor = Color.Transparent
            Button8.BackColor = Color.Transparent
            Button9.BackColor = Color.Transparent
            Button10.BackColor = Color.Transparent
            Button11.BackColor = Color.Transparent
            Button12.BackColor = Color.Transparent
            Button13.BackColor = Color.Transparent
            Button14.BackColor = Color.Transparent
            Button15.BackColor = Color.Transparent
            Button16.BackColor = Color.Transparent
            Button17.BackColor = Color.Transparent
            Button18.BackColor = Color.Transparent
            Button19.BackColor = Color.Transparent
            Button20.BackColor = Color.Transparent
            BtnCalificar.Enabled = False

            Funcalificar(respuesta1, respuesta2)
            LblTurno.Text = i.ToString

        End If
    End Sub

    Public Sub Puntaje(ByVal grupo As Integer)
        Select Case grupo


            Case 1
                PuntoGrupo1 = PuntoGrupo1 + 1

                MsgBox(" Punto para el grupo :  " + grupo.ToString, MsgBoxStyle.Information)
                LblPuntoG1.Text = PuntoGrupo1.ToString

            Case 2
                PuntoGrupo2 = PuntoGrupo2 + 1
                MsgBox("  Punto para el grupo :  " + grupo.ToString, MsgBoxStyle.Information)
                LblPuntoG2.Text = PuntoGrupo2.ToString
            Case 3
                PuntoGrupo3 = PuntoGrupo3 + 1
                MsgBox("  Punto para el grupo :  " + grupo.ToString, MsgBoxStyle.Information)
                LblPuntoG3.Text = PuntoGrupo3.ToString
            Case 4
                PuntoGrupo4 = PuntoGrupo4 + 1
                MsgBox("  Punto para el grupo :  " + grupo.ToString, MsgBoxStyle.Information)
                LblPuntoG4.Text = PuntoGrupo4.ToString
            Case 0
                PuntoGrupo5 = PuntoGrupo5 + 1
                MsgBox("  Punto para el grupo : 5 ", MsgBoxStyle.Information)
                LblPuntoG5.Text = PuntoGrupo5.ToString
        End Select

    End Sub



    Private Sub DeshacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click
        SumaPunto = 0
        contar = 0
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        HabilitaBotones(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
        LblTitulo1.Text = ""
        LblTitulo2.Text = ""
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        Button5.BackColor = Color.Transparent
        Button6.BackColor = Color.Transparent
        Button7.BackColor = Color.Transparent
        Button8.BackColor = Color.Transparent
        Button9.BackColor = Color.Transparent
        Button10.BackColor = Color.Transparent
        Button11.BackColor = Color.Transparent
        Button12.BackColor = Color.Transparent
        Button13.BackColor = Color.Transparent
        Button14.BackColor = Color.Transparent
        Button15.BackColor = Color.Transparent
        Button16.BackColor = Color.Transparent
        Button17.BackColor = Color.Transparent
        Button18.BackColor = Color.Transparent
        Button19.BackColor = Color.Transparent
        Button20.BackColor = Color.Transparent
    End Sub

    Dim grupo As Integer
    Public Sub Funcalificar(ByVal res1 As String, ByVal res2 As String)
        Dim cadena As String

        cadena = res1 + res2


        Turno(True)


        Select Case (cadena)


            Case "116"

                Button1.Visible = False
                Button16.Visible = False
                grupo = i - 1
                Puntaje(grupo)

            Case "161"

                Button1.Visible = False
                Button16.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "24"

                Button2.Visible = False
                Button4.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "42"

                Button2.Visible = False
                Button4.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)

            Case "318"

                Button3.Visible = False
                Button18.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)

            Case "183"

                Button3.Visible = False
                Button18.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "520"

                Button5.Visible = False
                Button20.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "205"

                Button5.Visible = False
                Button20.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "615"

                Button6.Visible = False
                Button15.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "156"

                Button6.Visible = False
                Button15.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "712"

                Button7.Visible = False
                Button12.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "127"

                Button7.Visible = False
                Button12.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "811"

                Button8.Visible = False
                Button11.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "118"

                Button8.Visible = False
                Button11.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "914"

                Button9.Visible = False
                Button14.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "149"

                Button9.Visible = False
                Button14.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "1017"

                Button10.Visible = False
                Button17.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "1710"

                Button10.Visible = False
                Button17.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "1319"

                Button13.Visible = False
                Button19.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
            Case "1913"

                Button13.Visible = False
                Button19.Visible = False
                grupo = i - 1
                Puntaje(grupo)
                'MsgBox(" el punto es del grupo :  " + grupo.ToString)
                ' MsgBox("El turno es del grupo " + i.ToString)
            Case Else
                MsgBox("la pareja  de opciones escogida es Incorrecta", MsgBoxStyle.Critical, "Intenta Nuevamente")


        End Select


    End Sub

    Public i As Integer = 1
    Public Function Turno(ByVal g1 As Boolean) As Integer
        Do
            If (i = 5) Then
                g1 = True
                i = 1
                LblTurno.Text = i.ToString
            Else

                i += 1

            End If
        Loop While (g1 = False)

    End Function



    Private Sub RestaurarJuegoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurarJuegoToolStripMenuItem.Click
        SumaPunto = 0

        i = 1
        'NumeroGrupo = NumeroGrupo + 1
        LblTurno.Text = i.ToString
        PuntoGrupo1 = 0
        LblPuntoG1.Text = 0
        PuntoGrupo2 = 0
        LblPuntoG2.Text = 0
        PuntoGrupo3 = 0
        LblPuntoG3.Text = 0
        PuntoGrupo4 = 0
        LblPuntoG4.Text = 0
        PuntoGrupo5 = 0
        LblPuntoG5.Text = 0

        contar = 0
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        HabilitaBotones(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
        VerBotones(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)

        LblTitulo1.Text = ""
        LblTitulo2.Text = ""
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        Button5.BackColor = Color.Transparent
        Button6.BackColor = Color.Transparent
        Button7.BackColor = Color.Transparent
        Button8.BackColor = Color.Transparent
        Button9.BackColor = Color.Transparent
        Button10.BackColor = Color.Transparent
        Button11.BackColor = Color.Transparent
        Button12.BackColor = Color.Transparent
        Button13.BackColor = Color.Transparent
        Button14.BackColor = Color.Transparent
        Button15.BackColor = Color.Transparent
        Button16.BackColor = Color.Transparent
        Button17.BackColor = Color.Transparent
        Button18.BackColor = Color.Transparent
        Button19.BackColor = Color.Transparent
        Button20.BackColor = Color.Transparent
        BtnCalificar.Enabled = False
    End Sub





End Class
