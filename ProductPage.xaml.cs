using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KoldunTrade
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        int CountProduct = TradeBaiguzinEntities.GetContext().Product.Count();
        int CountProductMax = TradeBaiguzinEntities.GetContext().Product.Count();
        public ProductPage()
        {
            InitializeComponent();
            var currentProduct = TradeBaiguzinEntities.GetContext().Product.ToList();
            ProductListView.ItemsSource = currentProduct;

            Sort.SelectedIndex = 0;
            Filter.SelectedIndex = 0;
           
            UpdateProduct();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateProduct();
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProduct();
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProduct();
        }
        
        private void UpdateProduct()
        {
            var currentProduct = TradeBaiguzinEntities.GetContext().Product.ToList();

            //фильрация
            if (Filter.SelectedIndex == 0)
            {
                currentProduct = currentProduct;
            }
            else if (Filter.SelectedIndex == 1)
                currentProduct = currentProduct.Where(product => product.ProductDiscountAmount < 10).ToList();
            else if (Filter.SelectedIndex == 2)
                currentProduct = currentProduct.Where(product => product.ProductDiscountAmount >= 10 && product.ProductDiscountAmount < 15).ToList();
            else if (Filter.SelectedIndex == 3)
                currentProduct = currentProduct.Where(product => product.ProductDiscountAmount > 15).ToList();

            //Сортировка
            if (Sort.SelectedIndex == 0)
                currentProduct = currentProduct;
            else if (Sort.SelectedIndex == 1)
                currentProduct = currentProduct.OrderBy(product => product.ProductCost).ToList();
            else if(Sort.SelectedIndex == 2)
                currentProduct = currentProduct.OrderByDescending(product => product.ProductCost).ToList();

            //поиск
            currentProduct = currentProduct.Where(o => o.ProductName.ToLower().Contains(TBSearch.Text.ToLower())).ToList();


            ProductListView.ItemsSource = currentProduct;
            CountProduct = currentProduct.Count();
            productCount.Text = "Выведено записей " + CountProduct.ToString() + " из " + CountProductMax.ToString();
        }

    }
}
