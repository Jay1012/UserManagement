﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="UserManagement.UserDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
    <h1>Users Detail</h1>
        <asp:GridView ID="grdUsers" runat="server" CellPadding="4" 
            ForeColor="#333333" GridLines="None" 
            DataKeyNames="UserID"
            onselectedindexchanged="grdUsers_SelectedIndexChanged" 
            onrowdeleting="grdUsers_RowDeleting1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Image" ShowSelectButton="True" 
                    SelectImageUrl="~/edit.png" />
                <asp:CommandField ButtonType="Image" DeleteImageUrl="~/delete.png" 
                    ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:Button ID="btnUser" runat="server" onclick="btnUser_Click" 
            Text="AddNew User" />
        <br />
        </center>
    </div>
    </form>
</body>
</html>
 