import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { recipeUrl } from "src/environments/environment";
import { UserLogin, UserRegister } from "../components/user-component/user.model";


@Injectable({
    providedIn : 'root'
  })

export class AuthService{

    constructor(private http : HttpClient){

    }
    login(loginUser : UserLogin){
      return this.http.post(recipeUrl.baseUrl + recipeUrl.userCont + 'login', loginUser)
    }
    logout(){
        localStorage.clear()
    }
    register(registerUser : UserRegister){
        return this.http.post(recipeUrl.baseUrl + recipeUrl.userCont + 'register', registerUser)
    }
}