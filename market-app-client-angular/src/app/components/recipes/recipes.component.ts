import { Component, OnInit,Input } from '@angular/core';
import { Recipe } from './recipe.model';
import { RecipeService } from '../../services/recipes.service';
import { Router, ActivatedRoute } from '@angular/router';

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
  ngOnInit(): void {
  // if(this.router.url != '/recipes'){
  //   this.activatedRoute.paramMap.subscribe(
  //     params => {
  //      this.filterBy = params.get('string')!
  //      console.log(this.filterBy)
  //       this.recipeService.getFilteredRecipes(this.filterBy).subscribe({
  //         next: (data) => {
  //           this.recipes = data
  //         }
  //       })
  //     }
  //   )
  // }else{
    this.recipeService.getRecipes().subscribe({
      next: (data) => {
        this.recipes = data
      }
    })
  // }
 
   
  }
  
}
