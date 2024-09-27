import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MovementStatusEditComponent } from './movementstatus-edit.component';

describe('MovementStatusEditComponent', () => {
  let component: MovementStatusEditComponent;
  let fixture: ComponentFixture<MovementStatusEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [MovementStatusEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovementStatusEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
