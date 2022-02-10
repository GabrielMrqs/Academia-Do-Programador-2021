import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHttpGrupoVeiculoService } from '../../grupoVeiculo/services/IHttpGrupoVeiculoService';
import { GrupoVeiculoListViewModel } from '../../grupoVeiculo/viewModels/GrupoVeiculoListViewModel';
import { IHttpVeiculoService } from '../services/IHttpVeiculoService';
import { VeiculoDetailsViewModel } from '../viewModels/VeiculoDetailsViewModel';
import { VeiculoEditViewModel } from '../viewModels/VeiculoEditViewModel';

@Component({
  selector: 'app-veiculo-editar',
  templateUrl: './veiculo-editar.component.html'
})
export class VeiculoEditarComponent implements OnInit {

  cadastroForm: FormGroup;
  id: any;
  veiculo: VeiculoEditViewModel;
  listaGruposVeiculo: GrupoVeiculoListViewModel[];
  
  constructor(private _Activatedroute: ActivatedRoute,
    @Inject('IHttpVeiculoServiceToken') private servicoVeiculo: IHttpVeiculoService,
    @Inject('IHttpGrupoVeiculoServiceToken') private servicoGrupoVeiculo: IHttpGrupoVeiculoService,
    private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nome: new FormControl(''),
      numeroPlaca: new FormControl(''),
      numeroChassi: new FormControl(''),
      foto: new FormControl(''),
      cor: new FormControl(''),
      marca: new FormControl(''),
      ano: new FormControl(''),
      numeroPortas: new FormControl(''),
      capacidadeTanque: new FormControl(''),
      capacidadePessoas: new FormControl(''),
      tamanhoPortaMalas: new FormControl(''),
      kmInicial: new FormControl(''),
      tipoCombustivel: new FormControl(''),
      idGrupoVeiculo: new FormControl('')
    });

    this.carregarGrupoVeiculos();
    this.carregarVeiculo();
  }

  carregarGrupoVeiculos(): void {
    this.servicoGrupoVeiculo.getAll()
      .subscribe(parceiros => {
        this.listaGruposVeiculo = parceiros;
      });
  }

  carregarVeiculo(): void {
    this.servicoVeiculo.getById(this.id)
      .subscribe((veiculo: VeiculoDetailsViewModel) => {
        this.carregarFormulario(veiculo);
      });
  }

  carregarFormulario(veiculo: VeiculoDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(veiculo.id),
      nome: new FormControl(veiculo.nome),
      numeroPlaca: new FormControl(veiculo.numeroPlaca),
      numeroChassi: new FormControl(veiculo.numeroChassi),
      foto: new FormControl(veiculo.foto),
      cor: new FormControl(veiculo.cor),
      marca: new FormControl(veiculo.marca),
      ano: new FormControl(veiculo.ano),
      numeroPortas: new FormControl(veiculo.numeroPortas),
      capacidadeTanque: new FormControl(veiculo.capacidadeTanque),
      capacidadePessoas: new FormControl(veiculo.capacidadePessoas),
      tamanhoPortaMalas: new FormControl(veiculo.tamanhoPortaMalas),
      kmInicial: new FormControl(veiculo.kmInicial),
      tipoCombustivel: new FormControl(veiculo.tipoCombustivel),
      idGrupoVeiculo: new FormControl(veiculo.idGrupoVeiculo)
    });
  }

  atualizarVeiculo() {
    this.veiculo = Object.assign({}, this.veiculo, this.cadastroForm.value);
    this.veiculo.id = this.id;

    this.servicoVeiculo.editar(this.veiculo)
      .subscribe(() => {
        this.router.navigate(['veiculo/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['veiculo/listar']);
  }

}
