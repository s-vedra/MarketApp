export interface Recipe{
   id : number;
   name : string;
   description : string;
   image : string;
   type:string;
   ingridients: string;
}
export interface AddRecipe{
   name : string;
   description : string;
   image : string;
   type:string;
   ingridients: string;
}
export interface FavoriteRecipe{
   recipeId : number,
   userId : string
}