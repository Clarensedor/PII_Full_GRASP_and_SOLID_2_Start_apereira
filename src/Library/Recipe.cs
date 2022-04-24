//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

//cumplo expert y rsp ya que implemente una interface para no estar compartiendo los metodos entre clases, entiendo que al heredarlas se cumplen estos patrones 

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            IConsolePrinter consolePrinter = new ConsolePrinter();
            consolePrinter.Print(this.FinalProduct.Description);

            foreach (Step step in this.steps)
            {
                consolePrinter.Print($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}