Imports System
Imports System.Data
'importar referencia .COM (Microsoft ActiveX Data Objects 6.1 Library)



Public Class Form1

    Dim cn As New ADODB.Connection()
    Dim rs As New ADODB.Recordset()
    Dim rsProcedure As New ADODB.Recordset()
    Dim cnStr As String
    Dim cmd As New ADODB.Command()
    Dim tSQL As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' string de conexao com o banco
        cnStr = "Provider=SQLOLEDB;Initial Catalog=Scapol_Producao;Data Source=s-erp;User ID=sa;Password=Sc1p4l2009;"

        ' 2. Abre a Conexao
        cn.Open(cnStr)
        'cn.Close()

        Label1.Text = "Selecione a Empresa para atualizar a DRE"
        Label1.Visible = True
    End Sub

    Private Sub btnDistri_Click(sender As Object, e As EventArgs) Handles btnDistri.Click


        tSQL = " exec Scapol_Producao.dbo.PR_SITE_ACOMP_DRE_" + CStr(Format(Date.Now.Year, "0000")) + " '" + Format(Date.Now.Year, "0000") + "' "

        cn.CommandTimeout = 360
        cn.CommandTimeout = 360
        rs = cn.Execute(tSQL)


        MsgBox("DRE Scapol Distribuidora atualizada. Ano: " + Format(Date.Now.Year, "0000"))
    End Sub

    Private Sub btnNegocios_Click(sender As Object, e As EventArgs) Handles btnNegocios.Click

        tSQL = " exec Scapol_Producao.dbo.PR_SITE_ACOMP_DRE_NEGOCIOS_2017 " + " '" + Format(Date.Now.Year, "0000") + "' "

        cn.CommandTimeout = 360
            rs = cn.Execute(tSQL)

        MsgBox("DRE Scapol Negócios atualizada. Ano: " + Format(Date.Now.Year, "0000"))
    End Sub

    Private Sub btnSunrio_Click(sender As Object, e As EventArgs) Handles btnSunrio.Click


        tSQL = " exec Scapol_Producao.dbo.PR_SITE_ACOMP_DRE_SUNRIO " + " '" + Format(Date.Now.Year, "0000") + "' "

            cn.CommandTimeout = 360
            rs = cn.Execute(tSQL)

        MsgBox("DRE Sunrio atualizada. Ano: " + Format(Date.Now.Year, "0000"))
    End Sub

    Private Sub btnQualidy_Click(sender As Object, e As EventArgs) Handles btnQualidy.Click


        tSQL = " exec Scapol_Producao.dbo.PR_SITE_ACOMP_DRE_QUALIDY " + " '" + Format(Date.Now.Year, "0000") + "' "

            cn.CommandTimeout = 360
            rs = cn.Execute(tSQL)



        MsgBox("DRE Qualidy atualizada. Ano: " + Format(Date.Now.Year, "0000"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tSQL = " exec Scapol_Producao.dbo.PR_SITE_ACOMP_DRE_ARMAZEM " + " '" + Format(Date.Now.Year, "0000") + "' "

        cn.CommandTimeout = 360
        rs = cn.Execute(tSQL)



        MsgBox("DRE Armazem atualizada. Ano: " + Format(Date.Now.Year, "0000"))
    End Sub
End Class
