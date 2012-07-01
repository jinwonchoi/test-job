Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Threading
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module MiniCTI
	
    Public gsCOM_CD As String
    Public gsUSER_ID As String
    Public gsUSER_NM As String
    Public gsUSR_HP As String
    Public gsADDR1 As String
    Public gsWOO_NO As String
    Public gsH_TELNO As String
    Public gsDEPART_CD As String
    Public gsGRADE As String
    Public gsEXTENSION_NO As String
    Public gsWORK_TYPE As String
    Public gsENTERING_DD As String
    Public gsRETIRE_DD As String
    Public gsUSER_EMAIL As String
    Public gsDEPART_NM As String
    Public gsUSER_PWD As String
    Public gsWORK_AREA As String
    Public gsCompany As String

    Public gsTeam_CD As String
    Public gsTeam_NM As String

    Public gsSocketIP As String
    Public gsSocketPort As String


    Public gsConString As String                  ' DB Con String
    Public Const file_path As String = "C:\MiniCTI"
    Public Const config_file As String = "\config\MiniCTI_config_demo.xml"
    Public Const gsAppVersion As String = "Ver 2.1.1.1B"
    Public gsPopUpOption As String = "MDI"

    Public gsUseARS As String = "N"

    Public FormAliveYN As String = "N"

    Public DBConReadYn As String = "N"                      ' DB Connection string read 여부

    Public gbIsCustomerTablePatched As Boolean = False

    Public Const gsExcelSheetCustomer As String = "고객정보"
    Public Const gsCheckCustomerColumnName As String = "회사코드"
    Public Const giCustomerImportColCount As Integer = 9


    Public Function gfTelNoTransReturn(ByVal telno As String) As String
        Dim tel As String = "000-0000-0000"

        Try
            Dim tel_no As String = telno.Trim.Substring(0, 3)

            Dim pre_tel_no As String = "0000"
            Dim mid_tel_no As String = "0000"
            Dim last_tel_no As String = "0000"

            If tel_no = "010" Or tel_no = "011" Or tel_no = "016" Or tel_no = "017" Or tel_no = "018" Or tel_no = "019" Then
                pre_tel_no = tel_no
                Dim rest_telno As String = telno.Substring(3)
                If rest_telno.Length = 7 Then
                    mid_tel_no = telno.Substring(3, 3)
                    last_tel_no = telno.Substring(6)
                ElseIf rest_telno.Length = 8 Then
                    mid_tel_no = telno.Substring(3, 4)
                    last_tel_no = telno.Substring(7)
                End If

                tel = pre_tel_no + "-" + mid_tel_no + "-" + last_tel_no
            Else

                tel_no = telno.Trim.Substring(0, 2)

                If tel_no = "02" Then            ' 서울 지역일때
                    pre_tel_no = "02"

                    Dim rest_telno As String = telno.Substring(2)
                    If rest_telno.Length = 7 Then
                        mid_tel_no = telno.Substring(2, 3)
                        last_tel_no = telno.Substring(5)
                    ElseIf rest_telno.Length = 8 Then
                        mid_tel_no = telno.Substring(2, 4)
                        last_tel_no = telno.Substring(6)
                    End If

                    tel = pre_tel_no + "-" + mid_tel_no + "-" + last_tel_no
                Else
                    pre_tel_no = telno.Substring(0, 3)

                    Dim rest_telno As String = telno.Substring(3)
                    If rest_telno.Length = 7 Then
                        mid_tel_no = telno.Substring(3, 3)
                        last_tel_no = telno.Substring(6)
                    ElseIf rest_telno.Length = 8 Then
                        mid_tel_no = telno.Substring(3, 4)
                        last_tel_no = telno.Substring(7)
                    End If

                    tel = pre_tel_no + "-" + mid_tel_no + "-" + last_tel_no
                End If

            End If

        Catch ex As Exception
            tel = "000-0000-0000"
        End Try

        Return tel

    End Function

    Public Function IsHPNumber(ByVal num As String) As String
        Dim tel_no As String = num.Trim.Substring(0, 3)

        If tel_no = "010" Or tel_no = "011" Or tel_no = "016" Or tel_no = "017" Or tel_no = "018" Or tel_no = "019" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Public Sub popup1()
    '    Dim newF As New FRM_CUSTOMER_POPUP
    '    newF.Show()

    'End Sub

    Public Function XmlRead(ByVal n As Integer, ByVal keyname As String) As String
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load(file_path & config_file)

            Dim root As XmlElement = doc.DocumentElement


            Dim elemList As XmlNodeList = root.GetElementsByTagName(keyname)

            Return elemList.Item(0).ChildNodes(n).FirstChild.Value.ToString

            Exit Function

        Catch ex As Exception
            Call WriteLog("Error(XMLRead) : " & ex.ToString)
            Return ""
        End Try

    End Function

    Public Sub XmlReadMode()
        Try
            gsConString = "Data Source=" & XmlRead(1, "db") & ";Initial Catalog=" & XmlRead(2, "db") & ";User ID=" & XmlRead(3, "db") & ";Password=" & XmlRead(4, "db")
            DBConReadYn = "Y"
            gsUseARS = XmlRead(0, "worktype")
        Catch ex As Exception
            DBConReadYn = "N"
            gsConString = ""
        End Try
    End Sub

    Public Sub SettoolBar(ByVal initbol As Boolean, ByVal selectbol As Boolean, ByVal savebol As Boolean, ByVal deletebol As Boolean, ByVal helpbol As Boolean, ByVal formexitbol As Boolean, ByVal exitbol As Boolean)
        'FRM_MAIN.toolInit.Enabled = initbol
        'FRM_MAIN.toolSelect.Enabled = selectbol
        'FRM_MAIN.toolSave.Enabled = savebol
        'FRM_MAIN.toolDelete.Enabled = deletebol
        'FRM_MAIN.toolHelp.Enabled = helpbol
        'FRM_MAIN.toolFormExit.Enabled = formexitbol
        'FRM_MAIN.toolExit.Enabled = exitbol

    End Sub
    Public  Function Find_Query(ByVal s_code As String) As String
        Dim SQL As String = ""
        Try
            SQL = " SELECT '' S_MENU_NM,'XXXX' S_MENU_CD UNION ALL SELECT S_MENU_NM,S_MENU_CD FROM T_S_CODE WHERE  COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '" & s_code & "'"
        Catch ex As Exception
            SQL = ""
        End Try
        Return SQL

    End Function


    '**********************************************************************************************************
    '****************************** 모두 이함수 사용합시다 ****************************************************
    '**********************************************************************************************************
    Public Function GetData_table1(ByVal constring As String, ByVal strSql As String) As DataTable

        Dim con As MySqlClient.MySqlConnection
        Dim com As MySqlClient.MySqlCommand
        Dim da As MySqlClient.MySqlDataAdapter
        Dim dt As New DataTable
        Dim temp As String = ""



        Try
            con = New MySqlClient.MySqlConnection(constring)
            com = New MySqlClient.MySqlCommand(strSql, con)
            da = New MySqlClient.MySqlDataAdapter(com)

            com.CommandType = CommandType.Text
            com.CommandText = strSql

            con.Open()
            da.Fill(dt)

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            GetData_table1 = dt
            con.Close()
            
            dt = Nothing
            da = Nothing
            com = Nothing
            con = Nothing
        End Try
    End Function

    Public Function GetData_table_Error(ByVal constring As String, ByVal strSql As String) As DataTable

        Dim con As MySqlClient.MySqlConnection
        Dim com As MySqlClient.MySqlCommand
        Dim da As MySqlClient.MySqlDataAdapter
        Dim dt As New DataTable
        Dim temp As String = ""

        Try
            con = New MySqlClient.MySqlConnection(constring)
            com = New MySqlClient.MySqlCommand(strSql, con)
            da = New MySqlClient.MySqlDataAdapter(com)

            com.CommandType = CommandType.Text
            com.CommandText = strSql

            con.Open()
            da.Fill(dt)

        Finally
            GetData_table_Error = dt
            con.Close()
            dt = Nothing
            da = Nothing
            com = Nothing
            con = Nothing
        End Try
    End Function

    'Public Function GetDT(ByVal constring As String, ByVal strSql As String) As DataTable

    '    Dim s_dbcon As String = constring
    '    Dim con As SqlClient.SqlConnection
    '    Dim com As SqlClient.SqlCommand
    '    Dim da As SqlClient.SqlDataAdapter
    '    Dim dt As New DataTable
    '    Dim temp As String = ""
    '    Dim i As Integer

    '    con = New SqlClient.SqlConnection(s_dbcon)
    '    com = New SqlClient.SqlCommand
    '    da = New SqlClient.SqlDataAdapter(com)

    '    Try
    '        com.CommandType = CommandType.Text
    '        com.CommandText = strSql

    '        con.Open()
    '        com.CommandTimeout = 60000
    '        '자동증가 컬럼 추가 (DataGridView 페이징을 위해서)
    '        dt.Columns.Add(Increment_Column(1, 1))
    '        da.Fill(dt)
    '        com.Parameters.Clear()
    '    Catch ex As Exception
    '        Call WriteLog("eVoice.clsWebAppComModule.GetData_table - " & strSql & ">>" & com.CommandText & ":" & ex.ToString)
    '    Finally
    '        GetDT = dt
    '        con.Close()
    '        dt = Nothing
    '        da = Nothing
    '        com = Nothing
    '        con = Nothing
    '    End Try
    'End Function

    'Public Function Increment_Column(ByVal iSeed As Integer, ByVal iStep As Integer) As DataColumn
    '    Dim col As New DataColumn()
    '    Try
    '        col.DataType = System.Type.GetType("System.Int32")
    '        col.ColumnName = "newID"
    '        col.AutoIncrement = True
    '        col.AutoIncrementSeed = iSeed
    '        col.AutoIncrementStep = iStep
    '    Catch ex As Exception
    '        WriteLog("eVoice.clsWebAppComModule.Setting_DrpPage : " & ex.ToString)
    '    End Try
    '    Increment_Column = col
    'End Function

    Public Function GetData_exe(ByVal constring As String, ByVal procedurename As String, ByVal ParamArray parameters() As String) As Boolean

        Dim bol As Boolean = True
        Dim s_dbcon As String = constring
        Dim con As SqlClient.SqlConnection
        Dim com As SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim querystring As String = "Exec "     '프로시져 실행구문을 작성한다.
        Dim i As Integer


        Try

            con = New SqlClient.SqlConnection(s_dbcon)
            com = New SqlClient.SqlCommand
            da = New SqlClient.SqlDataAdapter(com)
            ds = New DataSet

            querystring = querystring & procedurename & " "     '프로시져의 명을 실행구문에 추가한다.

            If parameters.Length > 0 Then
                querystring = querystring & "'" & parameters(0).Replace("'", "''") & "'"        '첫번째 파라메터를 실행구문에 추가한다.
            End If

            For i = 1 To parameters.Length - 1
                querystring = querystring & ", '" & parameters(i).Replace("'", "''") & "'"      '두번째 이후 파라메터들을 실행구문에 추가한다.
            Next

            com.CommandText = querystring

            com.Connection = con
            con.Open()

            Dim j As Integer = com.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            bol = False
            Call WriteLog("Exception : " & ex.ToString)
        End Try

        Return bol

    End Function

    'Public Function GetData_table(ByVal constring As String, ByVal procedurename As String, ByVal ParamArray parameters() As String) As DataTable

    '    Dim s_dbcon As String = constring  'ConfigurationManager.ConnectionStrings(constring).ConnectionString
    '    Dim con As SqlClient.SqlConnection
    '    Dim com As SqlClient.SqlCommand
    '    Dim da As SqlClient.SqlDataAdapter
    '    Dim dt As New DataTable
    '    Dim temp As String = ""
    '    Dim i As Integer

    '    con = New SqlClient.SqlConnection(s_dbcon)
    '    com = New SqlClient.SqlCommand
    '    da = New SqlClient.SqlDataAdapter(com)

    '    Try

    '        If parameters.Length > 0 Then
    '            For i = 0 To parameters.Length - 1
    '                If i = 0 Then
    '                    temp = "'" & parameters(i).Replace("'", "''") & "'"
    '                Else
    '                    temp = temp & ",'" & parameters(i).Replace("'", "''") & "'"      '두번째 이후 파라메터들을 실행구문에 추가
    '                End If
    '            Next
    '        End If

    '        If procedurename.StartsWith("P_") = True Then
    '            com.CommandText = "Exec " & procedurename & " " & temp    '프로시져 실행구문
    '        Else
    '            com.CommandText = procedurename     '쿼리 실행구문
    '        End If
    '        'If ConfigurationManager.AppSettings("LOG").ToString.ToUpper = "Y" Then _
    '        'eVoice_Common.eVoiceLog.WriteLog("eVoice.clsWebAppComModule.GetData_table - ", com.CommandText, "debug")
    '        com.Connection = con
    '        con.Open()
    '        da.Fill(dt)
    '        com.Parameters.Clear()
    '    Catch ex As Exception
    '        'Call WriteLog("Exception : " & GetData_table--> procedurename & ">>" & com.CommandText & ":" & ex.ToString )
    '    Finally
    '        GetData_table = dt
    '        con.Close()
    '        dt = Nothing
    '        da = Nothing
    '        com = Nothing
    '        con = Nothing
    '    End Try
    'End Function

    Public Sub WriteLog(ByVal msg As String)

        Dim strNow As String
        Dim strNow1 As String

        Try
            strNow = Format(Now, "yyyyMMddHHmmss")

            '파일 스트림 생성
            Dim fs As FileStream = New FileStream(file_path & "\log\TStoryWorld_" & strNow.Substring(0, 8) & ".log", FileMode.Append)

            '파일 입력 작업을 위해 StreamWriter 객체를 얻는다
            Dim sw As StreamWriter = New StreamWriter(fs, System.Text.Encoding.Default)

            strNow1 = "[" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "]"

            sw.WriteLine(strNow1)
            sw.WriteLine("          " & msg)

            sw.Close()
            fs = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Public Sub log_delete()

        Dim log_delete_day As String = DateTime.Now.AddDays(-5).ToString.Substring(0, 10).Replace("-", "")

        Try
            Dim dir1 As DirectoryInfo = New DirectoryInfo(file_path & "\log")
            Dim datfiles() As FileInfo = dir1.GetFiles("*.log")

            Dim f As FileInfo

            For Each f In datfiles
                ' 0      1     2  3    4     5 
                'Online_Daemon_To_Host_lib_20101118.log()
                Dim f_name() As String = f.Name.ToString.Split("_")
                'If f.Name.Contains(log_delete_day) = False Then
                '    Call WriteLog("Log Data 삭제 --> 삭제 파일명 : " & f.Name.ToString.Trim)
                '    f.Delete()
                'End If

                If f_name(5).ToString.Replace(".log", "") < log_delete_day Then
                    f.Delete()
                    Call WriteLog("Log Data  --> File Name : " & f.Name.ToString.Trim)
                End If

            Next

            f = Nothing
            dir1 = Nothing

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Function Mysql_GetData_table(ByVal constring As String, ByVal sqltext As String, ByVal ParamArray parameters() As String) As DataTable

        Dim s_dbcon As String = constring
        Dim con As MySqlConnection
        Dim com As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim temp As String = ""

        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        con = New MySqlConnection(constring) 'SqlClient.SqlConnection(s_dbcon)
        com = New MySqlCommand
        da = New MySqlDataAdapter(com)

        Try
            com.CommandText = sqltext     '쿼리 실행구문
            'WriteLog(sqltext)
            com.Connection = con
            con.Open()
            If sqltext.Trim.ToLower.StartsWith("select") = True Then
                da.Fill(dt)
            Else
                Dim j As Integer = com.ExecuteNonQuery()
            End If
            com.Parameters.Clear()
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Mysql_GetData_table = Nothing
        Finally
            Mysql_GetData_table = dt
            con.Close()
            dt = Nothing
            da = Nothing
            com = Nothing
            con = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Function

    Public Function Mysql_Transact_Data(ByVal constring As String, ByVal sqltext As String, ByVal ParamArray parameters() As String) As Integer

        Dim s_dbcon As String = constring
        Dim con As MySqlConnection
        Dim com As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim temp As String = ""
        Dim iRow As Integer

        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        con = New MySqlConnection(constring) 'SqlClient.SqlConnection(s_dbcon)
        com = New MySqlCommand
        da = New MySqlDataAdapter(com)

        Try
            com.CommandText = sqltext     '쿼리 실행구문
            'WriteLog(sqltext)
            com.Connection = con
            con.Open()
            If sqltext.Trim.ToLower.StartsWith("select") = True Then
                Throw (New Exception("Query is not available with this method."))
            Else
                iRow = com.ExecuteNonQuery()
            End If
            com.Parameters.Clear()
            Mysql_Transact_Data = iRow
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Mysql_Transact_Data = 0
        Finally
            con.Close()
            da = Nothing
            com = Nothing
            con = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Function

    Public Sub CB_Set(ByVal constring As String, ByVal sqltext As String, ByVal obj As Object, ByVal TextField As String, ByVal ValueField As String, ByVal SelectValue As Object, ByVal ParamArray parameters() As String)
        Dim dt As DataTable
        Try
            dt = Mysql_GetData_table(constring, sqltext, parameters)
            obj.DataSource = dt
            obj.DisplayMember = TextField
            obj.ValueMember = ValueField
            If SelectValue = Nothing Then Exit Try
            If obj.ValueMember.Contains(SelectValue) = True Then
                obj.SelectedValue = SelectValue
            End If

        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally
            dt = Nothing
        End Try
    End Sub

    Public Sub CB_Set2(ByVal obj As ComboBox, ByVal type As String, ByVal iSTART As Short, ByVal iEND As Short, ByVal iInterval As Short, ByVal SelectText As String, ByVal ParamArray parameters() As String)

        Dim i As Short = iEND - iSTART '+ 1
        Dim j As Short = 0
        Dim k As Short = 0

        Try
            If i < 1 OrElse iInterval < 1 Then Exit Try
            obj.Items.Clear()
            k = i / iInterval
            Dim ItemObject(k) As System.Object

            Select Case type.ToLower.Trim
                Case "datetime"
                    While j <= k
                        i = iSTART + (iInterval * j)
                        'WriteLog("j:" & j & " i:" & i)
                        If i < 10 Then
                            ItemObject(j) = "0" & CStr(i)
                        Else
                            ItemObject(j) = CStr(i)
                        End If
                        j += 1
                    End While
                    obj.Items.AddRange(ItemObject)
                Case Else
                    While j <= k
                        i = iSTART + (iInterval * j)
                        ItemObject(j) = CStr(i)
                        j += 1
                    End While
                    obj.Items.AddRange(ItemObject)
            End Select

            If parameters.Length > 0 Then
                Select Case parameters(0).Trim.ToLower
                    Case "add"
                        obj.Items.Insert(0, "")
                        obj.SelectedIndex = 0
                    Case Else
                End Select
            End If
            If obj.FindString(SelectText) >= 0 Then
                'obj.SelectedText = SelectText
                obj.Text = SelectText
            End If

            ItemObject = Nothing
        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally

        End Try
    End Sub

    Public Sub GV_DataBind(ByVal constring As String, ByVal sqltext As String, ByVal obj As DataGridView, ByVal ParamArray parameters() As String)
        Dim dt As DataTable

        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            obj.AutoGenerateColumns = False
            dt = Mysql_GetData_table(constring, sqltext, parameters)
            If dt.Rows.Count = 1 AndAlso dt.Rows(0).Item(0).ToString = "합계" Then  '데이타가 없는 경우 합계도 안보여주기.
                obj.DataSource = Nothing
            Else
                obj.DataSource = dt
            End If
        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally
            dt = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Public Sub Excells_Import(ByVal filepath As String)
        Dim dt As DataTable
        Dim dt2 As New DataTable
        Dim temp As String = ""
        Dim ext As String = ""
        Dim i As Integer = 0
        Dim k As Integer = 0

        Try
            i = filepath.LastIndexOf(".")
            If i > 0 Then ext = filepath.Substring(i + 1)
            dt = GetDataFromExcel(filepath, ext)
            'WriteLog("excells_Import : " & dt.Rows.Count & " ext:" & ext)
            ''테이블에 insert
            If gbIsCustomerTablePatched Then
                If (giCustomerImportColCount + 3) <> dt.Columns.Count Then
                    MsgBox("엑셀포맷이 맞지 않습니다. 확인해주세요.", MsgBoxStyle.OkOnly, "정보")
                    Return
                End If
            Else
                If giCustomerImportColCount <> dt.Columns.Count Then
                    MsgBox("엑셀포맷이 맞지 않습니다. 확인해주세요.", MsgBoxStyle.OkOnly, "정보")
                    Return
                End If
            End If

            For i = 0 To dt.Rows.Count - 1
                'WriteLog("i : " & i & " dt.Rows(i)(0) : " & dt.Rows(i)(0).ToString().Trim & " dt.Rows(i)(1) : " & dt.Rows(i)(1).ToString().Trim & " dt.Rows(i)(2) : " & dt.Rows(i)(2).ToString().Trim & " dt.Rows(i)(3) : " & dt.Rows(i)(3).ToString().Trim)
                '칼럼명인 경우 스킵
                If dt.Rows(i)(0).ToString().Trim = gsExcelSheetCustomer Then
                    Continue For
                End If

                If dt.Rows(i)(0).ToString().Trim <> "" AndAlso dt.Rows(i)(0).ToString().Trim.Length < 5 Then

                    If (gbIsCustomerTablePatched) Then
                        temp = "INSERT INTO T_CUSTOMER(COM_CD,CUSTOMER_NM, " & _
                                "COMPANY,DEPARTMENT,JOB_TITLE, " & _
                                "C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO, " & _
                                "CUSTOMER_ADDR,CUSTOMER_ETC,C_TELNO1,H_TELNO1) " & _
                                " Values('" & _
                                dt.Rows(i)(0).ToString().Trim & "','" & _
                                dt.Rows(i)(1).ToString().Trim & "','" & _
                                dt.Rows(i)(2).ToString().Trim & "','" & _
                                dt.Rows(i)(3).ToString().Trim & "','" & _
                                dt.Rows(i)(4).ToString().Trim & "','" & _
                                dt.Rows(i)(5).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(6).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(7).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(8).ToString().Trim & "','" & _
                                dt.Rows(i)(9).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(10).ToString().Trim & "','" & _
                                dt.Rows(i)(11).ToString().Trim & "','" & _
                                dt.Rows(i)(5).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(6).ToString().Replace("-", "").Replace(" ", "").Trim & "')"
                    Else
                        temp = "INSERT INTO T_CUSTOMER(COM_CD,CUSTOMER_NM, " & _
                                "C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO, " & _
                                "CUSTOMER_ADDR,CUSTOMER_ETC,C_TELNO1,H_TELNO1) " & _
                                " Values('" & _
                                dt.Rows(i)(0).ToString().Trim & "','" & _
                                dt.Rows(i)(1).ToString().Trim & "','" & _
                                dt.Rows(i)(2).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(3).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(4).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(5).ToString().Trim & "','" & _
                                dt.Rows(i)(6).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(7).ToString().Trim & "','" & _
                                dt.Rows(i)(8).ToString().Trim & "','" & _
                                dt.Rows(i)(2).ToString().Replace("-", "").Replace(" ", "").Trim & "','" & _
                                dt.Rows(i)(3).ToString().Replace("-", "").Replace(" ", "").Trim & "') "
                    End If

                    'WriteLog(temp)
                    dt2 = Mysql_GetData_table(gsConString, temp)
                    k += 1
                    dt2.Reset()
                End If
            Next
            WriteLog("*** Target Count : " & dt.Rows.Count & " => Insert Count : " & k & " ***")
            MsgBox(k & "건이 처리되었습니다.", MsgBoxStyle.OkOnly, "정보")

        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally
            dt = Nothing
            dt2 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If k > 0 Then Call Audit_Log(AUDIT_TYPE.CUSTOMER_IMPORT, "Customer Import:" & CStr(k))
        End Try
    End Sub

    Public Function GetDataFromExcel(ByVal FilePath As String, ByVal FileExt As String) As DataTable
        Dim constring As String

        If FileExt.ToLower.Trim = "xls" Then
            constring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & FilePath & _
                    ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;"""
        Else  'FileExt.ToLower.Trim = "xlsx" Then
            constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FilePath & _
                    ";Extended Properties=""Excel 12.0;HDR=YES;IMEX=1;"""
        End If
        Dim dt As New DataTable
        Dim cn As New System.Data.OleDb.OleDbConnection(constring)
        Try
            cn.Open()
            dt = cn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, _
                                        New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'For i = 0 To dt.Rows.Count - 1
            '    MessageBox.Show(dt.Rows(i)("TABLE_NAME"))
            'Next

            dt.Reset()
            Dim com As New OleDb.OleDbCommand("SELECT * FROM [" & gsExcelSheetCustomer & "$]", cn)
            Dim Adapter As New System.Data.OleDb.OleDbDataAdapter()
            Adapter.SelectCommand = com
            Adapter.Fill(dt)
            'WriteLog("GetDataFromExcel Rows.Count - " & dt.Rows.Count & " / " & dt.Rows(0)(0).ToString)
        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally
            GetDataFromExcel = dt
            cn.Close()
            dt.Dispose()
            cn.Dispose()
        End Try
    End Function

    Public Function Get_TELNO(ByVal tenno1 As String)
        Dim telno As String = tenno1.Replace("-", "").Trim
        Try
            If telno.Length < 7 Then Exit Try
            Select Case telno.Length
                Case 7
                    telno = telno.Substring(0, 3) & "-" & telno.Substring(3)
                Case 8
                    If telno.StartsWith("2") = True Then
                        telno = "02-" & telno.Substring(1, 3) & "-" & telno.Substring(4)
                    Else
                        telno = telno.Substring(0, 4) & "-" & telno.Substring(4)
                    End If
                Case Else
                    If telno.StartsWith("0") = False Then telno = "0" & telno
                    If telno.StartsWith("02") = True Then '024445555   9  0244445555
                        telno = "02-" & telno.Substring(2, telno.Length - 6) & "-" & telno.Substring(telno.Length - 4)
                    Else  '0101234567 10    01012345678 11
                        telno = telno.Substring(0, 3) & "-" & telno.Substring(3, telno.Length - 7) & "-" & telno.Substring(telno.Length - 4)
                    End If
            End Select

        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally
            Get_TELNO = telno
        End Try

    End Function

    Public Sub Excells_Export(ByVal filepath As String)
        Dim dt As DataTable
        Dim temp As String = ""
        Dim i As Integer = 0
        Dim k As Integer = 0

        Try
            Dim excelApp As New Microsoft.Office.Interop.Excel.Application
            If excelApp Is Nothing Then
                MsgBox("엑셀이 설치되지 않았거나 다른문제가 있습니다.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If

            'temp = "SELECT COM_CD,CUSTOMER_ID, CUSTOMER_NM,C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR,CUSTOMER_ETC FROM T_CUSTOMER ORDER BY COM_CD,CUSTOMER_ID LIMIT 0, 100 "
            If (gbIsCustomerTablePatched) Then
                temp = "SELECT COM_CD,CUSTOMER_ID, CUSTOMER_NM,COMPANY, DEPARTMENT, JOB_TITLE, C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR,CUSTOMER_ETC FROM T_CUSTOMER ORDER BY COM_CD,CUSTOMER_ID "
            Else
                temp = "SELECT COM_CD,CUSTOMER_ID, CUSTOMER_NM,C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR,CUSTOMER_ETC FROM T_CUSTOMER ORDER BY COM_CD,CUSTOMER_ID "

            End If
            dt = Mysql_GetData_table(gsConString, temp)

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            If File.Exists(filepath) Then File.Delete(filepath)

            Dim excelBook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add
            Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet = CType(excelBook.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
            excelWorksheet.Name = gsExcelSheetCustomer '==>"고객정보"

            With excelWorksheet
                .Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft '셀 텍스트 맞춤을 left 로 지정. 
                .Columns.NumberFormat = "@"   '셀서식을 텍스트 타입으로 지정. 회사번호나 전화번호가 0으로 시작되므로 필요.

                ' 첫줄에 칼럼 타이틀을 써줍니다.
                .Cells(1, 1) = "회사코드"
                .Cells(1, 2) = "고객아이디"
                .Cells(1, 3) = "고객명"
                If (gbIsCustomerTablePatched) Then
                    .Cells(1, 4) = "회사"
                    .Cells(1, 5) = "소속"
                    .Cells(1, 6) = "직급"
                    .Cells(1, 7) = "직장 번호"
                    .Cells(1, 8) = "핸드폰 번호"
                    .Cells(1, 9) = "팩스 번호"
                    .Cells(1, 10) = "고객유형 코드"
                    .Cells(1, 11) = "우편번호"
                    .Cells(1, 12) = "고객 주소"
                    .Cells(1, 13) = "기타 정보"
                Else
                    .Cells(1, 4) = "직장 번호"
                    .Cells(1, 5) = "핸드폰 번호"
                    .Cells(1, 6) = "팩스 번호"
                    .Cells(1, 7) = "고객유형 코드"
                    .Cells(1, 8) = "우편번호"
                    .Cells(1, 9) = "고객 주소"
                    .Cells(1, 10) = "기타 정보"
                End If

                If dt.Rows.Count < 1 Then Exit Try

                ' 두번째 줄 부터 데이터를 입력
                For k = 0 To dt.Rows.Count - 1
                    For i = 0 To dt.Columns.Count - 1
                        .Cells(k + 2, i + 1) = dt.Rows(k).Item(i).ToString.Replace(" ", "")
                    Next
                Next

                excelApp.Visible = False '저장후 자동으로 엑셀 파일이 열리지 않는다
                ChDir("C:\")
                excelApp.ActiveWorkbook.SaveAs(Filename:=filepath, _
                                               Password:="", WriteResPassword:="", _
                                               ReadOnlyRecommended:=False, CreateBackup:=False)
            End With

            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
            'excelWorksheet = Nothing
            excelBook.Close()
            excelApp.Quit()
            'System.Runtime.InteropServices.Marshal.ReleaseComO(bject(excelWorksheet))
            'System.Runtime.InteropServices.Marshal.ReleaseComO(bject(excelBook))
            'System.Runtime.InteropServices.Marshal.ReleaseComO(bject(excelApp))
            excelApp = Nothing
            excelBook = Nothing
            excelWorksheet = Nothing
        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally
            dt = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If k > 0 Then Call Audit_Log(AUDIT_TYPE.CUSTOMER_EXPORT, "Customer Export:" & CStr(k + 1))
        End Try
    End Sub

    Public Sub Excel_Export2(ByVal filepath As String, ByVal title As String, ByVal DV As DataGridView, Optional ByVal TStyle As String = "")
        Dim temp As String = ""
        Dim i As Integer = 0
        Dim k As Integer = 0
        Dim Alp As String() = {"A", "B", "C", "D", "E", "F", "G", "H", _
                               "I", "J", "K", "L", "M", "N", "O", "P", _
                               "Q", "R", "S", "T", "U", "V", "W", "X", _
                               "Y", "Z"}
        Dim excelApp As New Microsoft.Office.Interop.Excel.Application
        Dim excelBook As Microsoft.Office.Interop.Excel.Workbook
        Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet
        Try
            If excelApp Is Nothing Then
                MsgBox("엑셀이 설치되지 않았거나 다른문제가 있습니다.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            If File.Exists(filepath) Then File.Delete(filepath)

            excelBook = excelApp.Workbooks.Add
            excelWorksheet = CType(excelBook.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
            
            With excelWorksheet
                .Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft '셀 텍스트 맞춤을 left 로 지정. 
                .Columns.NumberFormat = "@"   '셀서식을 텍스트 타입으로 지정. 회사번호나 전화번호가 0으로 시작되므로 필요.

                'If DV.RowCount < 1 Then Exit Try
                'MsgBox(DV.ColumnCount & "-" & DV.RowCount.ToString)
                For i = 0 To DV.ColumnCount - 1
                    'If DV.Columns(i).Displayed = True Then
                    If TStyle.Contains(i.ToString & ",") Then
                        .Range(Alp.GetValue(i).ToString & "1:" & Alp.GetValue(i).ToString & (DV.RowCount + 1).ToString).Columns.NumberFormat = "@"
                    End If
                    For k = 0 To DV.RowCount
                        If k = 0 Then ' 첫줄에 칼럼 타이틀을 써줍니다.
                            .Range(Alp.GetValue(i).ToString & "1").Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DeepSkyBlue)
                            .Cells(k + 1, i + 1) = DV.Columns(i).HeaderText.Replace(" ", "")
                        Else  '  두번째 줄 부터 데이터를 입력
                            .Cells(k + 1, i + 1) = DV.Rows(k - 1).Cells(i).Value.ToString.Replace(" ", "")
                        End If
                    Next
                    ' End If
                Next
                excelApp.Visible = False '저장후 자동으로 엑셀 파일이 열리지 않는다
                ChDir("C:\")
                excelApp.ActiveWorkbook.SaveAs(Filename:=filepath, Password:="", WriteResPassword:="", ReadOnlyRecommended:=False, CreateBackup:=False)
            End With

            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
        Catch ex As Exception
            WriteLog(ex.ToString)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            excelWorksheet = Nothing
            excelBook = Nothing
            excelApp.Quit()
            excelApp = Nothing
            GC.Collect()

        End Try
    End Sub

    Enum AUDIT_TYPE
        CUSTOMER_IMPORT = 0
        CUSTOMER_EXPORT = 1
        CODE_ADD = 2
        CODE_DEL = 3
        CODE_MOD = 4
        PWD_MOD = 5
        CALLLOG_DOWN = 6
        USER_ADD = 7
        USER_DEL = 8
        USER_MOD = 9
    End Enum

    Public Sub Audit_Log(ByVal auditType As AUDIT_TYPE, ByVal auditDesc As String)

        Dim tm As String = Format(Now, "yyyyMMddHHmmss")
        Dim auditCode As String = "0000"
        Dim auditCodeDesc As String = "0000"
        Try
            'select COM_CD,CUSTOMER_ID,TELNO_TYPE,TELNO from t_customer_telno
            'gsCOM_CD

            Select Case auditType
                Case AUDIT_TYPE.CUSTOMER_IMPORT
                    auditCode = "0001"
                    auditCodeDesc = auditCode & ":CUSTOMER_IMPORT"
                Case AUDIT_TYPE.CUSTOMER_EXPORT
                    auditCode = "0002"
                    auditCodeDesc = auditCode & ":CUSTOMER_EXPORT"
                Case AUDIT_TYPE.CODE_ADD
                    auditCode = "0003"
                    auditCodeDesc = auditCode & ":CODE_ADD"
                Case AUDIT_TYPE.CODE_DEL
                    auditCode = "0004"
                    auditCodeDesc = auditCode & ":CODE_DEL"
                Case AUDIT_TYPE.CODE_MOD
                    auditCode = "0005"
                    auditCodeDesc = auditCode & ":CODE_MOD"
                Case AUDIT_TYPE.PWD_MOD
                    auditCode = "0006"
                    auditCodeDesc = auditCode & ":PWD_MOD"
                Case AUDIT_TYPE.CALLLOG_DOWN
                    auditCode = "0007"
                    auditCodeDesc = auditCode & ":CALLLOG_DOWN"
                Case AUDIT_TYPE.USER_ADD
                    auditCode = "0008"
                    auditCodeDesc = auditCode & ":USER_ADD"
                Case AUDIT_TYPE.USER_DEL
                    auditCode = "0009"
                    auditCodeDesc = auditCode & ":USER_DEL"
                Case AUDIT_TYPE.USER_MOD
                    auditCode = "0010"
                    auditCodeDesc = auditCode & ":USER_MOD"
            End Select

            Dim SQL As String = " INSERT INTO t_auditlog( COM_CD,USER_ID,AUDIT_DD,AUDIT_CD, AUDIT_DESC) VALUES( "
            SQL = SQL & "'" & gsCOM_CD & "'"
            SQL = SQL & ",'" & gsUSER_ID & "'"
            SQL = SQL & ",'" & tm & "'"
            SQL = SQL & ",'" & auditCode & "'"
            SQL = SQL & ",'" & auditDesc & "')"

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing

            Call WriteLog("Audit_Log: " & "[" & gsCOM_CD & "][" & gsUSER_ID & "][" & tm & "][" & auditCodeDesc & "]")

        Catch ex As Exception
            Call WriteLog("Audit_Log:Write Error:" & "[" & gsCOM_CD & "][" & gsUSER_ID & "][" & tm & "][" & auditCodeDesc & "]")
            Call WriteLog("Audit_Log:Write Error:" & ex.ToString)
        End Try
    End Sub

    Public Sub setComboSelect(ByVal sender As System.Object, ByVal idx As Integer)
        Dim cBox As ComboBox = sender
        If cBox.Items.Count >= idx + 1 Then
            cBox.SelectedIndex = idx
        Else
            cBox.SelectedIndex = 0
        End If
    End Sub

    Public Function IsT_CustomerTablePatched(ByVal tableName As String, ByVal columnName As String)
        Dim dt1 As DataTable
        Try
            Dim SQL As String = " SELECT COMPANY FROM t_customer "
            SQL = SQL & " limit 1"

            dt1 = GetData_table_Error(gsConString, SQL)
            Dim CNT As String = "0"

            CNT = dt1.Rows.Count
            Return True
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(":IsT_CustomerTablePatched:" & ex.ToString)
            Return False
        Finally
            dt1 = Nothing
        End Try
    End Function

    Public Sub CheckCustomerTablePatched()
        If (IsT_CustomerTablePatched("T_CUSTOMER", "COMPANY")) Then
            gbIsCustomerTablePatched = True
            Call WriteLog("MiniCTI : IsT_CustomerTablePatched=OK")
        Else
            gbIsCustomerTablePatched = False
            Call WriteLog("MiniCTI : IsT_CustomerTablePatched=FAIL")
        End If
    End Sub
End Module
