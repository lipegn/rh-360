import { Component } from '@angular/core';

@Component({
  selector: 'app-emp-dados',
  standalone: true,
  imports: [],
  templateUrl: './emp-dados.component.html',
  styleUrl: './emp-dados.component.scss'
})
export class EmpDadosComponent {
  empresa: Partial<{
    nome: string
    , cnpj: string
    , adm: string
    , cpf: string
    , email: string
    , telefone: string
    , cep: string
    , endereco: string
  }> = {}

  constructor() {
    this.empresa = {
      cnpj: '11.394.715/0001-92'
      , adm: 'Meu RH 360*'
      , cpf: '111.222.111.33'
      , email: 'emailbombo@gmail.com'
      , telefone: '(33) 9999-9999'
      , cep: '33333-333'
      , endereco: 'Avenida anhaia melo, 3333'
      , nome: 'Meu RH 360*'
    }
  }
}
