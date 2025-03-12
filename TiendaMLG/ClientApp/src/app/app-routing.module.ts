import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component'; // 📌 Importa el componente que deseas mostrar en la raíz

const routes: Routes = [
  { path: '', component: AppComponent } // 📌 Esto asegura que la ruta principal (`/`) carga el `AppComponent`
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
