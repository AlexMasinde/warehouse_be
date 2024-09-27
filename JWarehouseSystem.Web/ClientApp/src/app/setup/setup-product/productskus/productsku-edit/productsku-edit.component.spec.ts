import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductSKUEditComponent } from './productsku-edit.component';

describe('ProductSKUEditComponent', () => {
  let component: ProductSKUEditComponent;
  let fixture: ComponentFixture<ProductSKUEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ProductSKUEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductSKUEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
