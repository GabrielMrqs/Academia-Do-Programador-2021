import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IHttpGrupoVeiculoService } from '../../grupoVeiculo/services/IHttpGrupoVeiculoService';
import { GrupoVeiculoListViewModel } from '../../grupoVeiculo/viewModels/GrupoVeiculoListViewModel';
import { IHttpVeiculoService } from '../services/IHttpVeiculoService';
import { VeiculoCreateViewModel } from '../viewModels/VeiculoCreateViewModel';

@Component({
  selector: 'app-veiculo-criar',
  templateUrl: './veiculo-criar.component.html'
})
export class VeiculoCriarComponent implements OnInit {

  cadastroForm: FormGroup;

  veiculo: VeiculoCreateViewModel;
  listaGruposVeiculo: GrupoVeiculoListViewModel[];

  constructor(@Inject('IHttpVeiculoServiceToken') private servicoVeiculo: IHttpVeiculoService,
    @Inject('IHttpGrupoVeiculoServiceToken') private servicoGrupoVeiculo: IHttpGrupoVeiculoService,
    private router: Router) { }

  ngOnInit(): void {

    this.cadastroForm = new FormGroup({
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

    this.carregarGruposVeiculo();   
  }

  adicionarVeiculo() {
    this.veiculo = Object.assign({}, this.veiculo, this.cadastroForm.value);

    this.servicoVeiculo.inserir(this.veiculo)
      .subscribe(() => {
        this.router.navigate(['veiculo/listar']);
      });
  }

  carregarGruposVeiculo(): void {
    this.servicoGrupoVeiculo.getAll()
      .subscribe(grupos => {
        this.listaGruposVeiculo = grupos;
      });
  }

  cancelar(): void {
    this.router.navigate(['veiculo/listar']);
  }

  getBase64(file: Blob) {
    var reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = function () {
      console.log(reader.result);
    };
    reader.onerror = function (error) {
      console.log('Error: ', error);
    };
 }
 carregarFoto():void{
   
  var file = (document.querySelector('#files > input[type="file"]')! as HTMLInputElement)!.files![0];
  this.getBase64(file); // prints the base64 string
 }

}
