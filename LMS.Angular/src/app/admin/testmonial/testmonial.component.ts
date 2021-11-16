import { Component, OnInit } from '@angular/core';
import { TestimonialService } from 'src/app/Service/testimonial.service';

@Component({
  selector: 'app-testmonial',
  templateUrl: './testmonial.component.html',
  styleUrls: ['./testmonial.component.css']
})
export class TestmonialComponent implements OnInit {
  constructor(public testService:TestimonialService) { }
 
  ngOnInit(): void {
    this.testService.getTestimonial();
    // this.panelOpenState = false;
  }

showMyMessage = false

showMessageSoon() {
  setTimeout(() => {
    this.showMyMessage = true
  }, 3000)
}

  flip: string = 'inactive';

  toggleFlip() {
    this.flip = (this.flip == 'inactive') ? 'active' : 'inactive';
  }
 

}
