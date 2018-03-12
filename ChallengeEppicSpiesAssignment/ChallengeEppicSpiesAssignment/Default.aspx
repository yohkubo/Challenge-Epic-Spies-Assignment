<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEppicSpiesAssignment.Default" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 151px;
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <h2 style="font-family: Arial, Helvetica, sans-serif">Spy New Assignment Form</h2>
            <br />
            Spy Code Name: <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Precious Assingment:<asp:Calendar ID="previousCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            Start Date of New Assingment:<asp:Calendar ID="startCalendar" runat="server" OnSelectionChanged="startCalendar_SelectionChanged"></asp:Calendar>
            <br />
            Projected End Date of New Assignment:<asp:Calendar ID="endCalendar" runat="server" OnSelectionChanged="endCalendar_SelectionChanged"></asp:Calendar>
            Assignment period:
            <asp:Label ID="periodLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
