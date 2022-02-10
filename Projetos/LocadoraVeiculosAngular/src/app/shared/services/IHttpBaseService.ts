import { Observable } from "rxjs";

export interface IHttpBaseService<TListVM, TDetailsVM, TCreateVM, IEditVM> {
    getAll(): Observable<TListVM[]>
    inserir(registro: TCreateVM): Observable<TCreateVM>
    getById(registroId: number): Observable<TDetailsVM>
    editar(registro: IEditVM): Observable<IEditVM>
    excluir(registroId: number): Observable<number>
}