import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationGuard implements CanActivate {

  constructor(private toastr:ToastrService, private router: Router ){}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      const token = localStorage.getItem('token');
      if(token){

        if(state.url.indexOf('admin') >= 0){
          let user:any = localStorage.getItem('user');
          if(user){
            user = JSON.parse(user);
            if(user.role == 'Admin')
            {return true}
            else {
              this.toastr.warning('You are Not Admin')
              return false;
            }
          }
          else {this.toastr.warning("You ara not admin"); return false}
        }

        if(state.url.indexOf('accountant') >= 0){
          let user:any = localStorage.getItem('user');
          if(user){
            user = JSON.parse(user);
            if(user.role == 'Accountant')
            {return true}
            else {
              this.toastr.warning('You are Not Accountant')
              return false;
            }
          }
          else {this.toastr.warning("You ara not Accountant"); return false}
        }

        if(state.url.indexOf('client') >= 0){
          let user:any = localStorage.getItem('user');
          if(user){
            user = JSON.parse(user);
            if(user.role == 'Trainee')
            {return true}
            else {
              this.toastr.warning('You are Not Trainee')
              return false;
            }
          }
          else {this.toastr.warning("You ara not Trainee"); return false}
        }

        if(state.url.indexOf('trainer') >= 0){
          let user:any = localStorage.getItem('user');
          if(user){
            user = JSON.parse(user);
            if(user.role == 'Trainer')
            {return true}
            else {
              this.toastr.warning('You are Not trainer')
              return false;
            }
          }
          else {this.toastr.warning("You ara not trainer"); return false}
        }
        return false;
      }
      else {
        this.toastr.warning("You ara not authorize")

        this.router.navigate(['']);
        return false;}



}
}
