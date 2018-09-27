using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace MaterialDesignThemes.Wpf
{
    public partial class MaterialDesignThemeTextBox
    {
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    {
                        BindingExpression binding = GetBindingExpression();
                        if (binding != null)
                        {
                            binding.UpdateSource();
                        }
                        break;
                    }
                case Key.Escape:
                    {
                        BindingExpression binding = GetBindingExpression();
                        if (binding != null)
                        {
                            binding.UpdateTarget();
                        }
                        break;
                    }
            }

            BindingExpression GetBindingExpression()
            {
                TextBox textBox = (TextBox)sender;
                DependencyProperty property = TextBox.TextProperty;
                BindingExpression binding = BindingOperations.GetBindingExpression(textBox, property);
                return binding;
            };
        }
    }
}
