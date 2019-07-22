import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SidebarPushComponent } from './sidebar-push.component';

describe('SidebarPushComponent', () => {
  let component: SidebarPushComponent;
  let fixture: ComponentFixture<SidebarPushComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SidebarPushComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SidebarPushComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
