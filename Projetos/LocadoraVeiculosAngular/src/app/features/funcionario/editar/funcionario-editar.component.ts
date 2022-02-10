import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHttpFuncionarioService } from '../services/IHttpFuncionarioService';
import { FuncionarioDetailsViewModel } from '../viewModels/FuncionarioDetailsViewModel';
import { FuncionarioEditViewModel } from '../viewModels/FuncionarioEditViewModel';

@Component({
  selector: 'app-funcionario-editar',
  templateUrl: './funcionario-editar.component.html'
})
export class FuncionarioEditarComponent implements OnInit {

  cadastroForm: FormGroup;
  id: any;
  funcionario: FuncionarioEditViewModel;

  constructor(private _Activatedroute: ActivatedRoute,
    @Inject('IHttpFuncionarioServiceToken') private servicoFuncionario: IHttpFuncionarioService,
    private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nome: new FormControl(''),
      salario: new FormControl(''),
      dataEntrada: new FormControl(''),
      cpfFuncionario: new FormControl(''),
      usuario: new FormControl(''),
      senha: new FormControl(''),
    });

    this.carregarFuncionario();
  }

  carregarFuncionario(): void {
    this.servicoFuncionario.getById(this.id)
      .subscribe((funcionario: FuncionarioDetailsViewModel) => {
        this.carregarFormulario(funcionario);
      });
  }

  carregarFormulario(funcionario: FuncionarioDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(funcionario.id),
      nome: new FormControl(funcionario.nome),
      salario: new FormControl(funcionario.salario),
      dataEntrada: new FormControl(funcionario.dataEntrada.toLocaleString().substring(0, 10)),
      cpfFuncionario: new FormControl(funcionario.cpfFuncionario),
      usuario: new FormControl(funcionario.usuario),
      senha: new FormControl(funcionario.senha),
    });
  }

  atualizarFuncionario() {
    this.funcionario = Object.assign({}, this.funcionario, this.cadastroForm.value);
    this.funcionario.id = this.id;

    this.servicoFuncionario.editar(this.funcionario)
      .subscribe(() => {
        this.router.navigate(['funcionario/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['funcionario/listar']);
  }

}
