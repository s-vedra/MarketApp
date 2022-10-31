import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  isLoggedIn!: boolean
  constructor(private auth : AuthService, private router : Router) { }

  ngOnInit(): void {
    this.loggedIn()
  }
  logout(){
    this.auth.logout()
    this.router.navigate(['/login'])
    this.loggedIn()
  }
  
  loggedIn(){
    if (localStorage.getItem('user_auth')) {
     return this.isLoggedIn = true
    }else{
      return this.isLoggedIn = false
    }
  }
}
