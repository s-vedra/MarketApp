import { Component, Input, OnInit } from '@angular/core';
import { FavoriteRecipe, Recipe } from '../recipe.model';
import { RecipeService } from 'src/app/services/recipes.service';
import { ActivatedRoute, Router } from '@angular/router';
import jwt_decode from 'jwt-decode';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {

  recipe!:Recipe
  token: any
  role!: string
  userId! : string
  constructor(private route: ActivatedRoute, private service: RecipeService, private router : Router) { }

  ngOnInit(): void {

    this.route.paramMap.subscribe(
      params => {
        const id = +params.get('id')!
        this.service.getRecipe(id).subscribe({
          next : (data) => {
            this.recipe = data
          }
        })
      } 
      )
      this.token = jwt_decode(localStorage.getItem('user_auth')!)
      this.role = this.token.role
      this.userId = this.token.jti 
  }
  onDeleteRecipe(){
    this.service.deleteRecipe(this.recipe.id).subscribe({
      next: (data) => {
        this.router.navigate(['/recipes'])
      }
    })
  }
  addToFavorites(){
    this.service.addToFavorites({recipeId : this.recipe.id, userId : this.userId}).subscribe({
      next: (data) => {
        this.router.navigate(['user', this.userId, 'recipes'])
      }
    })
  }
}
