import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHttpGrupoVeiculoService } from '../services/IHttpGrupoVeiculoService';
import { GrupoVeiculoDetailsViewModel } from '../viewModels/GrupoVeiculoDetailsViewModel';
import { GrupoVeiculoEditViewModel } from '../viewModels/GrupoVeiculoEditViewModel';

@Component({
  selector: 'app-grupo-veiculo-editar',
  templateUrl: './grupo-veiculo-editar.component.html'
})
export class GrupoVeiculoEditarComponent implements OnInit {

  cadastroForm: FormGroup;
  id: any;
  grupo: GrupoVeiculoEditViewModel;

  constructor(private _Activatedroute: ActivatedRoute,@Inject('IHttpGrupoVeiculoServiceToken') private servicoGrupoVeiculo: IHttpGrupoVeiculoService,private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nomeTipo: new FormControl(''),
      valorDiarioPDiario: new FormControl(''),
      valorKmRodadoPDiario: new FormControl(''),
      valorDiarioPControlado: new FormControl(''),
      limitePControlado: new FormControl(''),
      valorKmRodadoPControlado: new FormControl(''),
      valorDiarioPLivre: new FormControl('')
    });

    this.carregarGrupoVeiculo();
  }

  carregarGrupoVeiculo(): void {
    this.servicoGrupoVeiculo.getById(this.id)
      .subscribe((grupo: GrupoVeiculoDetailsViewModel) => {
        this.carregarFormulario(grupo);
      });
  }

  carregarFormulario(grupo: GrupoVeiculoDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(grupo.id),
      nomeTipo: new FormControl(grupo.nomeTipo),
      valorDiarioPDiario: new FormControl(grupo.valorDiarioPDiario),
      valorKmRodadoPDiario: new FormControl(grupo.valorKmRodadoPDiario),
      valorDiarioPControlado: new FormControl(grupo.valorDiarioPControlado),
      limitePControlado: new FormControl(grupo.limitePControlado),
      valorKmRodadoPControlado: new FormControl(grupo.valorKmRodadoPControlado),
      valorDiarioPLivre: new FormControl(grupo.valorDiarioPLivre)
    });
  }

  atualizarGrupoVeiculo() {
    this.grupo = Object.assign({}, this.grupo, this.cadastroForm.value);
    this.grupo.id = this.id;

    this.servicoGrupoVeiculo.editar(this.grupo)
      .subscribe(() => {
        this.router.navigate(['grupoVeiculo/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['grupoVeiculo/listar']);
  }

}
