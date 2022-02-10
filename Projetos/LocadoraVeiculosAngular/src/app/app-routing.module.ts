import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientePfCriarComponent } from './features/clientePf/criar/cliente-pf-criar.component';
import { ClientePfEditarComponent } from './features/clientePf/editar/cliente-pf-editar.component';
import { ClientePfListarComponent } from './features/clientePf/listar/cliente-pf-listar.component';
import { ClientePjCriarComponent } from './features/clientePj/criar/cliente-pj-criar.component';
import { ClientePjEditarComponent } from './features/clientePj/editar/cliente-pj-editar.component';
import { ClientePjListarComponent } from './features/clientePj/listar/cliente-pj-listar.component';
import { CupomCriarComponent } from './features/cupom/criar/cupom-criar.component';
import { CupomEditarComponent } from './features/cupom/editar/cupom-editar.component';
import { CupomListarComponent } from './features/cupom/listar/cupom-listar.component';
import { FuncionarioCriarComponent } from './features/funcionario/criar/funcionario-criar.component';
import { FuncionarioEditarComponent } from './features/funcionario/editar/funcionario-editar.component';
import { FuncionarioListarComponent } from './features/funcionario/listar/funcionario-listar.component';
import { GrupoVeiculoCriarComponent } from './features/grupoVeiculo/criar/grupo-veiculo-criar.component';
import { GrupoVeiculoEditarComponent } from './features/grupoVeiculo/editar/grupo-veiculo-editar.component';
import { GrupoVeiculoListarComponent } from './features/grupoVeiculo/listar/grupo-veiculo-listar.component';
import { ParceiroCriarComponent } from './features/parceiro/criar/parceiro-criar.component';
import { ParceiroEditarComponent } from './features/parceiro/editar/parceiro-editar.component';
import { ParceiroListarComponent } from './features/parceiro/listar/parceiro-listar.component';
import { ServicoCriarComponent } from './features/servico/criar/servico-criar.component';
import { ServicoEditarComponent } from './features/servico/editar/servico-editar.component';
import { ServicoListarComponent } from './features/servico/listar/servico-listar.component';
import { VeiculoCriarComponent } from './features/veiculo/criar/veiculo-criar.component';
import { VeiculoEditarComponent } from './features/veiculo/editar/veiculo-editar.component';
import { VeiculoListarComponent } from './features/veiculo/listar/veiculo-listar.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'parceiro/listar', component: ParceiroListarComponent },
  { path: 'parceiro/criar', component: ParceiroCriarComponent },
  { path: 'parceiro/editar/:id', component: ParceiroEditarComponent },
  { path: 'cupom/listar', component: CupomListarComponent },
  { path: 'cupom/criar', component: CupomCriarComponent },
  { path: 'cupom/editar/:id', component: CupomEditarComponent },
  { path: 'funcionario/listar', component: FuncionarioListarComponent },
  { path: 'funcionario/criar', component: FuncionarioCriarComponent },
  { path: 'funcionario/editar/:id', component: FuncionarioEditarComponent },
  { path: 'servico/listar', component: ServicoListarComponent },
  { path: 'servico/criar', component: ServicoCriarComponent },
  { path: 'servico/editar/:id', component: ServicoEditarComponent },
  { path: 'grupoVeiculo/listar', component: GrupoVeiculoListarComponent },
  { path: 'grupoVeiculo/criar', component: GrupoVeiculoCriarComponent },
  { path: 'grupoVeiculo/editar/:id', component: GrupoVeiculoEditarComponent },
  { path: 'veiculo/listar', component:  VeiculoListarComponent},
  { path: 'veiculo/criar', component: VeiculoCriarComponent },
  { path: 'veiculo/editar/:id', component:VeiculoEditarComponent },
  { path: 'clientePj/listar', component:  ClientePjListarComponent},
  { path: 'clientePj/criar', component: ClientePjCriarComponent },
  { path: 'clientePj/editar/:id', component:ClientePjEditarComponent },
  { path: 'clientePf/listar', component:  ClientePfListarComponent},
  { path: 'clientePf/criar', component: ClientePfCriarComponent },
  { path: 'clientePf/editar/:id', component:ClientePfEditarComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
