import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderStatusEditComponent } from './orderstatus-edit.component';

describe('OrderStatusEditComponent', () => {
  let component: OrderStatusEditComponent;
  let fixture: ComponentFixture<OrderStatusEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [OrderStatusEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrderStatusEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
