import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { CupomType } from '../../grupoVeiculo/CupomEnum';
import { IHttpCupomService } from '../services/IHttpCupomService';
import { IHttpParceiroService } from '../../parceiro/services/IHttpParceiroService';
import { ParceiroListViewModel } from '../../parceiro/viewModels/ParceiroListViewModel';
import { CupomCreateViewModel } from '../viewModels/CupomCreateViewModel';

@Component({
  selector: 'app-cupom-criar',
  templateUrl: './cupom-criar.component.html'
})
export class CupomCriarComponent implements OnInit {

  cadastroForm: FormGroup;

  cupom: CupomCreateViewModel;
  listaParceiros: ParceiroListViewModel[];

  tipos = CupomType;
  chaves: any[];

  constructor(@Inject('IHttpCupomServiceToken') private servicoCupom: IHttpCupomService,
    @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService,
    private router: Router) { }

  ngOnInit(): void {
    this.chaves = Object.keys(this.tipos).filter(t => !isNaN(Number(t)));

    this.cadastroForm = new FormGroup({
      nome: new FormControl(''),
      codigo: new FormControl(''),
      valor: new FormControl(''),
      tipo: new FormControl(''),
      validade: new FormControl(''),
      idParceiro: new FormControl(''),
      meio: new FormControl(''),
      valorMinimo: new FormControl(''),
    });

    this.carregarParceiros();
  }

  adicionarCupom() {
    this.cupom = Object.assign({}, this.cupom, this.cadastroForm.value);

    this.servicoCupom.inserir(this.cupom)
      .subscribe(() => {
        this.router.navigate(['cupom/listar']);
      });
  }

  carregarParceiros(): void {
    this.servicoParceiro.getAll()
      .subscribe(parceiros => {
        this.listaParceiros = parceiros;
      });
  }

  cancelar(): void {
    this.router.navigate(['cupom/listar']);
  }
}
