import { Component } from '@angular/core';

@Component({
  selector: 'app-bvit-component',
  templateUrl: './bvit.component.html'
})
export class BvitComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
