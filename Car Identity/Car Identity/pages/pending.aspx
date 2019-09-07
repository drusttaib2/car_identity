<%@ Page Title="" Language="C#" MasterPageFile="~/pages/main_master.Master" AutoEventWireup="true" CodeBehind="pending.aspx.cs" Inherits="Car_Identity.pages.pending" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../style/pending.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>

        <div>
            <asp:Image ID="Image1" runat="server" BorderColor="#666666" CssClass="image"></asp:Image>
            <asp:Image ID="Image2" runat="server" BorderColor="#666666" CssClass="image"></asp:Image>
            <asp:Image ID="Image3" runat="server" BorderColor="#666666" CssClass="image"></asp:Image>
            <asp:Image ID="Image4" runat="server" BorderColor="#666666" CssClass="image"></asp:Image>
            <asp:Image ID="Image5" runat="server" BorderColor="#666666" CssClass="image"></asp:Image>
        </div>
        <br />
<asp:Label ID="Label2" runat="server" Text="تۆمارکردن___بڕی پارە___فڕێندراو___کۆمپیوتەر___سزا"></asp:Label>
        <br />
        <br />
           <asp:Label ID="Label1" runat="server" Text="بڕی سزا:0"></asp:Label>
    </center> 
</asp:Content>
