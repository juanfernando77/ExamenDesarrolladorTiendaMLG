import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; // ✅ Importa esto correctamente

import { AppComponent } from './app.component';
import { TiendaService } from './services/tienda.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule // ✅ Agrega correctamente este módulo
  ],
  providers: [
    TiendaService // ✅ Agrega el servicio aquí para que esté disponible en la app
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
