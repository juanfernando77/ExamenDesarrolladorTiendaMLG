import { Component, OnInit } from '@angular/core';
import { TiendaService } from './services/tienda.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  tiendas: any[] = [];

  constructor(private tiendaService: TiendaService) {
    console.log('🔹 Constructor ejecutado');  // 👀 Verifica si el constructor se ejecuta
  }

  ngOnInit() {
    console.log('✅ ngOnInit ejecutado');  // 👀 Esto DEBE aparecer en la consola

    this.tiendaService.getTiendas().subscribe(
      (data) => {
        console.log('📌 Tiendas cargadas:', data);
        this.tiendas = data;
      },
      (error) => {
        console.error('⚠️ Error al obtener tiendas:', error);
      }
    );
  }
}
