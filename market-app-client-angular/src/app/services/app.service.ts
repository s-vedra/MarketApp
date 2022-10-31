import { Injectable } from "@angular/core";
Injectable(
    {
        providedIn: 'root'
    }
)
export class HttpService{
    route:string = 'https://localhost:7087/api/'
    products: string = 'Products/'
    recipes: string = 'Recipes/'
}