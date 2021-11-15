import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'timepipe'
})
export class TimepipePipe implements PipeTransform {

  transform(value: Date, ...args: unknown[]): unknown {

    
    return null;
  }

}
