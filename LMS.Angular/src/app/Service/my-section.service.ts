import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class MySectionService {
  mySections:any[]=[];
  sectionUnits:any[]=[];
  constructor(private http:HttpClient) { }

  GetMySectionInfo(traineeId:number|undefined,){
    this.http.post('http://localhost:54921/api/Customer/ReturnSection/'+traineeId,null).subscribe((res:any)=>{
      this.mySections=res;
    })
  }

  GetSectionUnit(sectionId:number|undefined){
    this.http.post('http://localhost:54921/api/Section/ReturnSectionUnits/'+sectionId,null).subscribe((res:any)=>{
      this.sectionUnits=res;
    })
  }




}
