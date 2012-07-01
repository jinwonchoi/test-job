Public Class FRM_CALLLOG

    Private temp As String
    Private temp2 As String = ""

    Private Sub FRM_CALLLOG_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Call SettoolBar(False, True, False, False, False, True, True)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub FRM_CALLLOG_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            CB_Set2(drpHour1, "datetime", 0, 23, 1, "00")
            CB_Set2(drpHour2, "datetime", 0, 23, 1, "23")
            CB_Set2(drpMin1, "datetime", 0, 59, 1, "00")
            CB_Set2(drpMin2, "datetime", 0, 59, 1, "59")
            temp = "SELECT '' S_MENU_CD, '-' S_MENU_NM UNION " & _
                   "SELECT S_MENU_CD, S_MENU_NM FROM t_s_code Where COM_CD='" & gsCOM_CD & "' and L_MENU_CD='005' Order By S_MENU_CD "
            CB_Set(gsConString, temp, drpCalltype, "S_MENU_NM", "S_MENU_CD", "")

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsSelect()
        Try
            ''DataGridView1
            temp = "SELECT "
            temp &= " CONCAT(SUBSTRING(TONG_START_TIME,1,4) , '-' , SUBSTRING(TONG_START_TIME,5,2) , '-' , SUBSTRING(TONG_START_TIME,7,2), ' ', SUBSTRING(TONG_START_TIME,9,2) , ':' , SUBSTRING(TONG_START_TIME,11,2) , ':' , SUBSTRING(TONG_START_TIME,13,2)) TONG_START_TIME"
            temp &= " ,CONCAT(SUBSTRING(TONG_END_TIME,1,4) , '-' , SUBSTRING(TONG_END_TIME,5,2) , '-' , SUBSTRING(TONG_END_TIME,7,2), ' ', SUBSTRING(TONG_END_TIME,9,2) , ':' , SUBSTRING(TONG_END_TIME,11,2) , ':' , SUBSTRING(TONG_END_TIME,13,2)) TONG_END_TIME"
            temp &= " ,TONG_DURATION, EXTENSION_NO, ANI, CALL_TYPE, CALL_RESULT "
            temp &= " ,(SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '005' AND S_MENU_CD = CALL_TYPE ) CALL_TYPE_NAME"
            temp &= " ,(SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '009' AND S_MENU_CD = CALL_RESULT ) CALL_RESULT_NAME"
            temp &= " FROM T_CALL_HISTORY "
            temp &= " Where COM_CD='" & gsCOM_CD & "'"
            temp &= " AND TONG_START_TIME >= '" & DPDate1.Text.Replace("-", "").Replace("/", "").Trim & drpHour1.Text.Trim & drpMin1.Text.Trim & "00'"
            temp &= " AND TONG_START_TIME <= '" & DPDate2.Text.Replace("-", "").Replace("/", "").Trim & drpHour2.Text.Trim & drpMin2.Text.Trim & "60'"
            If drpCalltype.SelectedValue.ToString <> "" Then temp &= " AND CALL_TYPE='" & drpCalltype.SelectedValue.ToString.Trim & "' "
            If txtTongNo.Text.Trim <> "" Then temp &= " AND ANI like '%" & txtTongNo.Text.Trim.Replace("-", "") & "%' "
            If txtExtNo.Text.Trim <> "" Then temp &= " AND EXTENSION_NO like '" & txtExtNo.Text.Trim & "%'"
            temp &= " ORDER BY TONG_START_TIME, EXTENSION_NO "
            'WriteLog("sqltext:" & temp)
            GV_DataBind(gsConString, temp, DataGridView1)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsFormExit()
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Call gsSelect()
    End Sub

    Private Sub FRM_CALLLOG_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Call gsFormExit()
    End Sub
End Class