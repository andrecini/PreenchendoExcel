Imports Syncfusion.XlsIO
Imports System.Drawing

Public Class ExcelCreator
    Inherits Dados
   
    Public Shared Sub CreateExcel()
       
        Using excelEngine As ExcelEngine = New ExcelEngine()
           
            Dim application As IApplication = excelEngine.Excel
            application.DefaultVersion = ExcelVersion.Excel2010

            Try 
                Dim workbook As IWorkbook = application.Workbooks.Open("TabelaModelo.xlsx")

                Dim worksheet As IWorksheet = workbook.Worksheets(0)

                InsertDataInWorksheet(worksheet)

                workbook.SaveAs(String.Format("Tabela({0}).xlsx", _ID))
                
                MessageBox.Show("Excel criado com sucesso. Verificar na pasta ...\bin\Debug!")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try   
            
        End Using

    End Sub

    Private Shared Sub InsertDataInWorksheet(ByVal ws As IWorksheet)
        
        Dim dc As DataCenter = New DataCenter()
        
        ws.Range("txtID").Text = _ID.ToString()
        ws.Range("txtOperator").Text = _operator
        ws.Range("txtResponsible").Text = _responsible
        ws.Range("txtDate").Text = _date
        ws.Range("txtLocal").Text = _local

        'Adicionar lógica do preenchimento da tabela
        For index = 10 To 108
            ws.Range("A" + index.ToString()).Text = (index-9).ToString
            ws.Range("B" + index.ToString()).Text = dc.names(index-10)
            ws.Range("C" + index.ToString()).Text = dc.ages(index-10)
            ws.Range("D" + index.ToString()).Text = dc.states(index-10)

            ws.InsertRow(index + 1, 1, ExcelInsertOptions.FormatAsBefore)
        Next

        ws.Range("A109").Text = 100
        ws.Range("B109").Text = dc.names(99)
        ws.Range("C109").Text = dc.ages(99)
        ws.Range("D109").Text = dc.states(99)

        ws.Range("txtMedia").Text = dc.ages.Average()
    End Sub



End Class




