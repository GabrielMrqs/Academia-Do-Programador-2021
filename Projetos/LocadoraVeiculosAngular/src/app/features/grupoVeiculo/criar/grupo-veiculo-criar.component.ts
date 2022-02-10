import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IHttpGrupoVeiculoService } from '../services/IHttpGrupoVeiculoService';
import { GrupoVeiculoCreateViewModel } from '../viewModels/GrupoVeiculoCreateViewModel';

@Component({
  selector: 'app-grupo-veiculo-criar',
  templateUrl: './grupo-veiculo-criar.component.html'
})
export class GrupoVeiculoCriarComponent implements OnInit {

  cadastroForm: FormGroup;

  grupo: GrupoVeiculoCreateViewModel;

  constructor(@Inject('IHttpGrupoVeiculoServiceToken') private servicoGrupoVeiculo: IHttpGrupoVeiculoService, private router: Router) { }

  ngOnInit(): void {
    this.cadastroForm = new FormGroup({
      nomeTipo: new FormControl(''),
      valorDiarioPDiario: new FormControl(''),
      valorKmRodadoPDiario: new FormControl(''),
      valorDiarioPControlado: new FormControl(''),
      limitePControlado: new FormControl(''),
      valorKmRodadoPControlado: new FormControl(''),
      valorDiarioPLivre: new FormControl('')
    });

  }

  adicionarGrupoVeiculo() {
    this.grupo = Object.assign({}, this.grupo, this.cadastroForm.value);

    this.servicoGrupoVeiculo.inserir(this.grupo)
      .subscribe(() => {
        this.router.navigate(['grupoVeiculo/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['grupoVeiculo/listar']);
  }
}
