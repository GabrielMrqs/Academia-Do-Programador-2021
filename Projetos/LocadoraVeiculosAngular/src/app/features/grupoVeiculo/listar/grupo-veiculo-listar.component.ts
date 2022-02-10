import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpGrupoVeiculoService } from '../services/IHttpGrupoVeiculoService';
import { GrupoVeiculoListViewModel } from '../viewModels/GrupoVeiculoListViewModel';

@Component({
  selector: 'app-grupo-veiculo-listar',
  templateUrl: './grupo-veiculo-listar.component.html'
})
export class GrupoVeiculoListarComponent implements OnInit {

  listaGruposDeVeiculo: GrupoVeiculoListViewModel[];
  listaGruposDeVeiculoTotal: GrupoVeiculoListViewModel[];
  grupoVeiculoSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpGrupoVeiculoServiceToken') private servicoGrupoVeiculo: IHttpGrupoVeiculoService, private servicoModal: NgbModal) { }

  ngOnInit(): void {
    this.obterGruposDeVeiculo();
  }

  obterGruposDeVeiculo(): void {
    this.servicoGrupoVeiculo.getAll()
      .subscribe(cupons => {
        this.listaGruposDeVeiculoTotal = cupons;
        this.atualizarGruposDeVeiculo();
      });
  }

  atualizarGruposDeVeiculo() {
    this.listaGruposDeVeiculo = this.listaGruposDeVeiculoTotal
      .map((grupoVeiculo, i) => ({ u: i + 1, ...grupoVeiculo }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaGruposDeVeiculoTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoGrupoVeiculo.excluir(this.grupoVeiculoSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['grupoVeiculo/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }

}
