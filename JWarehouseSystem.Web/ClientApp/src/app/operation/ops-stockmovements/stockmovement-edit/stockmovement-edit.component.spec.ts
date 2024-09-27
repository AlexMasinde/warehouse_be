import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StockMovementEditComponent } from './stockmovement-edit.component';

describe('StockMovementEditComponent', () => {
  let component: StockMovementEditComponent;
  let fixture: ComponentFixture<StockMovementEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [StockMovementEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StockMovementEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
