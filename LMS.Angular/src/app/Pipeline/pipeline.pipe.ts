import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'pipeline'
})
export class PipelinePipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    return null;
  }

}
