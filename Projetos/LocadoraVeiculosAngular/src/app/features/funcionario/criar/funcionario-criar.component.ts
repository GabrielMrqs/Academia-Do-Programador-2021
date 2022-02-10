import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IHttpFuncionarioService } from '../services/IHttpFuncionarioService';
import { FuncionarioCreateViewModel } from '../viewModels/FuncionarioCreateViewModel';

@Component({
  selector: 'app-funcionario-criar',
  templateUrl: './funcionario-criar.component.html'
})
export class FuncionarioCriarComponent implements OnInit {

    cadastroForm: FormGroup;
    funcionario: FuncionarioCreateViewModel;
  
    constructor(@Inject('IHttpFuncionarioServiceToken') private servicoFuncionario: IHttpFuncionarioService, private router: Router) { }
  
    ngOnInit(): void {
      this.cadastroForm = new FormGroup({
        nome: new FormControl(''),
        salario: new FormControl(''),
        dataEntrada: new FormControl(''),
        cpfFuncionario: new FormControl(''),
        usuario: new FormControl(''),
        senha: new FormControl(''),
      });
    }
  
    adicionarFuncionario() {
      this.funcionario = Object.assign({}, this.funcionario, this.cadastroForm.value);
  
      this.servicoFuncionario.inserir(this.funcionario)
        .subscribe(() => {
          this.router.navigate(['funcionario/listar']);
        });
    }
  
    cancelar(): void {
      this.router.navigate(['funcionario/listar']);
    } 

}
