<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample.aspx.cs" Inherits="storedProcedure.sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 204px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HiddenField ID="hfContactID" runat ="server" />
        <table>
                   <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Id"></asp:Label>
                </td>
                <td colspan="2" class="auto-style1">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td colspan="2" class="auto-style1">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            ------
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
                </td>
                <td colspan="2" class="auto-style1">
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
            </tr>
            -------
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Country"></asp:Label>
                </td>
                <td colspan="2" class="auto-style1">
                     <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                </td>
            </tr>
            ---------
            <tr>
                <td>

                </td>
                <td colspan="2" class="auto-style1">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="Save" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="Delete"/>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="Update" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="Clear" />
                </td>
            </tr>
            ------
            <tr>
                <td>

                </td>
                <td colspan="2" class="auto-style1">
                    <asp:Label ID="lblSuccessMssg" runat="server" Text="" ForeColor ="Green"></asp:Label>
                </td>
            </tr>
            -----
            <tr>
                <td>

                </td>
                <td colspan="2" class="auto-style1">
                    <asp:Label ID="lblDeleteMssg" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            -----
             <tr>
                <td>

                </td>
                <td colspan="2" class="auto-style1">
                    <asp:Label ID="lblUpdateMssg" runat="server" Text="" ForeColor="black"></asp:Label>
                </td>
            </tr>
            
        </table>
        <br />
       <asp:GridView ID="GridView1" runat ="server" BackColor="White" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Age" HeaderText="Age" />
                <asp:BoundField DataField="Country" HeaderText="Country" />
                
             
                <asp:ButtonField CommandName="Cancel" Text="Button" />
                
             
            </Columns>
        </asp:GridView>

    </div>
    </form>
</body>
</html>
