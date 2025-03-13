import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root' // ✅ Esto permite que el servicio esté disponible en toda la app
})
export class TiendaService {
  private apiUrl = 'https://localhost:7132/api/tienda'; // Asegúrate de que la URL es correcta

  constructor(private http: HttpClient) { }

  getTiendas(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
