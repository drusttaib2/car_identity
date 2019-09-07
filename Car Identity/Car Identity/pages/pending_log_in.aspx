<%@ Page Title="" Language="C#" MasterPageFile="~/pages/main_master.Master" AutoEventWireup="true" CodeBehind="pending_log_in.aspx.cs" Inherits="Car_Identity.pages.pending_log_in" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../style/home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><div>
    <h3>وشەی نهێنی</h3>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="تۆمارکردن" OnClick="Button1_Click" />
        <br />
    
        </div>
        </center>
</asp:Content>
