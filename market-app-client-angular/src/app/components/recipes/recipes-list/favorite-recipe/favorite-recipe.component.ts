import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RecipeService } from 'src/app/services/recipes.service';

@Component({
  selector: 'app-favorite-recipe',
  templateUrl: './favorite-recipe.component.html',
  styleUrls: ['./favorite-recipe.component.css']
})
export class FavoriteRecipeComponent implements OnInit {

  recipes! : Array<any>
  constructor(private service : RecipeService, private route : ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      params => {
       const id = params.get('id')!
        this.service.getFavoriteRecipes(id).subscribe({
          next : (data) => {
            this.recipes = data
          }
        })
      }
    )
    
  }

}
