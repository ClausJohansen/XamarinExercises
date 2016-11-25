using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace AdditionExtension
{
    class AddExt : IMarkupExtension
    {
        public int NumberOfApples { get; set; }
        public int NumberOfPears { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            int numberOfFruits = NumberOfApples + NumberOfPears;

            return string.Format("{0} apples and {1} pears add up to {2} fruits.", NumberOfApples, NumberOfPears, numberOfFruits);
        }
    }
}
