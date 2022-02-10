import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpClientePjService } from '../services/IHttpClientePjService';
import { ClientePjListViewModel } from '../viewModels/ClientePjListViewModel';

@Component({
  selector: 'app-cliente-pj-listar',
  templateUrl: './cliente-pj-listar.component.html'
})
export class ClientePjListarComponent implements OnInit {

  listaClientePjsTotal: ClientePjListViewModel[];
  listaClientePjs: ClientePjListViewModel[];
  clienteCNPJSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpClientePjServiceToken') private servicoClientePj: IHttpClientePjService, private servicoModal: NgbModal) {
  }

  ngOnInit(): void {
    this.obterClientePjs();
  }

  obterClientePjs(): void {
    this.servicoClientePj.getAll()
      .subscribe(clienteCNPJs => {
        this.listaClientePjsTotal = clienteCNPJs;
        this.atualizarClientePjs();
      });
  }

  atualizarClientePjs() {
    this.listaClientePjs = this.listaClientePjsTotal
      .map((clienteCNPJ, i) => ({ u: i + 1, ...clienteCNPJ }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaClientePjsTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoClientePj.excluir(this.clienteCNPJSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['clientePj/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }
}
