import { Component, OnInit } from '@angular/core';
import { ClienteService } from './services/cliente.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'clientapp';
  clientes: any[] = [];

  constructor(private clienteService: ClienteService) { }

  ngOnInit() {
    alert('✅ ngOnInit ejecutado');

    this.clienteService.getClientes().subscribe(
      (data) => {
        console.log('📌 Clientes obtenidos desde Angular:', data);
        this.clientes = data; // 🛠️ ALMACENAR CLIENTES
      },
      (error) => {
        console.error('⚠️ Error al obtener clientes en Angular:', error);
      }
    );
  }
}
