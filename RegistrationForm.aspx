<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="UserManagement.RegistrationForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <center>
    <div >
            <table>
            <caption><h1>Regestration Form</h1></caption>
            <tr><td>&nbsp;</td></tr>
            <tr><td>
                  FirstName:   
                </td>
                <td>
                  <asp:TextBox ID="txtfname" runat="server" MaxLength="30"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rdfname" ControlToValidate="txtfname" 
                        ValidationGroup="Userdetail" runat="server" ErrorMessage="*" Display="Dynamic" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr><td>
                  LastName:   
                </td>
                <td>
                  <asp:TextBox ID="txtlname" runat="server" MaxLength="30"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rdflname" ValidationGroup="Userdetail" 
                        ControlToValidate="txtlname" runat="server" ErrorMessage="*" Display="Dynamic" 
                        ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            
            <tr><td>
                  Gender:   
                </td>
                <td>
                  
                  <asp:RadioButtonList runat="server" ID="rblgndr">
                  <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                  <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                  </asp:RadioButtonList>
                </td>
                <td>
                  
                    &nbsp;</td>
            </tr>
            
            <tr><td>
                  Email:
                </td>
                <td>
                  <asp:TextBox ID="txtemail" runat="server" MaxLength="30"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rqdemail" ValidationGroup="Userdetail" 
                        ControlToValidate="txtemail" runat="server" ErrorMessage="*" Display="Dynamic" 
                        ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            
            <tr><td>
                  Address:   
                </td>
                <td>
                  <asp:TextBox ID="txtaddress" TextMode="MultiLine" runat="server" MaxLength="100"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td>
                  Country:   
                </td>
                <td>
                  <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlCountry_SelectedIndexChanged">
                </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            
            <tr>
            <td>
                  State:   
                </td>
                <td>
                <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True">

                </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr><td>
                    <asp:Button ID="btncncl" runat="server" Text="Cancel" onclick="btncncl_Click" />
                </td>
                <td>
                  <asp:Button ID="btnSave" runat="server" Text="Submit" onclick="btnSave_Click" 
                        ValidationGroup="Userdetail" />
                    <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
                        Text="Update" Visible="False" ValidationGroup="Userdetail" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
            <td><asp:HyperLink ID="hpldetail" runat="server" Text="ShowAllUsers" NavigateUrl="~/UserDetails.aspx"></asp:HyperLink></td>
            </tr>

            </table>
    </div>
    </center>
    </form>
</body>
</html>
