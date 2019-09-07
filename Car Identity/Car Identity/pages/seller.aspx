<%@ Page Title="" Language="C#" MasterPageFile="~/pages/main_master.Master" AutoEventWireup="true" CodeBehind="seller.aspx.cs" Inherits="Car_Identity.pages.seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../style/buyer_seller.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox"></asp:TextBox>:ژمارەی نهێنی
  
     <br class="clear"/>
        <br />
    <div class="main">
    <div >
        <asp:Label ID="Label1" runat="server" Text="ئۆفیسی زانیاری" CssClass="header"></asp:Label>
        <br />
    <asp:TextBox ID="of_family_owner" runat="server" CssClass="textbox"></asp:TextBox>:سەرپەرشتیاری خێزان 
        <br />  
    <asp:TextBox ID="of_address" runat="server" CssClass="textbox"></asp:TextBox>:ناونیشان
        <br />
    <asp:TextBox ID="of_application_id" runat="server" CssClass="textbox"></asp:TextBox>:ژمارەی مامەڵە
        </div>

     <br class="clear"/>
        <br />
   
    <div>
     <asp:Label ID="Label2" runat="server" Text="کارتی زانیاری" CssClass="header"></asp:Label>
        <br />
    <asp:TextBox ID="ni_number" runat="server" CssClass="textbox"></asp:TextBox>:ژمارە 
        <br />
    <asp:TextBox ID="ni_name" runat="server" CssClass="textbox"></asp:TextBox>:ناو 
        <br />  

    <asp:TextBox ID="ni_father" runat="server" CssClass="textbox"></asp:TextBox>:باوک 
        <br />
    <asp:TextBox ID="ni_grandfather" runat="server" CssClass="textbox"></asp:TextBox>:باپیر 
        <br />
    <asp:TextBox ID="ni_surname" runat="server" CssClass="textbox"></asp:TextBox>:نازناو
        <br />
    <asp:TextBox ID="ni_mother" runat="server" CssClass="textbox"></asp:TextBox>:دایک 
        <br />
    <asp:TextBox ID="ni_sex" runat="server" CssClass="textbox"></asp:TextBox>:ڕەگەز 
        <br />
    <asp:TextBox ID="ni_blood_type" runat="server" CssClass="textbox"></asp:TextBox>:گروپی خوێن 

    </div>
         <br class="clear"/>
        <br />
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
       

    </div>
    <br class="clear"/>
    <br />
        
    <asp:Button ID="Button1" runat="server" Text="تۆمارکردن" OnClick="Button1_Click" />
        </div>
        </center>
</asp:Content>
