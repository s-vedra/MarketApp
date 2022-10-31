import { Component, OnInit, Input } from '@angular/core';
import {FormGroup, FormControl, Validators} from '@angular/forms'
import { AddRecipe, Recipe } from '../../recipe.model';
import { RecipeService } from 'src/app/services/recipes.service';
import { Router, ActivatedRoute } from '@angular/router';




@Component({
  selector: 'app-recipes-edit',
  templateUrl: './recipes-edit.component.html',
  styleUrls: ['./recipes-edit.component.css']
})
export class RecipesEditComponent implements OnInit {

  recipeForm! : FormGroup
  recipe! : Recipe
  newRecipe! : AddRecipe
  constructor(private service: RecipeService, private router: Router, private activatedRoute : ActivatedRoute) { }

  ngOnInit(): void {
    this.recipeForm = new FormGroup
    (
      {
          id: new FormControl(0),
          name: new FormControl('', [Validators.required]),
          description: new FormControl('', [Validators.required]),
          image: new FormControl('', [Validators.required]),
          type: new FormControl('', [Validators.required]),
          ingredients: new FormControl('', [Validators.required])
        }
    )
        if(this.router.url != '/recipe'){
          this.activatedRoute.paramMap.subscribe(
            params => {
             const id = +params.get('id')!
             this.service.getRecipe(id).subscribe({
              next: (data) => {
                this.recipe = data
                this.recipeForm.setValue(this.recipe)
              }
             })
            }
          )
        }

      this.recipeForm.setValue(this.recipe)
  }
  submitForm(){
    
  if(this.router.url != '/recipe'){
    this.recipe = this.recipeForm.value
    console.log(this.recipe)
    this.service.updateRecipe(this.recipe).subscribe({
      next: (data) => {
        this.router.navigate(['/recipes'])
      }
    })
  }else{
    this.newRecipe = this.recipeForm.value
   console.log(this.newRecipe)
   this.service.addRecipe(this.newRecipe).subscribe({
    next: (data) => {
      this.router.navigate(['/recipes']);
    }
   })
  }
  }

  get name(){
    return this.recipeForm.get('name')
  }
  get description(){
    return this.recipeForm.get('description')
  }
  get image(){
    return this.recipeForm.get('image')
  }
  get type(){
    return this.recipeForm.get('type')
  }
  get ingredients(){
    return this.recipeForm.get('ingredients')
  }
}
