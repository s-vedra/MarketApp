import { Component, OnInit } from '@angular/core';
import { UserRegister } from '../user.model';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {

  userRegister! : UserRegister
  userRegisterForm! : FormGroup
  constructor(private auth : AuthService) { }

  ngOnInit(): void {
    this.userRegisterForm = new FormGroup({
      firstName: new FormControl('', [Validators.required]),
      lastName : new FormControl('', [Validators.required]),
      username : new FormControl('', [Validators.required]),
      password : new FormControl('', [Validators.required]),
      email : new FormControl('', [Validators.required])
    })
  }

  registerUser(){
    this.userRegister = this.userRegisterForm.value
    console.log(this.userRegister)
    this.auth.register(this.userRegister).subscribe({
      next: (data) => {
        alert('Succesfully registered')
      }
    })
  }

  get firstName(){
    return this.userRegisterForm.get('firstName')
  }
  get lastName(){
    return this.userRegisterForm.get('lastName')
  }
  get username(){
    return this.userRegisterForm.get('username')
  }
  get password(){
    return this.userRegisterForm.get('password')
  }
  get email(){
    return this.userRegisterForm.get('email')
  }
}
