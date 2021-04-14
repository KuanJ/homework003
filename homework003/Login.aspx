<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="homework003.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="UTF-8" />
    <title>登入頁面</title>
    <link rel="stylesheet" type="text/css" href="login.css" />
    <script type="text/javascript" src="login.js"></script>
</head>
<body>
    <a href="WebForm2.aspx">回上頁</a>
    <div id="login_frame">
        <form method="post" action="login.js">
            <p>
                <label class="label_input">使用者名稱:</label><input type="text" id="username" class="text_field" /></p>
            <p>
                <label class="label_input">密碼:</label><input type="text" id="password" class="text_field" /></p>
            <div id="login_control">
                <input type="button" id="btn_login" value="登入" onclick="login();" />
                <input type="button" id="btn" value="註冊"  />
            </div>
        </form>
    </div>
</body>
</html>
