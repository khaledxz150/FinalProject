import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { PurchesService } from 'src/app/Service/purches.service';

@Component({
  selector: 'app-insert-refund',
  templateUrl: './insert-refund.component.html',
  styleUrls: ['./insert-refund.component.css']
})
export class InsertRefundComponent implements OnInit {
  formGroup: FormGroup = new FormGroup({
    notes:new FormControl('', [Validators.required]),
  });

  constructor(public purches:PurchesService) { }

  ngOnInit(): void {
  }

  Create(){
    this.purches.mainNotes=this.formGroup.value.notes
    this.purches.SendRefundRequest();
  }


}
