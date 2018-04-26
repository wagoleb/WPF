using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ListBoxControl;

namespace GenderTemplateSelectorNM
{
    class GenderTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MaleTemplate { get; set; }
        public DataTemplate FemaleTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            PersonData person = item as PersonData;

            if (person.genderType == PersonData.gender.male)
                return MaleTemplate;

            return FemaleTemplate;

        }
    }
}
