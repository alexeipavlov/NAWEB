<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocumentCard.aspx.cs" Inherits="NAWEB.DocumentCard" MasterPageFile="~/Site.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="OrderCardContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="navbar">
        <Items>
            <asp:MenuItem Text="Edit"></asp:MenuItem>
            <asp:MenuItem Text="Delete"></asp:MenuItem>
            <asp:MenuItem Text="Save"></asp:MenuItem>
        </Items>
    </asp:Menu>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:FormView ID="OrderHeaderView" runat="server" Font-Names="Segoe UI" Font-Size="12px" Width="486px">
                <ItemTemplate>
                    <table style="width:100%;">
                        <tr>
                            <td style="width: 130px">
                                <asp:Label ID="Label11" runat="server" Text="No."></asp:Label>
                            </td>
                            <td style="width: 182px">
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("DocNo") %>'></asp:Label>
                            </td>
                            <td style="width: 142px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 130px">
                                <asp:Label ID="Label12" runat="server" Text="Document Date"></asp:Label>
                            </td>
                            <td style="width: 182px">
                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("DocDate","{0:d}") %>'></asp:Label>
                            </td>
                            <td style="width: 142px">
                                <asp:Label ID="Label15" runat="server" Text="Payment Date"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text='<%# Eval("DueDate","{0:d}") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 130px">
                                <asp:Label ID="Label13" runat="server" Text="Customer No."></asp:Label>
                            </td>
                            <td style="width: 182px">
                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("CustNo") %>'></asp:Label>
                            </td>
                            <td style="width: 142px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 130px">
                                <asp:Label ID="Label14" runat="server" Text="Customer Name"></asp:Label>
                            </td>
                            <td style="width: 182px">
                                <asp:Label ID="Label8" runat="server" Text='<%# Eval("CustName") %>'></asp:Label>
                            </td>
                            <td style="width: 142px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 130px">&nbsp;</td>
                            <td style="width: 182px">&nbsp;</td>
                            <td style="width: 142px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 130px">&nbsp;</td>
                            <td style="width: 182px">&nbsp;</td>
                            <td style="width: 142px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 130px">&nbsp;</td>
                            <td colspan="3" style="width: 182px">
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:FormView>
            <asp:GridView ID="OrderLineView" runat="server" Width="489px" AutoGenerateColumns="False" CssClass="input-group" Font-Names="Segoe UI" Font-Size="12px">
                <AlternatingRowStyle BackColor="#99CCFF" />
                <Columns>
                    <asp:TemplateField HeaderText="Type">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Font-Names="Tahoma" Font-Size="12px" SelectedValue='<%# Eval("Type") %>'>
                                <asp:ListItem Value="1">Item</asp:ListItem>
                                <asp:ListItem Value="2">G/L Account</asp:ListItem>
                                <asp:ListItem Value="3">Fixed Asset</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Font-Names="Tahoma" Font-Size="12px" SelectedValue='<%# Eval("Type") %>'>
                                <asp:ListItem Value="1">Item</asp:ListItem>
                                <asp:ListItem Value="2">G/L Account</asp:ListItem>
                                <asp:ListItem Value="3">Fixed Asset</asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="No" HeaderText="No." />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" >
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="UnitPrice" DataFormatString="{0:c}" HeaderText="Unit Price">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Amount" DataFormatString="{0:c}" HeaderText="Amount">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                </Columns>
                <HeaderStyle BackColor="#FF6600" Font-Names="Tahoma" />
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
