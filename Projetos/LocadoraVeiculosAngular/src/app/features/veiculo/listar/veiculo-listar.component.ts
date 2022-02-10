import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpVeiculoService } from '../services/IHttpVeiculoService';
import { VeiculoListViewModel } from '../viewModels/VeiculoListViewModel';

@Component({
  selector: 'app-veiculo-listar',
  templateUrl: './veiculo-listar.component.html'
})
export class VeiculoListarComponent implements OnInit {

  listaVeiculos: VeiculoListViewModel[];
  listaVeiculosTotal: VeiculoListViewModel[];
  veiculoSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpVeiculoServiceToken') private servicoVeiculo: IHttpVeiculoService, private servicoModal: NgbModal) { }

  ngOnInit(): void {
    this.obterVeiculos();
  }

  obterVeiculos(): void {
    this.servicoVeiculo.getAll()
      .subscribe(veiculos => {
        this.listaVeiculosTotal = veiculos;
        this.atualizarVeiculos();
      });
  }

  atualizarVeiculos() {
    this.listaVeiculos = this.listaVeiculosTotal
      .map((veiculo, i) => ({ u: i + 1, ...veiculo }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaVeiculosTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoVeiculo.excluir(this.veiculoSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['veiculo/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }
}
