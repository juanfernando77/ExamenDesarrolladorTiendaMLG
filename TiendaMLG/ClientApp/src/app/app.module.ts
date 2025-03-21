import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; 

import { AppComponent } from './app.component';
import { ClienteService } from './services/cliente.service'; 

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule 
  ],
  providers: [ClienteService], 
  bootstrap: [AppComponent]
})
export class AppModule { }
