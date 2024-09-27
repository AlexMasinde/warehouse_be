import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PurchaseStatusEditComponent } from './purchasestatus-edit.component';

describe('PurchaseStatusEditComponent', () => {
  let component: PurchaseStatusEditComponent;
  let fixture: ComponentFixture<PurchaseStatusEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [PurchaseStatusEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PurchaseStatusEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
