import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpParceiroService } from '../services/IHttpParceiroService';
import { ParceiroListViewModel } from '../viewModels/ParceiroListViewModel';

@Component({
  selector: 'app-listarparceiro',
  templateUrl: './parceiro-listar.component.html'
})
export class ParceiroListarComponent implements OnInit {

  listaParceirosTotal: ParceiroListViewModel[];
  listaParceiros: ParceiroListViewModel[];
  parceiroSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService, private servicoModal: NgbModal) {
  }

  ngOnInit(): void {
    this.obterParceiros();
  }

  obterParceiros(): void {
    this.servicoParceiro.getAll()
      .subscribe(parceiros => {
        this.listaParceirosTotal = parceiros;
        this.atualizarParceiros();
      });
  }

  atualizarParceiros() {
    this.listaParceiros = this.listaParceirosTotal
      .map((parceiro, i) => ({ u: i + 1, ...parceiro }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaParceirosTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoParceiro.excluir(this.parceiroSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['parceiro/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }
}
