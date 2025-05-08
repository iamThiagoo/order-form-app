using Trabalho.controllers;
using Trabalho.models;
using Trabalho.views;

namespace Trabalho
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ProdutoModel model = new ProdutoModel();
            ProdutoView view = new ProdutoView();
            ProductController controller = new ProductController(model, view);
            view.SetController(controller);

            Application.Run(view);
        }
    }
}