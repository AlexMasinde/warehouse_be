import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DockEditComponent } from './dock-edit.component';

describe('DockEditComponent', () => {
  let component: DockEditComponent;
  let fixture: ComponentFixture<DockEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [DockEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DockEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
