Public Class FRM_CALL_STATISTICS1

    Private temp As String
    Private temp2 As String = ""
    Private result As Integer = 0

    Private Sub FRM_CALL_STATISTICS1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Call SettoolBar(False, True, False, False, False, True, True)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub FRM_CALL_STATISTICS1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            temp = "SELECT '' USER_ID, '-' USER_NM UNION " & _
                   "SELECT CONCAT(USER_ID, '.', USER_NM) USER_ID, CONCAT(USER_ID, '.', USER_NM) USER_NM " & _
                   "FROM T_USER Where COM_CD='" & gsCOM_CD & "' Order By USER_ID "
            CB_Set(gsConString, temp, drpName, "USER_NM", "USER_ID", "")

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsSelect()

        Dim Gubun As String = ""
        Dim User As String = ""
        Dim temp2 As String = "''"
        Dim temp1 As String = ""
        Dim temp3 As String = "''"

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

            If drpName.SelectedValue.ToString <> "" Then
                temp1 = " AND TONG_USER Like '" & drpName.SelectedValue.ToString.Trim & "%' "
            End If

            ''DataGridView1
            temp = "select a.gubun "
            temp &= ", Substring_index(a.TONG_USER ,'.',1) Sawon_ID "
            temp &= ", Substr(a.TONG_USER, length(Substring_index(a.TONG_USER ,'.',1))+2) Sawon_Name "
            temp &= ",IFNULL(a.call_received,0) call_received "  '총통화수
            temp &= ",IFNULL(a.call_received,0) call_ib "  '인바운드
            'temp &= ",IFNULL(b.Call_IB,0) call_ib " '인바운드
            temp &= ",IFNULL(a.Call_OB,0) call_ob " '아웃바운드
            temp &= ",IFNULL(a.Call_Ext,0) call_ext, IFNULL(b.Consult_Complete,0) consult_complete " '내선 '상담건수
            temp &= ",IFNULL(b.Consult_Transfer,0) consult_transfer, IFNULL(b.Consult_CallBack,0) consult_callback " '이관건수'콜백건수
            temp &= ",IFNULL(b.Call_Etc,0) call_etc " '기타
            temp &= " from ("
            temp &= " SELECT " & temp3 & " Gubun, tong_user"
            temp &= ", sum(if(CALL_RESULT = '3',1,0)) Call_received"
            temp &= ", sum(if(CALL_TYPE = '1',1,0)) Call_IB "
            temp &= ", sum(if(CALL_TYPE = '2',1,0)) Call_OB "
            temp &= ", sum(if(CALL_TYPE = '3',1,0)) Call_Ext "
            temp &= " FROM t_call_history "
            temp &= " Where COM_CD='" & gsCOM_CD & "'"
            temp &= " AND substr(tong_start_time, 1,8) >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= " AND substr(tong_start_time, 1,8) <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= temp1
            temp &= " GROUP BY " & temp3 & ", tong_user"
            temp &= " ) a left join ( "
            temp &= " SELECT " & temp2 & " Gubun, tong_user"
            'temp &= ", sum(if(CALL_TYPE = '0',0,1)) Call_Total"
            temp &= ", count(*) Consult_Complete  "
            temp &= ", sum(if(CONSULT_RESULT = '06',1,0)) Consult_Transfer "
            temp &= ", sum(if(CALL_BACK_YN = 'Y',1,0)) Consult_CallBack "
            temp &= ", sum(if(CALL_TYPE in ('1','2','3'),0,1)) Call_Etc  "
            temp &= " FROM t_customer_history "
            temp &= " Where COM_CD='" & gsCOM_CD & "'"
            temp &= " AND TOND_DD >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= " AND TOND_DD <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= temp1
            temp &= " GROUP BY " & temp2 & ", tong_user"
            temp &= " ) b on a.gubun = b.gubun and a.tong_user = b.tong_user  "
            temp &= "  where a.Call_received + a.call_OB + a.call_Ext >0 "
            temp &= " UNION "
            temp &= "select a.gubun "
            temp &= ", '' Sawon_ID "
            temp &= ", '' Sawon_Name "
            temp &= ",IFNULL(a.call_received,0) call_received "
            temp &= ",IFNULL(a.call_received,0) call_ib"
            'temp &= ",IFNULL(b.Call_IB,0) call_ib"
            temp &= ",IFNULL(a.Call_OB,0) call_ob  "
            temp &= ",IFNULL(a.Call_Ext,0) call_ext, IFNULL(b.Consult_Complete,0) consult_complete "
            temp &= ",IFNULL(b.Consult_Transfer,0) consult_transfer, IFNULL(b.Consult_CallBack,0) consult_callback "
            temp &= ",IFNULL(b.Call_Etc,0) call_etc "
            temp &= " from ("
            temp &= " SELECT '합계' Gubun, '' tong_user"
            temp &= ", sum(if(CALL_RESULT = '3',1,0)) Call_received"
            temp &= ", sum(if(CALL_TYPE = '1',1,0)) Call_IB "
            temp &= ", sum(if(CALL_TYPE = '2',1,0)) Call_OB "
            temp &= ", sum(if(CALL_TYPE = '3',1,0)) Call_Ext "
            temp &= " FROM t_call_history "
            temp &= " Where COM_CD='" & gsCOM_CD & "'"
            temp &= " AND substr(tong_start_time, 1,8) >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= " AND substr(tong_start_time, 1,8) <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= temp1
            temp &= " ) a left join ( "
            temp &= " SELECT '합계' Gubun, '' tong_user"
            temp &= ", sum(if(CALL_TYPE = '0',0,1)) Call_Total"
            temp &= ", count(*) Consult_Complete  "
            temp &= ", sum(if(CONSULT_RESULT = '06',1,0)) Consult_Transfer "
            temp &= ", sum(if(CALL_BACK_YN = 'Y',1,0)) Consult_CallBack "
            temp &= ", sum(if(CALL_TYPE in ('1','2','3'),0,1)) Call_Etc  "
            temp &= " FROM t_customer_history "
            temp &= " Where COM_CD='" & gsCOM_CD & "'"
            temp &= " AND TOND_DD >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= " AND TOND_DD <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & "'"
            temp &= temp1
            temp &= " ) b on a.gubun = b.gubun and a.tong_user = b.tong_user  "
            temp &= "  where a.Call_received + a.call_OB + a.call_Ext >0 "
            temp &= " ORDER BY  Gubun , Sawon_ID "
            'WriteLog(temp)
            GV_DataBind(gsConString, temp, DataGridView1)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            result = 1
        End Try
    End Sub

    Public Sub gsFormExit()
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Call gsSelect()
    End Sub

    'Private Sub DataGridView1_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
    '    If e.IsLastVisibleRow = True And e.RowIndex > 0 Then
    '        Call WriteLog("IsLastVisibleRow " & " : " & e.RowIndex.ToString)
    '        e.InheritedRowStyle.BackColor = Color.LightGray
    '    Else
    '        e.InheritedRowStyle.BackColor = Color.White

    '    End If
    'End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            With SaveFileDialog1
                .CheckPathExists = True
                .Filter = "Excel통합문서(*.xlsx)|*.xlsx|Excel97-2003문서(*.xls)|*.xls"
                .FileName = "개인통화건수" & "_" & Format(Now, "yyyyMMdd")
                .Title = "개인통화건수 엑셀로 내보내기"
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
            Call Excel_Export2(SaveFileDialog1.FileName, SaveFileDialog1.Title, DataGridView1, "0,1,2,")
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub FRM_CALL_STATISTICS1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Call gsFormExit()
    End Sub
End Class