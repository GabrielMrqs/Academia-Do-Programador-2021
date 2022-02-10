import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHttpClientePjService } from '../../clientePj/services/IHttpClientePjService';
import { ClientePjListViewModel } from '../../clientePj/viewModels/ClientePjListViewModel';
import { IHttpClientePfService } from '../services/IHttpClientePfService';
import { ClientePfDetailsViewModel } from '../viewModels/ClientePfDetailsViewModel';
import { ClientePfEditViewModel } from '../viewModels/ClientePfEditViewModel';

@Component({
  selector: 'app-cliente-pf-editar',
  templateUrl: './cliente-pf-editar.component.html'
})
export class ClientePfEditarComponent implements OnInit {

  cadastroForm: FormGroup;
  id: any;
  clientePf: ClientePfEditViewModel;
  listaClientePjs: ClientePjListViewModel[];

  constructor(private _Activatedroute: ActivatedRoute,
    @Inject('IHttpClientePfServiceToken') private servicoClientePf: IHttpClientePfService,
    @Inject('IHttpClientePjServiceToken') private servicoClientePj: IHttpClientePjService,
    private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nome:new FormControl(''),
      endereco:new FormControl(''), 
      telefone:new FormControl(''),
      cpf:new FormControl(''),
      email:new FormControl(''),
      rg:new FormControl(''),
      cnh:new FormControl(''),
      dataValidade:new FormControl(''),
      idCliente:new FormControl(''),
    });

    this.carregarClientePjs();
    this.carregarClientePf();
  }

  carregarClientePjs(): void {
    this.servicoClientePj.getAll()
      .subscribe(parceiros => {
        this.listaClientePjs = parceiros;
      });
  }

  carregarClientePf(): void {
    this.servicoClientePf.getById(this.id)
      .subscribe((clientePf: ClientePfDetailsViewModel) => {
        this.carregarFormulario(clientePf);
      });
  }

  carregarFormulario(clientePf: ClientePfDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(clientePf.id),
      nome:new FormControl(clientePf.nome),
      endereco:new FormControl(clientePf.endereco), 
      telefone:new FormControl(clientePf.telefone),
      cpf:new FormControl(clientePf.cpf),
      email:new FormControl(clientePf.email),
      rg:new FormControl(clientePf.rg),
      cnh:new FormControl(clientePf.cnh),
      dataValidade:new FormControl(clientePf.dataValidade.toLocaleString().substring(0, 10)),
      idCliente:new FormControl(clientePf.idCliente),
    });
  }

  atualizarClientePf() {
    this.clientePf = Object.assign({}, this.clientePf, this.cadastroForm.value);
    this.clientePf.id = this.id;

    this.servicoClientePf.editar(this.clientePf)
      .subscribe(() => {
        this.router.navigate(['clientePf/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['clientePf/listar']);
  }
}
