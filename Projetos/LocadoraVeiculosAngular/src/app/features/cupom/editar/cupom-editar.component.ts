import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CupomType } from '../../grupoVeiculo/CupomEnum';
import { IHttpParceiroService } from '../../parceiro/services/IHttpParceiroService';
import { ParceiroListViewModel } from '../../parceiro/viewModels/ParceiroListViewModel';
import { IHttpCupomService } from '../services/IHttpCupomService';
import { CupomDetailsViewModel } from '../viewModels/CupomDetailsViewModel';
import { CupomEditViewModel } from '../viewModels/CupomEditViewModel';

@Component({
  selector: 'app-cupom-editar',
  templateUrl: './cupom-editar.component.html'
})
export class CupomEditarComponent implements OnInit {

  cadastroForm: FormGroup;
  id: any;
  cupom: CupomEditViewModel;
  listaParceiros: ParceiroListViewModel[];

  tipos = CupomType;
  chaves: any[];

  constructor(private _Activatedroute: ActivatedRoute,
    @Inject('IHttpCupomServiceToken') private servicoCupom: IHttpCupomService,
    @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService,
    private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.chaves = Object.keys(this.tipos).filter(t => !isNaN(Number(t)));

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      meio: new FormControl(''),
      codigo: new FormControl(''),
      nome: new FormControl(''),
      valor: new FormControl(''),
      valorMinimo: new FormControl(''),
      validade: new FormControl(''),
      idParceiro: new FormControl(''),
      tipo: new FormControl('')
    });

    this.carregarParceiros();
    this.carregarCupom();
  }

  carregarParceiros(): void {
    this.servicoParceiro.getAll()
      .subscribe(parceiros => {
        this.listaParceiros = parceiros;
      });
  }

  carregarCupom(): void {
    this.servicoCupom.getById(this.id)
      .subscribe((cupom: CupomDetailsViewModel) => {
        this.carregarFormulario(cupom);
      });
  }

  carregarFormulario(cupom: CupomDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(cupom.id),
      meio: new FormControl(cupom.meio),
      codigo: new FormControl(cupom.codigo),
      nome: new FormControl(cupom.nome),
      valor: new FormControl(cupom.valor),
      valorMinimo: new FormControl(cupom.valorMinimo),
      validade: new FormControl(cupom.validade.toLocaleString().substring(0, 10)),
      idParceiro: new FormControl(cupom.idParceiro),
      tipo: new FormControl(cupom.tipo)
    });
  }

  atualizarCupom() {
    this.cupom = Object.assign({}, this.cupom, this.cadastroForm.value);
    this.cupom.id = this.id;

    this.servicoCupom.editar(this.cupom)
      .subscribe(() => {
        this.router.navigate(['cupom/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['cupom/listar']);
  }
}
