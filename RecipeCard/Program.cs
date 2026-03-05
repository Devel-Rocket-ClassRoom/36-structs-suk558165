using Microsoft.VisualBasic;
using System;

Ingredient[] recipe = new Ingredient[]
{
    new Ingredient("스파게티면", 200, "g"),
    new Ingredient("토마토소스", 150, "ml"),
    new Ingredient("양파",  2, "개"),
    new Ingredient("마늘", 6, "쪽"),
};
RecipeCard pasta = new RecipeCard("토마토 파스타", 2, recipe);

Console.WriteLine("=== 원본 레시피 ===");
pasta.PrintRecipe();
Console.WriteLine("");
Console.WriteLine("=== 4인분으로 변환 ===");
pasta.ScaleRecipe(4).PrintRecipe(); // 배열 4번 순회 하고 출력





