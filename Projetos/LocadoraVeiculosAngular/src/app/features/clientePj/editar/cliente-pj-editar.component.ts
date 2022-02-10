import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CupomListViewModel } from '../../cupom/viewModels/CupomListViewModel';
import { IHttpClientePjService } from '../services/IHttpClientePjService';
import { ClientePjDetailsViewModel } from '../viewModels/ClientePjDetailsViewModel';
import { ClientePjEditViewModel } from '../viewModels/ClientePjEditViewModel';

@Component({
  selector: 'app-cliente-pj-editar',
  templateUrl: './cliente-pj-editar.component.html'
})
export class ClientePjEditarComponent implements OnInit {

  id: any;
  clientePj: ClientePjEditViewModel;
  cadastroForm: FormGroup;

  constructor(private _Activatedroute: ActivatedRoute, @Inject('IHttpClientePjServiceToken') private servicoClientePj: IHttpClientePjService, private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nome: new FormControl(''),
      endereco: new FormControl(''),
      telefone: new FormControl(''),
      cnpj: new FormControl(''),
      email: new FormControl(''),
    });

    this.carregarClientePj();
  }

  carregarClientePj() {
    this.servicoClientePj.getById(this.id)
      .subscribe((clientePj: ClientePjDetailsViewModel) => {
        this.carregarFormulario(clientePj);
      });
  }

  atualizarClientePj() {
    this.clientePj = Object.assign({}, this.clientePj, this.cadastroForm.value);
    this.clientePj.id = this.id;

    this.servicoClientePj.editar(this.clientePj)
      .subscribe(() => {
        this.router.navigate(['clientePj/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['clientePj/listar']);
  }

  carregarFormulario(clientePj: ClientePjDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(clientePj.id),
      nome: new FormControl(clientePj.nome),
      endereco: new FormControl(clientePj.endereco),
      telefone: new FormControl(clientePj.telefone),
      cnpj: new FormControl(clientePj.cnpj),
      email: new FormControl(clientePj.email),
    });

  }

}
