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
                        <input id="txtUsuario" runat="server" type="text" class="form-control" placeholder="Usuario">
                    </div>
                </div>
                <div class="col-xs-4">
                    <div class="input-group">
                        <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                        <input id="txtContrasena" runat="server" type="password" class="form-control" placeholder="Contraseña">
                    </div>
                </div>
                <div class="col-xs-5">
                    <div class="input-group">
                        <span class="input-group-addon"><i class="fa fa-male"></i></span>
                        <input id="txtNombre" runat="server" type="text" class="form-control" placeholder="Nombre">
                    </div>
                </div>
            </div>
           
        </div>
        <!-- /.box-body -->
        <div class="box-footer">
            <div class="row">
                <div class="col-xs-4">
                    <asp:LinkButton ID="Adicionar" runat="server" Text="Insertar" CssClass="btn btn-primary"
                        OnClick="AddUsuario_Click">
                <span aria-hidden="true" class="fa fa-user-plus"> Insertar</span>
                    </asp:LinkButton>
                </div>

                <div class="col-xs-4">
                    <asp:LinkButton ID="Listar" runat="server" Text="Listar" CssClass="btn btn-default"
                        OnClick="ListarUsuario_Click">
                <span aria-hidden="true" class="fa fa-list"> Listar</span>
                    </asp:LinkButton>
                </div>
            </div>
            <br />
            <div class="row">


         <div class="col-xs-12">
          <div class="box">
            <div class="box-header">
              <h3 class="box-title">Listado de Usuarios</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">

                <div class="table-responsive">
                    <asp:GridView ID="GridViewUsuarios" runat="server" GridLines="None"
                        CssClass="gvuser table table-striped table-bordered text-sm"
                        CellSpacing="0" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                    </asp:GridView>
                </div>

            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        
        </div>

            </div>
        </div>
    </div>

</asp:Content>
