<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">        
        <section class="row mt-5">
            <div class="col">
                <h2 class="text-center text-lg-start">DEPILACION DEFINITIVA</h2>
            </div>
            <div class="row mt-3">
                <div class="col-12 col-lg-5 mt-5 align-self-center">
                    <h3>De que trata:</h3>
                    <p class="text-letra">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
                    </p>

                </div>
                <div class="col-12 col-lg-7">
                    <img class="img-fluid" alt="Imagen Depilacion Definitiva" src="img/DepilacionDef.jpg" />
                </div>
            </div>
        </section>
        <section class="mt-5">
            <div class="row">
                <div class="col">
                    <h2 class="text-center text-lg-end">DEPILACION SISTEMA ESPAÑOL</h2>
                </div>
                <div class="row mt-5">
                    <div class="col col-lg-5 order-lg-last align-self-center">
                        <h3>De que trata:</h3>
                        <p class="text-letra">
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
                        </p>
                    </div>
                    <div class="col-12 col-lg-7 order-lg-first">
                        <img class="img-fluid" alt="Depilacion española" src="img/DepilacionEspañol.jpg" />
                    </div>
                </div>
            </div>
            <div class="row mt-5">
                <div class="col-12 col-lg-4 mt-1 mt-md-0">
                    <h3 class="text-center text-uppercase">Permanente de pestañas</h3>
                    <img class="img-fluid card-img" src="img/permanente-pes.jpg" />
                </div>
                <div class="col-12 col-lg-4 mt-1 mt-md-0">
                    <h3 class="text-center text-uppercase">Extension pelo por pelo</h3>
                    <img class="img-fluid card-img" alt="pelo por pelo" src="img/permanente-pestanas (1).jpg" />
                </div>
                <div class="col-12 col-lg-4 mt-1 mt-md-0">
                    <h3 class="text-center text-uppercase">Perfilado
                    <br />
                        de cejas</h3>
                    <img class="img-fluid card-img" src="img/perfiladocejas (1).jpg" />
                </div>
            </div>
        </section>      
    </div>



</asp:Content>
