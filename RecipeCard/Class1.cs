using System;
using System.Collections.Generic;
using System.Text;

struct Ingredient
{
    public string Name;
    public double Amount;
    public string Unit;

    public Ingredient(string name, double amount, string unit)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }
}
struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");
        foreach (Ingredient ingredient in Ingredients)
        {
            // ingredient.Name, ingredient.Amount, ingredient.Unit 활용
            Console.WriteLine($"-{ingredient.Name} {ingredient.Amount}{ingredient.Unit}");
        }
    }
    public RecipeCard ScaleRecipe(int newServings) // 인분수에 맞게 재료량을 조정한 새 RecipeCard 를 반환하는 메서드
    {
        Ingredient[] newIngredients = new Ingredient[Ingredients.Length]; // 기존 재료 배열과 같은 크기의 새 배열 생성

        for (int i = 0; i < Ingredients.Length; i++) // 모든 재료를 순회하며 양을 조정
        {
            double newAmount = Ingredients[i].Amount * newServings / Servings; // 이름, 조정된 양, 단위로 새 Ingredient 생성
            newIngredients[i] = new Ingredient
                (
                Ingredients[i].Name, //재료 이름 그대로
                newAmount, //수정한 양
                Ingredients[i].Unit //단위 그대로
                 );
        }

        return new RecipeCard(Name, newServings, newIngredients); // 새 RecipeCard 반환
    }
}

