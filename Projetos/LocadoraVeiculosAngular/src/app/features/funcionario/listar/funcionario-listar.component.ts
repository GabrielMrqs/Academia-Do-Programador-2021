import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpFuncionarioService } from '../services/IHttpFuncionarioService';
import { FuncionarioListViewModel } from '../viewModels/FuncionarioListViewModel';

@Component({
  selector: 'app-funcionario-listar',
  templateUrl: './funcionario-listar.component.html'
})
export class FuncionarioListarComponent implements OnInit {

  listaFuncionariosTotal: FuncionarioListViewModel[];
  listaFuncionarios: FuncionarioListViewModel[];
  funcionarioSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpFuncionarioServiceToken') private servicoFuncionario: IHttpFuncionarioService, private servicoModal: NgbModal) {
  }

  ngOnInit(): void {
    this.obterFuncionarios();
  }

  obterFuncionarios(): void {
    this.servicoFuncionario.getAll()
      .subscribe(funcionarios => {
        this.listaFuncionariosTotal = funcionarios;
        this.atualizarFuncionarios();
      });
  }

  atualizarFuncionarios() {
    this.listaFuncionarios = this.listaFuncionariosTotal
      .map((Funcionario, i) => ({ u: i + 1, ...Funcionario }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaFuncionariosTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoFuncionario.excluir(this.funcionarioSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['funcionario/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }
    
}
