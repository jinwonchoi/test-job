Public Class FRM_CODELIST

    Private temp As String
    Private temp2 As String = ""
    Private T_LCode As String      ' 대분류코드 
    Private T_SCode As String       ' 소분류코드
    Private T_DCode As String       ' 수정불가 소분류코드
    Private M_PARAM As String = ""
    Private LGrpNode(1000) As TreeNode  ' 대그룹 node

    Private Sub FRM_CODELIST_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call SetToolBar(False, False, True, True, False, True, True)
    End Sub

    Private Sub FRM_CODELIST_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Call SetToolBar(False, False, True, True, False, True, True)
            Call Controls_Setting()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub Controls_Setting()
        Try
            Me.WindowState = FormWindowState.Maximized
            txtLcode.MaxLength = 3
            txtLcodenm.MaxLength = 30
            txtScode.MaxLength = 4
            txtScodenm.MaxLength = 30

            temp = "SELECT a.l_menu_cd, a.l_menu_nm, b.s_menu_cd, b.s_menu_nm, b.modify_yn " & _
                    "From t_l_code a left JOIN t_s_code b " & _
                    "ON b.COM_CD=a.COM_CD and b.l_menu_cd=a.l_menu_cd " & _
                    "Where a.COM_CD='" & gsCOM_CD & "' " & _
                    "order by a.l_menu_cd, b.s_menu_cd"
            CodeList_TreeView_Setting(temp)
            drpMod.Text = "Y"
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub


    Private Sub CodeList_TreeView_Setting(ByVal sqltext As String)

        Dim i, k As Integer
        Dim _tnRoot As TreeNode         ' root node
        Dim Lcode As String = ""
        Dim Scode As String = ""
        Dim dt1 As DataTable

        Try
            k = 0
            T_LCode = ""
            T_SCode = ""
            T_DCode = ""
            TreeView1.Nodes.Clear()
            _tnRoot = New TreeNode(gsCompany)
            _tnRoot.Tag = gsCOM_CD & "^^^Y"
            TreeView1.Nodes.Add(_tnRoot)

            dt1 = Mysql_GetData_table(gsConString, sqltext)

            If dt1.Rows.Count > 0 Then
                For i = 0 To dt1.Rows.Count - 1
                    Dim tmp1 As String = dt1.Rows(i).Item("l_menu_cd").ToString()
                    Dim tmp2 As String = dt1.Rows(i).Item("s_menu_cd").ToString()
                    Dim tmp3 As String = dt1.Rows(i).Item("l_menu_nm").ToString()
                    Dim tmp4 As String = dt1.Rows(i).Item("s_menu_nm").ToString()
                    Dim tmp5 As String = dt1.Rows(i).Item("modify_yn").ToString().ToUpper  'Y:수정가능, N:수정불가능
                    If Lcode <> tmp1 Then
                        LGrpNode(k) = AddTreeNode(_tnRoot, tmp3, gsCOM_CD & "^" & tmp1 & "^^Y")
                        T_LCode &= gsCOM_CD & "^" & tmp1 & "^,"
                        k += 1
                        Lcode = tmp1
                    End If
                    If Scode <> tmp2 Then
                        AddTreeNode(LGrpNode(k - 1), tmp4, gsCOM_CD & "^" & tmp1 & "^" & tmp2 & "^" & tmp5)
                        T_SCode &= gsCOM_CD & "^" & tmp1 & "^" & tmp2 & ","
                        If tmp5.ToUpper.Trim = "N" Then T_DCode &= gsCOM_CD & "^" & tmp1 & "^" & tmp2 & ","
                        Scode = tmp2
                    End If
                Next
            End If

            TreeView1.ExpandAll()
            ' Init_Treeview()

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt1 = Nothing
        End Try
    End Sub

    Protected Function AddTreeNode(ByVal tn As TreeNode, ByVal nodename As String, ByVal nodevalue As String) As TreeNode
        Dim tnNew As TreeNode = Nothing
        Try
            tnNew = New TreeNode(nodename)
            tnNew.Tag = nodevalue
            tn.Nodes.Add(tnNew)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
        Return tnNew
    End Function

    Protected Sub Init_Treeview()
        Try
            Dim i, j As Integer
            For i = 0 To TreeView1.Nodes(0).GetNodeCount(False) - 1
                TreeView1.Nodes(0).Nodes(i).Collapse()
                'For j = 0 To TreeView1.Nodes(0).Nodes(i).GetNodeCount(False) - 1
                '    TreeView1.Nodes(0).Nodes(i).Nodes(j).Collapse()
                'Next
            Next

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Try
            If TreeView1.SelectedNode Is Nothing Then Exit Try

            Dim iLevel As Integer = TreeView1.SelectedNode.Level
            Dim param() As String = TreeView1.SelectedNode.Tag.ToString.Split("^")
            M_PARAM = iLevel & "^" & TreeView1.SelectedNode.Tag.ToString & "^" & TreeView1.SelectedNode.Text
            btnSave.Enabled = True
            btnDelete.Enabled = True

            Select Case iLevel
                Case 0
                    txtLcode.Text = ""
                    txtLcodenm.Text = ""
                    txtScode.Text = ""
                    txtScodenm.Text = ""
                    drpMod.Text = "Y"
                    txtLcode.Enabled = True
                    txtLcodenm.Enabled = True
                    txtScode.Enabled = False
                    txtScodenm.Enabled = False
                    drpMod.Enabled = False
                Case 1
                    txtLcode.Text = param(1)
                    txtLcodenm.Text = TreeView1.SelectedNode.Text
                    txtScode.Text = param(2)
                    txtScodenm.Text = ""
                    drpMod.Text = param(3)
                    txtLcode.Enabled = False
                    txtLcodenm.Enabled = True
                    txtScode.Enabled = True
                    txtScodenm.Enabled = True
                    drpMod.Enabled = True
                Case 2
                    txtLcode.Text = param(1)
                    txtLcodenm.Text = TreeView1.SelectedNode.Parent.Text
                    txtScode.Text = param(2)
                    txtScodenm.Text = TreeView1.SelectedNode.Text
                    drpMod.Text = param(3)
                    txtLcode.Enabled = False
                    txtLcodenm.Enabled = False
                    txtScode.Enabled = False
                    txtScodenm.Enabled = True
                    drpMod.Enabled = True
                    If param(3).Trim.ToUpper = "N" Then
                        btnSave.Enabled = False
                        btnDelete.Enabled = False
                    End If
            End Select

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsSave()
        Dim dt As DataTable
        Dim temp11 As String = ""
        Dim temp12 As String = ""
        Try
            If M_PARAM.Contains("^") = False Then Exit Try
            'M_PARAM= iLevel & "^" & gsCOM_CD & "^" & l_menu_cd & "^" & s_menu_cd & "^" & modify_yn  & "^" & TreeView1.SelectedNode.Text
            'Call WriteLog(Me.Name & " : M_PARAM-" & M_PARAM)
            'Call WriteLog(Me.Name & " : T_DCode-" & T_DCode)
            Dim param() As String = M_PARAM.Split("^")
            If param(0).Trim = "" OrElse param(1).Trim = "" Then Exit Try
            If txtLcode.Text.Trim = "" Then
                MsgBox("대분류 코드를 입력하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            ElseIf txtLcodenm.Text.Trim = "" Then
                MsgBox("대분류 코드명을 입력하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If

            If T_DCode.Contains(param(1).Trim & "^" & txtLcode.Text.Trim & "^" & txtScode.Text.Trim & ",") = True Then '수정
                MsgBox("이 코드는 수정할 수 없습니다.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If

            '대항목 처리
            If T_LCode.Contains(param(1).Trim & "^" & txtLcode.Text.Trim & "^,") = True Then '수정
                temp = "Update t_l_code set L_MENU_NM='" & txtLcodenm.Text.Trim & "' Where COM_CD='" & param(1).Trim & "' and l_menu_cd='" & txtLcode.Text.Trim & "' "

                temp12 = "UPDATE"
                temp11 = "LCode," & txtLcode.Text.Trim & "," & "," & txtLcodenm.Text.Trim
            Else  '추가
                temp = "Insert into t_l_code(COM_CD,L_MENU_CD,L_MENU_NM) values('" & param(1).Trim & "','" & txtLcode.Text.Trim & "','" & txtLcodenm.Text.Trim & "') "

                temp12 = "ADD"
                temp11 = "LCode," & txtLcode.Text.Trim & "," & "," & txtLcodenm.Text.Trim
            End If

            dt = Mysql_GetData_table(gsConString, temp)

            If txtScode.Text.Trim = "" AndAlso txtScodenm.Text.Trim = "" Then
                MsgBox("처리되었습니다", MsgBoxStyle.OkOnly, "정보")
                Controls_Setting()
                Exit Try
            End If

            If txtScode.Text.Trim = "" Then
                MsgBox("소분류 코드를 입력하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            ElseIf txtScodenm.Text.Trim = "" Then
                MsgBox("소분류 코드명을 입력하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If

            '소항목 처리
            If T_SCode.Contains(param(1).Trim & "^" & txtLcode.Text.Trim & "^" & txtScode.Text.Trim & ",") = True Then '수정
                temp = "Update t_s_code set S_MENU_NM='" & txtScodenm.Text.Trim & "', MODIFY_YN='" & drpMod.Text.Trim & "' " & _
                      "Where COM_CD='" & param(1).Trim & "' and l_menu_cd='" & txtLcode.Text.Trim & "' and s_menu_cd='" & txtScode.Text.Trim & "' "

                temp12 = "UPDATE"
                temp11 = "SCode," & txtLcode.Text.Trim & "," & txtScode.Text.Trim & "," & txtScodenm.Text.Trim

            Else  '추가
                temp = "Insert into t_s_code(COM_CD,L_MENU_CD,S_MENU_CD,S_MENU_NM,MODIFY_YN) " & _
                      "values('" & param(1).Trim & "','" & txtLcode.Text.Trim & "','" & txtScode.Text.Trim & "','" & txtScodenm.Text.Trim & "','" & drpMod.Text.Trim & "') "

                temp12 = "ADD"
                temp11 = "SCode," & txtLcode.Text.Trim & "," & txtScode.Text.Trim & "," & txtScodenm.Text.Trim
            End If

            dt = Mysql_GetData_table(gsConString, temp)
            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
            Controls_Setting()

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
            If temp12 = "ADD" Then
                Call Audit_Log(AUDIT_TYPE.CODE_ADD, temp11)
            ElseIf temp12 = "UPDATE" Then
                Call Audit_Log(AUDIT_TYPE.CODE_MOD, temp11)
            End If
        End Try
    End Sub

    Public Sub gsDelete()
        Dim dt As DataTable
        Dim temp11 As String = ""
        Try
            If M_PARAM.Contains("^") = False Then Exit Try
            'M_PARAM= iLevel & "^" & gsCOM_CD & "^" & l_menu_cd & "^" & s_menu_cd & "^" & modify_yn  & "^" & TreeView1.SelectedNode.Text
            Dim param() As String = M_PARAM.Split("^")
            If param(0).Trim = "" OrElse param(1).Trim = "" OrElse param(2).Trim = "" Then Exit Try
            MsgBox(param(5).Trim & " 코드를 삭제하시겠습니까?", MsgBoxStyle.YesNo, "확인")
            If param(0).Trim = "1" Then '대항목 삭제
                temp = "Delete from t_l_code Where COM_CD='" & param(1).Trim & "' and l_menu_cd='" & param(2).Trim & "' "
                temp11 = "LCode," & param(2).Trim & "," & "," & param(5)
            ElseIf param(0).Trim = "2" Then  '소항목 삭제
                temp = "Delete from t_s_code Where COM_CD='" & param(1).Trim & "' and l_menu_cd='" & param(2).Trim & "' and s_menu_cd='" & param(3).Trim & "' "
                temp11 = "SCode," & param(2).Trim & "," & param(3).Trim & "," & param(5)
            End If

            dt = Mysql_GetData_table(gsConString, temp)
            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
            Controls_Setting()

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
            If temp11 <> "" Then Call Audit_Log(AUDIT_TYPE.CODE_DEL, temp11)
        End Try
    End Sub

    Public Sub gsFormExit()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call gsSave()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call gsDelete()
    End Sub

End Class