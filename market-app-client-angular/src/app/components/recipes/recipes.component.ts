import { Component, OnInit,Input } from '@angular/core';
import { Recipe } from './recipe.model';
import { RecipeService } from '../../services/recipes.service';
import { Router, ActivatedRoute } from '@angular/router';
import jwt_decode from 'jwt-decode';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css'],
})
export class RecipesComponent implements OnInit {
  
  
  constructor(private recipeService : RecipeService, private router : Router, private activatedRoute : ActivatedRoute) {
   
   }
   filterBy! : string
  recipes! : Array<Recipe>
  userId! : string
  token! : any
  ngOnInit(): void {
    this.recipeService.getRecipes().subscribe({
      next: (data) => {
        this.recipes = data
      }
    })
    this.token = jwt_decode(localStorage.getItem('user_auth')!)
    this.userId = this.token.jti
  }
  
}
