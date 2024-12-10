import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpDadosComponent } from './emp-dados.component';

describe('EmpDadosComponent', () => {
  let component: EmpDadosComponent;
  let fixture: ComponentFixture<EmpDadosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EmpDadosComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EmpDadosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
