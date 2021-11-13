import { Component, OnInit, VERSION } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faEdit, faTrashAlt } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { TraineeService } from 'src/app/Service/trainee.service';
import { AddTrainerComponent } from '../trainer-info/add-trainer/add-trainer.component';
import { EditTrainerComponent } from '../trainer-info/edit-trainer/edit-trainer.component';
import { AddTraineeComponent } from './add-trainee/add-trainee.component';
import { EditTraineeComponent } from './edit-trainee/edit-trainee.component';

@Component({
  selector: 'app-trainee-info',
  templateUrl: './trainee-info.component.html',
  styleUrls: ['./trainee-info.component.css', '../../../assets/css/tstyle.css']
})
export class TraineeInfoComponent implements OnInit {

  constructor(public Servicetrainee: TraineeService, private dialog: MatDialog) {


  }
  faEdit = faEdit
  faTrashAlt = faTrashAlt;

  filterTerm: any;
  title = 'angulardatatables';
  dtOptions: any = {};

  ngOnInit(): void {

    this.Servicetrainee.getTrainee();
    // this.Servicetrainee.trainee;

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 3,
      processing: true,
      dom: 'Bfrtip',
      buttons: [
        'copy', 'csv', 'excel', 'print'
      ]
    };
  }
  //   deleteCourse(courseId:number){
  //   this.courseService.deleteCourse(courseId);
  // }
  public data = [
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
  ];

  name = 'Angular ' + VERSION.major;

  printPage() {
    window.print();
  }
  AddTrainee() {
    this.dialog.open(AddTraineeComponent, {
      height: '80%',
      width: '60%'
    })
  }
  DeleteTrainee(traineeId: number) {
    this.Servicetrainee.DeleteTrainee(traineeId);
  }

  // UpdateTrainer(){
  //   this.dialog.open(UpdateTrainerComponent,{
  //     height: '80%',
  //     width: '60%'
  // })
  // }


  UpdateTrainee(traineeId: number) {

    debugger
    const item = this.Servicetrainee.trainee.find(i => i.traineeId == traineeId);


    this.dialog.open(EditTraineeComponent, { data: item })
      // if(this.courseId)
    //    this.homeService.updatecourse(item);

  }



  ChangeTraineeStatus(id: number) {

    let dialogRef = this.dialog.open(AlertDialogComponent);
    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {
        this.Servicetrainee.EditStatus(id);

      }


    })


  }


  date = new Date(2020, 1, 1);
  minDate = new Date(2000, 0, 1);
  maxDate = new Date(2020, 0, 1);
  public MinDateVal(event: any) {
    this.minDate = <Date>event;
  }

  public MaxDateVal(event: any) {
    this.maxDate = <Date>event;
  }

}
