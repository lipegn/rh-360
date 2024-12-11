import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { EmpDadosComponent } from './components/empresa/emp-dados/emp-dados.component';

export const routes: Routes = [
    { path: '', redirectTo: '/login', pathMatch: 'full' },
    { path: 'login', component: LoginComponent },
    { path: 'empresa', component: EmpDadosComponent },
];
