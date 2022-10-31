import { Component, OnInit, Input, Output } from '@angular/core';
import { RecipeService } from 'src/app/services/recipes.service';
import { Recipe } from '../recipe.model';
import { ActivatedRoute } from '@angular/router';
import { FormControl } from '@angular/forms';
import { debounceTime } from 'rxjs';

@Component({
  selector: 'app-recipes-list',
  templateUrl: './recipes-list.component.html',
  styleUrls: ['./recipes-list.component.css'],
})
export class RecipesListComponent implements OnInit {
  searchBy! : string
  @Input() recipes! : Array<Recipe>;
  

  constructor(private recipeService : RecipeService, private route : ActivatedRoute) { }

  ngOnInit(): void {
   
  }
  searchFilter(){
    this.recipeService.getFilteredRecipes(this.searchBy).pipe(
      debounceTime(500)).subscribe({
        next: (data) => {
          this.recipes = data
          console.log(this.searchBy)
        }
      })
  }
}
