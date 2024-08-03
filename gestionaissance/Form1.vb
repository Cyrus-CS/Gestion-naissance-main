Imports System.Data.OleDb
Imports System.Data

Public Class Form1

    'Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PNL TECK\source\repos\gestionaissance\gestionaissance.accdb;Persist Security Info=False"
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gestionaissance.accdb;Persist Security Info=False"
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbl_reference.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles modifier.Click

        Dim nom As String = Me.nameNom.Text
        Dim prenom As String = Me.prenom.Text
        Dim hopital As String = Me.hopital.Text
        Dim comm As String = Me.commune.Text
        Dim [date] As String = Me.dateNais.Value.ToString("yyyy-MM-dd")
        Dim dad As String = Me.dad.Text
        Dim ref As String = Me.reference.Text
        Dim mr As String = Me.mr.Text

        If ref = "" Then
            MessageBox.Show("Veuillez saisir le numéro de référence à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                'variable representant la base de donnée 
                Dim con_data As New OleDbConnection(Me.Provider)
                'ouverture de la connection et envoi des informations vers la base de données 
                con_data.Open()
                'MessageBox.Show("Success Connection...!")
                Dim requete As String = "UPDATE born SET nom= '" & nom & "', prenom='" & prenom & "',commune='" & comm & "', hopital='" & hopital & "', DateNaissance='" & [date] & "', dad='" & dad & "', mother='" & mr & "' WHERE reference='" & ref & "' "


                Dim command As New OleDbCommand(requete, con_data)
                If command.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Modification éffectuée")
                Else
                    MessageBox.Show("Erreur lors de l'execution de la modification")
                End If
                con_data.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles save.Click

        Dim nom As String = Me.nameNom.Text
        Dim prenom As String = Me.prenom.Text
        Dim hopital As String = Me.hopital.Text
        Dim comm As String = Me.commune.Text
        Dim [date] As String = Me.dateNais.Value.ToString("yyyy-MM-dd")
        Dim dad As String = Me.dad.Text
        Dim ref As String = Me.reference.Text
        Dim mr As String = Me.mr.Text

        If nom = "" Or prenom = "" Or hopital = "" Or dad = "" Or mr = "" Or comm = "" Or ref = "" Then
            MessageBox.Show("Veuillez remplir tous les champs de saisie!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try

                'variable representant la base de donnée 
                Dim con_data As New OleDbConnection(Me.Provider)

                'ouverture de la connection et envoi des informations vers la base de données 
                con_data.Open()
                'MessageBox.Show("Success Connection...!")
                Dim requete As String = "INSERT INTO born(reference, nom, prenom, commune, hopital, DateNaissance, dad, mother) values('" & ref & "','" & nom & "','" & prenom & "','" & comm & "','" & hopital & "','" & [date] & "','" & dad & "','" & mr & "')"
                Dim command As New OleDbCommand(requete, con_data)
                If command.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Les données ont été ajouté avec succès dans la base de donnée!!")
                Else
                    MessageBox.Show("Base de donnée non trouvée ! Erreur de connection!")
                End If
                con_data.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        Dim ref As String = Me.reference.Text
        Try
            'variable representant la base de donnée 
            Dim con_data As New OleDbConnection(Me.Provider)
            'ouverture de la connection et envoi des informations vers la base de données 
            con_data.Open()
            'MessageBox.Show("Success Connection...!")
            Dim requete As String = "Delete from born  WHERE reference='" & ref & "' "
            Dim command As New OleDbCommand(requete, con_data)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("La suppression éffectué")

            Else
                MessageBox.Show("Erreur lors de l'execution de la suppression")
            End If
            con_data.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
