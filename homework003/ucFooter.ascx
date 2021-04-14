<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFooter.ascx.cs" Inherits="homework003.ucFooter" %>
<footer style="width: 100%; background: #00ffff;">
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Width="100%">
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Left">
                Copy right uBay 有限公司 2021<br />
                <span>電子郵件:xxxx@gmail.com</span><br />
                <span>高雄辦公室:    07-xxxxxxx</span>　<span>地址:xxxxxxxxxxxx</span><br />
                <span>台北辦公室:    02-xxxxxxx</span>　<span>地址:xxxxxxxxxxxx</span><br />
            </asp:TableCell>

            <asp:TableCell HorizontalAlign="Right">
                        <span style="float: right;"><a href="https://law.moj.gov.tw/Service/Privacy.aspx">隱私權宣告頁</a></span><br /><br />
                        <span style="float: right;"><a href="Privacy.aspx">資料保護法宣言</a></span>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</footer>
