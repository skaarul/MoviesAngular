import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActorProducerComponent } from './actor-producer.component';

describe('ActorProducerComponent', () => {
  let component: ActorProducerComponent;
  let fixture: ComponentFixture<ActorProducerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActorProducerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActorProducerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
