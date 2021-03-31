Imports System.IO

Public Class Form1
    Private Sub btnCreateWS_Click(sender As Object, e As EventArgs) Handles btnCreateWS.Click
        If VerificaCaixasVazias()
            RecebeDados()

            If VerificaSePlanilhaExiste() = False
                ExcelCreator.CreateExcel()
            End If
            
        End If
        
    End Sub

    Private Shared Function VerificaCaixasVazias() As Boolean
       
        For Each x As Control In Form1.GroupBox1.Controls
            
            If x.Tag = "data" And x.Text = ""
                MessageBox.Show("Preencha todos os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

        Next

        Return True

    End Function

    Private Shared Sub RecebeDados()
        Dados._ID = Form1.txtID.Text
        Dados._operator = Form1.txtOperator.Text
        Dados._responsible = Form1.txtResponsible.Text
        Dados._date = Form1.dteDate.Value.ToString().Substring(0, 10)
        Dados._local = Form1.cmbLocal.Text
    End Sub

    Private Function VerificaSePlanilhaExiste() As Boolean
        If File.Exists(String.Format("Tabela({0}).xlsx", Dados._ID.ToString()))
            if DialogResult.Yes = MessageBox.Show("Um arquivo com esse ID já existe. Deseja Sobrescrevê-lo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                ExcelCreator.CreateExcel()
            End If
            Return True
        End If
        
        Return False
    End Function
    

End Class
