import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHttpServicoService } from '../services/IHttpServicoService';
import { ServicoType } from '../ServicoEnum';
import { ServicoDetailsViewModel } from '../viewModels/ServicoDetailsViewModel';
import { ServicoEditViewModel } from '../viewModels/ServicoEditViewModel';

@Component({
  selector: 'app-servico-editar',
  templateUrl: './servico-editar.component.html'
})
export class ServicoEditarComponent implements OnInit {

  cadastroForm: FormGroup;
  id: any;
  servico: ServicoEditViewModel;

  tipos = ServicoType;
  chaves: any[];

  constructor(private _Activatedroute: ActivatedRoute, @Inject('IHttpServicoServiceToken') private servicoServico: IHttpServicoService, private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.chaves = Object.keys(this.tipos).filter(t => !isNaN(Number(t)));

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nome: new FormControl(''),
      preco: new FormControl(''),
      calculoTipo: new FormControl('')
    });

    this.carregarServico();
  }

  carregarServico(): void {
    this.servicoServico.getById(this.id)
      .subscribe((servico: ServicoDetailsViewModel) => {
        this.carregarFormulario(servico);
      });
  }

  carregarFormulario(servico: ServicoDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(servico.id),
      nome: new FormControl(servico.nome),
      preco: new FormControl(servico.preco),
      calculoTipo: new FormControl(servico.calculoTipo)
    });
  }

  atualizarServico() {
    this.servico = Object.assign({}, this.servico, this.cadastroForm.value);
    this.servico.id = this.id;

    this.servicoServico.editar(this.servico)
      .subscribe(() => {
        this.router.navigate(['servico/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['servico/listar']);
  }
}
