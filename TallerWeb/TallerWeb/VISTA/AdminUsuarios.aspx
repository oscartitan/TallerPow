<%@ Page Title="" Language="C#" MasterPageFile="~/VISTA/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="AdminUsuarios.aspx.cs" Inherits="TallerWeb.VISTA.AdminUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="box box-primary">
        <div class="box-header with-border">
            <h3 class="box-title">Administrador de Usuarios</h3>
        </div>
        <div class="box-body">
            <div class="row">
                <div class="col-xs-3">
                    <div class="input-group">
                        <span class="input-group-addon"><i class="fa  fa-user"></i></span>
                        <input type="text" class="form-control" placeholder="Usuario">
                    </div>
                </div>
                <div class="col-xs-4">
                    <div class="input-group">
                        <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                        <input type="text" class="form-control" placeholder="Contraseña">
                    </div>
                </div>
                <div class="col-xs-5">
                    <div class="input-group">
                        <span class="input-group-addon"><i class="fa fa-male"></i></span>
                        <input type="text" class="form-control" placeholder="Nombre">
                    </div>
                </div>
            </div>
        </div>
        <!-- /.box-body -->
    </div>

</asp:Content>
