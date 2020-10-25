import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BvitComponent } from './bvit.component';

describe('BvitComponent', () => {
  let component: BvitComponent;
  let fixture: ComponentFixture<BvitComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BvitComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BvitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should display a meaningful title about Basic Vehicle Incident Tracker', async(() => {
    const titleText = fixture.nativeElement.querySelector('h1').textContent;
    expect(titleText).toEqual('Basic Vehicle Incident Tracker (BVIT)');
  }));

  it('should start with count 0, then increments by 1 when clicked', async(() => {
    const countElement = fixture.nativeElement.querySelector('strong');
    expect(countElement.textContent).toEqual('0');

    const incrementButton = fixture.nativeElement.querySelector('button');
    incrementButton.click();
    fixture.detectChanges();
    expect(countElement.textContent).toEqual('1');
  }));
});
