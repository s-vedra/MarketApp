import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { RecipesComponent } from './components/recipes/recipes.component';
import { RecipesListComponent } from './components/recipes/recipes-list/recipes-list.component';
import { RecipeDetailComponent } from './components/recipes/recipe-detail/recipe-detail.component';
import { RecipeItemComponent } from './components/recipes/recipes-list/recipe-item/recipe-item.component';
import { FormsModule } from '@angular/forms';
import { TextFontDirective } from './directives/text-font.directive';
import { RouterModule, Routes } from '@angular/router';
import { RecipesEditComponent } from './components/recipes/recipes-list/recipes-edit/recipes-edit.component';
import {ReactiveFormsModule} from '@angular/forms'
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http'
import { HttpService } from './services/app.service';
import { RecipeService } from './services/recipes.service';
import { UserComponentComponent } from './components/user-component/user-component.component';
import { AuthInterceptor } from './services/interceptors.service';
import { AuthService } from './services/auth.service';
import { AuthGard } from './services/authgard.service';
import { UserRegisterComponent } from './components/user-component/user-register/user-register.component';
import { FavoriteRecipeComponent } from './components/recipes/recipes-list/favorite-recipe/favorite-recipe.component';

 

const appRoutes : Routes = [
  {path: '', component : RecipesComponent, canActivate: [AuthGard]},
  {path: 'recipes', component : RecipesComponent, canActivate: [AuthGard] },
  {path: 'recipe/:id', component: RecipeDetailComponent},
  {path: 'recipe', component: RecipesEditComponent},
  {path: 'recipe/:id/edit', component: RecipesEditComponent},
  {path: 'recipes/:string', component : RecipesComponent},
  {path: 'login', component : UserComponentComponent},
  {path: 'register', component: UserRegisterComponent},
  {path: 'user/:id/recipes', component: FavoriteRecipeComponent}
]
@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    RecipesComponent,
    RecipesListComponent,
    RecipeDetailComponent,
    RecipeItemComponent,
    TextFontDirective,
    RecipesEditComponent,
    UserComponentComponent,
    UserRegisterComponent,
    FavoriteRecipeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [HttpService, RecipeService, AuthService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor, 
    multi:  true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
