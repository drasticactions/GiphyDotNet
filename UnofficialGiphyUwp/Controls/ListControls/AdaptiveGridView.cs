/*
Taken from https://github.com/LanceMcCarthy/UwpProjects/blob/master/UwpHelpers/UwpHelpers.Controls/ListControls/AdaptiveGridView.cs
---
Code provided as-is, no warranty implied
Thanks to https://github.com/r2d2rigo for the restricted aspect ratio formula and MinItemWidth MinItemHeight approach
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnofficialGiphyUwp.Controls.ListControls
{
    /// <summary>
    /// A GridView that lets you set a MinWidth and MinHeight for items you want to restrict to an aspect ration, but still resize
    /// </summary>
    public class AdaptiveGridView : GridView
    {
        #region DependencyProperties

        /// <summary>
        /// Minimum height for item
        /// </summary>
        public double MinItemHeight
        {
            get { return (double)GetValue(AdaptiveGridView.MinItemHeightProperty); }
            set { SetValue(AdaptiveGridView.MinItemHeightProperty, value); }
        }

        public static readonly DependencyProperty MinItemHeightProperty =
            DependencyProperty.Register(
                "MinItemHeight",
                typeof(double),
                typeof(AdaptiveGridView),
                new PropertyMetadata(1.0, (s, a) =>
                {
                    if (!double.IsNaN((double)a.NewValue))
                    {
                        ((AdaptiveGridView)s).InvalidateMeasure();
                    }
                }));

        /// <summary>
        /// Minimum width for item (must be greater than zero)
        /// </summary>
        public double MinItemWidth
        {
            get { return (double)GetValue(AdaptiveGridView.MinimumItemWidthProperty); }
            set { SetValue(AdaptiveGridView.MinimumItemWidthProperty, value); }
        }

        public static readonly DependencyProperty MinimumItemWidthProperty =
            DependencyProperty.Register(
                "MinItemWidth",
                typeof(double),
                typeof(AdaptiveGridView),
                new PropertyMetadata(1.0, (s, a) =>
                {
                    if (!Double.IsNaN((double)a.NewValue))
                    {
                        ((AdaptiveGridView)s).InvalidateMeasure();
                    }
                }));

        /// <summary>
        /// Maximum width for item (must be greater than zero)
        /// </summary>
        public double MaxItemWidth
        {
            get { return (double)GetValue(AdaptiveGridView.MaximumItemWidthProperty); }
            set { SetValue(AdaptiveGridView.MaximumItemWidthProperty, value); }
        }

        public static readonly DependencyProperty MaximumItemWidthProperty =
            DependencyProperty.Register(
                "MaxItemWidth",
                typeof(double),
                typeof(AdaptiveGridView),
                new PropertyMetadata(1.0, (s, a) =>
                {
                    if (!Double.IsNaN((double)a.NewValue))
                    {
                        ((AdaptiveGridView)s).InvalidateMeasure();
                    }
                }));

        /// <summary>
        /// Minimum height for item
        /// </summary>
        public double MaxItemHeight
        {
            get { return (double)GetValue(AdaptiveGridView.MaximumItemHeightProperty); }
            set { SetValue(AdaptiveGridView.MaximumItemHeightProperty, value); }
        }

        public static readonly DependencyProperty MaximumItemHeightProperty =
            DependencyProperty.Register(
                "MaxItemHeight",
                typeof(double),
                typeof(AdaptiveGridView),
                new PropertyMetadata(1.0, (s, a) =>
                {
                    if (!double.IsNaN((double)a.NewValue))
                    {
                        ((AdaptiveGridView)s).InvalidateMeasure();
                    }
                }));

        #endregion

        public AdaptiveGridView()
        {
            if (this.ItemContainerStyle == null)
            {
                this.ItemContainerStyle = new Style(typeof(GridViewItem));
            }

            this.ItemContainerStyle.Setters.Add(new Setter(GridViewItem.HorizontalContentAlignmentProperty, HorizontalAlignment.Stretch));

            this.Loaded += (s, a) =>
            {
                if (this.ItemsPanelRoot != null)
                {
                    this.InvalidateMeasure();
                }
            };
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            var panel = this.ItemsPanelRoot as ItemsWrapGrid;
            if (panel != null)
            {
                if (MinItemWidth == 0)
                    throw new DivideByZeroException("You need to have a MinItemWidth greater than zero");

                var numColumns = Math.Floor(availableSize.Width / MinItemWidth);
                numColumns = numColumns == 0 ? 1 : numColumns;
                var numRows = Math.Ceiling(this.Items.Count / numColumns);

                var itemWidth = availableSize.Width / numColumns;
                var aspectRatio = MinItemHeight / MinItemWidth;
                var itemHeight = itemWidth * aspectRatio;
                if (MaxItemHeight > 0 && (itemHeight > MaxItemHeight))
                {
                    itemHeight = MaxItemHeight;
                }
                panel.ItemWidth = itemWidth;
                panel.ItemHeight = itemHeight;
            }

            return base.MeasureOverride(availableSize);
        }
    }
}
