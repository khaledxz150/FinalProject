import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TraineeInfoComponent } from './trainee-info.component';

describe('TraineeInfoComponent', () => {
  let component: TraineeInfoComponent;
  let fixture: ComponentFixture<TraineeInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TraineeInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TraineeInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
