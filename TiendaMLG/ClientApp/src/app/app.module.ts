import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; // ✅ IMPORTAR

import { AppComponent } from './app.component';
import { ClienteService } from './services/cliente.service'; // ✅ IMPORTAR EL SERVICIO

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule // ✅ NECESARIO PARA HACER PETICIONES HTTP
  ],
  providers: [ClienteService], // ✅ DEBE ESTAR AQUÍ
  bootstrap: [AppComponent]
})
export class AppModule { }
