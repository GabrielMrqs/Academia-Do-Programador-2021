import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { IHttpClientePjService } from '../../clientePj/services/IHttpClientePjService';
import { ClientePjListViewModel } from '../../clientePj/viewModels/ClientePjListViewModel';
import { IHttpClientePfService } from '../services/IHttpClientePfService';
import { ClientePfCreateViewModel } from '../viewModels/ClientePfCreateViewModel';

@Component({
  selector: 'app-cliente-pf-criar',
  templateUrl: './cliente-pf-criar.component.html'
})
export class ClientePfCriarComponent implements OnInit {

  cadastroForm: FormGroup;

  clienteCPF: ClientePfCreateViewModel;
  listaClientePjs: ClientePjListViewModel[];

  constructor(@Inject('IHttpClientePfServiceToken') private servicoClientePf: IHttpClientePfService,
    @Inject('IHttpClientePjServiceToken') private servicoClientePj: IHttpClientePjService,
    private router: Router) { }

  ngOnInit(): void {

    this.cadastroForm = new FormGroup({
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
  }

  adicionarClientePf() {
    this.clienteCPF = Object.assign({}, this.clienteCPF, this.cadastroForm.value);

    this.servicoClientePf.inserir(this.clienteCPF)
      .subscribe(() => {
        this.router.navigate(['clientePf/listar']);
      });
  }

  carregarClientePjs(): void {
    this.servicoClientePj.getAll()
      .subscribe(clientePjs => {
        this.listaClientePjs = clientePjs;
      });
  }

  cancelar(): void {
    this.router.navigate(['clientePf/listar']);
  }
}
