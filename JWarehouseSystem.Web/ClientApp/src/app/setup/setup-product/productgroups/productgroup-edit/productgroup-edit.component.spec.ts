import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductGroupEditComponent } from './productGroup-edit.component';

describe('ProductGroupEditComponent', () => {
  let component: ProductGroupEditComponent;
  let fixture: ComponentFixture<ProductGroupEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ProductGroupEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductGroupEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
