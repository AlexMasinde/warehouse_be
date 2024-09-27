import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DockStatusEditComponent } from './dockstatus-edit.component';

describe('DockStatusEditComponent', () => {
  let component: DockStatusEditComponent;
  let fixture: ComponentFixture<DockStatusEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [DockStatusEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DockStatusEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
