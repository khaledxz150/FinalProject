import { Time } from "@angular/common";

export class Attendance{
    lectureId:number=1;
    isPresent :boolean = false;
    isActive : boolean =true;
    creationDate:Time |undefined;
    createdBy:bigint|undefined;
    traineeId:number|undefined;
 
}