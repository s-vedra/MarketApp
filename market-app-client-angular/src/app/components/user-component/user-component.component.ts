import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { UserLogin } from './user.model';

@Component({
  selector: 'app-user-component',
  templateUrl: './user-component.component.html',
  styleUrls: ['./user-component.component.css']
})
export class UserComponentComponent implements OnInit {

  userLoginForm!: FormGroup
  user! : UserLogin
  tokenData : any
  constructor(private auth : AuthService, private router : Router) { }

  ngOnInit(): void {
   this.userLoginForm = new FormGroup({
    id: new FormControl(0),
    username : new FormControl('', [Validators.required]),
    password : new FormControl('', [Validators.required])
   })
  }
  loginUser(){
   this.user = this.userLoginForm.value
   this.auth.login(this.user).subscribe({
    next : (data) => {
      console.log(data)
      this.tokenData = data
      localStorage.setItem('user_auth', this.tokenData.token)
      this.router.navigate(['/recipes'])
    }
   })
  }

  get username(){
    return this.userLoginForm.get('username')
  }
  get password(){
    return this.userLoginForm.get('password')
  }
}
