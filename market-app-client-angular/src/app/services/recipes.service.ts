import { AddRecipe, Recipe } from "../components/recipes/recipe.model";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpService } from "./app.service";
import {HttpClient} from '@angular/common/http'
import { recipeUrl } from "src/environments/environment";


@Injectable({
        providedIn : 'root'
    })
export class RecipeService {

        constructor(private http : HttpClient, private httpService : HttpService){

        }



        
    getRecipes(): Observable<Array<Recipe>>{
        return this.http.get<Array<Recipe>>(recipeUrl.baseUrl + recipeUrl.recipesCont + 'recipes')
    }
    getRecipe(id:number) : Observable<Recipe>{
       return this.http.get<Recipe>(this.httpService.route + this.httpService.recipes + 'recipe/' + id)
    }
    getFilteredRecipes(name : string): Observable<Array<Recipe>>{
        return this.http.get<Array<Recipe>>(this.httpService.route + this.httpService.recipes + 'recipes/' + name)
    }
    addRecipe(recipe : AddRecipe) : Observable<any>{
        return this.http.post<AddRecipe>(this.httpService.route + this.httpService.recipes + 'recipe', recipe)
    }
    deleteRecipe(id : number): Observable<any>{
        return this.http.delete(this.httpService.route + this.httpService.recipes + 'delete/' + id)
    }
    updateRecipe(recipe : Recipe) : Observable<any>{
        return this.http.patch<Recipe>(this.httpService.route + this.httpService.recipes + 'recipe/' + recipe.id + '/edit', recipe)
    }
//     filterRecipes(filter : string): Array<Recipe>{
//         return this.getRecipes().filter(x => x.name.toLowerCase().includes(filter.toLowerCase()))
//     }
//     deleteRecipe(recipe : Recipe){
//         const item = this.recipeArray.indexOf(recipe)
//         this.recipeArray.splice(item, 1)
//     }
//     private checkIfPresent(recipe: Recipe) : boolean{
//         for (const iterator of this.recipeArray) {
//                 if(iterator.id == recipe.id){
//                         return true
//                 }
                
//         }
//         return false;
//     }
    
//     addRecipe(recipe: Recipe){
//         if(this.checkIfPresent(recipe) == true){
//                 this.foundRecipe = this.recipeArray.find(x => x.id == recipe.id)!
//                       this.foundRecipe.name = recipe.name,
//                       this.foundRecipe.description = recipe.description,
//                       this.foundRecipe.image = recipe.image,
//                       this.foundRecipe.type = recipe.type
//         }else{
//                         recipe.id = 5
//                         this.recipeArray.push(recipe)
//                 }
//     }
    
}