<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Default</title>
</head>
<body>
 <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" UseSubmitBehavior="false" />

     <input type="button" value="点击我测试URL为独立参数" id="AjaxBtn" onclick="TestAjax_Url()();" />
    </form>
</body>

    <script src="Source/js/jquery-1.11.3.min.js"></script>
   <script>
       function TestAjax_Url() {
           var setting = {
               type: "GET",
               contentType: "application/json;charset=utf-8",
               error: function (err) { alert('Ajax请求失败，错误信息为：' + err.responseText); },
               success: function (returnval) { alert(returnval); }
           };

           $.ajax("Resource/DynamicText.aspx?rondom=" + Math.random(), setting);
       }
   </script>
</html>
