import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './navegacao/footer/footer.component';
import { HeaderComponent } from './navegacao/header/header.component';
import { MenuComponent } from './navegacao/menu/menu.component';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CupomCriarComponent } from './features/cupom/criar/cupom-criar.component';
import { CupomEditarComponent } from './features/cupom/editar/cupom-editar.component';
import { CupomListarComponent } from './features/cupom/listar/cupom-listar.component';
import { HttpCupomService } from './features/cupom/services/http-cupom.service';
import { FuncionarioCriarComponent } from './features/funcionario/criar/funcionario-criar.component';
import { FuncionarioEditarComponent } from './features/funcionario/editar/funcionario-editar.component';
import { FuncionarioListarComponent } from './features/funcionario/listar/funcionario-listar.component';
import { HttpFuncionarioService } from './features/funcionario/services/http-funcionario.service';
import { GrupoVeiculoCriarComponent } from './features/grupoVeiculo/criar/grupo-veiculo-criar.component';
import { GrupoVeiculoEditarComponent } from './features/grupoVeiculo/editar/grupo-veiculo-editar.component';
import { GrupoVeiculoListarComponent } from './features/grupoVeiculo/listar/grupo-veiculo-listar.component';
import { HttpGrupoVeiculoService } from './features/grupoVeiculo/services/http-grupo-veiculo.service';
import { ParceiroCriarComponent } from './features/parceiro/criar/parceiro-criar.component';
import { ParceiroEditarComponent } from './features/parceiro/editar/parceiro-editar.component';
import { ParceiroListarComponent } from './features/parceiro/listar/parceiro-listar.component';
import { HttpParceiroService } from './features/parceiro/services/http-parceiro.service';
import { ServicoCriarComponent } from './features/servico/criar/servico-criar.component';
import { ServicoEditarComponent } from './features/servico/editar/servico-editar.component';
import { ServicoListarComponent } from './features/servico/listar/servico-listar.component';
import { HttpServicoService } from './features/servico/services/http-servico.service';
import { VeiculoCriarComponent } from './features/veiculo/criar/veiculo-criar.component';
import { VeiculoEditarComponent } from './features/veiculo/editar/veiculo-editar.component';
import { VeiculoListarComponent } from './features/veiculo/listar/veiculo-listar.component';
import { HttpVeiculoService } from './features/veiculo/services/http-veiculo.service';
import { ClientePjListarComponent } from './features/clientePj/listar/cliente-pj-listar.component';
import { ClientePjCriarComponent } from './features/clientePj/criar/cliente-pj-criar.component';
import { ClientePjEditarComponent } from './features/clientePj/editar/cliente-pj-editar.component';
import { HttpClientePjService } from './features/clientePj/services/http-cliente-pj.service';
import { ClientePfListarComponent } from './features/clientePf/listar/cliente-pf-listar.component';
import { ClientePfCriarComponent } from './features/clientePf/criar/cliente-pf-criar.component';
import { HttpClientePfService } from './features/clientePf/services/http-cliente-pf.service';
import { ClientePfEditarComponent } from './features/clientePf/editar/cliente-pf-editar.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    MenuComponent,
    HomeComponent,
    ParceiroListarComponent,
    ParceiroCriarComponent,
    ParceiroEditarComponent,
    CupomListarComponent,
    CupomCriarComponent,
    CupomEditarComponent,
    FuncionarioCriarComponent,
    FuncionarioEditarComponent,
    FuncionarioListarComponent,
    ServicoCriarComponent,
    ServicoListarComponent,
    ServicoEditarComponent,
    GrupoVeiculoCriarComponent,
    GrupoVeiculoEditarComponent,
    GrupoVeiculoListarComponent,
    VeiculoCriarComponent,
    VeiculoEditarComponent,
    VeiculoListarComponent,
    ClientePjListarComponent,
    ClientePjCriarComponent,
    ClientePjEditarComponent,
    ClientePfEditarComponent,
    ClientePfListarComponent,
    ClientePfCriarComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
    FormsModule,
    NgbModule
  ],
  providers: [
    { provide: 'IHttpParceiroServiceToken', useClass: HttpParceiroService },
    { provide: 'IHttpCupomServiceToken', useClass: HttpCupomService },
    { provide: 'IHttpFuncionarioServiceToken', useClass: HttpFuncionarioService },
    { provide: 'IHttpServicoServiceToken', useClass: HttpServicoService },
    { provide: 'IHttpGrupoVeiculoServiceToken', useClass: HttpGrupoVeiculoService },
    { provide: 'IHttpVeiculoServiceToken', useClass: HttpVeiculoService },
    { provide: 'IHttpClientePjServiceToken', useClass: HttpClientePjService },    
    { provide: 'IHttpClientePfServiceToken', useClass: HttpClientePfService },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
