<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NAWEB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel Width="100%" runat="server">
        <div class="form-froup">
            <table border="0" cellspacing="0">
                <tr>
                    <td>
        <label class="control-label" for="FilterTextBox">
            Nosaukums:
        </label>
                        </td><td>
        <asp:TextBox runat="server" ID="FilterTextBox" CssClass="form-control" OnTextChanged="FilterTextBox_TextChanged" Height="29px" Width="237px"></asp:TextBox></td>
        <td><asp:Button ID="ApplyFilterButton" runat="server" for="FilterTextBox" Text="Apply" CssClass="btn btn-primary" Height="43px" OnClick="ApplyFilterButton_Click" Width="116px" /></td>
                    </tr>
                </table>
        </div>
    </asp:Panel>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="table " Font-Size="Small" GridLines="Horizontal" Height="85px" OnPageIndexChanging="GridView1_PageIndexChanging" ShowFooter="True" ShowHeaderWhenEmpty="True" Width="829px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <AlternatingRowStyle BackColor="#99CCFF" />
    <Columns>
        <asp:BoundField DataField="No" HeaderText="Nr." >
        <ItemStyle Width="30px" />
        </asp:BoundField>
        <asp:BoundField DataField="Name" HeaderText="Nosaukums" >
        <ControlStyle Width="120px" />
        </asp:BoundField>
        <asp:BoundField DataField="Address" HeaderText="Adrese" />
        <asp:ButtonField Text="New Invoice">
        <ControlStyle CssClass="btn btn-info" />
        </asp:ButtonField>
    </Columns>
    <PagerSettings Mode="NextPreviousFirstLast" />
        <SelectedRowStyle BackColor="#FF9999" />
</asp:GridView>

</asp:Content>
