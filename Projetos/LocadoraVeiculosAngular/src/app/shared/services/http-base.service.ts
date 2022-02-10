import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEditVM } from '../IEditVM';


@Injectable({
  providedIn: 'root'
})
export abstract class HttpBaseService<TListVM, TDetailsVM, TCreateVM, TEditVM extends IEditVM>{

  private apiUrl = 'https://localhost:44306/api/'
  public diretorio: string

  constructor(private http: HttpClient) { }

  getAll(): Observable<TListVM[]> {
    return this.http.get<TListVM[]>(`${this.apiUrl + this.diretorio}`);
  }
  inserir(registro: TCreateVM): Observable<TCreateVM> {
    return this.http.post<TCreateVM>(this.apiUrl + this.diretorio, registro);
  }
  getById(registroId: number): Observable<TDetailsVM> {
    return this.http.get<TDetailsVM>(`${this.apiUrl + this.diretorio}/${registroId}`);
  }
  editar(registro: TEditVM): Observable<TEditVM> {
    return this.http.put<TEditVM>(`${this.apiUrl + this.diretorio}/${registro.id}`, registro);
  }
  excluir(registroId: number): Observable<number> {
    return this.http.delete<number>(`${this.apiUrl + this.diretorio}/${registroId}`);
  }
}
