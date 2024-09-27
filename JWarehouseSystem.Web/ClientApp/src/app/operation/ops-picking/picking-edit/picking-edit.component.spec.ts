import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PickingEditComponent } from './picking-edit.component';

describe('PickingEditComponent', () => {
  let component: PickingEditComponent;
  let fixture: ComponentFixture<PickingEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [PickingEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PickingEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
