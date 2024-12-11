import { Component, inject } from '@angular/core';
import { BuscaCepService } from '../../../services/busca-cep.service';

@Component({
  selector: 'app-emp-modal',
  standalone: true,
  imports: [],
  templateUrl: './emp-modal.component.html',
  styleUrl: './emp-modal.component.scss'
})
export class EmpModalComponent {
  readonly buscaCep = inject(BuscaCepService);
  constructor() { }

  consultaCEP(event: FocusEvent) {
    const inputElement = event.target as HTMLInputElement;
    this.buscaCep.consultaCEP(inputElement.value).subscribe(dados => {
      alert((dados as any).logradouro);
    });
  }
}
