import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductStatusEditComponent } from './productstatus-edit.component';

describe('ProductStatusEditComponent', () => {
  let component: ProductStatusEditComponent;
  let fixture: ComponentFixture<ProductStatusEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ProductStatusEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductStatusEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
