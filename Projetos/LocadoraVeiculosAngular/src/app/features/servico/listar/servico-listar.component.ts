import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpServicoService } from '../services/IHttpServicoService';
import { ServicoListViewModel } from '../viewModels/ServicoListViewModel';

@Component({
  selector: 'app-servico-listar',
  templateUrl: './servico-listar.component.html'
})
export class ServicoListarComponent implements OnInit {


  listaServicosTotal: ServicoListViewModel[];
  listaServicos: ServicoListViewModel[];
  servicoSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpServicoServiceToken') private servicoServico: IHttpServicoService, private servicoModal: NgbModal) {
  }

  ngOnInit(): void {
    this.obterServicos();
  }

  obterServicos(): void {
    this.servicoServico.getAll()
      .subscribe(servicos => {
        this.listaServicosTotal = servicos;
        this.atualizarServicos();
      });
  }

  atualizarServicos() {
    this.listaServicos = this.listaServicosTotal
      .map((Servico, i) => ({ u: i + 1, ...Servico }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaServicosTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoServico.excluir(this.servicoSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['servico/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }

}
