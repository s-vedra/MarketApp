import { AddRecipe, FavoriteRecipe, Recipe } from "../components/recipes/recipe.model";
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
       return this.http.get<Recipe>(recipeUrl.baseUrl + recipeUrl.recipesCont + 'recipe/' + id)
    }
    getFilteredRecipes(name : string): Observable<Array<Recipe>>{
        return this.http.get<Array<Recipe>>(recipeUrl.baseUrl + recipeUrl.recipesCont + 'recipes/' + name)
    }
    addRecipe(recipe : AddRecipe) : Observable<any>{
        return this.http.post<AddRecipe>(recipeUrl.baseUrl + recipeUrl.recipesCont + 'recipe', recipe)
    }
    deleteRecipe(id : number): Observable<any>{
        return this.http.delete(recipeUrl.baseUrl + recipeUrl.recipesCont + 'delete/' + id)
    }
    updateRecipe(recipe : Recipe) : Observable<any>{
        return this.http.patch<Recipe>(recipeUrl.baseUrl + recipeUrl.recipesCont + 'recipe/' + recipe.id + '/edit', recipe)
    }
    getFavoriteRecipes(id: string) : Observable<any>{
        return this.http.get<Array<any>>(recipeUrl.baseUrl + recipeUrl.userCont + 'user/' + id + '/recipes')
    }
    addToFavorites(favoriteRecipe : FavoriteRecipe) : Observable<any>{
        return this.http.post<FavoriteRecipe>(recipeUrl.baseUrl + recipeUrl.recipesCont + 'recipe/' + favoriteRecipe.userId + '/favorite', favoriteRecipe)
    }
}