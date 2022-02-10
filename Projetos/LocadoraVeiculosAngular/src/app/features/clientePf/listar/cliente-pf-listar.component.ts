import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpClientePfService } from '../services/IHttpClientePfService';
import { ClientePfListViewModel } from '../viewModels/ClientePfListViewModel';

@Component({
  selector: 'app-cliente-pf-listar',
  templateUrl: './cliente-pf-listar.component.html'
})
export class ClientePfListarComponent implements OnInit {

  listaClientePfsTotal: ClientePfListViewModel[];
  listaClientePfs: ClientePfListViewModel[];
  clienteCPFSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpClientePfServiceToken') private servicoClientePf: IHttpClientePfService, private servicoModal: NgbModal) {
  }

  ngOnInit(): void {
    this.obterClientePfs();
  }

  obterClientePfs(): void {
    this.servicoClientePf.getAll()
      .subscribe(clienteCPFs => {
        this.listaClientePfsTotal = clienteCPFs;
        this.atualizarClientePfs();
      });
  }

  atualizarClientePfs() {
    this.listaClientePfs = this.listaClientePfsTotal
      .map((clienteCPF, i) => ({ u: i + 1, ...clienteCPF }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaClientePfsTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoClientePf.excluir(this.clienteCPFSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['clientePf/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }

}
