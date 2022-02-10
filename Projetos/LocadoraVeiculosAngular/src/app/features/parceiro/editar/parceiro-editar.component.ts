import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CupomListViewModel } from '../../cupom/viewModels/CupomListViewModel';
import { IHttpParceiroService } from '../services/IHttpParceiroService';
import { ParceiroDetailsViewModel } from '../viewModels/ParceiroDetailsViewModel';
import { ParceiroEditViewModel } from '../viewModels/ParceiroEditViewModel';

@Component({
  selector: 'app-parceiro-editar',
  templateUrl: './parceiro-editar.component.html'
})
export class ParceiroEditarComponent implements OnInit {

  sub: any;
  id: any;
  parceiro: ParceiroEditViewModel;
  descontos: CupomListViewModel[];
  cadastroForm: FormGroup;

  constructor(private _Activatedroute: ActivatedRoute, @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService, private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nome: new FormControl('')
    });

    this.carregarParceiro();
  }

  carregarParceiro() {
    this.servicoParceiro.getById(this.id)
      .subscribe((parceiro: ParceiroDetailsViewModel) => {
        this.carregarFormulario(parceiro);
      });
  }

  atualizarParceiro() {
    this.parceiro = Object.assign({}, this.parceiro, this.cadastroForm.value);
    this.parceiro.id = this.id;

    this.servicoParceiro.editar(this.parceiro)
      .subscribe(() => {
        this.router.navigate(['parceiro/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['parceiro/listar']);
  }

  carregarFormulario(parceiro: ParceiroDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(parceiro.id),
      nome: new FormControl(parceiro.nome),
    });

    this.descontos = parceiro.descontos;
  }
}
