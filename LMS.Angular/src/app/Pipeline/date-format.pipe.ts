import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'dateFormat'
})
export class DateFormatPipe implements PipeTransform {

  transform(value: string, ...args: unknown[]):unknown {
    const date=new Date(value);
    //day/month/year
    const formattedDate=`${date.getDate()}/${date.getMonth()+1}/${date.getFullYear()}`;
    return formattedDate;


  }
}
