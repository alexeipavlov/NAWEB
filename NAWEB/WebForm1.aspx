<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NAWEB.WebForm1" MasterPageFile="~/Site.Master" %>
<asp:Content ID="WebForm1Content" runat="server" ContentPlaceHolderID="MainContent">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
            <ajaxToolkit:DropDownExtender ID="TextBox1DDE" runat="server" TargetControlID="TextBox1" DropDownControlID="panel1"></ajaxToolkit:DropDownExtender>
            <asp:Panel ID="panel1" runat="server">
                <asp:BulletedList ID="list1" runat="server" DisplayMode="LinkButton" OnClick="list1_Click">
                    <asp:ListItem Text="Value1" Selected="True" Value="Value1" />
                    <asp:ListItem Text="Value2" Value="Value2" />
                    <asp:ListItem Text="Value3" Value="Value3" />
                </asp:BulletedList>
            </asp:Panel>
        </ContentTemplate>
        <Triggers>
            
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
