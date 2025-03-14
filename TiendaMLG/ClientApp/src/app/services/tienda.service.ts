import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TiendaService {
  private apiUrl = 'https://localhost:7132/api/tienda';

  constructor(private http: HttpClient) { }

  getTiendas(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
