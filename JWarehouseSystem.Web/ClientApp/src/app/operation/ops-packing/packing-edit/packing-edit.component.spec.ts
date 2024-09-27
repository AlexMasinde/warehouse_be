import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PackingEditComponent } from './packing-edit.component';

describe('PackingEditComponent', () => {
  let component: PackingEditComponent;
  let fixture: ComponentFixture<PackingEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [PackingEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PackingEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
