Public Class FRM_CALL_STATISTICS3

    Private temp As String
    Private temp2 As String = ""
    Private result As Integer = 0

    Private Sub FRM_CALL_STATISTICS3_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Call SettoolBar(False, True, False, False, False, True, True)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub FRM_CALL_STATISTICS3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Call Controls_Setting()
            Call gsSelect()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub Controls_Setting()
        Try
            Me.WindowState = FormWindowState.Maximized
            DPDate1.Value = Now
            DPDate2.Value = Now

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsSelect()

        Dim dt As DataTable
        Dim Gubun As String = ""
        Dim User As String = ""
        Dim temp2 As String = "''"
        Dim temp3 As String = "''"
        Dim temp1 As String = ""

        Try
            Select Case drpGubun.Text.Trim
                Case ""
                    drpGubun.Text = "일자"
                    temp2 = " Date_Format(TOND_DD, '%Y-%m-%d') "
                    temp3 = " Date_Format(tong_start_time, '%Y-%m-%d') "
                Case "일자"
                    temp2 = " Date_Format(TOND_DD, '%Y-%m-%d') "
                    temp3 = " Date_Format(tong_start_time, '%Y-%m-%d') "
                Case "주"
                    temp2 = " CONCAT(Date_Format(TOND_DD, '%Y-%U'), 'W') "   'WEEK(TOND_DD)
                    temp3 = " CONCAT(Date_Format(tong_start_time, '%Y-%U'), 'W') "   'WEEK(TOND_DD)
                Case "월"
                    temp2 = " Date_Format(TOND_DD, '%Y-%m') "
                    temp3 = " Date_Format(tong_start_time, '%Y-%m') "
                Case "분기"
                    temp2 = " CONCAT(Date_Format(TOND_DD, '%Y-'), QUARTER(TOND_DD), 'Q') "
                    temp3 = " CONCAT(Date_Format(tong_start_time, '%Y-'), QUARTER(tong_start_time), 'Q') "
                Case "년"
                    temp2 = " Date_Format(TOND_DD, '%Y')  "
                    temp3 = " Date_Format(tong_start_time, '%Y')  "
            End Select

            ''DataGridView1

            temp = "select a.gubun, IFNULL(a.call_received,0) call_received, IFNULL(a.Call_Total,0) call_total, " & _
                   " IFNULL(a.call_received,0) call_ib, IFNULL(a.Call_OB,0) call_ob,  " & _
                   " IFNULL(a.Call_Ext,0) call_ext, IFNULL(b.Consult_Complete,0) consult_complete, " & _
                   " IFNULL(b.Consult_Transfer,0) consult_transfer, IFNULL(b.Consult_CallBack,0) consult_callback, " & _
                   " IFNULL(b.Call_Etc,0) call_etc " & _
                   " from (" & _
                   " SELECT " & temp3 & " Gubun" & _
                   ", sum(if(CALL_RESULT = '1',1,0)) call_total" & _
                   ", sum(if(CALL_RESULT = '3',1,0)) Call_received" & _
                   ", sum(if(CALL_TYPE = '1',1,0)) Call_IB " & _
                   ", sum(if(CALL_TYPE = '2',1,0)) Call_OB, sum(if(CALL_TYPE = '3',1,0)) Call_Ext " & _
                   " FROM t_call_history " & _
                   " Where COM_CD='" & gsCOM_CD & "'" & _
                   " AND substr(tong_start_time, 1,8) >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " AND substr(tong_start_time, 1,8) <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " GROUP BY " & temp3 & _
                   " ) a left join ( " & _
                   " SELECT " & temp2 & " Gubun" & _
                   ", count(*) Consult_Complete  " & _
                   ", sum(if(CONSULT_RESULT = '06',1,0)) Consult_Transfer " & _
                   ", sum(if(CALL_BACK_YN = 'Y',1,0)) Consult_CallBack " & _
                   ", sum(if(CALL_TYPE in ('1','2','3'),0,1)) Call_Etc  " & _
                   " FROM t_customer_history " & _
                   " Where COM_CD='" & gsCOM_CD & "'" & _
                   " AND TOND_DD >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " AND TOND_DD <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " GROUP BY " & temp2 & _
                   " ) b on a.gubun = b.gubun "
            temp &= "  where a.Call_total + a.Call_received + a.call_IB + a.call_OB + a.call_Ext >0 "

            temp &= " UNION "
            temp &= "select a.gubun, IFNULL(a.call_received,0) call_received, IFNULL(a.Call_Total,0) call_total, " & _
                   " IFNULL(a.call_received,0) call_ib, IFNULL(a.Call_OB,0) call_ob,  " & _
                   " IFNULL(a.Call_Ext,0) call_ext, IFNULL(b.Consult_Complete,0) consult_complete, " & _
                   " IFNULL(b.Consult_Transfer,0) consult_transfer, IFNULL(b.Consult_CallBack,0) consult_callback, " & _
                   " IFNULL(b.Call_Etc,0) call_etc " & _
                   " from (" & _
                   " SELECT  '합계'  Gubun" & _
                   ", sum(if(CALL_RESULT = '1',1,0)) call_total" & _
                   ", sum(if(CALL_RESULT = '3',1,0)) Call_received" & _
                   ", sum(if(CALL_TYPE = '1',1,0)) Call_IB " & _
                   ", sum(if(CALL_TYPE = '2',1,0)) Call_OB, sum(if(CALL_TYPE = '3',1,0)) Call_Ext " & _
                   " FROM t_call_history " & _
                   " Where COM_CD='" & gsCOM_CD & "'" & _
                   " AND substr(tong_start_time, 1,8) >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " AND substr(tong_start_time, 1,8) <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " ) a left join ( " & _
                   " SELECT  '합계'  Gubun" & _
                   ", count(*) Consult_Complete " & _
                   ", sum(if(CONSULT_RESULT = '06',1,0)) Consult_Transfer " & _
                   ", sum(if(CALL_BACK_YN = 'Y',1,0)) Consult_CallBack " & _
                   ", sum(if(CALL_TYPE in ('1','2','3'),0,1)) Call_Etc " & _
                   " FROM t_customer_history " & _
                   " Where COM_CD='" & gsCOM_CD & "'" & _
                   " AND TOND_DD >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " AND TOND_DD <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'" & _
                   " ) b on a.gubun = b.gubun "
            temp &= "  where a.Call_total + a.Call_received + a.call_IB + a.call_OB + a.call_Ext >0 "
            temp &= " ORDER BY  Gubun "
            'WriteLog("" & temp)

            GV_DataBind(gsConString, temp, DataGridView1)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
            result = 1
        End Try
    End Sub

    Public Sub gsFormExit()
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Call gsSelect()
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            With SaveFileDialog1
                .CheckPathExists = True
                .Filter = "Excel통합문서(*.xlsx)|*.xlsx|Excel97-2003문서(*.xls)|*.xls"
                .FileName = "전체통화건수" & "_" & Format(Now, "yyyyMMdd")
                .Title = "전체통화건수 엑셀로 내보내기"
                .ShowDialog()
            End With
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            result = 0
            Call gsSelect()
            While (result = 0)
                Threading.Thread.Sleep(1000)
            End While
            Call Excel_Export2(SaveFileDialog1.FileName, SaveFileDialog1.Title, DataGridView1, "0,1,")
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub FRM_CALL_STATISTICS3_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Call gsFormExit()
    End Sub
End Class