import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { IHttpClientePjService } from '../services/IHttpClientePjService';
import { ClientePjCreateViewModel } from '../viewModels/ClientePjCreateViewModel';

@Component({
  selector: 'app-cliente-pj-criar',
  templateUrl: './cliente-pj-criar.component.html'
})
export class ClientePjCriarComponent implements OnInit {

  cadastroForm: FormGroup;
  clientePj: ClientePjCreateViewModel;

  constructor(@Inject('IHttpClientePjServiceToken') private servicoClientePj: IHttpClientePjService, private router: Router) { }

  ngOnInit(): void {
    this.cadastroForm = new FormGroup({
      nome: new FormControl(''),
      endereco: new FormControl(''),
      telefone: new FormControl(''),
      cnpj: new FormControl(''),
      email: new FormControl(''),
    });
  }

  adicionarClientePj() {
    this.clientePj = Object.assign({}, this.clientePj, this.cadastroForm.value);

    this.servicoClientePj.inserir(this.clientePj)
      .subscribe(() => {
        this.router.navigate(['clientePj/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['clientePj/listar']);
  }
}
