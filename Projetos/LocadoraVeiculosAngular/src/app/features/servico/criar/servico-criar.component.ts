import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IHttpServicoService } from '../services/IHttpServicoService';
import { ServicoType } from '../ServicoEnum';
import { ServicoCreateViewModel } from '../viewModels/ServicoCreateViewModel';

@Component({
  selector: 'app-servico-criar',
  templateUrl: './servico-criar.component.html'
})
export class ServicoCriarComponent implements OnInit {

  cadastroForm: FormGroup;
  servico: ServicoCreateViewModel;

  tipos = ServicoType;
  chaves: any[];

  constructor(@Inject('IHttpServicoServiceToken') private servicoServico: IHttpServicoService, private router: Router) { }

  ngOnInit(): void {
    this.chaves = Object.keys(this.tipos).filter(t => !isNaN(Number(t)));
    this.cadastroForm = new FormGroup({
      nome: new FormControl(''),
      preco: new FormControl(''),
      calculoTipo: new FormControl('')
    });
  }

  adicionarServico() {
    this.servico = Object.assign({}, this.servico, this.cadastroForm.value);

    this.servicoServico.inserir(this.servico)
      .subscribe(() => {
        this.router.navigate(['servico/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['servico/listar']);
  } 
}
