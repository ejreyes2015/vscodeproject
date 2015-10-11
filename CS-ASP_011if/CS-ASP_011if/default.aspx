<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_011if._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
        <br />
        <br />
        If you could only eat one food for the rest of your life, what would you choose?<br />
        <asp:RadioButton ID="pizzaRadioButton" runat="server" GroupName="FoodGroup" Text="Pizza" />
&nbsp;<br />
        <asp:RadioButton ID="saladRadioButton" runat="server" GroupName="FoodGroup" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Salad" />
        <br />
        <asp:RadioButton ID="pbjRadioButton" runat="server" GroupName="FoodGroup" Text="peanut butter and jelly" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" style="height: 26px" Text="Ok" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
